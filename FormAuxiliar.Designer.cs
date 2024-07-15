namespace REC_TANASESCU_ALEXANDRU_GABRIEL_M730
{
    partial class FormAuxiliar
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
            this.labelNume = new System.Windows.Forms.Label();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.labelPretLei = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxMaterial = new System.Windows.Forms.TextBox();
            this.textBoxPretLei = new System.Windows.Forms.TextBox();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(47, 56);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(64, 25);
            this.labelNume.TabIndex = 0;
            this.labelNume.Text = "Nume";
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Location = new System.Drawing.Point(47, 124);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(81, 25);
            this.labelMaterial.TabIndex = 1;
            this.labelMaterial.Text = "Material";
            // 
            // labelPretLei
            // 
            this.labelPretLei.AutoSize = true;
            this.labelPretLei.Location = new System.Drawing.Point(47, 192);
            this.labelPretLei.Name = "labelPretLei";
            this.labelPretLei.Size = new System.Drawing.Size(78, 25);
            this.labelPretLei.TabIndex = 2;
            this.labelPretLei.Text = "Pret Lei";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(178, 56);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(288, 29);
            this.textBoxNume.TabIndex = 3;
            // 
            // textBoxMaterial
            // 
            this.textBoxMaterial.Location = new System.Drawing.Point(178, 124);
            this.textBoxMaterial.Name = "textBoxMaterial";
            this.textBoxMaterial.Size = new System.Drawing.Size(288, 29);
            this.textBoxMaterial.TabIndex = 4;
            // 
            // textBoxPretLei
            // 
            this.textBoxPretLei.Location = new System.Drawing.Point(178, 188);
            this.textBoxPretLei.Name = "textBoxPretLei";
            this.textBoxPretLei.Size = new System.Drawing.Size(288, 29);
            this.textBoxPretLei.TabIndex = 5;
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(606, 140);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(120, 53);
            this.buttonAdauga.TabIndex = 6;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // FormAuxiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.textBoxPretLei);
            this.Controls.Add(this.textBoxMaterial);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.labelPretLei);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.labelNume);
            this.Name = "FormAuxiliar";
            this.Text = "FormAuxiliar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label labelPretLei;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxMaterial;
        private System.Windows.Forms.TextBox textBoxPretLei;
        private System.Windows.Forms.Button buttonAdauga;
    }
}