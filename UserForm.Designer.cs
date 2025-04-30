namespace OOPIP
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Exit = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.LogOutButton = new MaterialSkin.Controls.MaterialButton();
            this.ExitButton = new MaterialSkin.Controls.MaterialButton();
            this.Export = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.ExportButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ExportComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.ChooseExportButton = new MaterialSkin.Controls.MaterialButton();
            this.dataGridExport = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.TabPage();
            this.materialSearchCard = new MaterialSkin.Controls.MaterialCard();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SearchButton = new MaterialSkin.Controls.MaterialButton();
            this.SearchValueButton = new System.Windows.Forms.Button();
            this.SearchValueTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.SearchValueLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SearchColumnButton = new System.Windows.Forms.Button();
            this.SearchDataButton = new System.Windows.Forms.Button();
            this.SearchColumnComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.SearchColumnLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SearchDataLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SearchDataComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.DataGridSearch = new System.Windows.Forms.DataGridView();
            this.View = new System.Windows.Forms.TabPage();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.CardView = new MaterialSkin.Controls.MaterialCard();
            this.MateriaViewDatalLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ComboBoxViewData = new MaterialSkin.Controls.MaterialComboBox();
            this.ViewButton = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Exit.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.Export.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExport)).BeginInit();
            this.Search.SuspendLayout();
            this.materialSearchCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSearch)).BeginInit();
            this.View.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.CardView.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "view.png");
            this.imageList2.Images.SetKeyName(1, "search.png");
            this.imageList2.Images.SetKeyName(2, "delete.png");
            this.imageList2.Images.SetKeyName(3, "add.png");
            this.imageList2.Images.SetKeyName(4, "addUser.png");
            this.imageList2.Images.SetKeyName(5, "exit.png");
            this.imageList2.Images.SetKeyName(6, "update.png");
            this.imageList2.Images.SetKeyName(7, "sort.png");
            this.imageList2.Images.SetKeyName(8, "export.png");
            this.imageList2.Images.SetKeyName(9, "import.png");
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Exit
            // 
            this.Exit.Controls.Add(this.materialCard2);
            this.Exit.ImageKey = "exit.png";
            this.Exit.Location = new System.Drawing.Point(4, 39);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(1164, 773);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.LogOutButton);
            this.materialCard2.Controls.Add(this.ExitButton);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(0, 0);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(519, 212);
            this.materialCard2.TabIndex = 28;
            // 
            // LogOutButton
            // 
            this.LogOutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LogOutButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.LogOutButton.Depth = 0;
            this.LogOutButton.HighEmphasis = true;
            this.LogOutButton.Icon = null;
            this.LogOutButton.Location = new System.Drawing.Point(306, 97);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LogOutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.LogOutButton.Size = new System.Drawing.Size(82, 36);
            this.LogOutButton.TabIndex = 1;
            this.LogOutButton.Text = "Log out";
            this.LogOutButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LogOutButton.UseAccentColor = false;
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ExitButton.Depth = 0;
            this.ExitButton.HighEmphasis = true;
            this.ExitButton.Icon = null;
            this.ExitButton.Location = new System.Drawing.Point(115, 97);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ExitButton.Size = new System.Drawing.Size(64, 36);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ExitButton.UseAccentColor = false;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Export
            // 
            this.Export.Controls.Add(this.materialCard1);
            this.Export.Controls.Add(this.dataGridExport);
            this.Export.ImageKey = "export.png";
            this.Export.Location = new System.Drawing.Point(4, 39);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(1164, 773);
            this.Export.TabIndex = 8;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.ExportButton);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.ExportComboBox);
            this.materialCard1.Controls.Add(this.ChooseExportButton);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(79, 484);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(519, 212);
            this.materialCard1.TabIndex = 26;
            // 
            // ExportButton
            // 
            this.ExportButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExportButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ExportButton.Depth = 0;
            this.ExportButton.HighEmphasis = true;
            this.ExportButton.Icon = null;
            this.ExportButton.Location = new System.Drawing.Point(297, 138);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExportButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ExportButton.Size = new System.Drawing.Size(77, 36);
            this.ExportButton.TabIndex = 26;
            this.ExportButton.Text = "Export";
            this.ExportButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ExportButton.UseAccentColor = false;
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Visible = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(189, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(162, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Choose data for export";
            // 
            // ExportComboBox
            // 
            this.ExportComboBox.AutoResize = false;
            this.ExportComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ExportComboBox.Depth = 0;
            this.ExportComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ExportComboBox.DropDownHeight = 174;
            this.ExportComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExportComboBox.DropDownWidth = 121;
            this.ExportComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ExportComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExportComboBox.FormattingEnabled = true;
            this.ExportComboBox.IntegralHeight = false;
            this.ExportComboBox.ItemHeight = 43;
            this.ExportComboBox.Items.AddRange(new object[] {
            "user",
            "equipment",
            "category",
            "supply",
            "supplier",
            "supply_equipment"});
            this.ExportComboBox.Location = new System.Drawing.Point(100, 60);
            this.ExportComboBox.MaxDropDownItems = 4;
            this.ExportComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ExportComboBox.Name = "ExportComboBox";
            this.ExportComboBox.Size = new System.Drawing.Size(308, 49);
            this.ExportComboBox.StartIndex = 0;
            this.ExportComboBox.TabIndex = 2;
            // 
            // ChooseExportButton
            // 
            this.ChooseExportButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChooseExportButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ChooseExportButton.Depth = 0;
            this.ChooseExportButton.HighEmphasis = true;
            this.ChooseExportButton.Icon = null;
            this.ChooseExportButton.Location = new System.Drawing.Point(147, 138);
            this.ChooseExportButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ChooseExportButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChooseExportButton.Name = "ChooseExportButton";
            this.ChooseExportButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ChooseExportButton.Size = new System.Drawing.Size(79, 36);
            this.ChooseExportButton.TabIndex = 1;
            this.ChooseExportButton.Text = "choose";
            this.ChooseExportButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ChooseExportButton.UseAccentColor = false;
            this.ChooseExportButton.UseVisualStyleBackColor = true;
            this.ChooseExportButton.Click += new System.EventHandler(this.ChooseExportButton_Click);
            // 
            // dataGridExport
            // 
            this.dataGridExport.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridExport.Location = new System.Drawing.Point(-4, 0);
            this.dataGridExport.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridExport.Name = "dataGridExport";
            this.dataGridExport.RowHeadersWidth = 51;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.dataGridExport.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridExport.Size = new System.Drawing.Size(1186, 466);
            this.dataGridExport.TabIndex = 25;
            // 
            // Search
            // 
            this.Search.Controls.Add(this.materialSearchCard);
            this.Search.Controls.Add(this.DataGridSearch);
            this.Search.ImageKey = "search.png";
            this.Search.Location = new System.Drawing.Point(4, 39);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(3);
            this.Search.Size = new System.Drawing.Size(1164, 773);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // materialSearchCard
            // 
            this.materialSearchCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialSearchCard.Controls.Add(this.ResetButton);
            this.materialSearchCard.Controls.Add(this.SearchButton);
            this.materialSearchCard.Controls.Add(this.SearchValueButton);
            this.materialSearchCard.Controls.Add(this.SearchValueTextBox);
            this.materialSearchCard.Controls.Add(this.SearchValueLabel);
            this.materialSearchCard.Controls.Add(this.SearchColumnButton);
            this.materialSearchCard.Controls.Add(this.SearchDataButton);
            this.materialSearchCard.Controls.Add(this.SearchColumnComboBox);
            this.materialSearchCard.Controls.Add(this.SearchColumnLabel);
            this.materialSearchCard.Controls.Add(this.SearchDataLabel);
            this.materialSearchCard.Controls.Add(this.SearchDataComboBox);
            this.materialSearchCard.Depth = 0;
            this.materialSearchCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSearchCard.Location = new System.Drawing.Point(17, 372);
            this.materialSearchCard.Margin = new System.Windows.Forms.Padding(14);
            this.materialSearchCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSearchCard.Name = "materialSearchCard";
            this.materialSearchCard.Padding = new System.Windows.Forms.Padding(14);
            this.materialSearchCard.Size = new System.Drawing.Size(1047, 185);
            this.materialSearchCard.TabIndex = 26;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Yellow;
            this.ResetButton.Location = new System.Drawing.Point(914, 118);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(78, 39);
            this.ResetButton.TabIndex = 13;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Visible = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SearchButton.Depth = 0;
            this.SearchButton.HighEmphasis = true;
            this.SearchButton.Icon = null;
            this.SearchButton.Location = new System.Drawing.Point(914, 53);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SearchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SearchButton.Size = new System.Drawing.Size(78, 36);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Search";
            this.SearchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SearchButton.UseAccentColor = false;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Visible = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchValueButton
            // 
            this.SearchValueButton.BackColor = System.Drawing.Color.Gray;
            this.SearchValueButton.Location = new System.Drawing.Point(709, 129);
            this.SearchValueButton.Name = "SearchValueButton";
            this.SearchValueButton.Size = new System.Drawing.Size(87, 39);
            this.SearchValueButton.TabIndex = 11;
            this.SearchValueButton.Text = "OK";
            this.SearchValueButton.UseVisualStyleBackColor = false;
            this.SearchValueButton.Visible = false;
            this.SearchValueButton.Click += new System.EventHandler(this.SearchValueButton_Click);
            // 
            // SearchValueTextBox
            // 
            this.SearchValueTextBox.AnimateReadOnly = false;
            this.SearchValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchValueTextBox.Depth = 0;
            this.SearchValueTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SearchValueTextBox.LeadingIcon = null;
            this.SearchValueTextBox.Location = new System.Drawing.Point(667, 61);
            this.SearchValueTextBox.MaxLength = 50;
            this.SearchValueTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.SearchValueTextBox.Multiline = false;
            this.SearchValueTextBox.Name = "SearchValueTextBox";
            this.SearchValueTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SearchValueTextBox.Size = new System.Drawing.Size(174, 50);
            this.SearchValueTextBox.TabIndex = 10;
            this.SearchValueTextBox.Text = "";
            this.SearchValueTextBox.TrailingIcon = null;
            this.SearchValueTextBox.Visible = false;
            // 
            // SearchValueLabel
            // 
            this.SearchValueLabel.AutoSize = true;
            this.SearchValueLabel.Depth = 0;
            this.SearchValueLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SearchValueLabel.Location = new System.Drawing.Point(700, 23);
            this.SearchValueLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchValueLabel.Name = "SearchValueLabel";
            this.SearchValueLabel.Size = new System.Drawing.Size(96, 19);
            this.SearchValueLabel.TabIndex = 9;
            this.SearchValueLabel.Text = "Choose value";
            this.SearchValueLabel.Visible = false;
            // 
            // SearchColumnButton
            // 
            this.SearchColumnButton.BackColor = System.Drawing.Color.Gray;
            this.SearchColumnButton.Location = new System.Drawing.Point(437, 129);
            this.SearchColumnButton.Name = "SearchColumnButton";
            this.SearchColumnButton.Size = new System.Drawing.Size(87, 39);
            this.SearchColumnButton.TabIndex = 8;
            this.SearchColumnButton.Text = "OK";
            this.SearchColumnButton.UseVisualStyleBackColor = false;
            this.SearchColumnButton.Visible = false;
            this.SearchColumnButton.Click += new System.EventHandler(this.SearchColumnButton_Click);
            // 
            // SearchDataButton
            // 
            this.SearchDataButton.BackColor = System.Drawing.Color.Gray;
            this.SearchDataButton.Location = new System.Drawing.Point(142, 129);
            this.SearchDataButton.Name = "SearchDataButton";
            this.SearchDataButton.Size = new System.Drawing.Size(87, 39);
            this.SearchDataButton.TabIndex = 7;
            this.SearchDataButton.Text = "OK";
            this.SearchDataButton.UseVisualStyleBackColor = false;
            this.SearchDataButton.Click += new System.EventHandler(this.SearchDataButton_Click);
            // 
            // SearchColumnComboBox
            // 
            this.SearchColumnComboBox.AutoResize = false;
            this.SearchColumnComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchColumnComboBox.Depth = 0;
            this.SearchColumnComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.SearchColumnComboBox.DropDownHeight = 174;
            this.SearchColumnComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchColumnComboBox.DropDownWidth = 121;
            this.SearchColumnComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SearchColumnComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SearchColumnComboBox.FormattingEnabled = true;
            this.SearchColumnComboBox.IntegralHeight = false;
            this.SearchColumnComboBox.ItemHeight = 43;
            this.SearchColumnComboBox.Location = new System.Drawing.Point(395, 60);
            this.SearchColumnComboBox.MaxDropDownItems = 4;
            this.SearchColumnComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.SearchColumnComboBox.Name = "SearchColumnComboBox";
            this.SearchColumnComboBox.Size = new System.Drawing.Size(174, 49);
            this.SearchColumnComboBox.StartIndex = 0;
            this.SearchColumnComboBox.TabIndex = 5;
            this.SearchColumnComboBox.Visible = false;
            // 
            // SearchColumnLabel
            // 
            this.SearchColumnLabel.AutoSize = true;
            this.SearchColumnLabel.Depth = 0;
            this.SearchColumnLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SearchColumnLabel.Location = new System.Drawing.Point(434, 23);
            this.SearchColumnLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchColumnLabel.Name = "SearchColumnLabel";
            this.SearchColumnLabel.Size = new System.Drawing.Size(111, 19);
            this.SearchColumnLabel.TabIndex = 4;
            this.SearchColumnLabel.Text = "Choose column";
            this.SearchColumnLabel.Visible = false;
            // 
            // SearchDataLabel
            // 
            this.SearchDataLabel.AutoSize = true;
            this.SearchDataLabel.Depth = 0;
            this.SearchDataLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SearchDataLabel.Location = new System.Drawing.Point(139, 23);
            this.SearchDataLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchDataLabel.Name = "SearchDataLabel";
            this.SearchDataLabel.Size = new System.Drawing.Size(90, 19);
            this.SearchDataLabel.TabIndex = 3;
            this.SearchDataLabel.Text = "Choose data";
            // 
            // SearchDataComboBox
            // 
            this.SearchDataComboBox.AutoResize = false;
            this.SearchDataComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchDataComboBox.Depth = 0;
            this.SearchDataComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.SearchDataComboBox.DropDownHeight = 174;
            this.SearchDataComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchDataComboBox.DropDownWidth = 121;
            this.SearchDataComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SearchDataComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SearchDataComboBox.FormattingEnabled = true;
            this.SearchDataComboBox.IntegralHeight = false;
            this.SearchDataComboBox.ItemHeight = 43;
            this.SearchDataComboBox.Items.AddRange(new object[] {
            "equipment",
            "category",
            "supply",
            "supplier"});
            this.SearchDataComboBox.Location = new System.Drawing.Point(100, 60);
            this.SearchDataComboBox.MaxDropDownItems = 4;
            this.SearchDataComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.SearchDataComboBox.Name = "SearchDataComboBox";
            this.SearchDataComboBox.Size = new System.Drawing.Size(174, 49);
            this.SearchDataComboBox.StartIndex = 0;
            this.SearchDataComboBox.TabIndex = 2;
            // 
            // DataGridSearch
            // 
            this.DataGridSearch.BackgroundColor = System.Drawing.Color.Gray;
            this.DataGridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridSearch.Location = new System.Drawing.Point(0, 0);
            this.DataGridSearch.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridSearch.Name = "DataGridSearch";
            this.DataGridSearch.RowHeadersWidth = 51;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.DataGridSearch.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridSearch.Size = new System.Drawing.Size(1186, 354);
            this.DataGridSearch.TabIndex = 25;
            // 
            // View
            // 
            this.View.Controls.Add(this.DataGridView);
            this.View.Controls.Add(this.CardView);
            this.View.ImageKey = "view.png";
            this.View.Location = new System.Drawing.Point(4, 39);
            this.View.Name = "View";
            this.View.Padding = new System.Windows.Forms.Padding(3);
            this.View.Size = new System.Drawing.Size(1164, 773);
            this.View.TabIndex = 0;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.Color.Gray;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(0, 0);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridView.Size = new System.Drawing.Size(1186, 466);
            this.DataGridView.TabIndex = 24;
            // 
            // CardView
            // 
            this.CardView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CardView.Controls.Add(this.MateriaViewDatalLabel);
            this.CardView.Controls.Add(this.ComboBoxViewData);
            this.CardView.Controls.Add(this.ViewButton);
            this.CardView.Depth = 0;
            this.CardView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CardView.Location = new System.Drawing.Point(0, 478);
            this.CardView.Margin = new System.Windows.Forms.Padding(14);
            this.CardView.MouseState = MaterialSkin.MouseState.HOVER;
            this.CardView.Name = "CardView";
            this.CardView.Padding = new System.Windows.Forms.Padding(14);
            this.CardView.Size = new System.Drawing.Size(519, 212);
            this.CardView.TabIndex = 1;
            // 
            // MateriaViewDatalLabel
            // 
            this.MateriaViewDatalLabel.AutoSize = true;
            this.MateriaViewDatalLabel.Depth = 0;
            this.MateriaViewDatalLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MateriaViewDatalLabel.Location = new System.Drawing.Point(189, 14);
            this.MateriaViewDatalLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.MateriaViewDatalLabel.Name = "MateriaViewDatalLabel";
            this.MateriaViewDatalLabel.Size = new System.Drawing.Size(150, 19);
            this.MateriaViewDatalLabel.TabIndex = 3;
            this.MateriaViewDatalLabel.Text = "Choose data for view";
            // 
            // ComboBoxViewData
            // 
            this.ComboBoxViewData.AutoResize = false;
            this.ComboBoxViewData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxViewData.Depth = 0;
            this.ComboBoxViewData.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxViewData.DropDownHeight = 174;
            this.ComboBoxViewData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxViewData.DropDownWidth = 121;
            this.ComboBoxViewData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBoxViewData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxViewData.FormattingEnabled = true;
            this.ComboBoxViewData.IntegralHeight = false;
            this.ComboBoxViewData.ItemHeight = 43;
            this.ComboBoxViewData.Items.AddRange(new object[] {
            "equipment",
            "category",
            "supply",
            "supplier"});
            this.ComboBoxViewData.Location = new System.Drawing.Point(104, 60);
            this.ComboBoxViewData.MaxDropDownItems = 4;
            this.ComboBoxViewData.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxViewData.Name = "ComboBoxViewData";
            this.ComboBoxViewData.Size = new System.Drawing.Size(308, 49);
            this.ComboBoxViewData.StartIndex = 0;
            this.ComboBoxViewData.TabIndex = 2;
            // 
            // ViewButton
            // 
            this.ViewButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ViewButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ViewButton.Depth = 0;
            this.ViewButton.HighEmphasis = true;
            this.ViewButton.Icon = null;
            this.ViewButton.Location = new System.Drawing.Point(228, 145);
            this.ViewButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ViewButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ViewButton.Size = new System.Drawing.Size(64, 36);
            this.ViewButton.TabIndex = 1;
            this.ViewButton.Text = "View";
            this.ViewButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ViewButton.UseAccentColor = false;
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.View);
            this.materialTabControl1.Controls.Add(this.Search);
            this.materialTabControl1.Controls.Add(this.Export);
            this.materialTabControl1.Controls.Add(this.Exit);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList2;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1172, 816);
            this.materialTabControl1.TabIndex = 1;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 883);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Exit.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.Export.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExport)).EndInit();
            this.Search.ResumeLayout(false);
            this.materialSearchCard.ResumeLayout(false);
            this.materialSearchCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSearch)).EndInit();
            this.View.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.CardView.ResumeLayout(false);
            this.CardView.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabPage Exit;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton LogOutButton;
        private MaterialSkin.Controls.MaterialButton ExitButton;
        private System.Windows.Forms.TabPage Export;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton ExportButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox ExportComboBox;
        private MaterialSkin.Controls.MaterialButton ChooseExportButton;
        private System.Windows.Forms.DataGridView dataGridExport;
        private System.Windows.Forms.TabPage Search;
        private MaterialSkin.Controls.MaterialCard materialSearchCard;
        private System.Windows.Forms.Button ResetButton;
        private MaterialSkin.Controls.MaterialButton SearchButton;
        private System.Windows.Forms.Button SearchValueButton;
        private MaterialSkin.Controls.MaterialTextBox SearchValueTextBox;
        private MaterialSkin.Controls.MaterialLabel SearchValueLabel;
        private System.Windows.Forms.Button SearchColumnButton;
        private System.Windows.Forms.Button SearchDataButton;
        private MaterialSkin.Controls.MaterialComboBox SearchColumnComboBox;
        private MaterialSkin.Controls.MaterialLabel SearchColumnLabel;
        private MaterialSkin.Controls.MaterialLabel SearchDataLabel;
        private MaterialSkin.Controls.MaterialComboBox SearchDataComboBox;
        private System.Windows.Forms.DataGridView DataGridSearch;
        private System.Windows.Forms.TabPage View;
        private System.Windows.Forms.DataGridView DataGridView;
        private MaterialSkin.Controls.MaterialCard CardView;
        private MaterialSkin.Controls.MaterialLabel MateriaViewDatalLabel;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxViewData;
        private MaterialSkin.Controls.MaterialButton ViewButton;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
    }
}