namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.View
{
    partial class BuscarRescates
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
            RescuesDataGrid = new DataGridView();
            TitleLbl = new Label();
            EnterIDLbl = new Label();
            SearchButton = new Button();
            IdComboBox = new ComboBox();
            ExitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)RescuesDataGrid).BeginInit();
            SuspendLayout();
            // 
            // RescuesDataGrid
            // 
            RescuesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RescuesDataGrid.Location = new Point(170, 129);
            RescuesDataGrid.Name = "RescuesDataGrid";
            RescuesDataGrid.Size = new Size(468, 204);
            RescuesDataGrid.TabIndex = 0;
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Font = new Font("Rockwell Nova Extra Bold", 14F, FontStyle.Bold);
            TitleLbl.Location = new Point(295, 9);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(204, 25);
            TitleLbl.TabIndex = 5;
            TitleLbl.Text = "Search Rescues";
            TitleLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // EnterIDLbl
            // 
            EnterIDLbl.AutoSize = true;
            EnterIDLbl.Font = new Font("Segoe UI", 14F);
            EnterIDLbl.Location = new Point(211, 71);
            EnterIDLbl.Name = "EnterIDLbl";
            EnterIDLbl.Size = new Size(149, 25);
            EnterIDLbl.TabIndex = 11;
            EnterIDLbl.Text = "Selecciona la ID:";
            EnterIDLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // SearchButton
            // 
            SearchButton.Font = new Font("Segoe UI", 11F);
            SearchButton.Location = new Point(493, 70);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(82, 30);
            SearchButton.TabIndex = 13;
            SearchButton.Text = "Buscar";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // IdComboBox
            // 
            IdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            IdComboBox.FormattingEnabled = true;
            IdComboBox.Location = new Point(366, 73);
            IdComboBox.Name = "IdComboBox";
            IdComboBox.Size = new Size(121, 23);
            IdComboBox.TabIndex = 14;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI", 18F);
            ExitButton.Location = new Point(340, 374);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(122, 43);
            ExitButton.TabIndex = 15;
            ExitButton.Text = "Volver";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // BuscarRescates
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
            Controls.Add(RescuesDataGrid);
            Name = "BuscarRescates";
            Text = "BuscarRescates";
            Load += BuscarRescates_Load;
            ((System.ComponentModel.ISupportInitialize)RescuesDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView RescuesDataGrid;
        private Label TitleLbl;
        private Label EnterIDLbl;
        private Button SearchButton;
        private ComboBox IdComboBox;
        private Button ExitButton;
    }
}