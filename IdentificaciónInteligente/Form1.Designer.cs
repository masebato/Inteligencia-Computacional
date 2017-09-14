namespace IdentificaciónInteligente
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
            this.pictureBox_Color = new System.Windows.Forms.PictureBox();
            this.bt_examinar = new System.Windows.Forms.Button();
            this.bt_tratamiento = new System.Windows.Forms.Button();
            this.bt_ = new System.Windows.Forms.Button();
            this.bt_salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_Gris = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.list_binarizacion = new System.Windows.Forms.ListBox();
            this.bt_Alg_Evo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.list_proceso = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gris)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Color
            // 
            this.pictureBox_Color.Location = new System.Drawing.Point(14, 61);
            this.pictureBox_Color.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Color.Name = "pictureBox_Color";
            this.pictureBox_Color.Size = new System.Drawing.Size(263, 221);
            this.pictureBox_Color.TabIndex = 0;
            this.pictureBox_Color.TabStop = false;
            // 
            // bt_examinar
            // 
            this.bt_examinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_examinar.Image = global::IdentificaciónInteligente.Properties.Resources.examinar;
            this.bt_examinar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_examinar.Location = new System.Drawing.Point(66, 619);
            this.bt_examinar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_examinar.Name = "bt_examinar";
            this.bt_examinar.Size = new System.Drawing.Size(106, 41);
            this.bt_examinar.TabIndex = 1;
            this.bt_examinar.Text = "Examinar";
            this.bt_examinar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_examinar.UseVisualStyleBackColor = true;
            this.bt_examinar.Click += new System.EventHandler(this.bt_examinar_Click);
            // 
            // bt_tratamiento
            // 
            this.bt_tratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tratamiento.Location = new System.Drawing.Point(210, 619);
            this.bt_tratamiento.Margin = new System.Windows.Forms.Padding(2);
            this.bt_tratamiento.Name = "bt_tratamiento";
            this.bt_tratamiento.Size = new System.Drawing.Size(104, 41);
            this.bt_tratamiento.TabIndex = 2;
            this.bt_tratamiento.Text = "Tratamiento";
            this.bt_tratamiento.UseVisualStyleBackColor = true;
            this.bt_tratamiento.Click += new System.EventHandler(this.bt_tratamiento_Click);
            // 
            // bt_
            // 
            this.bt_.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_.Image = global::IdentificaciónInteligente.Properties.Resources.cancelar;
            this.bt_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_.Location = new System.Drawing.Point(760, 619);
            this.bt_.Margin = new System.Windows.Forms.Padding(2);
            this.bt_.Name = "bt_";
            this.bt_.Size = new System.Drawing.Size(101, 41);
            this.bt_.TabIndex = 3;
            this.bt_.Text = "Cancelar";
            this.bt_.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_.UseVisualStyleBackColor = true;
            // 
            // bt_salir
            // 
            this.bt_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salir.Image = global::IdentificaciónInteligente.Properties.Resources.salir;
            this.bt_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_salir.Location = new System.Drawing.Point(916, 619);
            this.bt_salir.Margin = new System.Windows.Forms.Padding(2);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(72, 41);
            this.bt_salir.TabIndex = 4;
            this.bt_salir.Text = "Salir";
            this.bt_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Imagen Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1054, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Procedimiento";
            // 
            // pictureBox_Gris
            // 
            this.pictureBox_Gris.Location = new System.Drawing.Point(11, 365);
            this.pictureBox_Gris.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Gris.Name = "pictureBox_Gris";
            this.pictureBox_Gris.Size = new System.Drawing.Size(266, 221);
            this.pictureBox_Gris.TabIndex = 8;
            this.pictureBox_Gris.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 329);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Imagen Escala de Grises";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Binarización";
            // 
            // list_binarizacion
            // 
            this.list_binarizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_binarizacion.FormattingEnabled = true;
            this.list_binarizacion.HorizontalScrollbar = true;
            this.list_binarizacion.ItemHeight = 16;
            this.list_binarizacion.Location = new System.Drawing.Point(298, 38);
            this.list_binarizacion.Name = "list_binarizacion";
            this.list_binarizacion.Size = new System.Drawing.Size(734, 548);
            this.list_binarizacion.TabIndex = 11;
            // 
            // bt_Alg_Evo
            // 
            this.bt_Alg_Evo.Enabled = false;
            this.bt_Alg_Evo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Alg_Evo.Location = new System.Drawing.Point(344, 619);
            this.bt_Alg_Evo.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Alg_Evo.Name = "bt_Alg_Evo";
            this.bt_Alg_Evo.Size = new System.Drawing.Size(157, 41);
            this.bt_Alg_Evo.TabIndex = 12;
            this.bt_Alg_Evo.Text = "Algoritmo Evolutivo";
            this.bt_Alg_Evo.UseVisualStyleBackColor = true;
            this.bt_Alg_Evo.Click += new System.EventHandler(this.bt_Alg_Evo_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(544, 619);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sistema Experto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // list_proceso
            // 
            this.list_proceso.FormattingEnabled = true;
            this.list_proceso.Location = new System.Drawing.Point(1057, 38);
            this.list_proceso.Name = "list_proceso";
            this.list_proceso.Size = new System.Drawing.Size(226, 550);
            this.list_proceso.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 687);
            this.Controls.Add(this.list_proceso);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_Alg_Evo);
            this.Controls.Add(this.list_binarizacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox_Gris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.bt_);
            this.Controls.Add(this.bt_tratamiento);
            this.Controls.Add(this.bt_examinar);
            this.Controls.Add(this.pictureBox_Color);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Color;
        private System.Windows.Forms.Button bt_examinar;
        private System.Windows.Forms.Button bt_tratamiento;
        private System.Windows.Forms.Button bt_;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_Gris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox list_binarizacion;
        private System.Windows.Forms.Button bt_Alg_Evo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox list_proceso;
    }
}