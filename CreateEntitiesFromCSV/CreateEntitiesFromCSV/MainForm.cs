using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;
using MapCSVtoEntities;

namespace CreateEntitiesFromCSV
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private OpenFileDialog ofd;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //int size = -1;
            ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = ofd.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    txtBoxFileLocation.Text = file;
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void btnCreateClass_Click(object sender, EventArgs e)
        {
            try
            {
                string fileNameAndLocation = txtBoxFileLocation.Text;
                var classFileName = Path.ChangeExtension(fileNameAndLocation, ".cs");

                var classCodes = MapCSVtoEntities.CreateClass.GenerateCodes(fileNameAndLocation, ',');
                txtBoxConfirmation.Text = "CLass file is created in following location.\n\n" + classFileName;
                File.WriteAllText(classFileName, classCodes);
                string text = File.ReadAllText(classFileName);
                txtBoxOutput.Text = "\n" + text;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n{ex.StackTrace}");
            }
        }
    }
}
