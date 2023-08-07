namespace _02.MarketDesktopApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            groupBox1 = new GroupBox();
            txtBarcode = new TextBox();
            groupBox2 = new GroupBox();
            dgList = new DataGridView();
            Count = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Quantitiy = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            gbPayment = new GroupBox();
            btnCash = new Button();
            btnKK = new Button();
            txtPayment = new TextBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            btnComplete = new Button();
            btnReset = new Button();
            lbRemaing = new Label();
            groupBox6 = new GroupBox();
            dgPayment = new DataGridView();
            Type = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            lbTotal = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgList).BeginInit();
            gbPayment.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPayment).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBarcode);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(945, 219);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            // 
            // txtBarcode
            // 
            txtBarcode.Font = new Font("Times New Roman", 48F, FontStyle.Regular, GraphicsUnit.Point);
            txtBarcode.Location = new Point(36, 54);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(855, 118);
            txtBarcode.TabIndex = 0;
            txtBarcode.KeyPress += txtBarcode_KeyPress;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgList);
            groupBox2.Location = new Point(12, 259);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(945, 915);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = " ";
            // 
            // dgList
            // 
            dgList.AllowUserToAddRows = false;
            dgList.BackgroundColor = SystemColors.ControlLight;
            dgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgList.Columns.AddRange(new DataGridViewColumn[] { Count, Name, Quantitiy, Price, TotalPrice });
            dgList.Location = new Point(21, 33);
            dgList.Name = "dgList";
            dgList.RowHeadersVisible = false;
            dgList.RowHeadersWidth = 62;
            dgList.RowTemplate.Height = 33;
            dgList.Size = new Size(895, 843);
            dgList.TabIndex = 0;
            // 
            // Count
            // 
            Count.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Count.HeaderText = "#";
            Count.MinimumWidth = 8;
            Count.Name = "Count";
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 8;
            Name.Name = "Name";
            Name.Width = 400;
            // 
            // Quantitiy
            // 
            Quantitiy.HeaderText = "Quantitiy";
            Quantitiy.MinimumWidth = 8;
            Quantitiy.Name = "Quantitiy";
            Quantitiy.Width = 150;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.Width = 150;
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "TotalPrice";
            TotalPrice.MinimumWidth = 8;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Width = 150;
            // 
            // gbPayment
            // 
            gbPayment.Controls.Add(btnCash);
            gbPayment.Controls.Add(btnKK);
            gbPayment.Controls.Add(txtPayment);
            gbPayment.Location = new Point(1026, 208);
            gbPayment.Margin = new Padding(3, 2, 3, 2);
            gbPayment.Name = "gbPayment";
            gbPayment.Padding = new Padding(3, 2, 3, 2);
            gbPayment.Size = new Size(683, 337);
            gbPayment.TabIndex = 2;
            gbPayment.TabStop = false;
            gbPayment.Text = " ";
            // 
            // btnCash
            // 
            btnCash.BackColor = Color.PaleGoldenrod;
            btnCash.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnCash.Image = (Image)resources.GetObject("btnCash.Image");
            btnCash.Location = new Point(359, 147);
            btnCash.Name = "btnCash";
            btnCash.Size = new Size(287, 158);
            btnCash.TabIndex = 2;
            btnCash.UseVisualStyleBackColor = false;
            btnCash.Click += btnCash_Click;
            // 
            // btnKK
            // 
            btnKK.BackColor = Color.PaleGoldenrod;
            btnKK.Font = new Font("Times New Roman", 32F, FontStyle.Regular, GraphicsUnit.Point);
            btnKK.Image = (Image)resources.GetObject("btnKK.Image");
            btnKK.Location = new Point(41, 147);
            btnKK.Name = "btnKK";
            btnKK.Size = new Size(287, 158);
            btnKK.TabIndex = 1;
            btnKK.UseVisualStyleBackColor = false;
            btnKK.Click += btnKK_Click;
            // 
            // txtPayment
            // 
            txtPayment.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            txtPayment.ForeColor = Color.ForestGreen;
            txtPayment.Location = new Point(30, 41);
            txtPayment.Name = "txtPayment";
            txtPayment.Size = new Size(628, 89);
            txtPayment.TabIndex = 0;
            txtPayment.Text = "100,25";
            txtPayment.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lbTotal);
            groupBox4.Location = new Point(1026, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(683, 172);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = " ";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnComplete);
            groupBox5.Controls.Add(btnReset);
            groupBox5.Controls.Add(lbRemaing);
            groupBox5.Location = new Point(1026, 858);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(683, 316);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = " ";
            // 
            // btnComplete
            // 
            btnComplete.BackColor = Color.DarkSeaGreen;
            btnComplete.Font = new Font("Times New Roman", 32F, FontStyle.Regular, GraphicsUnit.Point);
            btnComplete.Image = (Image)resources.GetObject("btnComplete.Image");
            btnComplete.Location = new Point(359, 140);
            btnComplete.Margin = new Padding(3, 2, 3, 2);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(287, 158);
            btnComplete.TabIndex = 3;
            btnComplete.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Salmon;
            btnReset.Font = new Font("Times New Roman", 32F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.Location = new Point(41, 140);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(287, 158);
            btnReset.TabIndex = 4;
            btnReset.UseVisualStyleBackColor = false;
            // 
            // lbRemaing
            // 
            lbRemaing.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbRemaing.ForeColor = Color.Brown;
            lbRemaing.Location = new Point(112, 26);
            lbRemaing.Name = "lbRemaing";
            lbRemaing.Size = new Size(453, 102);
            lbRemaing.TabIndex = 1;
            lbRemaing.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dgPayment);
            groupBox6.Location = new Point(1026, 566);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(683, 277);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            // 
            // dgPayment
            // 
            dgPayment.AllowUserToAddRows = false;
            dgPayment.BackgroundColor = SystemColors.ButtonFace;
            dgPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPayment.Columns.AddRange(new DataGridViewColumn[] { Type, Total });
            dgPayment.Location = new Point(30, 43);
            dgPayment.Name = "dgPayment";
            dgPayment.RowHeadersVisible = false;
            dgPayment.RowHeadersWidth = 62;
            dgPayment.RowTemplate.Height = 25;
            dgPayment.Size = new Size(628, 207);
            dgPayment.TabIndex = 2;
            // 
            // Type
            // 
            Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Type.HeaderText = "Type";
            Type.MinimumWidth = 8;
            Type.Name = "Type";
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Total.HeaderText = "Total";
            Total.MinimumWidth = 8;
            Total.Name = "Total";
            // 
            // lbTotal
            // 
            lbTotal.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotal.ForeColor = Color.Brown;
            lbTotal.Location = new Point(112, 40);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(477, 97);
            lbTotal.TabIndex = 0;
            lbTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(18F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1726, 1193);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(gbPayment);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Text = "MainForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgList).EndInit();
            gbPayment.ResumeLayout(false);
            gbPayment.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgPayment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox gbPayment;
        private GroupBox groupBox4;
        private TextBox txtBarcode;
        private DataGridView dgList;
        private GroupBox groupBox5;
        private TextBox txtPayment;
        private Label lbRemaing;
        private Button btnCash;
        private Button btnKK;
        private Button btnComplete;
        private Button btnReset;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Quantitiy;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn TotalPrice;
        private GroupBox groupBox6;
        private DataGridView dgPayment;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Total;
        private Label lbTotal;
    }
}