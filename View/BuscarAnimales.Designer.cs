namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.View
{
    partial class BuscarAnimales
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
            ExitButton = new Button();
            IdComboBox = new ComboBox();
            SearchButton = new Button();
            EnterIDLbl = new Label();
            TitleLbl = new Label();
            AnimalsDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)AnimalsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI", 18F);
            ExitButton.Location = new Point(336, 386);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(122, 43);
            ExitButton.TabIndex = 21;
            ExitButton.Text = "Volver";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // IdComboBox
            // 
            IdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            IdComboBox.FormattingEnabled = true;
            IdComboBox.Location = new Point(362, 85);
            IdComboBox.Name = "IdComboBox";
            IdComboBox.Size = new Size(121, 23);
            IdComboBox.TabIndex = 20;
            // 
            // SearchButton
            // 
            SearchButton.Font = new Font("Segoe UI", 11F);
            SearchButton.Location = new Point(489, 82);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(82, 30);
            SearchButton.TabIndex = 19;
            SearchButton.Text = "Buscar";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // EnterIDLbl
            // 
            EnterIDLbl.AutoSize = true;
            EnterIDLbl.Font = new Font("Segoe UI", 14F);
            EnterIDLbl.Location = new Point(207, 83);
            EnterIDLbl.Name = "EnterIDLbl";
            EnterIDLbl.Size = new Size(149, 25);
            EnterIDLbl.TabIndex = 18;
            EnterIDLbl.Text = "Selecciona la ID:";
            EnterIDLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Font = new Font("Rockwell Nova Extra Bold", 14F, FontStyle.Bold);
            TitleLbl.Location = new Point(291, 21);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(204, 25);
            TitleLbl.TabIndex = 17;
            TitleLbl.Text = "Search Rescues";
            TitleLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // AnimalsDataGrid
            // 
            AnimalsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AnimalsDataGrid.Location = new Point(166, 141);
            AnimalsDataGrid.Name = "AnimalsDataGrid";
            AnimalsDataGrid.Size = new Size(468, 204);
            AnimalsDataGrid.TabIndex = 16;
            // 
            // BuscarAnimales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.maui_blue_ocean_abstract;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(IdComboBox);
            Controls.Add(SearchButton);
            Controls.Add(EnterIDLbl);
            Controls.Add(TitleLbl);
            Controls.Add(AnimalsDataGrid);
            Name = "BuscarAnimales";
            Text = "BuscarAnimales";
            Load += BuscarAnimales_Load;
            ((System.ComponentModel.ISupportInitialize)AnimalsDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitButton;
        private ComboBox IdComboBox;
        private Button SearchButton;
        private Label EnterIDLbl;
        private Label TitleLbl;
        private DataGridView AnimalsDataGrid;
    }
}