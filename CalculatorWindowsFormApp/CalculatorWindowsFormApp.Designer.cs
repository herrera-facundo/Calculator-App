using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormApp
{
    partial class CalculatorWindowsFormApp
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
            this.seven = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.star = new System.Windows.Forms.Button();
            this.dash = new System.Windows.Forms.Button();
            this.period = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.two = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.sine = new System.Windows.Forms.Button();
            this.cosine = new System.Windows.Forms.Button();
            this.tangent = new System.Windows.Forms.Button();
            this.exponent = new System.Windows.Forms.Button();
            this.lblExpression = new System.Windows.Forms.Label();
            this.backspace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.RoyalBlue;
            this.seven.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seven.Font = new System.Drawing.Font("BankGothic Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.ForeColor = System.Drawing.SystemColors.Control;
            this.seven.Location = new System.Drawing.Point(12, 113);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(75, 39);
            this.seven.TabIndex = 0;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.RoyalBlue;
            this.four.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.four.Font = new System.Drawing.Font("BankGothic Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.ForeColor = System.Drawing.SystemColors.Control;
            this.four.Location = new System.Drawing.Point(12, 158);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(75, 39);
            this.four.TabIndex = 1;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.RoyalBlue;
            this.one.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.one.Font = new System.Drawing.Font("BankGothic Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.ForeColor = System.Drawing.SystemColors.Control;
            this.one.Location = new System.Drawing.Point(12, 203);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(75, 39);
            this.one.TabIndex = 2;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.RoyalBlue;
            this.plus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plus.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.ForeColor = System.Drawing.SystemColors.Control;
            this.plus.Location = new System.Drawing.Point(303, 71);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(42, 126);
            this.plus.TabIndex = 15;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.RoyalBlue;
            this.minus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minus.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.ForeColor = System.Drawing.SystemColors.Control;
            this.minus.Location = new System.Drawing.Point(303, 203);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(42, 80);
            this.minus.TabIndex = 16;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.RoyalBlue;
            this.enter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enter.Font = new System.Drawing.Font("BankGothic Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.ForeColor = System.Drawing.SystemColors.Control;
            this.enter.Location = new System.Drawing.Point(174, 248);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(123, 35);
            this.enter.TabIndex = 0;
            this.enter.Text = "enter";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.RoyalBlue;
            this.zero.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zero.Font = new System.Drawing.Font("BankGothic Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.ForeColor = System.Drawing.SystemColors.Control;
            this.zero.Location = new System.Drawing.Point(12, 248);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(75, 35);
            this.zero.TabIndex = 18;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // star
            // 
            this.star.BackColor = System.Drawing.Color.RoyalBlue;
            this.star.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.star.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.star.Font = new System.Drawing.Font("BankGothic Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.star.ForeColor = System.Drawing.SystemColors.Control;
            this.star.Location = new System.Drawing.Point(174, 71);
            this.star.Name = "star";
            this.star.Size = new System.Drawing.Size(75, 36);
            this.star.TabIndex = 19;
            this.star.Text = "*";
            this.star.UseVisualStyleBackColor = false;
            this.star.Click += new System.EventHandler(this.star_Click);
            // 
            // dash
            // 
            this.dash.BackColor = System.Drawing.Color.RoyalBlue;
            this.dash.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.dash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dash.Font = new System.Drawing.Font("BankGothic Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash.ForeColor = System.Drawing.SystemColors.Control;
            this.dash.Location = new System.Drawing.Point(93, 71);
            this.dash.Name = "dash";
            this.dash.Size = new System.Drawing.Size(75, 36);
            this.dash.TabIndex = 20;
            this.dash.Text = "/";
            this.dash.UseVisualStyleBackColor = false;
            this.dash.Click += new System.EventHandler(this.dash_Click);
            // 
            // period
            // 
            this.period.BackColor = System.Drawing.Color.RoyalBlue;
            this.period.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.period.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.period.Font = new System.Drawing.Font("BankGothic Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period.ForeColor = System.Drawing.SystemColors.Control;
            this.period.Location = new System.Drawing.Point(12, 71);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(75, 36);
            this.period.TabIndex = 21;
            this.period.Text = ".";
            this.period.UseVisualStyleBackColor = false;
            this.period.Click += new System.EventHandler(this.period_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.display.Font = new System.Drawing.Font("BankGothic Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(12, 29);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.Size = new System.Drawing.Size(237, 36);
            this.display.TabIndex = 22;
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.RoyalBlue;
            this.two.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.two.Font = new System.Drawing.Font("BankGothic Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.ForeColor = System.Drawing.SystemColors.Control;
            this.two.Location = new System.Drawing.Point(93, 203);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(75, 39);
            this.two.TabIndex = 25;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.RoyalBlue;
            this.five.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.five.Font = new System.Drawing.Font("BankGothic Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.ForeColor = System.Drawing.SystemColors.Control;
            this.five.Location = new System.Drawing.Point(93, 158);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(75, 39);
            this.five.TabIndex = 24;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.RoyalBlue;
            this.eight.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eight.Font = new System.Drawing.Font("BankGothic Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.ForeColor = System.Drawing.SystemColors.Control;
            this.eight.Location = new System.Drawing.Point(93, 113);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(75, 39);
            this.eight.TabIndex = 23;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.RoyalBlue;
            this.three.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.three.Font = new System.Drawing.Font("BankGothic Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.ForeColor = System.Drawing.SystemColors.Control;
            this.three.Location = new System.Drawing.Point(174, 203);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(75, 39);
            this.three.TabIndex = 30;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.RoyalBlue;
            this.six.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.six.Font = new System.Drawing.Font("BankGothic Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.ForeColor = System.Drawing.SystemColors.Control;
            this.six.Location = new System.Drawing.Point(174, 158);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(75, 39);
            this.six.TabIndex = 29;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.RoyalBlue;
            this.nine.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nine.Font = new System.Drawing.Font("BankGothic Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.ForeColor = System.Drawing.SystemColors.Control;
            this.nine.Location = new System.Drawing.Point(174, 113);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(75, 39);
            this.nine.TabIndex = 28;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Firebrick;
            this.clear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Font = new System.Drawing.Font("BankGothic Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(255, 29);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(90, 36);
            this.clear.TabIndex = 31;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // sine
            // 
            this.sine.BackColor = System.Drawing.Color.RoyalBlue;
            this.sine.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sine.Font = new System.Drawing.Font("BankGothic Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sine.ForeColor = System.Drawing.SystemColors.Control;
            this.sine.Location = new System.Drawing.Point(255, 113);
            this.sine.Name = "sine";
            this.sine.Size = new System.Drawing.Size(42, 39);
            this.sine.TabIndex = 32;
            this.sine.Text = "sin";
            this.sine.UseVisualStyleBackColor = false;
            this.sine.Click += new System.EventHandler(this.sine_Click);
            // 
            // cosine
            // 
            this.cosine.BackColor = System.Drawing.Color.RoyalBlue;
            this.cosine.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cosine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cosine.Font = new System.Drawing.Font("BankGothic Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cosine.ForeColor = System.Drawing.SystemColors.Control;
            this.cosine.Location = new System.Drawing.Point(255, 158);
            this.cosine.Name = "cosine";
            this.cosine.Size = new System.Drawing.Size(42, 39);
            this.cosine.TabIndex = 33;
            this.cosine.Text = "cos";
            this.cosine.UseVisualStyleBackColor = false;
            this.cosine.Click += new System.EventHandler(this.cosine_Click);
            // 
            // tangent
            // 
            this.tangent.BackColor = System.Drawing.Color.RoyalBlue;
            this.tangent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.tangent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tangent.Font = new System.Drawing.Font("BankGothic Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tangent.ForeColor = System.Drawing.SystemColors.Control;
            this.tangent.Location = new System.Drawing.Point(255, 203);
            this.tangent.Name = "tangent";
            this.tangent.Size = new System.Drawing.Size(42, 39);
            this.tangent.TabIndex = 34;
            this.tangent.Text = "tan";
            this.tangent.UseVisualStyleBackColor = false;
            this.tangent.Click += new System.EventHandler(this.tangent_Click);
            // 
            // exponent
            // 
            this.exponent.BackColor = System.Drawing.Color.RoyalBlue;
            this.exponent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exponent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exponent.Font = new System.Drawing.Font("BankGothic Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exponent.ForeColor = System.Drawing.SystemColors.Control;
            this.exponent.Location = new System.Drawing.Point(255, 71);
            this.exponent.Name = "exponent";
            this.exponent.Size = new System.Drawing.Size(42, 36);
            this.exponent.TabIndex = 35;
            this.exponent.Text = "^";
            this.exponent.UseVisualStyleBackColor = false;
            this.exponent.Click += new System.EventHandler(this.exponent_Click);
            // 
            // lblExpression
            // 
            this.lblExpression.AutoSize = true;
            this.lblExpression.Font = new System.Drawing.Font("BankGothic Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpression.ForeColor = System.Drawing.SystemColors.Control;
            this.lblExpression.Location = new System.Drawing.Point(13, 13);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(0, 12);
            this.lblExpression.TabIndex = 36;
            // 
            // backspace
            // 
            this.backspace.BackColor = System.Drawing.Color.RoyalBlue;
            this.backspace.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backspace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backspace.Font = new System.Drawing.Font("BankGothic Md BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspace.ForeColor = System.Drawing.SystemColors.Control;
            this.backspace.Location = new System.Drawing.Point(93, 248);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(75, 35);
            this.backspace.TabIndex = 37;
            this.backspace.Text = "⌫";
            this.backspace.UseVisualStyleBackColor = false;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // Calculator
            // 
            this.AcceptButton = this.enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.CancelButton = this.clear;
            this.ClientSize = new System.Drawing.Size(357, 294);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.lblExpression);
            this.Controls.Add(this.exponent);
            this.Controls.Add(this.tangent);
            this.Controls.Add(this.cosine);
            this.Controls.Add(this.sine);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.three);
            this.Controls.Add(this.six);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.two);
            this.Controls.Add(this.five);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.display);
            this.Controls.Add(this.period);
            this.Controls.Add(this.dash);
            this.Controls.Add(this.star);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.one);
            this.Controls.Add(this.four);
            this.Controls.Add(this.seven);
            this.KeyPreview = true;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button star;
        private System.Windows.Forms.Button dash;
        private System.Windows.Forms.Button period;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button sine;
        private System.Windows.Forms.Button cosine;
        private System.Windows.Forms.Button tangent;
        private System.Windows.Forms.Button exponent;
        private System.Windows.Forms.Label lblExpression;
        private System.Windows.Forms.Button backspace;
    }
}

