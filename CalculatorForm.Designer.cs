using System.IO;

namespace Calculator
{
    partial class CalculatorForm
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
            this.tbCalcInput = new System.Windows.Forms.TextBox();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.groupKeypad = new System.Windows.Forms.GroupBox();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnClearResult = new System.Windows.Forms.Button();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.lblResultOutput = new System.Windows.Forms.Label();
            this.groupResult = new System.Windows.Forms.GroupBox();
            this.lblErrorText = new System.Windows.Forms.Label();
            this.groupKeypad.SuspendLayout();
            this.groupResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCalcInput
            // 
            this.tbCalcInput.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCalcInput.Location = new System.Drawing.Point(18, 19);
            this.tbCalcInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCalcInput.Name = "tbCalcInput";
            this.tbCalcInput.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbCalcInput.Size = new System.Drawing.Size(187, 43);
            this.tbCalcInput.TabIndex = 0;
            this.tbCalcInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbCalcInput.KeyUp += this.tbCalcInput_HandleKeyUp;
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(6, 169);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(39, 37);
            this.btnOne.TabIndex = 1;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(51, 169);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(39, 37);
            this.btnTwo.TabIndex = 2;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(96, 169);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(39, 37);
            this.btnThree.TabIndex = 3;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(96, 126);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(39, 37);
            this.btnSix.TabIndex = 6;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(51, 126);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(39, 37);
            this.btnFive.TabIndex = 5;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(6, 126);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(39, 37);
            this.btnFour.TabIndex = 4;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(96, 83);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(39, 37);
            this.btnNine.TabIndex = 9;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(51, 83);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(39, 37);
            this.btnEight.TabIndex = 8;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(6, 83);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(39, 37);
            this.btnSeven.TabIndex = 7;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(6, 212);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(84, 37);
            this.btnZero.TabIndex = 10;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // groupKeypad
            // 
            this.groupKeypad.Controls.Add(this.btnSubtract);
            this.groupKeypad.Controls.Add(this.btnMultiply);
            this.groupKeypad.Controls.Add(this.btnDivide);
            this.groupKeypad.Controls.Add(this.btnClearResult);
            this.groupKeypad.Controls.Add(this.btnEvaluate);
            this.groupKeypad.Controls.Add(this.btnAdd);
            this.groupKeypad.Controls.Add(this.btnDot);
            this.groupKeypad.Controls.Add(this.btnSeven);
            this.groupKeypad.Controls.Add(this.btnZero);
            this.groupKeypad.Controls.Add(this.btnOne);
            this.groupKeypad.Controls.Add(this.btnNine);
            this.groupKeypad.Controls.Add(this.btnTwo);
            this.groupKeypad.Controls.Add(this.btnEight);
            this.groupKeypad.Controls.Add(this.btnThree);
            this.groupKeypad.Controls.Add(this.btnFour);
            this.groupKeypad.Controls.Add(this.btnSix);
            this.groupKeypad.Controls.Add(this.btnFive);
            this.groupKeypad.Location = new System.Drawing.Point(18, 166);
            this.groupKeypad.Name = "groupKeypad";
            this.groupKeypad.Size = new System.Drawing.Size(187, 255);
            this.groupKeypad.TabIndex = 11;
            this.groupKeypad.TabStop = false;
            this.groupKeypad.Text = "Digital Keypad";
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(141, 40);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(39, 37);
            this.btnSubtract.TabIndex = 17;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(96, 40);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(39, 37);
            this.btnMultiply.TabIndex = 16;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(51, 40);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(39, 37);
            this.btnDivide.TabIndex = 15;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnClearResult
            // 
            this.btnClearResult.Location = new System.Drawing.Point(6, 40);
            this.btnClearResult.Name = "btnClearResult";
            this.btnClearResult.Size = new System.Drawing.Size(39, 37);
            this.btnClearResult.TabIndex = 14;
            this.btnClearResult.Text = "C";
            this.btnClearResult.UseVisualStyleBackColor = true;
            this.btnClearResult.Click += new System.EventHandler(this.btnClearResult_Click);
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaluate.Location = new System.Drawing.Point(141, 169);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(39, 80);
            this.btnEvaluate.TabIndex = 13;
            this.btnEvaluate.Text = "Enter";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(141, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(39, 80);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(96, 212);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(39, 37);
            this.btnDot.TabIndex = 11;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // lblResultOutput
            // 
            this.lblResultOutput.Location = new System.Drawing.Point(6, 25);
            this.lblResultOutput.Name = "lblResultOutput";
            this.lblResultOutput.Size = new System.Drawing.Size(174, 23);
            this.lblResultOutput.TabIndex = 12;
            // 
            // groupResult
            // 
            this.groupResult.Controls.Add(this.lblErrorText);
            this.groupResult.Controls.Add(this.lblResultOutput);
            this.groupResult.Location = new System.Drawing.Point(18, 70);
            this.groupResult.Name = "groupResult";
            this.groupResult.Size = new System.Drawing.Size(187, 90);
            this.groupResult.TabIndex = 13;
            this.groupResult.TabStop = false;
            this.groupResult.Text = "Result:";
            // 
            // lblErrorText
            // 
            this.lblErrorText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorText.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErrorText.Location = new System.Drawing.Point(6, 64);
            this.lblErrorText.Name = "lblErrorText";
            this.lblErrorText.Size = new System.Drawing.Size(174, 16);
            this.lblErrorText.TabIndex = 13;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 434);
            this.Controls.Add(this.groupResult);
            this.Controls.Add(this.groupKeypad);
            this.Controls.Add(this.tbCalcInput);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CalculatorForm";
            this.Text = "MP1 - Calculator";
            this.groupKeypad.ResumeLayout(false);
            this.groupResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblResultOutput;

        private System.Windows.Forms.GroupBox groupResult;

        private System.Windows.Forms.Label lblErrorText;

        private System.Windows.Forms.Button btnClearResult;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSubtract;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEvaluate;

        private System.Windows.Forms.GroupBox groupKeypad;
        private System.Windows.Forms.Button btnDot;

        private System.Windows.Forms.Button btnZero;

        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;

        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;

        private System.Windows.Forms.Button btnThree;

        private System.Windows.Forms.TextBox tbCalcInput;

        #endregion
    }
}