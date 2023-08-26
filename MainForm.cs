using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace garushisu_patcher
{
    public partial class MainForm : Form
    {

        private static MainForm instance;

        public static MainForm Instance
        {
            get { return instance; }
            set { instance = value; }
        }

        public MainForm()
        {
            instance = this;
            InitializeComponent();
        }


        private String folderPathSelector()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                dialog.Dispose();

                return dialog.SelectedPath;
            } else
            {
                return null;
            }
        }

        private String filePathSelector()
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if(dialog.ShowDialog() == DialogResult.OK) {
                return dialog.FileName;
            } else
            {
                return null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MenuClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                textboxAkatsukiPath.Enabled = true;
            } else
            {
                textboxAkatsukiPath.Enabled = false;
            }
        }

        private void textboxOsu_Click(object sender, EventArgs e)
        {
            textboxOsu.Text = folderPathSelector();
        }

        private void textboxAkatsukiPath_Click(object sender, EventArgs e)
        {
            textboxAkatsukiPath.Text = filePathSelector();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadForm form = new LoadForm();
            form.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SavedForm form = new SavedForm();
            form.ShowDialog();
        }

        private async void btnLaunch_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo(textboxAkatsukiPath.Text);
                Process.Start(processStartInfo);
            }
            await Task.Delay(2000);
            ProcessStartInfo processStartInfo1 = new ProcessStartInfo(textboxOsu.Text + "\\osu!.exe", " -devserver " + textboxAddress.Text);
            Process.Start(processStartInfo1);

            Close();
        }
    }
}
