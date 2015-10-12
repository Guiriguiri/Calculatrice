namespace Calculatrice_safronov
{
    partial class WIN_CALC
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.zt_Write = new System.Windows.Forms.TextBox();
            this.zt_read = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_carre = new System.Windows.Forms.Button();
            this.btn_racine = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_divise = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_less = new System.Windows.Forms.Button();
            this.btn_dot = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_PI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zt_Write
            // 
            this.zt_Write.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zt_Write.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zt_Write.Enabled = false;
            this.zt_Write.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zt_Write.Location = new System.Drawing.Point(2, 3);
            this.zt_Write.Name = "zt_Write";
            this.zt_Write.Size = new System.Drawing.Size(280, 33);
            this.zt_Write.TabIndex = 0;
            this.zt_Write.TabStop = false;
            this.zt_Write.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // zt_read
            // 
            this.zt_read.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zt_read.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zt_read.Enabled = false;
            this.zt_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zt_read.Location = new System.Drawing.Point(2, 42);
            this.zt_read.Name = "zt_read";
            this.zt_read.Size = new System.Drawing.Size(280, 37);
            this.zt_read.TabIndex = 1;
            this.zt_read.TabStop = false;
            this.zt_read.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(6, 85);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(64, 48);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.TabStop = false;
            this.btn_reset.Text = "CE";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_carre
            // 
            this.btn_carre.BackColor = System.Drawing.Color.Coral;
            this.btn_carre.FlatAppearance.BorderSize = 0;
            this.btn_carre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_carre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_carre.Location = new System.Drawing.Point(76, 85);
            this.btn_carre.Name = "btn_carre";
            this.btn_carre.Size = new System.Drawing.Size(64, 48);
            this.btn_carre.TabIndex = 3;
            this.btn_carre.TabStop = false;
            this.btn_carre.Text = "x^n";
            this.btn_carre.UseVisualStyleBackColor = false;
            this.btn_carre.Click += new System.EventHandler(this.btn_carre_Click);
            // 
            // btn_racine
            // 
            this.btn_racine.BackColor = System.Drawing.Color.Coral;
            this.btn_racine.FlatAppearance.BorderSize = 0;
            this.btn_racine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_racine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_racine.Location = new System.Drawing.Point(147, 85);
            this.btn_racine.Name = "btn_racine";
            this.btn_racine.Size = new System.Drawing.Size(63, 48);
            this.btn_racine.TabIndex = 4;
            this.btn_racine.TabStop = false;
            this.btn_racine.Text = " √ ";
            this.btn_racine.UseVisualStyleBackColor = false;
            this.btn_racine.Click += new System.EventHandler(this.btn_racine_Click);
            // 
            // btn_7
            // 
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.Location = new System.Drawing.Point(6, 139);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(64, 46);
            this.btn_7.TabIndex = 5;
            this.btn_7.TabStop = false;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.Location = new System.Drawing.Point(76, 139);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(64, 46);
            this.btn_8.TabIndex = 6;
            this.btn_8.TabStop = false;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.Location = new System.Drawing.Point(146, 139);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(64, 46);
            this.btn_9.TabIndex = 7;
            this.btn_9.TabStop = false;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_divise
            // 
            this.btn_divise.BackColor = System.Drawing.Color.Coral;
            this.btn_divise.FlatAppearance.BorderSize = 0;
            this.btn_divise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_divise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_divise.Location = new System.Drawing.Point(216, 139);
            this.btn_divise.Name = "btn_divise";
            this.btn_divise.Size = new System.Drawing.Size(64, 46);
            this.btn_divise.TabIndex = 8;
            this.btn_divise.TabStop = false;
            this.btn_divise.Text = "÷";
            this.btn_divise.UseVisualStyleBackColor = false;
            this.btn_divise.Click += new System.EventHandler(this.btn_divise_Click);
            // 
            // btn_4
            // 
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Location = new System.Drawing.Point(6, 191);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(64, 49);
            this.btn_4.TabIndex = 9;
            this.btn_4.TabStop = false;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.Location = new System.Drawing.Point(76, 191);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(64, 49);
            this.btn_5.TabIndex = 10;
            this.btn_5.TabStop = false;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_6
            // 
            this.btn_6.CausesValidation = false;
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.Location = new System.Drawing.Point(147, 191);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(63, 49);
            this.btn_6.TabIndex = 11;
            this.btn_6.TabStop = false;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.BackColor = System.Drawing.Color.Coral;
            this.btn_multi.FlatAppearance.BorderSize = 0;
            this.btn_multi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multi.Location = new System.Drawing.Point(216, 191);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(64, 49);
            this.btn_multi.TabIndex = 12;
            this.btn_multi.TabStop = false;
            this.btn_multi.Text = "x";
            this.btn_multi.UseVisualStyleBackColor = false;
            this.btn_multi.Click += new System.EventHandler(this.btn_multi_Click);
            // 
            // btn_1
            // 
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(6, 246);
            this.btn_1.Name = "btn_1";
            this.btn_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_1.Size = new System.Drawing.Size(64, 47);
            this.btn_1.TabIndex = 13;
            this.btn_1.TabStop = false;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(76, 246);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(64, 47);
            this.btn_2.TabIndex = 14;
            this.btn_2.TabStop = false;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(146, 246);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(64, 47);
            this.btn_3.TabIndex = 15;
            this.btn_3.TabStop = false;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_less
            // 
            this.btn_less.BackColor = System.Drawing.Color.Coral;
            this.btn_less.FlatAppearance.BorderSize = 0;
            this.btn_less.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_less.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_less.Location = new System.Drawing.Point(216, 246);
            this.btn_less.Name = "btn_less";
            this.btn_less.Size = new System.Drawing.Size(64, 47);
            this.btn_less.TabIndex = 16;
            this.btn_less.TabStop = false;
            this.btn_less.Text = "-";
            this.btn_less.UseVisualStyleBackColor = false;
            this.btn_less.Click += new System.EventHandler(this.btn_less_Click);
            // 
            // btn_dot
            // 
            this.btn_dot.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_dot.FlatAppearance.BorderSize = 0;
            this.btn_dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dot.Location = new System.Drawing.Point(6, 299);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(64, 46);
            this.btn_dot.TabIndex = 17;
            this.btn_dot.TabStop = false;
            this.btn_dot.Text = ",";
            this.btn_dot.UseVisualStyleBackColor = false;
            this.btn_dot.Click += new System.EventHandler(this.btn_dot_Click);
            // 
            // btn_0
            // 
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.Location = new System.Drawing.Point(76, 299);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(64, 46);
            this.btn_0.TabIndex = 18;
            this.btn_0.TabStop = false;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_equal
            // 
            this.btn_equal.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_equal.FlatAppearance.BorderSize = 0;
            this.btn_equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equal.Location = new System.Drawing.Point(147, 299);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(63, 46);
            this.btn_equal.TabIndex = 19;
            this.btn_equal.TabStop = false;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = false;
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Coral;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(216, 299);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(64, 46);
            this.btn_add.TabIndex = 20;
            this.btn_add.TabStop = false;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_PI
            // 
            this.btn_PI.BackColor = System.Drawing.Color.Coral;
            this.btn_PI.FlatAppearance.BorderSize = 0;
            this.btn_PI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PI.Location = new System.Drawing.Point(216, 85);
            this.btn_PI.Name = "btn_PI";
            this.btn_PI.Size = new System.Drawing.Size(63, 48);
            this.btn_PI.TabIndex = 21;
            this.btn_PI.TabStop = false;
            this.btn_PI.Text = "π";
            this.btn_PI.UseVisualStyleBackColor = false;
            this.btn_PI.Click += new System.EventHandler(this.btn_PI_Click);
            // 
            // WIN_CALC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 347);
            this.Controls.Add(this.btn_PI);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_dot);
            this.Controls.Add(this.btn_less);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_divise);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_racine);
            this.Controls.Add(this.btn_carre);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.zt_read);
            this.Controls.Add(this.zt_Write);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WIN_CALC";
            this.Text = "BG_Calculatrice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox zt_Write;
        public System.Windows.Forms.TextBox zt_read;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_carre;
        private System.Windows.Forms.Button btn_racine;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_divise;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_less;
        private System.Windows.Forms.Button btn_dot;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_PI;
    }
}

