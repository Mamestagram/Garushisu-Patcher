using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Windows.Forms;

namespace garushisu_patcher
{
    public partial class LoadForm : Form
    {
        public static String savedAddress;
        public static String savedOsuPath;
        public static String savedPatcherPath;

        static DataTable dataTable;

        public LoadForm()
        {
            InitializeComponent();
        }

        private void cmbPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            MainForm.Instance.textboxAddress.Text = dataTable.Rows[cmbPreset.SelectedIndex].ItemArray[1].ToString();
            MainForm.Instance.textboxOsu.Text = dataTable.Rows[cmbPreset.SelectedIndex].ItemArray[2].ToString();
            MainForm.Instance.textboxAkatsukiPath.Text = dataTable.Rows[cmbPreset.SelectedIndex].ItemArray[3].ToString();

            Close();
        }

        private void LoadForm_Load(object sender, EventArgs e)
        {
            String sqlQuery = "select [name], [address], [path], [patcherpath] from [setting]";

            DataTable dt = new DataTable();
            OleDbCommand command = new OleDbCommand();
            OleDbDataAdapter da = new OleDbDataAdapter();
            OleDbConnection cnAccess = new OleDbConnection();
            cnAccess.ConnectionString = Properties.Settings.Default.settingConnection;
            
            try
            {
                cnAccess.Open();
                command.Connection = cnAccess;
                command.CommandText = sqlQuery;
                da.SelectCommand = command;

                da.Fill(dt);
            } catch
            {
                String message = "Failed to load configuration. The Microsoft Access database engine 2010 redistributable component required for loading may not be installed. Do you want to install it?";

                DialogResult dr = MessageBox.Show(message,
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {

                    ProcessStartInfo pi = new ProcessStartInfo()
                    {
                        FileName = "https://www.microsoft.com/en-us/download/details.aspx?id=13255",
                        UseShellExecute = true,
                    };

                    Process.Start(pi);

                    Close();

                    return;

                }
            } finally
            {
                command.Dispose();
                da.Dispose();
                cnAccess.Close();
            }

            dataTable = dt;

            foreach (DataRow row in dataTable.Rows)
            {
                cmbPreset.Items.Add(row.ItemArray[0]);
            }
        }
    }
}
