namespace cSharpRussianRoulette
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRules = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnChoice = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFacePie = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRules
            // 
            this.btnRules.Font = new System.Drawing.Font("Stencil Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRules.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRules.Location = new System.Drawing.Point(532, 187);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(87, 44);
            this.btnRules.TabIndex = 0;
            this.btnRules.Text = "Rules";
            this.btnRules.UseVisualStyleBackColor = true;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Stencil Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStart.Location = new System.Drawing.Point(532, 362);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(87, 44);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Play";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPass
            // 
            this.btnPass.Font = new System.Drawing.Font("Stencil Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPass.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPass.Location = new System.Drawing.Point(532, 449);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(87, 44);
            this.btnPass.TabIndex = 2;
            this.btnPass.Text = "Pass";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnChoice
            // 
            this.btnChoice.Font = new System.Drawing.Font("Stencil Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnChoice.Location = new System.Drawing.Point(532, 269);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.Size(87, 44);
            this.btnChoice.TabIndex = 3;
            this.btnChoice.Text = "Spin ";
            this.btnChoice.UseVisualStyleBackColor = true;
            this.btnChoice.Click += new System.EventHandler(this.btnChoice_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(142, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 306);
            this.panel1.TabIndex = 4;
            // 
            // lblFacePie
            // 
            this.lblFacePie.AutoSize = true;
            this.lblFacePie.Font = new System.Drawing.Font("Stencil Std", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacePie.ForeColor = System.Drawing.Color.Red;
            this.lblFacePie.Location = new System.Drawing.Point(119, 43);
            this.lblFacePie.Name = "lblFacePie";
            this.lblFacePie.Size = new System.Drawing.Size(376, 38);
            this.lblFacePie.TabIndex = 0;
            this.lblFacePie.Text = "Lets Play Pie On Face";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Font = new System.Drawing.Font("Stencil Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPlayAgain.Location = new System.Drawing.Point(243, 529);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(159, 44);
            this.btnPlayAgain.TabIndex = 5;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(671, 605);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblFacePie);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnChoice);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnRules);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnChoice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFacePie;
        private System.Windows.Forms.Button btnPlayAgain;
    }
}

