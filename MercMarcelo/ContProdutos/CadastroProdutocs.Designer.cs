namespace MercMarcelo.Produtos
{
    partial class CadastroProdutocs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodbrr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMedida = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMedida = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcompra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtvenda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtqtd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id :";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.SlateBlue;
            this.txtid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtid.ForeColor = System.Drawing.Color.Lavender;
            this.txtid.Location = new System.Drawing.Point(130, 66);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.SlateBlue;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.ForeColor = System.Drawing.Color.Lavender;
            this.txtDescricao.Location = new System.Drawing.Point(130, 103);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(298, 20);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescricao_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição :";
            // 
            // txtcodbrr
            // 
            this.txtcodbrr.BackColor = System.Drawing.Color.SlateBlue;
            this.txtcodbrr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodbrr.ForeColor = System.Drawing.Color.Lavender;
            this.txtcodbrr.Location = new System.Drawing.Point(130, 31);
            this.txtcodbrr.MaxLength = 14;
            this.txtcodbrr.Name = "txtcodbrr";
            this.txtcodbrr.Size = new System.Drawing.Size(298, 20);
            this.txtcodbrr.TabIndex = 1;
            this.txtcodbrr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            this.txtcodbrr.Validated += new System.EventHandler(this.txtcodbrr_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cod. Brrs. :";
            // 
            // cbCategorias
            // 
            this.cbCategorias.BackColor = System.Drawing.Color.SlateBlue;
            this.cbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategorias.ForeColor = System.Drawing.Color.Lavender;
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(130, 139);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(240, 21);
            this.cbCategorias.Sorted = true;
            this.cbCategorias.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categoria :";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(376, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.SlateBlue;
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.ForeColor = System.Drawing.Color.Lavender;
            this.txtMarca.Location = new System.Drawing.Point(130, 176);
            this.txtMarca.MaxLength = 30;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(240, 20);
            this.txtMarca.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Marca :";
            // 
            // btnMedida
            // 
            this.btnMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedida.Location = new System.Drawing.Point(376, 211);
            this.btnMedida.Name = "btnMedida";
            this.btnMedida.Size = new System.Drawing.Size(52, 23);
            this.btnMedida.TabIndex = 8;
            this.btnMedida.Text = "Add";
            this.btnMedida.UseVisualStyleBackColor = true;
            this.btnMedida.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Unid. Medida :";
            // 
            // cbMedida
            // 
            this.cbMedida.BackColor = System.Drawing.Color.SlateBlue;
            this.cbMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMedida.ForeColor = System.Drawing.Color.Lavender;
            this.cbMedida.FormattingEnabled = true;
            this.cbMedida.Location = new System.Drawing.Point(130, 213);
            this.cbMedida.Name = "cbMedida";
            this.cbMedida.Size = new System.Drawing.Size(240, 21);
            this.cbMedida.Sorted = true;
            this.cbMedida.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Preço de Compra : R$";
            // 
            // txtcompra
            // 
            this.txtcompra.BackColor = System.Drawing.Color.SlateBlue;
            this.txtcompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcompra.ForeColor = System.Drawing.Color.Lavender;
            this.txtcompra.Location = new System.Drawing.Point(130, 250);
            this.txtcompra.Name = "txtcompra";
            this.txtcompra.Size = new System.Drawing.Size(206, 20);
            this.txtcompra.TabIndex = 9;
            this.txtcompra.Enter += new System.EventHandler(this.txtcompra_Enter);
            this.txtcompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txtcompra.Leave += new System.EventHandler(this.txtcompra_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Preço de Venda : R$";
            // 
            // txtvenda
            // 
            this.txtvenda.BackColor = System.Drawing.Color.SlateBlue;
            this.txtvenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtvenda.ForeColor = System.Drawing.Color.Lavender;
            this.txtvenda.Location = new System.Drawing.Point(130, 287);
            this.txtvenda.Name = "txtvenda";
            this.txtvenda.Size = new System.Drawing.Size(205, 20);
            this.txtvenda.TabIndex = 10;
            this.txtvenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Qtd :";
            // 
            // txtqtd
            // 
            this.txtqtd.BackColor = System.Drawing.Color.SlateBlue;
            this.txtqtd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtqtd.ForeColor = System.Drawing.Color.Lavender;
            this.txtqtd.Location = new System.Drawing.Point(129, 327);
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.Size = new System.Drawing.Size(85, 20);
            this.txtqtd.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtqtd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtvenda);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtcompra);
            this.groupBox1.Controls.Add(this.btnMedida);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbMedida);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbCategorias);
            this.groupBox1.Controls.Add(this.txtcodbrr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(146, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 375);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Produtos";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(220, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Salvar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CadastroProdutocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CadastroProdutocs";
            this.Size = new System.Drawing.Size(623, 413);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodbrr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMedida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMedida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtvenda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtqtd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
