
namespace CSIAPIDEMO.AddForms
{
    partial class NewModel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_empy = new System.Windows.Forms.Button();
            this.btn_grids = new System.Windows.Forms.Button();
            this.btn_steeldeck = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pn_grids = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_numberofgridsx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_numberofgridsy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edt_spacingx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edt_spacingy = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.edt_bootomstoryheight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edt_typicalstoryheight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edt_numberofsotry = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pn_grids.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_steeldeck);
            this.panel1.Controls.Add(this.btn_grids);
            this.panel1.Controls.Add(this.btn_empy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 119);
            this.panel1.TabIndex = 0;
            // 
            // btn_empy
            // 
            this.btn_empy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empy.Location = new System.Drawing.Point(91, 13);
            this.btn_empy.Name = "btn_empy";
            this.btn_empy.Size = new System.Drawing.Size(161, 94);
            this.btn_empy.TabIndex = 0;
            this.btn_empy.Text = "Blank";
            this.btn_empy.UseVisualStyleBackColor = true;
            this.btn_empy.Click += new System.EventHandler(this.btn_empy_Click);
            // 
            // btn_grids
            // 
            this.btn_grids.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grids.Location = new System.Drawing.Point(314, 13);
            this.btn_grids.Name = "btn_grids";
            this.btn_grids.Size = new System.Drawing.Size(161, 94);
            this.btn_grids.TabIndex = 0;
            this.btn_grids.Text = "Grids";
            this.btn_grids.UseVisualStyleBackColor = true;
            this.btn_grids.Click += new System.EventHandler(this.btn_grids_Click);
            // 
            // btn_steeldeck
            // 
            this.btn_steeldeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_steeldeck.Location = new System.Drawing.Point(537, 13);
            this.btn_steeldeck.Name = "btn_steeldeck";
            this.btn_steeldeck.Size = new System.Drawing.Size(161, 94);
            this.btn_steeldeck.TabIndex = 0;
            this.btn_steeldeck.Text = "Steel Deck";
            this.btn_steeldeck.UseVisualStyleBackColor = true;
            this.btn_steeldeck.Click += new System.EventHandler(this.btn_steeldeck_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pn_grids);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 356);
            this.panel2.TabIndex = 1;
            // 
            // pn_grids
            // 
            this.pn_grids.Controls.Add(this.groupBox2);
            this.pn_grids.Controls.Add(this.groupBox1);
            this.pn_grids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_grids.Location = new System.Drawing.Point(0, 0);
            this.pn_grids.Name = "pn_grids";
            this.pn_grids.Size = new System.Drawing.Size(820, 356);
            this.pn_grids.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edt_spacingy);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.edt_spacingx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.edt_numberofgridsy);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.edt_numberofgridsx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grids Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of grid in X";
            // 
            // edt_numberofgridsx
            // 
            this.edt_numberofgridsx.Location = new System.Drawing.Point(223, 37);
            this.edt_numberofgridsx.Name = "edt_numberofgridsx";
            this.edt_numberofgridsx.Size = new System.Drawing.Size(134, 26);
            this.edt_numberofgridsx.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of grid in Y";
            // 
            // edt_numberofgridsy
            // 
            this.edt_numberofgridsy.Location = new System.Drawing.Point(223, 90);
            this.edt_numberofgridsy.Name = "edt_numberofgridsy";
            this.edt_numberofgridsy.Size = new System.Drawing.Size(134, 26);
            this.edt_numberofgridsy.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Spacing X";
            // 
            // edt_spacingx
            // 
            this.edt_spacingx.Location = new System.Drawing.Point(223, 143);
            this.edt_spacingx.Name = "edt_spacingx";
            this.edt_spacingx.Size = new System.Drawing.Size(134, 26);
            this.edt_spacingx.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Spacing Y";
            // 
            // edt_spacingy
            // 
            this.edt_spacingy.Location = new System.Drawing.Point(223, 196);
            this.edt_spacingy.Name = "edt_spacingy";
            this.edt_spacingy.Size = new System.Drawing.Size(134, 26);
            this.edt_spacingy.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.edt_bootomstoryheight);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.edt_typicalstoryheight);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.edt_numberofsotry);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(431, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 216);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stroy Data";
            // 
            // edt_bootomstoryheight
            // 
            this.edt_bootomstoryheight.Location = new System.Drawing.Point(220, 143);
            this.edt_bootomstoryheight.Name = "edt_bootomstoryheight";
            this.edt_bootomstoryheight.Size = new System.Drawing.Size(134, 26);
            this.edt_bootomstoryheight.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bottom Stoty Height";
            // 
            // edt_typicalstoryheight
            // 
            this.edt_typicalstoryheight.Location = new System.Drawing.Point(220, 90);
            this.edt_typicalstoryheight.Name = "edt_typicalstoryheight";
            this.edt_typicalstoryheight.Size = new System.Drawing.Size(134, 26);
            this.edt_typicalstoryheight.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Typical Story Height";
            // 
            // edt_numberofsotry
            // 
            this.edt_numberofsotry.Location = new System.Drawing.Point(220, 37);
            this.edt_numberofsotry.Name = "edt_numberofsotry";
            this.edt_numberofsotry.Size = new System.Drawing.Size(134, 26);
            this.edt_numberofsotry.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Number of storys";
            // 
            // NewModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 475);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewModel";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Model";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pn_grids.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_steeldeck;
        private System.Windows.Forms.Button btn_grids;
        private System.Windows.Forms.Button btn_empy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pn_grids;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox edt_bootomstoryheight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edt_typicalstoryheight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edt_numberofsotry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox edt_spacingy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edt_spacingx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edt_numberofgridsy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edt_numberofgridsx;
        private System.Windows.Forms.Label label1;
    }
}