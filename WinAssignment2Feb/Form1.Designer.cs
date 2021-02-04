
namespace WinAssignment2Feb
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMovDetails = new System.Windows.Forms.TabPage();
            this.tabShowMov = new System.Windows.Forms.TabPage();
            this.tabUpdateMov = new System.Windows.Forms.TabPage();
            this.lblMovId = new System.Windows.Forms.Label();
            this.lblMovName = new System.Windows.Forms.Label();
            this.lblActor = new System.Windows.Forms.Label();
            this.lblTickets = new System.Windows.Forms.Label();
            this.txtMovId = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblMovieN = new System.Windows.Forms.Label();
            this.lblMvId = new System.Windows.Forms.Label();
            this.txtMvId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMovieN = new System.Windows.Forms.TextBox();
            this.txtActor = new System.Windows.Forms.TextBox();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabMovDetails.SuspendLayout();
            this.tabShowMov.SuspendLayout();
            this.tabUpdateMov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMovDetails);
            this.tabControl1.Controls.Add(this.tabShowMov);
            this.tabControl1.Controls.Add(this.tabUpdateMov);
            this.tabControl1.Location = new System.Drawing.Point(150, 77);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(426, 285);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMovDetails
            // 
            this.tabMovDetails.Controls.Add(this.btnShow);
            this.tabMovDetails.Controls.Add(this.txtMovId);
            this.tabMovDetails.Controls.Add(this.lblTickets);
            this.tabMovDetails.Controls.Add(this.lblActor);
            this.tabMovDetails.Controls.Add(this.lblMovName);
            this.tabMovDetails.Controls.Add(this.lblMovId);
            this.tabMovDetails.Location = new System.Drawing.Point(4, 22);
            this.tabMovDetails.Name = "tabMovDetails";
            this.tabMovDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovDetails.Size = new System.Drawing.Size(418, 259);
            this.tabMovDetails.TabIndex = 0;
            this.tabMovDetails.Text = "Movie Details";
            this.tabMovDetails.UseVisualStyleBackColor = true;
            this.tabMovDetails.Click += new System.EventHandler(this.tabMovDetails_Click_1);
            // 
            // tabShowMov
            // 
            this.tabShowMov.Controls.Add(this.txtMvId);
            this.tabShowMov.Controls.Add(this.lblMvId);
            this.tabShowMov.Controls.Add(this.lblMovieN);
            this.tabShowMov.Location = new System.Drawing.Point(4, 22);
            this.tabShowMov.Name = "tabShowMov";
            this.tabShowMov.Padding = new System.Windows.Forms.Padding(3);
            this.tabShowMov.Size = new System.Drawing.Size(418, 259);
            this.tabShowMov.TabIndex = 1;
            this.tabShowMov.Text = "Show Movies";
            this.tabShowMov.UseVisualStyleBackColor = true;
            this.tabShowMov.Click += new System.EventHandler(this.tabShowMov_Click);
            // 
            // tabUpdateMov
            // 
            this.tabUpdateMov.Controls.Add(this.button1);
            this.tabUpdateMov.Controls.Add(this.txtTickets);
            this.tabUpdateMov.Controls.Add(this.txtActor);
            this.tabUpdateMov.Controls.Add(this.txtMovieN);
            this.tabUpdateMov.Controls.Add(this.textBox1);
            this.tabUpdateMov.Controls.Add(this.label1);
            this.tabUpdateMov.Controls.Add(this.label2);
            this.tabUpdateMov.Controls.Add(this.label3);
            this.tabUpdateMov.Controls.Add(this.label4);
            this.tabUpdateMov.Location = new System.Drawing.Point(4, 22);
            this.tabUpdateMov.Name = "tabUpdateMov";
            this.tabUpdateMov.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdateMov.Size = new System.Drawing.Size(418, 259);
            this.tabUpdateMov.TabIndex = 2;
            this.tabUpdateMov.Text = "Update Movie";
            this.tabUpdateMov.UseVisualStyleBackColor = true;
            this.tabUpdateMov.Click += new System.EventHandler(this.tabUpdateMov_Click);
            // 
            // lblMovId
            // 
            this.lblMovId.AutoSize = true;
            this.lblMovId.Location = new System.Drawing.Point(87, 54);
            this.lblMovId.Name = "lblMovId";
            this.lblMovId.Size = new System.Drawing.Size(78, 13);
            this.lblMovId.TabIndex = 0;
            this.lblMovId.Text = "Enter Movie ID";
            // 
            // lblMovName
            // 
            this.lblMovName.AutoSize = true;
            this.lblMovName.Location = new System.Drawing.Point(87, 80);
            this.lblMovName.Name = "lblMovName";
            this.lblMovName.Size = new System.Drawing.Size(67, 13);
            this.lblMovName.TabIndex = 1;
            this.lblMovName.Text = "Movie Name";
            // 
            // lblActor
            // 
            this.lblActor.AutoSize = true;
            this.lblActor.Location = new System.Drawing.Point(87, 106);
            this.lblActor.Name = "lblActor";
            this.lblActor.Size = new System.Drawing.Size(32, 13);
            this.lblActor.TabIndex = 2;
            this.lblActor.Text = "Actor";
            this.lblActor.Click += new System.EventHandler(this.lblActor_Click);
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Location = new System.Drawing.Point(87, 137);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(66, 13);
            this.lblTickets.TabIndex = 3;
            this.lblTickets.Text = "Tickets Sold";
            // 
            // txtMovId
            // 
            this.txtMovId.Location = new System.Drawing.Point(192, 46);
            this.txtMovId.Name = "txtMovId";
            this.txtMovId.Size = new System.Drawing.Size(100, 20);
            this.txtMovId.TabIndex = 4;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(128, 191);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(192, 47);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show Movie";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblMovieN
            // 
            this.lblMovieN.AutoSize = true;
            this.lblMovieN.Location = new System.Drawing.Point(53, 74);
            this.lblMovieN.Name = "lblMovieN";
            this.lblMovieN.Size = new System.Drawing.Size(67, 13);
            this.lblMovieN.TabIndex = 0;
            this.lblMovieN.Text = "Movie Name";
            // 
            // lblMvId
            // 
            this.lblMvId.AutoSize = true;
            this.lblMvId.Location = new System.Drawing.Point(56, 42);
            this.lblMvId.Name = "lblMvId";
            this.lblMvId.Size = new System.Drawing.Size(76, 13);
            this.lblMvId.TabIndex = 1;
            this.lblMvId.Text = "Enter Movie Id";
            // 
            // txtMvId
            // 
            this.txtMvId.Location = new System.Drawing.Point(174, 42);
            this.txtMvId.Name = "txtMvId";
            this.txtMvId.Size = new System.Drawing.Size(100, 20);
            this.txtMvId.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(578, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(219, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(201, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tickets Sold";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Actor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Movie Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter Movie ID";
            // 
            // txtMovieN
            // 
            this.txtMovieN.Location = new System.Drawing.Point(201, 87);
            this.txtMovieN.Name = "txtMovieN";
            this.txtMovieN.Size = new System.Drawing.Size(100, 20);
            this.txtMovieN.TabIndex = 10;
            // 
            // txtActor
            // 
            this.txtActor.Location = new System.Drawing.Point(201, 117);
            this.txtActor.Name = "txtActor";
            this.txtActor.Size = new System.Drawing.Size(100, 20);
            this.txtActor.TabIndex = 11;
            // 
            // txtTickets
            // 
            this.txtTickets.Location = new System.Drawing.Point(201, 157);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(100, 20);
            this.txtTickets.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 47);
            this.button1.TabIndex = 13;
            this.button1.Text = "Show Movie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabMovDetails.ResumeLayout(false);
            this.tabMovDetails.PerformLayout();
            this.tabShowMov.ResumeLayout(false);
            this.tabShowMov.PerformLayout();
            this.tabUpdateMov.ResumeLayout(false);
            this.tabUpdateMov.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMovDetails;
        private System.Windows.Forms.TabPage tabShowMov;
        private System.Windows.Forms.TabPage tabUpdateMov;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtMovId;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.Label lblActor;
        private System.Windows.Forms.Label lblMovName;
        private System.Windows.Forms.Label lblMovId;
        private System.Windows.Forms.TextBox txtMvId;
        private System.Windows.Forms.Label lblMvId;
        private System.Windows.Forms.Label lblMovieN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.TextBox txtActor;
        private System.Windows.Forms.TextBox txtMovieN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

