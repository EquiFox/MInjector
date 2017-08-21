using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MInjector
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            RefreshMonoProcesses();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshMonoProcesses();
        }

        private void RefreshMonoProcesses()
        {
            processList.Items.Clear();
            settingsGroupBox.Enabled = false;
            injectBtn.Enabled = false;

            foreach (Process process in Process.GetProcesses())
            {
                try
                {
                    foreach (ProcessModule module in process.Modules)
                    {
                        if (module.FileName.Contains("mono.dll"))
                        {
                            processList.Items.Add(new PrintableProcess(process));
                        }
                    }
                }
                catch { }                
            }

            if (processList.Items.Count > 0)
            {
                processList.SelectedIndex = 0;
            }
        }

        private void processList_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool flag = (processList.SelectedItem != null && processList.SelectedItem is PrintableProcess);

            settingsGroupBox.Enabled = flag;
            injectBtn.Enabled = flag && !string.IsNullOrEmpty(asmPathTextBox.Text);
        }

        private void loadAsmBtn_Click(object sender, EventArgs e)
        {
            asmPathTextBox.Text = "";
            injectBtn.Enabled = false;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "DLL Files|*.dll";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    asmPathTextBox.Text = ofd.FileName;
                    injectBtn.Enabled = true;
                }
            }
        }

        private void injectBtn_Click(object sender, EventArgs e)
        {            
            PrintableProcess printableProcess = processList.SelectedItem as PrintableProcess;
            MonoInjector.Settings injectionSettings = new MonoInjector.Settings
            {
                AssemblyBytes = File.ReadAllBytes(asmPathTextBox.Text),
                Namespace = namespaceTxtBox.Text,
                ClassName = classTxtBox.Text,
                MethodName = methodTxtBox.Text,
                HideAssemblyLoad = hideAssemblyLoadCheck.Checked,
                HideGetAssemblies = hideAssemblyCheck.Checked
            };

            if (MonoInjector.Inject(printableProcess.InternalProcess, injectionSettings))
            {
                MessageBox.Show("Injection was successful !");
            }
            else
            {
                MessageBox.Show("An error occured while injecting...");

                asmPathTextBox.Text = "";
                namespaceTxtBox.Text = "";
                classTxtBox.Text = "";
                methodTxtBox.Text = "";
                hideAssemblyCheck.Checked = false;
                RefreshMonoProcesses();
            }
        }

        private void aboutLbl_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("This program is brought to you by EquiFox !\n");
            sb.AppendLine("MInjector: https://github.com/EquiFox/MInjector (This project)");
            sb.AppendLine("MInject: https://github.com/EquiFox/MInject (Mono injection library used by this software)");

            MessageBox.Show(sb.ToString(), "MInjector - About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
