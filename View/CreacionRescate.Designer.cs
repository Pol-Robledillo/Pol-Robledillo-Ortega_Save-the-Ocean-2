namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.View
{
    partial class CreacionRescate
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
            components = new System.ComponentModel.Container();
            errorProvider1 = new ErrorProvider(components);
            GameLbl = new Label();
            SaveBtn = new Button();
            GoBackBtn = new Button();
            EnterIDLbl = new Label();
            label1 = new Label();
            LocationTextBox = new TextBox();
            IdComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // GameLbl
            // 
            GameLbl.AutoSize = true;
            GameLbl.Font = new Font("Rockwell Nova Extra Bold", 14F, FontStyle.Bold);
            GameLbl.Location = new Point(25, 9);
            GameLbl.Name = "GameLbl";
            GameLbl.Size = new Size(265, 25);
            GameLbl.TabIndex = 5;
            GameLbl.Text = "Creación de Rescate";
            GameLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // SaveBtn
            // 
            SaveBtn.Font = new Font("Segoe UI", 11F);
            SaveBtn.Location = new Point(222, 170);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(82, 30);
            SaveBtn.TabIndex = 9;
            SaveBtn.Text = "Guardar";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // GoBackBtn
            // 
            GoBackBtn.Font = new Font("Segoe UI", 11F);
            GoBackBtn.Location = new Point(12, 170);
            GoBackBtn.Name = "GoBackBtn";
            GoBackBtn.Size = new Size(82, 30);
            GoBackBtn.TabIndex = 10;
            GoBackBtn.Text = "Cancelar";
            GoBackBtn.UseVisualStyleBackColor = true;
            GoBackBtn.Click += GoBackBtn_Click;
            // 
            // EnterIDLbl
            // 
            EnterIDLbl.AutoSize = true;
            EnterIDLbl.Font = new Font("Segoe UI", 12F);
            EnterIDLbl.Location = new Point(59, 107);
            EnterIDLbl.Name = "EnterIDLbl";
            EnterIDLbl.Size = new Size(197, 21);
            EnterIDLbl.TabIndex = 19;
            EnterIDLbl.Text = "Selecciona la ID del animal:";
            EnterIDLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(68, 46);
            label1.Name = "label1";
            label1.Size = new Size(179, 21);
            label1.TabIndex = 20;
            label1.Text = "Introduce la localización:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // LocationTextBox
            // 
            LocationTextBox.Location = new Point(68, 70);
            LocationTextBox.Name = "LocationTextBox";
            LocationTextBox.Size = new Size(179, 23);
            LocationTextBox.TabIndex = 21;
            // 
            // IdComboBox
            // 
            IdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            IdComboBox.FormattingEnabled = true;
            IdComboBox.Location = new Point(97, 131);
            IdComboBox.Name = "IdComboBox";
            IdComboBox.Size = new Size(121, 23);
            IdComboBox.TabIndex = 22;
            // 
            // CreacionRescate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.maui_blue_ocean_abstract;
            ClientSize = new Size(316, 212);
            Controls.Add(IdComboBox);
            Controls.Add(LocationTextBox);
            Controls.Add(label1);
            Controls.Add(EnterIDLbl);
            Controls.Add(GoBackBtn);
            Controls.Add(SaveBtn);
            Controls.Add(GameLbl);
            Name = "CreacionRescate";
            Text = "CreacionRescate";
            Load += CreacionRescate_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private Label GameLbl;
        private Button GoBackBtn;
        private Button SaveBtn;
        private ComboBox IdComboBox;
        private TextBox LocationTextBox;
        private Label label1;
        private Label EnterIDLbl;
    }
}