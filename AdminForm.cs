using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Security.Cryptography;

namespace OOPIP
{
    public partial class AdminForm : MaterialForm
    {
        Controller controller = new Controller(new BD());
        

        public AdminForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green200, TextShade.WHITE);
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            DataGridView.DataSource = controller.viewTable(ComboBoxViewData.SelectedItem.ToString()).Tables[0];
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchDataButton_Click_1(object sender, EventArgs e)
        {
            if(controller.checkSearch(SearchDataComboBox)) {
                SearchColumnComboBox.Items.Clear();
                controller.readyDataSearch(SearchDataComboBox.SelectedItem.ToString(), SearchColumnComboBox);
                SearchColumnLabel.Visible = true;
                SearchColumnComboBox.Visible = true;
                SearchColumnButton.Visible = true;
                ResetButton.Visible = true;
                SearchDataButton.BackColor = Color.Green;
                SearchColumnButton.BackColor = Color.Gray;
                SearchValueButton.BackColor = Color.Gray;
         
                
            }
            else
            {
                MaterialMessageBox.Show("Not select table");
            }
          

        }

        private void SearchColumnButton_Click(object sender, EventArgs e)
        {
            if (controller.checkSearch(SearchColumnComboBox))
            {
                controller.readyColoumnSearch(SearchColumnComboBox.SelectedItem.ToString());
                SearchValueLabel.Visible = true;
                SearchValueTextBox.Visible = true;
                SearchValueButton.Visible = true;
                SearchColumnButton.BackColor = Color.Green;
                SearchValueButton.BackColor = Color.Gray;
            }
            
          
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            SearchColumnLabel.Visible = false;
            SearchColumnComboBox.Visible = false;
            SearchColumnButton.Visible = false;
            ResetButton.Visible = false;
            SearchDataButton.BackColor = Color.Gray;

            SearchValueLabel.Visible = false;
            SearchValueTextBox.Visible = false;
            SearchValueButton.Visible = false;
            SearchColumnButton.BackColor = Color.Gray;
        }

        private void SearchValueButton_Click(object sender, EventArgs e)
        {
            if(SearchValueTextBox.Text != "")
            {
                controller.readyValueSearch(SearchValueTextBox.Text);
                SearchButton.Visible = true;
                SearchValueButton.BackColor = Color.Green;
            }
            else {
                MaterialMessageBox.Show("Enter value!!!");
            }
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataGridSearch.DataSource = controller.search().Tables[0];
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            updateGridView.DataSource = controller.chooseTableUpdate(UpdateComboBox.SelectedItem.ToString()).DefaultView;
            UpdateButton.Visible = true;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try { controller.update(UpdateComboBox.SelectedItem.ToString()); }
            catch (MySqlException) {
                MaterialMessageBox.Show("Введён не верный формат дынных!");
            }
            catch (System.FormatException)
            {
                MaterialMessageBox.Show("Введён не верный формат дынных!!!");
            }
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            AutorizationForm autorizationForm = new AutorizationForm();
            autorizationForm.Close();
            Close();
           
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            AutorizationForm autorizationForm = new AutorizationForm();
            autorizationForm.Show();
            Hide();
        }

        private void ChooseExportButton_Click(object sender, EventArgs e)
        {
            dataGridExport.DataSource = controller.viewTable(ExportComboBox.SelectedItem.ToString()).Tables[0];
            ExportButton.Visible = true;
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            controller.export(dataGridExport);
        }


        private void ChooseExcelButton_Click(object sender, EventArgs e)
        {
            controller.export(dataGridExport);
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {

            dataGridInventory.DataSource = controller.viewChanges().Tables[0];
            materialCardReport.Visible=true;

        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            controller.copyLastInventory(); 
        }

        private void materialButton1_Click_2(object sender, EventArgs e)
        {
            controller.exportToHead(dataGridInventory);
        }

        private void ChooseTableInventoryButton_Click(object sender, EventArgs e)
        {
            dataGridInventory.DataSource = controller.chooseTableUpdate(InventoryBox.SelectedItem.ToString()).DefaultView;
            UpdateInventoryButton.Visible = true;
        }

        private void UpdateInventoryButton_Click(object sender, EventArgs e)
        {
            controller.update(InventoryBox.SelectedItem.ToString());
            CreateInventoryButton.Visible = true;
        }

        private void CreateInventoryButton_Click(object sender, EventArgs e)
        {
            controller.copyLastInventory();
        }
    }
}
