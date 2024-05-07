namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.View
{
    partial class GameWindow
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
            GameLbl = new Label();
            HealButton = new Button();
            MoveAnimalButton = new Button();
            SearchRescuesButton = new Button();
            NewRescueButton = new Button();
            AnimalsInfoDataGrid = new DataGridView();
            RescueInfoLbl = new Label();
            AnimalInfoLbl = new Label();
            SearchAnimalsButton = new Button();
            NewAnimalButton = new Button();
            ExitButton = new Button();
            GameExpLbl = new Label();
            GameExpValueLbl = new Label();
            NextRescueButton = new Button();
            ((System.ComponentModel.ISupportInitialize)RescuesDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AnimalsInfoDataGrid).BeginInit();
            SuspendLayout();
            // 
            // RescuesDataGrid
            // 
            RescuesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RescuesDataGrid.Location = new Point(12, 86);
            RescuesDataGrid.Name = "RescuesDataGrid";
            RescuesDataGrid.Size = new Size(381, 200);
            RescuesDataGrid.TabIndex = 0;
            // 
            // GameLbl
            // 
            GameLbl.AutoSize = true;
            GameLbl.Font = new Font("Rockwell Nova Extra Bold", 14F, FontStyle.Bold);
            GameLbl.Location = new Point(297, 9);
            GameLbl.Name = "GameLbl";
            GameLbl.Size = new Size(207, 25);
            GameLbl.TabIndex = 4;
            GameLbl.Text = "Save the Ocean!";
            GameLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // HealButton
            // 
            HealButton.Font = new Font("Segoe UI", 18F);
            HealButton.Location = new Point(271, 324);
            HealButton.Name = "HealButton";
            HealButton.Size = new Size(122, 43);
            HealButton.TabIndex = 5;
            HealButton.Text = "Curar";
            HealButton.UseVisualStyleBackColor = true;
            HealButton.Click += HealButton_Click;
            // 
            // MoveAnimalButton
            // 
            MoveAnimalButton.Font = new Font("Segoe UI", 18F);
            MoveAnimalButton.Location = new Point(399, 324);
            MoveAnimalButton.Name = "MoveAnimalButton";
            MoveAnimalButton.Size = new Size(122, 43);
            MoveAnimalButton.TabIndex = 6;
            MoveAnimalButton.Text = "Trasladar";
            MoveAnimalButton.UseVisualStyleBackColor = true;
            MoveAnimalButton.Click += MoveAnimalButton_Click;
            // 
            // SearchRescuesButton
            // 
            SearchRescuesButton.Font = new Font("Segoe UI", 11F);
            SearchRescuesButton.Location = new Point(12, 292);
            SearchRescuesButton.Name = "SearchRescuesButton";
            SearchRescuesButton.Size = new Size(82, 30);
            SearchRescuesButton.TabIndex = 8;
            SearchRescuesButton.Text = "Buscar";
            SearchRescuesButton.UseVisualStyleBackColor = true;
            SearchRescuesButton.Click += SearchRescuesButton_Click;
            // 
            // NewRescueButton
            // 
            NewRescueButton.Font = new Font("Segoe UI", 11F);
            NewRescueButton.Location = new Point(100, 292);
            NewRescueButton.Name = "NewRescueButton";
            NewRescueButton.Size = new Size(82, 30);
            NewRescueButton.TabIndex = 7;
            NewRescueButton.Text = "Nuevo";
            NewRescueButton.UseVisualStyleBackColor = true;
            NewRescueButton.Click += NewRescueButton_Click;
            // 
            // AnimalsInfoDataGrid
            // 
            AnimalsInfoDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AnimalsInfoDataGrid.Location = new Point(399, 86);
            AnimalsInfoDataGrid.Name = "AnimalsInfoDataGrid";
            AnimalsInfoDataGrid.Size = new Size(389, 200);
            AnimalsInfoDataGrid.TabIndex = 9;
            // 
            // RescueInfoLbl
            // 
            RescueInfoLbl.AutoSize = true;
            RescueInfoLbl.Font = new Font("Segoe UI", 14F);
            RescueInfoLbl.Location = new Point(140, 48);
            RescueInfoLbl.Name = "RescueInfoLbl";
            RescueInfoLbl.Size = new Size(117, 25);
            RescueInfoLbl.TabIndex = 10;
            RescueInfoLbl.Text = "Info. Rescate";
            RescueInfoLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // AnimalInfoLbl
            // 
            AnimalInfoLbl.AutoSize = true;
            AnimalInfoLbl.Font = new Font("Segoe UI", 14F);
            AnimalInfoLbl.Location = new Point(531, 48);
            AnimalInfoLbl.Name = "AnimalInfoLbl";
            AnimalInfoLbl.Size = new Size(113, 25);
            AnimalInfoLbl.TabIndex = 11;
            AnimalInfoLbl.Text = "Info. Animal";
            AnimalInfoLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // SearchAnimalsButton
            // 
            SearchAnimalsButton.Font = new Font("Segoe UI", 11F);
            SearchAnimalsButton.Location = new Point(706, 292);
            SearchAnimalsButton.Name = "SearchAnimalsButton";
            SearchAnimalsButton.Size = new Size(82, 30);
            SearchAnimalsButton.TabIndex = 13;
            SearchAnimalsButton.Text = "Buscar";
            SearchAnimalsButton.UseVisualStyleBackColor = true;
            SearchAnimalsButton.Click += SearchAnimalsButton_Click;
            // 
            // NewAnimalButton
            // 
            NewAnimalButton.Font = new Font("Segoe UI", 11F);
            NewAnimalButton.Location = new Point(618, 292);
            NewAnimalButton.Name = "NewAnimalButton";
            NewAnimalButton.Size = new Size(82, 30);
            NewAnimalButton.TabIndex = 12;
            NewAnimalButton.Text = "Nuevo";
            NewAnimalButton.UseVisualStyleBackColor = true;
            NewAnimalButton.Click += NewAnimalButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI", 18F);
            ExitButton.Location = new Point(666, 395);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(122, 43);
            ExitButton.TabIndex = 14;
            ExitButton.Text = "Salir";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // GameExpLbl
            // 
            GameExpLbl.AutoSize = true;
            GameExpLbl.Font = new Font("Segoe UI", 14F);
            GameExpLbl.Location = new Point(12, 416);
            GameExpLbl.Name = "GameExpLbl";
            GameExpLbl.Size = new Size(100, 25);
            GameExpLbl.TabIndex = 15;
            GameExpLbl.Text = "Game Exp:";
            GameExpLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // GameExpValueLbl
            // 
            GameExpValueLbl.AutoSize = true;
            GameExpValueLbl.Font = new Font("Segoe UI", 14F);
            GameExpValueLbl.Location = new Point(108, 416);
            GameExpValueLbl.Name = "GameExpValueLbl";
            GameExpValueLbl.Size = new Size(21, 25);
            GameExpValueLbl.TabIndex = 16;
            GameExpValueLbl.Text = "?";
            GameExpValueLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // NextRescueButton
            // 
            NextRescueButton.Font = new Font("Segoe UI", 18F);
            NextRescueButton.Location = new Point(292, 395);
            NextRescueButton.Name = "NextRescueButton";
            NextRescueButton.Size = new Size(206, 43);
            NextRescueButton.TabIndex = 17;
            NextRescueButton.Text = "Siguente Rescate";
            NextRescueButton.UseVisualStyleBackColor = true;
            NextRescueButton.Click += NextRescueButton_Click;
            // 
            // GameWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.maui_blue_ocean_abstract;
            ClientSize = new Size(800, 450);
            Controls.Add(NextRescueButton);
            Controls.Add(GameExpValueLbl);
            Controls.Add(GameExpLbl);
            Controls.Add(ExitButton);
            Controls.Add(SearchAnimalsButton);
            Controls.Add(NewAnimalButton);
            Controls.Add(AnimalInfoLbl);
            Controls.Add(RescueInfoLbl);
            Controls.Add(AnimalsInfoDataGrid);
            Controls.Add(SearchRescuesButton);
            Controls.Add(NewRescueButton);
            Controls.Add(MoveAnimalButton);
            Controls.Add(HealButton);
            Controls.Add(GameLbl);
            Controls.Add(RescuesDataGrid);
            Name = "GameWindow";
            Text = "GameWindow";
            Load += GameWindow_Load;
            ((System.ComponentModel.ISupportInitialize)RescuesDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)AnimalsInfoDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView RescuesDataGrid;
        private Label GameLbl;
        private Button HealButton;
        private Button MoveAnimalButton;
        private Button SearchRescuesButton;
        private Button NewRescueButton;
        private DataGridView AnimalsInfoDataGrid;
        private Label RescueInfoLbl;
        private Label AnimalInfoLbl;
        private Button SearchAnimalsButton;
        private Button NewAnimalButton;
        private Button ExitButton;
        private Label GameExpLbl;
        private Label GameExpValueLbl;
        private Button NextRescueButton;
    }
}