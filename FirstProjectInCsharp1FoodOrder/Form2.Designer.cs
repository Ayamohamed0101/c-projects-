namespace FirstProjectInCsharp1FoodOrder
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbBurgerSummary = new System.Windows.Forms.GroupBox();
            this.gbCrepSumary = new System.Windows.Forms.GroupBox();
            this.gbPizzaSummary = new System.Windows.Forms.GroupBox();
            this.LblOrderSUmmary = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food summary";
            // 
            // gbBurgerSummary
            // 
            this.gbBurgerSummary.Location = new System.Drawing.Point(47, 100);
            this.gbBurgerSummary.Name = "gbBurgerSummary";
            this.gbBurgerSummary.Size = new System.Drawing.Size(348, 235);
            this.gbBurgerSummary.TabIndex = 1;
            this.gbBurgerSummary.TabStop = false;
            this.gbBurgerSummary.Text = "Burger Summary";
            // 
            // gbCrepSumary
            // 
            this.gbCrepSumary.Location = new System.Drawing.Point(447, 100);
            this.gbCrepSumary.Name = "gbCrepSumary";
            this.gbCrepSumary.Size = new System.Drawing.Size(348, 253);
            this.gbCrepSumary.TabIndex = 2;
            this.gbCrepSumary.TabStop = false;
            this.gbCrepSumary.Text = "Creip Summary";
            // 
            // gbPizzaSummary
            // 
            this.gbPizzaSummary.Location = new System.Drawing.Point(825, 100);
            this.gbPizzaSummary.Name = "gbPizzaSummary";
            this.gbPizzaSummary.Size = new System.Drawing.Size(348, 235);
            this.gbPizzaSummary.TabIndex = 3;
            this.gbPizzaSummary.TabStop = false;
            this.gbPizzaSummary.Text = "pizaa Summary";
            // 
            // LblOrderSUmmary
            // 
            this.LblOrderSUmmary.Location = new System.Drawing.Point(754, 475);
            this.LblOrderSUmmary.Name = "LblOrderSUmmary";
            this.LblOrderSUmmary.Size = new System.Drawing.Size(141, 92);
            this.LblOrderSUmmary.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 87);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(753, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total price";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 690);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblOrderSUmmary);
            this.Controls.Add(this.gbPizzaSummary);
            this.Controls.Add(this.gbCrepSumary);
            this.Controls.Add(this.gbBurgerSummary);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbBurgerSummary;
        private System.Windows.Forms.GroupBox gbCrepSumary;
        private System.Windows.Forms.GroupBox gbPizzaSummary;
        private System.Windows.Forms.Label LblOrderSUmmary;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}