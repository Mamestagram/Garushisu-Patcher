using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Windows.Forms;

namespace garushisu_patcher
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(cmbPreset.SelectedIndex == -1)
            {
                MessageBox.Show("Preset not specified!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String sqlQuery = "DELETE FROM [setting] where [name] = '" + cmbPreset.Text + "'";

            OleDbCommand command = new OleDbCommand();
            OleDbConnection cnAccess = new OleDbConnection();
            cnAccess.ConnectionString = Properties.Settings.Default.settingConnection;

            try
            {
                cnAccess.Open();
                command.Connection = cnAccess;
                command.CommandText = sqlQuery.ToString();
                command.ExecuteNonQuery();

            }
            catch
            {
                String message = "Failed to delete preset. The Microsoft Access database engine 2010 redistributable component required for delete may not be installed. Do you want to install it?";

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

                    MainForm.Instance.Close();
                }

                return;
            }
            finally
            {
                command.Dispose();
                cnAccess.Close();
            }

            MessageBox.Show("Successful to delete preset!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadForm.LoadFormInstance.Close();
            Close();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            String sqlQuery = "select [name] from [setting]";

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
            }
            catch
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
            }
            finally
            {
                command.Dispose();
                da.Dispose();
                cnAccess.Close();
            }
            
            foreach (DataRow dr in dt.Rows)
            {
                cmbPreset.Items.Add(dr.ItemArray[0]);
            }
        }
    }
}
