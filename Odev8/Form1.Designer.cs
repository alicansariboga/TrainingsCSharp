
namespace Odev8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxCarList = new System.Windows.Forms.ListBox();
            this.lblMainHeader = new System.Windows.Forms.Label();
            this.gbxCars = new System.Windows.Forms.GroupBox();
            this.dgrwCarList = new System.Windows.Forms.DataGridView();
            this.gbxCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrwCarList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxCarList
            // 
            this.lbxCarList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxCarList.FormattingEnabled = true;
            this.lbxCarList.ItemHeight = 21;
            this.lbxCarList.Location = new System.Drawing.Point(13, 73);
            this.lbxCarList.Name = "lbxCarList";
            this.lbxCarList.Size = new System.Drawing.Size(193, 256);
            this.lbxCarList.TabIndex = 0;
            // 
            // lblMainHeader
            // 
            this.lblMainHeader.AutoSize = true;
            this.lblMainHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMainHeader.Location = new System.Drawing.Point(13, 37);
            this.lblMainHeader.Name = "lblMainHeader";
            this.lblMainHeader.Size = new System.Drawing.Size(99, 21);
            this.lblMainHeader.TabIndex = 1;
            this.lblMainHeader.Text = "RENT A CAR";
            // 
            // gbxCars
            // 
            this.gbxCars.Controls.Add(this.dgrwCarList);
            this.gbxCars.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbxCars.Location = new System.Drawing.Point(228, 63);
            this.gbxCars.Name = "gbxCars";
            this.gbxCars.Size = new System.Drawing.Size(547, 266);
            this.gbxCars.TabIndex = 2;
            this.gbxCars.TabStop = false;
            this.gbxCars.Text = "Car List";
            // 
            // dgrwCarList
            // 
            this.dgrwCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrwCarList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrwCarList.Location = new System.Drawing.Point(3, 25);
            this.dgrwCarList.Name = "dgrwCarList";
            this.dgrwCarList.RowTemplate.Height = 25;
            this.dgrwCarList.Size = new System.Drawing.Size(541, 238);
            this.dgrwCarList.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxCars);
            this.Controls.Add(this.lblMainHeader);
            this.Controls.Add(this.lbxCarList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxCars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrwCarList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCarList;
        private System.Windows.Forms.Label lblMainHeader;
        private System.Windows.Forms.GroupBox gbxCars;
        private System.Windows.Forms.DataGridView dgrwCarList;
    }
}

