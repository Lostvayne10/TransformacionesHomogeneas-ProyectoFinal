namespace TransformacionesBasicas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.translaciony = new System.Windows.Forms.TextBox();
            this.translacionx = new System.Windows.Forms.TextBox();
            this.cbxgrados = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(9, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 398);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox1.Location = new System.Drawing.Point(573, 18);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(573, 61);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(19, 169);
            this.vScrollBar1.TabIndex = 2;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(610, 93);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nivel de escalado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 373);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Aplicar Transformacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Translacion",
            "Rotacion",
            "Escalado",
            "Reflexion X",
            "Reflexion Y"});
            this.comboBox2.Location = new System.Drawing.Point(581, 318);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(92, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // translaciony
            // 
            this.translaciony.Location = new System.Drawing.Point(581, 296);
            this.translaciony.Margin = new System.Windows.Forms.Padding(2);
            this.translaciony.Name = "translaciony";
            this.translaciony.Size = new System.Drawing.Size(92, 20);
            this.translaciony.TabIndex = 7;
            this.translaciony.Text = "Translacion en Y";
            this.translaciony.MouseClick += new System.Windows.Forms.MouseEventHandler(this.translaciony_MouseClick);
            this.translaciony.TextChanged += new System.EventHandler(this.translaciony_TextChanged);
            // 
            // translacionx
            // 
            this.translacionx.Location = new System.Drawing.Point(581, 273);
            this.translacionx.Margin = new System.Windows.Forms.Padding(2);
            this.translacionx.Name = "translacionx";
            this.translacionx.Size = new System.Drawing.Size(92, 20);
            this.translacionx.TabIndex = 8;
            this.translacionx.Text = "Translacion en X";
            this.translacionx.MouseClick += new System.Windows.Forms.MouseEventHandler(this.translacionx_MouseClick);
            this.translacionx.TextChanged += new System.EventHandler(this.translacionx_TextChanged);
            // 
            // cbxgrados
            // 
            this.cbxgrados.FormattingEnabled = true;
            this.cbxgrados.Items.AddRange(new object[] {
            "45",
            "90",
            "135",
            "180",
            "225",
            "270",
            "315",
            "360"});
            this.cbxgrados.Location = new System.Drawing.Point(581, 249);
            this.cbxgrados.Margin = new System.Windows.Forms.Padding(2);
            this.cbxgrados.Name = "cbxgrados";
            this.cbxgrados.Size = new System.Drawing.Size(92, 21);
            this.cbxgrados.TabIndex = 9;
            this.cbxgrados.Text = "Grados";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(711, 16);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(823, 439);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cbxgrados);
            this.Controls.Add(this.translacionx);
            this.Controls.Add(this.translaciony);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox translaciony;
        private System.Windows.Forms.TextBox translacionx;
        private System.Windows.Forms.ComboBox cbxgrados;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

