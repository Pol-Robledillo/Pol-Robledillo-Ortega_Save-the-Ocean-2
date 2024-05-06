namespace Pol_Robledillo_Ortega___Save_the_Ocean_2
{
    partial class TitleWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLbl = new Label();
            playButton = new Button();
            exitButton = new Button();
            BestGamesLbl = new Label();
            BestGamesGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)BestGamesGrid).BeginInit();
            SuspendLayout();
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Rockwell Nova Extra Bold", 24F, FontStyle.Bold);
            titleLbl.Location = new Point(194, 48);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(408, 42);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "SAVE THE OCEAN II";
            // 
            // playButton
            // 
            playButton.Font = new Font("Segoe UI", 18F);
            playButton.Location = new Point(263, 109);
            playButton.Name = "playButton";
            playButton.Size = new Size(135, 43);
            playButton.TabIndex = 1;
            playButton.Text = "Jugar";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 18F);
            exitButton.Location = new Point(404, 109);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(135, 43);
            exitButton.TabIndex = 2;
            exitButton.Text = "Salir";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // BestGamesLbl
            // 
            BestGamesLbl.AutoSize = true;
            BestGamesLbl.Font = new Font("Rockwell Nova Extra Bold", 14F, FontStyle.Bold);
            BestGamesLbl.Location = new Point(290, 191);
            BestGamesLbl.Name = "BestGamesLbl";
            BestGamesLbl.Size = new Size(222, 25);
            BestGamesLbl.TabIndex = 3;
            BestGamesLbl.Text = "Mejores Partidas";
            // 
            // BestGamesGrid
            // 
            BestGamesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BestGamesGrid.Location = new Point(194, 234);
            BestGamesGrid.Name = "BestGamesGrid";
            BestGamesGrid.Size = new Size(408, 150);
            BestGamesGrid.TabIndex = 4;
            // 
            // TitleWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.maui_blue_ocean_abstract;
            ClientSize = new Size(800, 450);
            Controls.Add(BestGamesGrid);
            Controls.Add(BestGamesLbl);
            Controls.Add(exitButton);
            Controls.Add(playButton);
            Controls.Add(titleLbl);
            Name = "TitleWindow";
            Text = "Form1";
            Load += TitleWindow_Load;
            ((System.ComponentModel.ISupportInitialize)BestGamesGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLbl;
        private Button playButton;
        private Button exitButton;
        private Label BestGamesLbl;
        private DataGridView BestGamesGrid;
    }
}
