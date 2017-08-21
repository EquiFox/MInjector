using MInject;
using System;
using System.Diagnostics;

namespace MInjector
{
    public static class MonoInjector
    {
        public static bool Inject(Process p_TargetProcess, Settings p_InjectionSettings)
        {
            MonoProcess monoProcess;

            if (MonoProcess.Attach(p_TargetProcess, out monoProcess))
            {
                try
                {
                    IntPtr monoDomain = monoProcess.GetRootDomain();
                    monoProcess.ThreadAttach(monoDomain);
                    monoProcess.SecuritySetMode(0);

                    if (p_InjectionSettings.HideAssemblyLoad)
                    {
                        monoProcess.DisableAssemblyLoadCallback();
                    }

                    IntPtr rawAssemblyImage = monoProcess.ImageOpenFromDataFull(p_InjectionSettings.AssemblyBytes);
                    IntPtr assemblyPointer = monoProcess.AssemblyLoadFromFull(rawAssemblyImage);
                    IntPtr assemblyImage = monoProcess.AssemblyGetImage(assemblyPointer);
                    IntPtr classPointer = monoProcess.ClassFromName(assemblyImage, p_InjectionSettings.Namespace, p_InjectionSettings.ClassName);
                    IntPtr methodPointer = monoProcess.ClassGetMethodFromName(classPointer, p_InjectionSettings.MethodName);

                    if (p_InjectionSettings.HideGetAssemblies)
                    {
                        monoProcess.HideLastAssembly(monoDomain);
                    }

                    monoProcess.RuntimeInvoke(methodPointer);

                    if (p_InjectionSettings.HideAssemblyLoad)
                    {
                        monoProcess.EnableAssemblyLoadCallback();
                    }

                    monoProcess.Dispose();
                    return true;
                }
                catch { }
            }

            return false;
        }

        public class Settings
        {
            public byte[] AssemblyBytes { get; set; }

            public string Namespace { get; set; }

            public string ClassName { get; set; }

            public string MethodName { get; set; }

            public bool HideAssemblyLoad { get; set; }

            public bool HideGetAssemblies { get; set; }
        }
    }
}
