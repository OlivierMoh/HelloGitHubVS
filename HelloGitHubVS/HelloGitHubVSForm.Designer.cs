namespace HelloGitHubVS
{
    partial class HelloGitHubVSForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.HelloGitHubButton = new System.Windows.Forms.Button();
            this.modifierButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HelloGitHubButton
            // 
            this.HelloGitHubButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.HelloGitHubButton.Location = new System.Drawing.Point(279, 154);
            this.HelloGitHubButton.Name = "HelloGitHubButton";
            this.HelloGitHubButton.Size = new System.Drawing.Size(201, 65);
            this.HelloGitHubButton.TabIndex = 0;
            this.HelloGitHubButton.Text = "Hello GitHub";
            this.HelloGitHubButton.UseVisualStyleBackColor = false;
            this.HelloGitHubButton.Click += new System.EventHandler(this.HelloGitHubButton_Click);
            // 
            // modifierButton
            // 
            this.modifierButton.Location = new System.Drawing.Point(282, 236);
            this.modifierButton.Name = "modifierButton";
            this.modifierButton.Size = new System.Drawing.Size(197, 54);
            this.modifierButton.TabIndex = 1;
            this.modifierButton.Text = "modifier arriere-plan";
            this.modifierButton.UseVisualStyleBackColor = true;
            this.modifierButton.Click += new System.EventHandler(this.modifierButton_Click);
            // 
            // HelloGitHubVSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modifierButton);
            this.Controls.Add(this.HelloGitHubButton);
            this.Name = "HelloGitHubVSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GitHub et Git pour Visual Studio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HelloGitHubButton;
        private System.Windows.Forms.Button modifierButton;
    }
}

