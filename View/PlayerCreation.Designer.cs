namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.View
{
    partial class PlayerCreation
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
            NameLbl = new Label();
            NameInput = new TextBox();
            OccupationLbl = new Label();
            OccupationComboBox = new ComboBox();
            CharacterCreationLbl = new Label();
            CreatePlayerButton = new Button();
            ReturnButton = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Font = new Font("Segoe UI", 12F);
            NameLbl.Location = new Point(42, 56);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(237, 21);
            NameLbl.TabIndex = 0;
            NameLbl.Text = "Introduce el nombre del jugador:";
            NameLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameInput
            // 
            NameInput.Location = new Point(76, 80);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(163, 23);
            NameInput.TabIndex = 1;
            // 
            // OccupationLbl
            // 
            OccupationLbl.AutoSize = true;
            OccupationLbl.Font = new Font("Segoe UI", 12F);
            OccupationLbl.Location = new Point(42, 120);
            OccupationLbl.Name = "OccupationLbl";
            OccupationLbl.Size = new Size(235, 21);
            OccupationLbl.TabIndex = 2;
            OccupationLbl.Text = "Escoge la ocupación del jugador:";
            OccupationLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OccupationComboBox
            // 
            OccupationComboBox.FormattingEnabled = true;
            OccupationComboBox.Location = new Point(76, 144);
            OccupationComboBox.Name = "OccupationComboBox";
            OccupationComboBox.Size = new Size(163, 23);
            OccupationComboBox.TabIndex = 3;
            // 
            // CharacterCreationLbl
            // 
            CharacterCreationLbl.AutoSize = true;
            CharacterCreationLbl.Font = new Font("Rockwell Nova Extra Bold", 14F, FontStyle.Bold);
            CharacterCreationLbl.Location = new Point(16, 15);
            CharacterCreationLbl.Name = "CharacterCreationLbl";
            CharacterCreationLbl.Size = new Size(292, 25);
            CharacterCreationLbl.TabIndex = 4;
            CharacterCreationLbl.Text = "Creación de Personaje";
            CharacterCreationLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CreatePlayerButton
            // 
            CreatePlayerButton.Font = new Font("Segoe UI", 12F);
            CreatePlayerButton.Location = new Point(40, 198);
            CreatePlayerButton.Name = "CreatePlayerButton";
            CreatePlayerButton.Size = new Size(115, 32);
            CreatePlayerButton.TabIndex = 5;
            CreatePlayerButton.Text = "Confirmar";
            CreatePlayerButton.UseVisualStyleBackColor = true;
            CreatePlayerButton.Click += CreatePlayerButton_Click;
            // 
            // ReturnButton
            // 
            ReturnButton.Font = new Font("Segoe UI", 12F);
            ReturnButton.Location = new Point(161, 198);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(115, 32);
            ReturnButton.TabIndex = 6;
            ReturnButton.Text = "Volver";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // PlayerCreation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.maui_blue_ocean_abstract;
            ClientSize = new Size(323, 248);
            Controls.Add(ReturnButton);
            Controls.Add(CreatePlayerButton);
            Controls.Add(CharacterCreationLbl);
            Controls.Add(OccupationComboBox);
            Controls.Add(OccupationLbl);
            Controls.Add(NameInput);
            Controls.Add(NameLbl);
            Name = "PlayerCreation";
            Text = "PlayerCreation";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLbl;
        private TextBox NameInput;
        private Label OccupationLbl;
        private ComboBox OccupationComboBox;
        private Label CharacterCreationLbl;
        private Button CreatePlayerButton;
        private Button ReturnButton;
        private ErrorProvider errorProvider1;
    }
}