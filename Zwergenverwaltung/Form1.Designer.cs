namespace Zwergenverwaltung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridViewTribe = new System.Windows.Forms.DataGridView();
            this.labelMain = new System.Windows.Forms.Label();
            this.dataGridViewDwarf = new System.Windows.Forms.DataGridView();
            this.dataGridViewWeapon = new System.Windows.Forms.DataGridView();
            this.numericUpDownTaxRate = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.numericUpDownTaxValue = new System.Windows.Forms.NumericUpDown();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTribe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDwarf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTaxRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTaxValue)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTribe
            // 
            this.dataGridViewTribe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTribe.Location = new System.Drawing.Point(240, 119);
            this.dataGridViewTribe.Name = "dataGridViewTribe";
            this.dataGridViewTribe.RowHeadersWidth = 51;
            this.dataGridViewTribe.Size = new System.Drawing.Size(823, 164);
            this.dataGridViewTribe.TabIndex = 0;
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.Location = new System.Drawing.Point(450, 41);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(379, 36);
            this.labelMain.TabIndex = 1;
            this.labelMain.Text = "Zwergenverwaltung";
            // 
            // dataGridViewDwarf
            // 
            this.dataGridViewDwarf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDwarf.Location = new System.Drawing.Point(240, 289);
            this.dataGridViewDwarf.Name = "dataGridViewDwarf";
            this.dataGridViewDwarf.RowHeadersWidth = 51;
            this.dataGridViewDwarf.RowTemplate.Height = 24;
            this.dataGridViewDwarf.Size = new System.Drawing.Size(823, 210);
            this.dataGridViewDwarf.TabIndex = 2;
            // 
            // dataGridViewWeapon
            // 
            this.dataGridViewWeapon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeapon.Location = new System.Drawing.Point(240, 505);
            this.dataGridViewWeapon.Name = "dataGridViewWeapon";
            this.dataGridViewWeapon.RowHeadersWidth = 51;
            this.dataGridViewWeapon.RowTemplate.Height = 24;
            this.dataGridViewWeapon.Size = new System.Drawing.Size(823, 152);
            this.dataGridViewWeapon.TabIndex = 3;
            // 
            // numericUpDownTaxRate
            // 
            this.numericUpDownTaxRate.DecimalPlaces = 3;
            this.numericUpDownTaxRate.Location = new System.Drawing.Point(55, 21);
            this.numericUpDownTaxRate.Name = "numericUpDownTaxRate";
            this.numericUpDownTaxRate.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownTaxRate.TabIndex = 4;
            this.numericUpDownTaxRate.Value = new decimal(new int[] {
            2125,
            0,
            0,
            196608});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(961, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Steuern:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(240, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // numericUpDownTaxValue
            // 
            this.numericUpDownTaxValue.DecimalPlaces = 3;
            this.numericUpDownTaxValue.Location = new System.Drawing.Point(55, 71);
            this.numericUpDownTaxValue.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownTaxValue.Name = "numericUpDownTaxValue";
            this.numericUpDownTaxValue.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownTaxValue.TabIndex = 9;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(68, 135);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(69, 164);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 11;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(68, 193);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(75, 23);
            this.buttonMove.TabIndex = 12;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 828);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.numericUpDownTaxValue);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericUpDownTaxRate);
            this.Controls.Add(this.dataGridViewWeapon);
            this.Controls.Add(this.dataGridViewDwarf);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.dataGridViewTribe);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTribe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDwarf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTaxRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTaxValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTribe;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.DataGridView dataGridViewDwarf;
        private System.Windows.Forms.DataGridView dataGridViewWeapon;
        private System.Windows.Forms.NumericUpDown numericUpDownTaxRate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownTaxValue;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonMove;
    }
}

