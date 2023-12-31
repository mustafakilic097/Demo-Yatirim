namespace demo_yatirim
{
    partial class settings
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.bakiyeReset = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.portfoyReset = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.bakiyeReset);
            this.materialCard1.Controls.Add(this.materialButton2);
            this.materialCard1.Controls.Add(this.portfoyReset);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(13, 13);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(455, 274);
            this.materialCard1.TabIndex = 0;
            // 
            // bakiyeReset
            // 
            this.bakiyeReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bakiyeReset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bakiyeReset.Depth = 0;
            this.bakiyeReset.HighEmphasis = true;
            this.bakiyeReset.Icon = null;
            this.bakiyeReset.Location = new System.Drawing.Point(178, 11);
            this.bakiyeReset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bakiyeReset.MinimumSize = new System.Drawing.Size(150, 100);
            this.bakiyeReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.bakiyeReset.Name = "bakiyeReset";
            this.bakiyeReset.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bakiyeReset.Size = new System.Drawing.Size(150, 100);
            this.bakiyeReset.TabIndex = 2;
            this.bakiyeReset.Text = "BAKİYEYİ SIFIRLA";
            this.bakiyeReset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bakiyeReset.UseAccentColor = false;
            this.bakiyeReset.UseVisualStyleBackColor = true;
            this.bakiyeReset.Click += new System.EventHandler(this.bakiyeReset_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(305, 219);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MinimumSize = new System.Drawing.Size(150, 50);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(150, 50);
            this.materialButton2.TabIndex = 1;
            this.materialButton2.Text = "HATA BİLDİR";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // portfoyReset
            // 
            this.portfoyReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.portfoyReset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.portfoyReset.Depth = 0;
            this.portfoyReset.HighEmphasis = true;
            this.portfoyReset.Icon = null;
            this.portfoyReset.Location = new System.Drawing.Point(18, 11);
            this.portfoyReset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.portfoyReset.MinimumSize = new System.Drawing.Size(150, 100);
            this.portfoyReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.portfoyReset.Name = "portfoyReset";
            this.portfoyReset.NoAccentTextColor = System.Drawing.Color.Empty;
            this.portfoyReset.Size = new System.Drawing.Size(152, 100);
            this.portfoyReset.TabIndex = 0;
            this.portfoyReset.Text = "PORTFÖYÜ SIFIRLA";
            this.portfoyReset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.portfoyReset.UseAccentColor = false;
            this.portfoyReset.UseVisualStyleBackColor = true;
            this.portfoyReset.Click += new System.EventHandler(this.portfoyReset_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 297);
            this.Controls.Add(this.materialCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "settings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ayarlar";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton portfoyReset;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton bakiyeReset;
    }
}