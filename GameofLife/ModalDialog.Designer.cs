
namespace GameofLife
{
    partial class ModalDialog
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.numericUpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.Label1Number = new System.Windows.Forms.Label();
            this.numericUpDownNumber2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumber3 = new System.Windows.Forms.NumericUpDown();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(21, 182);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(111, 182);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel ";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // numericUpDownNumber
            // 
            this.numericUpDownNumber.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownNumber.Location = new System.Drawing.Point(213, 89);
            this.numericUpDownNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownNumber.Name = "numericUpDownNumber";
            this.numericUpDownNumber.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownNumber.TabIndex = 2;
            this.numericUpDownNumber.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Label1Number
            // 
            this.Label1Number.AutoSize = true;
            this.Label1Number.Location = new System.Drawing.Point(18, 91);
            this.Label1Number.Name = "Label1Number";
            this.Label1Number.Size = new System.Drawing.Size(189, 13);
            this.Label1Number.TabIndex = 3;
            this.Label1Number.Text = "Milliseconds between new generations";
            // 
            // numericUpDownNumber2
            // 
            this.numericUpDownNumber2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownNumber2.Location = new System.Drawing.Point(213, 115);
            this.numericUpDownNumber2.Name = "numericUpDownNumber2";
            this.numericUpDownNumber2.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownNumber2.TabIndex = 4;
            // 
            // numericUpDownNumber3
            // 
            this.numericUpDownNumber3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownNumber3.Location = new System.Drawing.Point(213, 141);
            this.numericUpDownNumber3.Name = "numericUpDownNumber3";
            this.numericUpDownNumber3.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownNumber3.TabIndex = 5;
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(18, 115);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(80, 13);
            this.labelWidth.TabIndex = 6;
            this.labelWidth.Text = "Universe Width";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(18, 141);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(83, 13);
            this.labelHeight.TabIndex = 7;
            this.labelHeight.Text = "Universe Height";
            // 
            // ModalDialog
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(316, 221);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.numericUpDownNumber3);
            this.Controls.Add(this.numericUpDownNumber2);
            this.Controls.Add(this.Label1Number);
            this.Controls.Add(this.numericUpDownNumber);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModalDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModalDialog";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber;
        private System.Windows.Forms.Label Label1Number;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber2;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber3;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
    }
}