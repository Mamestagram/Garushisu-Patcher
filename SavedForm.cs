using System;
using System.Data.OleDb;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace garushisu_patcher
{
    public partial class SavedForm : Form
    {
        public SavedForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            StringBuilder sqlQuery = new StringBuilder();
            
            sqlQuery.AppendLine("INSERT INTO setting (name, address, path, patcherpath) ");
            sqlQuery.AppendLine("VALUES ('" + textboxPreset.Text + "', '" + MainForm.Instance.textboxAddress.Text + "', '" + MainForm.Instance.textboxOsu.Text + "', '" + MainForm.Instance.textboxAkatsukiPath.Text + "')");

            OleDbCommand command = new OleDbCommand();
            OleDbConnection cnAccess = new OleDbConnection();
            cnAccess.ConnectionString = Properties.Settings.Default.settingConnection;

            try
            {
                cnAccess.Open();
                command.Connection = cnAccess;
                command.CommandText = sqlQuery.ToString();
                command.ExecuteNonQuery();
            } catch
            {
                String message = "Failed to save settings. The Microsoft Access database engine 2010 redistributable component required for saving may not be installed. Do you want to install it?";

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
            }
            finally
            {
                command.Dispose();
                cnAccess.Close();
            }

            MessageBox.Show("Successfully saved!", "Preset saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
