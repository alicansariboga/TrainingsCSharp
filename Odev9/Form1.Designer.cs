
namespace Odev9
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
            this.dgrwCars = new System.Windows.Forms.DataGridView();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxBrand = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.lblPower = new System.Windows.Forms.Label();
            this.tbxPower = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.tbxCost = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lbld = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgrwCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrwCars
            // 
            this.dgrwCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrwCars.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrwCars.Location = new System.Drawing.Point(0, 0);
            this.dgrwCars.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgrwCars.Name = "dgrwCars";
            this.dgrwCars.Size = new System.Drawing.Size(1200, 251);
            this.dgrwCars.TabIndex = 0;
            // 
            // tbxId
            // 
            this.tbxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxId.Location = new System.Drawing.Point(96, 48);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(235, 26);
            this.tbxId.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(256, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 28);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxBrand
            // 
            this.tbxBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBrand.Location = new System.Drawing.Point(96, 80);
            this.tbxBrand.Name = "tbxBrand";
            this.tbxBrand.Size = new System.Drawing.Size(235, 26);
            this.tbxBrand.TabIndex = 14;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCost.Location = new System.Drawing.Point(14, 182);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(43, 20);
            this.lblCost.TabIndex = 22;
            this.lblCost.Text = "Fiyat";
            // 
            // tbxModel
            // 
            this.tbxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxModel.Location = new System.Drawing.Point(96, 112);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(235, 26);
            this.tbxModel.TabIndex = 15;
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPower.Location = new System.Drawing.Point(14, 150);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(39, 20);
            this.lblPower.TabIndex = 21;
            this.lblPower.Text = "Guc";
            // 
            // tbxPower
            // 
            this.tbxPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPower.Location = new System.Drawing.Point(96, 144);
            this.tbxPower.Name = "tbxPower";
            this.tbxPower.Size = new System.Drawing.Size(235, 26);
            this.tbxPower.TabIndex = 16;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModel.Location = new System.Drawing.Point(14, 118);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(52, 20);
            this.lblModel.TabIndex = 20;
            this.lblModel.Text = "Model";
            // 
            // tbxCost
            // 
            this.tbxCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxCost.Location = new System.Drawing.Point(96, 176);
            this.tbxCost.Name = "tbxCost";
            this.tbxCost.Size = new System.Drawing.Size(235, 26);
            this.tbxCost.TabIndex = 17;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBrand.Location = new System.Drawing.Point(14, 86);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(53, 20);
            this.lblBrand.TabIndex = 19;
            this.lblBrand.Text = "Marka";
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbld.Location = new System.Drawing.Point(14, 54);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(23, 20);
            this.lbld.TabIndex = 18;
            this.lbld.Text = "Id";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.tbxId);
            this.groupControl1.Controls.Add(this.btnAdd);
            this.groupControl1.Controls.Add(this.lbld);
            this.groupControl1.Controls.Add(this.lblBrand);
            this.groupControl1.Controls.Add(this.tbxBrand);
            this.groupControl1.Controls.Add(this.tbxCost);
            this.groupControl1.Controls.Add(this.lblCost);
            this.groupControl1.Controls.Add(this.lblModel);
            this.groupControl1.Controls.Add(this.tbxModel);
            this.groupControl1.Controls.Add(this.tbxPower);
            this.groupControl1.Controls.Add(this.lblPower);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(12, 258);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(352, 258);
            this.groupControl1.TabIndex = 24;
            this.groupControl1.Text = "Arac Ekleme";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dgrwCars);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrwCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrwCars;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxBrand;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.TextBox tbxPower;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox tbxCost;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lbld;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}

