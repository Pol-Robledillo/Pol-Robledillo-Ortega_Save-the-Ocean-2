namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.View
{
    partial class CreacionAnimal
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
            GameLbl = new Label();
            label1 = new Label();
            NameInput = new TextBox();
            label2 = new Label();
            SuperFamilySelect = new ComboBox();
            SpeciesInput = new TextBox();
            label3 = new Label();
            WeightInput = new TextBox();
            label4 = new Label();
            errorProvider1 = new ErrorProvider(components);
            GoBackBtn = new Button();
            SaveBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // GameLbl
            // 
            GameLbl.AutoSize = true;
            GameLbl.Font = new Font("Rockwell Nova Extra Bold", 14F, FontStyle.Bold);
            GameLbl.Location = new Point(12, 9);
            GameLbl.Name = "GameLbl";
            GameLbl.Size = new Size(298, 25);
            GameLbl.TabIndex = 5;
            GameLbl.Text = "Creación de un Animal";
            GameLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(84, 53);
            label1.Name = "label1";
            label1.Size = new Size(154, 21);
            label1.TabIndex = 21;
            label1.Text = "Introduce el nombre:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // NameInput
            // 
            NameInput.Location = new Point(84, 77);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(154, 23);
            NameInput.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(65, 112);
            label2.Name = "label2";
            label2.Size = new Size(192, 21);
            label2.TabIndex = 23;
            label2.Text = "Selecciona la superfamilia:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // SuperFamilySelect
            // 
            SuperFamilySelect.DropDownStyle = ComboBoxStyle.DropDownList;
            SuperFamilySelect.FormattingEnabled = true;
            SuperFamilySelect.Location = new Point(84, 136);
            SuperFamilySelect.Name = "SuperFamilySelect";
            SuperFamilySelect.Size = new Size(154, 23);
            SuperFamilySelect.TabIndex = 24;
            // 
            // SpeciesInput
            // 
            SpeciesInput.Location = new Point(84, 195);
            SpeciesInput.Name = "SpeciesInput";
            SpeciesInput.Size = new Size(154, 23);
            SpeciesInput.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(84, 171);
            label3.Name = "label3";
            label3.Size = new Size(154, 21);
            label3.TabIndex = 25;
            label3.Text = "Introduce la especie: ";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // WeightInput
            // 
            WeightInput.Location = new Point(84, 254);
            WeightInput.Name = "WeightInput";
            WeightInput.Size = new Size(154, 23);
            WeightInput.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(95, 230);
            label4.Name = "label4";
            label4.Size = new Size(132, 21);
            label4.TabIndex = 27;
            label4.Text = "Introduce el peso:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // GoBackBtn
            // 
            GoBackBtn.Font = new Font("Segoe UI", 11F);
            GoBackBtn.Location = new Point(12, 322);
            GoBackBtn.Name = "GoBackBtn";
            GoBackBtn.Size = new Size(82, 30);
            GoBackBtn.TabIndex = 30;
            GoBackBtn.Text = "Cancelar";
            GoBackBtn.UseVisualStyleBackColor = true;
            GoBackBtn.Click += GoBackBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Font = new Font("Segoe UI", 11F);
            SaveBtn.Location = new Point(228, 322);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(82, 30);
            SaveBtn.TabIndex = 29;
            SaveBtn.Text = "Guardar";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CreacionAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.maui_blue_ocean_abstract;
            ClientSize = new Size(322, 364);
            Controls.Add(GoBackBtn);
            Controls.Add(SaveBtn);
            Controls.Add(WeightInput);
            Controls.Add(label4);
            Controls.Add(SpeciesInput);
            Controls.Add(label3);
            Controls.Add(SuperFamilySelect);
            Controls.Add(label2);
            Controls.Add(NameInput);
            Controls.Add(label1);
            Controls.Add(GameLbl);
            Name = "CreacionAnimal";
            Text = "CreacionAnimal";
            Load += CreacionAnimal_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label GameLbl;
        private Label label1;
        private TextBox NameInput;
        private Label label2;
        private ComboBox SuperFamilySelect;
        private TextBox SpeciesInput;
        private Label label3;
        private TextBox WeightInput;
        private Label label4;
        private ErrorProvider errorProvider1;
        private Button GoBackBtn;
        private Button SaveBtn;
    }
}