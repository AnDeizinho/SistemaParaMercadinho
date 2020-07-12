namespace MercMarcelo.Controles
{
    partial class Colecao
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
            this.Lista = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.ItemHeight = 29;
            this.Lista.Location = new System.Drawing.Point(7, 27);
            this.Lista.Margin = new System.Windows.Forms.Padding(7);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(615, 236);
            this.Lista.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(7, 293);
            this.textBox1.Margin = new System.Windows.Forms.Padding(7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(377, 35);
            this.textBox1.TabIndex = 1;
            // 
            // tbnAdd
            // 
            this.tbnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tbnAdd.Location = new System.Drawing.Point(398, 288);
            this.tbnAdd.Margin = new System.Windows.Forms.Padding(7);
            this.tbnAdd.Name = "tbnAdd";
            this.tbnAdd.Size = new System.Drawing.Size(224, 45);
            this.tbnAdd.TabIndex = 2;
            this.tbnAdd.Text = "Adicionar";
            this.tbnAdd.UseVisualStyleBackColor = true;
            
            // 
            // Colecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 346);
            this.Controls.Add(this.tbnAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lista);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Colecao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colecao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button tbnAdd;
    }
}