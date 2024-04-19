namespace RPG_v2_refactor
{
    partial class spaceAdventure
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
            this.oxygenLevel = new System.Windows.Forms.TextBox();
            this.OxygenLabel = new System.Windows.Forms.Label();
            this.suitIntegrityLabel = new System.Windows.Forms.Label();
            this.suitIntegrity = new System.Windows.Forms.TextBox();
            this.FIRE = new System.Windows.Forms.Button();
            this.forwardsButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // oxygenLevel
            // 
            this.oxygenLevel.Location = new System.Drawing.Point(534, 575);
            this.oxygenLevel.Name = "oxygenLevel";
            this.oxygenLevel.Size = new System.Drawing.Size(100, 20);
            this.oxygenLevel.TabIndex = 0;
            this.oxygenLevel.Text = "[oxygen]";
            // 
            // OxygenLabel
            // 
            this.OxygenLabel.AutoSize = true;
            this.OxygenLabel.Location = new System.Drawing.Point(531, 559);
            this.OxygenLabel.Name = "OxygenLabel";
            this.OxygenLabel.Size = new System.Drawing.Size(72, 13);
            this.OxygenLabel.TabIndex = 1;
            this.OxygenLabel.Text = "Oxygen Level";
            // 
            // suitIntegrityLabel
            // 
            this.suitIntegrityLabel.AutoSize = true;
            this.suitIntegrityLabel.Location = new System.Drawing.Point(531, 598);
            this.suitIntegrityLabel.Name = "suitIntegrityLabel";
            this.suitIntegrityLabel.Size = new System.Drawing.Size(65, 13);
            this.suitIntegrityLabel.TabIndex = 3;
            this.suitIntegrityLabel.Text = "Suit Integrity";
            // 
            // suitIntegrity
            // 
            this.suitIntegrity.Location = new System.Drawing.Point(534, 614);
            this.suitIntegrity.Name = "suitIntegrity";
            this.suitIntegrity.Size = new System.Drawing.Size(100, 20);
            this.suitIntegrity.TabIndex = 2;
            this.suitIntegrity.Text = "[suitIntegrity]";
            // 
            // FIRE
            // 
            this.FIRE.Location = new System.Drawing.Point(95, 557);
            this.FIRE.Name = "FIRE";
            this.FIRE.Size = new System.Drawing.Size(424, 76);
            this.FIRE.TabIndex = 4;
            this.FIRE.Text = "fire";
            this.FIRE.UseVisualStyleBackColor = true;
            // 
            // forwardsButton
            // 
            this.forwardsButton.Location = new System.Drawing.Point(311, 361);
            this.forwardsButton.Name = "forwardsButton";
            this.forwardsButton.Size = new System.Drawing.Size(60, 65);
            this.forwardsButton.TabIndex = 5;
            this.forwardsButton.Text = "forwards";
            this.forwardsButton.UseVisualStyleBackColor = true;
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(377, 424);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(60, 65);
            this.rightButton.TabIndex = 6;
            this.rightButton.Text = "right";
            this.rightButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(311, 486);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(60, 65);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(245, 424);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(60, 65);
            this.leftButton.TabIndex = 8;
            this.leftButton.Text = "left";
            this.leftButton.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(48, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(585, 295);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // spaceAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 651);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.forwardsButton);
            this.Controls.Add(this.FIRE);
            this.Controls.Add(this.suitIntegrityLabel);
            this.Controls.Add(this.suitIntegrity);
            this.Controls.Add(this.OxygenLabel);
            this.Controls.Add(this.oxygenLevel);
            this.Name = "spaceAdventure";
            this.Text = "SpaceAdventure_Refactor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oxygenLevel;
        private System.Windows.Forms.Label OxygenLabel;
        private System.Windows.Forms.Label suitIntegrityLabel;
        private System.Windows.Forms.TextBox suitIntegrity;
        private System.Windows.Forms.Button FIRE;
        private System.Windows.Forms.Button forwardsButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

