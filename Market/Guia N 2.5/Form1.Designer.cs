namespace Guia_N_2._5
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
            this.btnComprar = new System.Windows.Forms.Button();
            this.rbCocaCola = new System.Windows.Forms.RadioButton();
            this.lblIngresar = new System.Windows.Forms.Label();
            this.rbSprite = new System.Windows.Forms.RadioButton();
            this.rbFanta = new System.Windows.Forms.RadioButton();
            this.rbPepsi = new System.Windows.Forms.RadioButton();
            this.lblBebidas = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblCanjear = new System.Windows.Forms.Label();
            this.txtDinero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(178, 10);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(100, 44);
            this.btnComprar.TabIndex = 2;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // rbCocaCola
            // 
            this.rbCocaCola.AutoSize = true;
            this.rbCocaCola.Location = new System.Drawing.Point(178, 118);
            this.rbCocaCola.Name = "rbCocaCola";
            this.rbCocaCola.Size = new System.Drawing.Size(95, 17);
            this.rbCocaCola.TabIndex = 10;
            this.rbCocaCola.Text = "Coca Cola ¢55";
            this.rbCocaCola.UseVisualStyleBackColor = true;
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Location = new System.Drawing.Point(19, 10);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(86, 13);
            this.lblIngresar.TabIndex = 12;
            this.lblIngresar.Text = "Ingresar moneda";
            // 
            // rbSprite
            // 
            this.rbSprite.AutoSize = true;
            this.rbSprite.Location = new System.Drawing.Point(178, 211);
            this.rbSprite.Name = "rbSprite";
            this.rbSprite.Size = new System.Drawing.Size(73, 17);
            this.rbSprite.TabIndex = 9;
            this.rbSprite.Text = "Sprite ¢35";
            this.rbSprite.UseVisualStyleBackColor = true;
            // 
            // rbFanta
            // 
            this.rbFanta.AutoSize = true;
            this.rbFanta.Location = new System.Drawing.Point(19, 211);
            this.rbFanta.Name = "rbFanta";
            this.rbFanta.Size = new System.Drawing.Size(73, 17);
            this.rbFanta.TabIndex = 8;
            this.rbFanta.Text = "Fanta ¢15";
            this.rbFanta.UseVisualStyleBackColor = true;
            // 
            // rbPepsi
            // 
            this.rbPepsi.AutoSize = true;
            this.rbPepsi.Location = new System.Drawing.Point(19, 118);
            this.rbPepsi.Name = "rbPepsi";
            this.rbPepsi.Size = new System.Drawing.Size(72, 17);
            this.rbPepsi.TabIndex = 7;
            this.rbPepsi.Text = "Pepsi ¢75";
            this.rbPepsi.UseVisualStyleBackColor = true;
            // 
            // lblBebidas
            // 
            this.lblBebidas.AutoSize = true;
            this.lblBebidas.Location = new System.Drawing.Point(16, 33);
            this.lblBebidas.Name = "lblBebidas";
            this.lblBebidas.Size = new System.Drawing.Size(98, 13);
            this.lblBebidas.TabIndex = 14;
            this.lblBebidas.Text = "Seleccionar bebida";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.lblBebidas);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox3);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox4);
            this.splitContainer1.Panel1.Controls.Add(this.rbCocaCola);
            this.splitContainer1.Panel1.Controls.Add(this.rbFanta);
            this.splitContainer1.Panel1.Controls.Add(this.rbPepsi);
            this.splitContainer1.Panel1.Controls.Add(this.rbSprite);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblCanjear);
            this.splitContainer1.Panel2.Controls.Add(this.txtDinero);
            this.splitContainer1.Panel2.Controls.Add(this.btnComprar);
            this.splitContainer1.Panel2.Controls.Add(this.lblIngresar);
            this.splitContainer1.Size = new System.Drawing.Size(299, 381);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Guia_N_2._5.Properties.Resources.pngwing_com_1_;
            this.pictureBox1.Location = new System.Drawing.Point(19, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Guia_N_2._5.Properties.Resources.pngwing_com;
            this.pictureBox2.Location = new System.Drawing.Point(178, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Guia_N_2._5.Properties.Resources.pngwing_com_3_;
            this.pictureBox3.Location = new System.Drawing.Point(19, 155);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Guia_N_2._5.Properties.Resources.pngwing1;
            this.pictureBox4.Location = new System.Drawing.Point(178, 155);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // lblCanjear
            // 
            this.lblCanjear.AutoSize = true;
            this.lblCanjear.Location = new System.Drawing.Point(19, 54);
            this.lblCanjear.Name = "lblCanjear";
            this.lblCanjear.Size = new System.Drawing.Size(0, 13);
            this.lblCanjear.TabIndex = 14;
            // 
            // txtDinero
            // 
            this.txtDinero.Location = new System.Drawing.Point(19, 34);
            this.txtDinero.Name = "txtDinero";
            this.txtDinero.Size = new System.Drawing.Size(100, 20);
            this.txtDinero.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 417);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.RadioButton rbCocaCola;
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.RadioButton rbSprite;
        private System.Windows.Forms.RadioButton rbFanta;
        private System.Windows.Forms.RadioButton rbPepsi;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblBebidas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtDinero;
        private System.Windows.Forms.Label lblCanjear;
    }
}

