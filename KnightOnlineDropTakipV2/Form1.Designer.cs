
namespace KnightOnlineDropTakipV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.dropNameTbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.partyMembersTbox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.priceNud = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.isSharedTrue = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.isSharedFalse = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.BtnGetir = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnMembers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNud)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(261, 27);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.Size = new System.Drawing.Size(710, 499);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseDoubleClick_1);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.LightGreen;
            this.AddBtn.Location = new System.Drawing.Point(18, 310);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // dropNameTbox
            // 
            this.dropNameTbox.Location = new System.Drawing.Point(12, 27);
            this.dropNameTbox.Name = "dropNameTbox";
            this.dropNameTbox.Size = new System.Drawing.Size(243, 23);
            this.dropNameTbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Party Members";
            // 
            // partyMembersTbox
            // 
            this.partyMembersTbox.Location = new System.Drawing.Point(11, 159);
            this.partyMembersTbox.Multiline = true;
            this.partyMembersTbox.Name = "partyMembersTbox";
            this.partyMembersTbox.Size = new System.Drawing.Size(243, 73);
            this.partyMembersTbox.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 23);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Drop Date";
            // 
            // priceNud
            // 
            this.priceNud.Location = new System.Drawing.Point(12, 71);
            this.priceNud.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.priceNud.Name = "priceNud";
            this.priceNud.Size = new System.Drawing.Size(243, 23);
            this.priceNud.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price";
            // 
            // isSharedTrue
            // 
            this.isSharedTrue.AutoSize = true;
            this.isSharedTrue.Location = new System.Drawing.Point(3, 15);
            this.isSharedTrue.Name = "isSharedTrue";
            this.isSharedTrue.Size = new System.Drawing.Size(42, 19);
            this.isSharedTrue.TabIndex = 10;
            this.isSharedTrue.TabStop = true;
            this.isSharedTrue.Text = "Yes";
            this.isSharedTrue.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.isSharedFalse);
            this.panel1.Controls.Add(this.isSharedTrue);
            this.panel1.Location = new System.Drawing.Point(11, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 48);
            this.panel1.TabIndex = 11;
            // 
            // isSharedFalse
            // 
            this.isSharedFalse.AutoSize = true;
            this.isSharedFalse.Location = new System.Drawing.Point(103, 15);
            this.isSharedFalse.Name = "isSharedFalse";
            this.isSharedFalse.Size = new System.Drawing.Size(41, 19);
            this.isSharedFalse.TabIndex = 11;
            this.isSharedFalse.TabStop = true;
            this.isSharedFalse.Text = "No";
            this.isSharedFalse.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Is Shared?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Drop Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 367);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteBtn.BackColor = System.Drawing.Color.Salmon;
            this.DeleteBtn.Location = new System.Drawing.Point(99, 310);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 15;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Wheat;
            this.UpdateBtn.Location = new System.Drawing.Point(180, 310);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 16;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // BtnGetir
            // 
            this.BtnGetir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnGetir.Location = new System.Drawing.Point(99, 339);
            this.BtnGetir.Name = "BtnGetir";
            this.BtnGetir.Size = new System.Drawing.Size(75, 23);
            this.BtnGetir.TabIndex = 17;
            this.BtnGetir.Text = "Fill";
            this.BtnGetir.UseVisualStyleBackColor = false;
            this.BtnGetir.Click += new System.EventHandler(this.BtnGetir_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnClear.Location = new System.Drawing.Point(18, 339);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 18;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnMembers
            // 
            this.BtnMembers.Location = new System.Drawing.Point(179, 339);
            this.BtnMembers.Name = "BtnMembers";
            this.BtnMembers.Size = new System.Drawing.Size(75, 23);
            this.BtnMembers.TabIndex = 19;
            this.BtnMembers.Text = "Members";
            this.BtnMembers.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(983, 538);
            this.Controls.Add(this.BtnMembers);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnGetir);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceNud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.partyMembersTbox);
            this.Controls.Add(this.dropNameTbox);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.dataGridView);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TYRANNOSAURUS ITEM DROP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNud)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox dropNameTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox partyMembersTbox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown priceNud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton isSharedTrue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton isSharedFalse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button BtnGetir;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnMembers;
    }
}

