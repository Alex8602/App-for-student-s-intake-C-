namespace REC_TANASESCU_ALEXANDRU_GABRIEL_M730
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
            this.articoleGridView = new System.Windows.Forms.DataGridView();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonSerializare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.articoleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.articoleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articoleGridView.Location = new System.Drawing.Point(12, 84);
            this.articoleGridView.Name = "dataGridView1";
            this.articoleGridView.RowHeadersWidth = 72;
            this.articoleGridView.RowTemplate.Height = 31;
            this.articoleGridView.Size = new System.Drawing.Size(776, 354);
            this.articoleGridView.TabIndex = 0;
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(49, 23);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(130, 43);
            this.buttonAdauga.TabIndex = 1;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(242, 23);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(136, 43);
            this.buttonInfo.TabIndex = 2;
            this.buttonInfo.Text = "Information";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonSerializare
            // 
            this.buttonSerializare.Location = new System.Drawing.Point(436, 23);
            this.buttonSerializare.Name = "buttonSerializare";
            this.buttonSerializare.Size = new System.Drawing.Size(121, 43);
            this.buttonSerializare.TabIndex = 3;
            this.buttonSerializare.Text = "Serializare";
            this.buttonSerializare.UseVisualStyleBackColor = true;
            this.buttonSerializare.Click += new System.EventHandler(this.buttonSerializare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSerializare);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.articoleGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.articoleGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView articoleGridView;
        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonSerializare;
    }
}

