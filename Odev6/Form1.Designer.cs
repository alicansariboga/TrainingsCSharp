﻿
namespace Odev6
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
            this.lbxProducts = new System.Windows.Forms.ListBox();
            this.lbxCart = new System.Windows.Forms.ListBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnConfirmCart = new System.Windows.Forms.Button();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxProducts
            // 
            this.lbxProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxProducts.FormattingEnabled = true;
            this.lbxProducts.ItemHeight = 21;
            this.lbxProducts.Location = new System.Drawing.Point(12, 82);
            this.lbxProducts.Name = "lbxProducts";
            this.lbxProducts.Size = new System.Drawing.Size(260, 340);
            this.lbxProducts.TabIndex = 0;
            // 
            // lbxCart
            // 
            this.lbxCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxCart.FormattingEnabled = true;
            this.lbxCart.ItemHeight = 21;
            this.lbxCart.Location = new System.Drawing.Point(328, 82);
            this.lbxCart.Name = "lbxCart";
            this.lbxCart.Size = new System.Drawing.Size(260, 340);
            this.lbxCart.TabIndex = 1;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProducts.Location = new System.Drawing.Point(12, 49);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(57, 21);
            this.lblProducts.TabIndex = 2;
            this.lblProducts.Text = "label1";
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCart.Location = new System.Drawing.Point(328, 49);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(57, 21);
            this.lblCart.TabIndex = 3;
            this.lblCart.Text = "label2";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddToCart.Location = new System.Drawing.Point(119, 432);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(150, 35);
            this.btnAddToCart.TabIndex = 4;
            this.btnAddToCart.Text = "button1";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnConfirmCart
            // 
            this.btnConfirmCart.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmCart.Location = new System.Drawing.Point(438, 432);
            this.btnConfirmCart.Name = "btnConfirmCart";
            this.btnConfirmCart.Size = new System.Drawing.Size(150, 35);
            this.btnConfirmCart.TabIndex = 5;
            this.btnConfirmCart.Text = "button2";
            this.btnConfirmCart.UseVisualStyleBackColor = true;
            this.btnConfirmCart.Click += new System.EventHandler(this.btnConfirmCart_Click);
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveFromCart.Location = new System.Drawing.Point(620, 82);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(150, 35);
            this.btnRemoveFromCart.TabIndex = 6;
            this.btnRemoveFromCart.Text = "button3";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearCart.Location = new System.Drawing.Point(620, 123);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(150, 35);
            this.btnClearCart.TabIndex = 7;
            this.btnClearCart.Text = "button4";
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 636);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.btnConfirmCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lbxCart);
            this.Controls.Add(this.lbxProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxProducts;
        private System.Windows.Forms.ListBox lbxCart;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnConfirmCart;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.Button btnClearCart;
    }
}

