namespace AutoSalonn
{
    partial class FilterForm
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
            this.Findbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typecomboBox1 = new System.Windows.Forms.ComboBox();
            this.masscomboBox2 = new System.Windows.Forms.ComboBox();
            this.namecomboBox3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Findbutton
            // 
            this.Findbutton.AutoEllipsis = true;
            this.Findbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Findbutton.Location = new System.Drawing.Point(133, 130);
            this.Findbutton.Name = "Findbutton";
            this.Findbutton.Size = new System.Drawing.Size(119, 33);
            this.Findbutton.TabIndex = 25;
            this.Findbutton.Text = "Показать";
            this.Findbutton.UseVisualStyleBackColor = true;
            this.Findbutton.Click += new System.EventHandler(this.Findbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Тип";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "масса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "имя";
            // 
            // typecomboBox1
            // 
            this.typecomboBox1.FormattingEnabled = true;
            this.typecomboBox1.Items.AddRange(new object[] {
            "квазар",
            "дырка",
            "черный",
            "блэк"});
            this.typecomboBox1.Location = new System.Drawing.Point(133, 15);
            this.typecomboBox1.Name = "typecomboBox1";
            this.typecomboBox1.Size = new System.Drawing.Size(121, 24);
            this.typecomboBox1.TabIndex = 30;
            this.typecomboBox1.SelectedIndexChanged += new System.EventHandler(this.typecomboBox1_SelectedIndexChanged);
            // 
            // masscomboBox2
            // 
            this.masscomboBox2.FormattingEnabled = true;
            this.masscomboBox2.Items.AddRange(new object[] {
            "миллионКГ",
            "стоКГ",
            "МилллиардКГ",
            "ТрилиардКГ"});
            this.masscomboBox2.Location = new System.Drawing.Point(133, 53);
            this.masscomboBox2.Name = "masscomboBox2";
            this.masscomboBox2.Size = new System.Drawing.Size(121, 24);
            this.masscomboBox2.TabIndex = 32;
            // 
            // namecomboBox3
            // 
            this.namecomboBox3.FormattingEnabled = true;
            this.namecomboBox3.Items.AddRange(new object[] {
            "Гарганюа",
            "СтрелецА",
            "Кластер Феникс",
            "TON 618"});
            this.namecomboBox3.Location = new System.Drawing.Point(133, 100);
            this.namecomboBox3.Name = "namecomboBox3";
            this.namecomboBox3.Size = new System.Drawing.Size(121, 24);
            this.namecomboBox3.TabIndex = 33;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1634, 1055);
            this.Controls.Add(this.namecomboBox3);
            this.Controls.Add(this.masscomboBox2);
            this.Controls.Add(this.typecomboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Findbutton);
            this.Name = "FilterForm";
            this.Text = "Радиус";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Findbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox typecomboBox1;
        private System.Windows.Forms.ComboBox masscomboBox2;
        private System.Windows.Forms.ComboBox namecomboBox3;
    }
}