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
            this.dataGridViewTribe = new System.Windows.Forms.DataGridView();
            this.labelMain = new System.Windows.Forms.Label();
            this.dataGridViewDwarf = new System.Windows.Forms.DataGridView();
            this.dataGridViewWeapon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTribe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDwarf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeapon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTribe
            // 
            this.dataGridViewTribe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTribe.Location = new System.Drawing.Point(253, 107);
            this.dataGridViewTribe.Name = "dataGridViewTribe";
            this.dataGridViewTribe.RowHeadersWidth = 51;
            this.dataGridViewTribe.Size = new System.Drawing.Size(488, 164);
            this.dataGridViewTribe.TabIndex = 0;
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.Location = new System.Drawing.Point(44, 31);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(379, 36);
            this.labelMain.TabIndex = 1;
            this.labelMain.Text = "Zwergenverwaltung";
            // 
            // dataGridViewDwarf
            // 
            this.dataGridViewDwarf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDwarf.Location = new System.Drawing.Point(253, 304);
            this.dataGridViewDwarf.Name = "dataGridViewDwarf";
            this.dataGridViewDwarf.RowHeadersWidth = 51;
            this.dataGridViewDwarf.RowTemplate.Height = 24;
            this.dataGridViewDwarf.Size = new System.Drawing.Size(488, 165);
            this.dataGridViewDwarf.TabIndex = 2;
            // 
            // dataGridViewWeapon
            // 
            this.dataGridViewWeapon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeapon.Location = new System.Drawing.Point(253, 506);
            this.dataGridViewWeapon.Name = "dataGridViewWeapon";
            this.dataGridViewWeapon.RowHeadersWidth = 51;
            this.dataGridViewWeapon.RowTemplate.Height = 24;
            this.dataGridViewWeapon.Size = new System.Drawing.Size(488, 197);
            this.dataGridViewWeapon.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 828);
            this.Controls.Add(this.dataGridViewWeapon);
            this.Controls.Add(this.dataGridViewDwarf);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.dataGridViewTribe);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTribe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDwarf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeapon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTribe;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.DataGridView dataGridViewDwarf;
        private System.Windows.Forms.DataGridView dataGridViewWeapon;
    }
}

