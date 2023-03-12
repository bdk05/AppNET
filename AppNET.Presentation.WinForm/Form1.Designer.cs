namespace AppNET.Presentation.WinForm
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Kaydet = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridCategory = new System.Windows.Forms.DataGridView();
            this.ctxgrdCategoryMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.save_urun = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuyingPrice = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.grdProduct = new System.Windows.Forms.DataGridView();
            this.ctxgrdProductMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.satis_yap = new System.Windows.Forms.Button();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.cbbUrun = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grdKasa = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategory)).BeginInit();
            this.ctxgrdCategoryMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            this.ctxgrdProductMenu.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKasa)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cozumle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Kaydet);
            this.groupBox1.Controls.Add(this.txtCategoryName);
            this.groupBox1.Controls.Add(this.txtCategoryId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 197);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kategori";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Kaydet
            // 
            this.Kaydet.Location = new System.Drawing.Point(253, 130);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(75, 23);
            this.Kaydet.TabIndex = 4;
            this.Kaydet.Text = "KAYDET";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(94, 79);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(234, 23);
            this.txtCategoryName.TabIndex = 3;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(94, 32);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(234, 23);
            this.txtCategoryId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id";
            // 
            // gridCategory
            // 
            this.gridCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategory.ContextMenuStrip = this.ctxgrdCategoryMenu;
            this.gridCategory.Location = new System.Drawing.Point(12, 322);
            this.gridCategory.Name = "gridCategory";
            this.gridCategory.RowHeadersVisible = false;
            this.gridCategory.RowTemplate.Height = 25;
            this.gridCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCategory.Size = new System.Drawing.Size(359, 323);
            this.gridCategory.TabIndex = 4;
            // 
            // ctxgrdCategoryMenu
            // 
            this.ctxgrdCategoryMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.düzenleToolStripMenuItem});
            this.ctxgrdCategoryMenu.Name = "ctxgrdCategoryMenu";
            this.ctxgrdCategoryMenu.Size = new System.Drawing.Size(117, 48);
            this.ctxgrdCategoryMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbbCategory);
            this.groupBox2.Controls.Add(this.save_urun);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBuyingPrice);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.txtStock);
            this.groupBox2.Controls.Add(this.txtProductName);
            this.groupBox2.Controls.Add(this.txtProductId);
            this.groupBox2.Location = new System.Drawing.Point(431, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 294);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Ürün";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Category";
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(83, 226);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(216, 23);
            this.cbbCategory.TabIndex = 11;
            // 
            // save_urun
            // 
            this.save_urun.Location = new System.Drawing.Point(246, 258);
            this.save_urun.Name = "save_urun";
            this.save_urun.Size = new System.Drawing.Size(112, 23);
            this.save_urun.TabIndex = 10;
            this.save_urun.Text = "URUN KAYDET";
            this.save_urun.UseVisualStyleBackColor = true;
            this.save_urun.Click += new System.EventHandler(this.save_urun_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "BuyingPrice";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Id";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtBuyingPrice
            // 
            this.txtBuyingPrice.Location = new System.Drawing.Point(83, 197);
            this.txtBuyingPrice.Name = "txtBuyingPrice";
            this.txtBuyingPrice.Size = new System.Drawing.Size(216, 23);
            this.txtBuyingPrice.TabIndex = 4;
            this.txtBuyingPrice.TextChanged += new System.EventHandler(this.txtCtgryId_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(83, 157);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(216, 23);
            this.txtPrice.TabIndex = 3;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(83, 121);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(216, 23);
            this.txtStock.TabIndex = 2;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(83, 84);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(216, 23);
            this.txtProductName.TabIndex = 1;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(83, 40);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(216, 23);
            this.txtProductId.TabIndex = 0;
            // 
            // grdProduct
            // 
            this.grdProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProduct.ContextMenuStrip = this.ctxgrdProductMenu;
            this.grdProduct.Location = new System.Drawing.Point(383, 322);
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.RowHeadersVisible = false;
            this.grdProduct.RowTemplate.Height = 25;
            this.grdProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProduct.Size = new System.Drawing.Size(468, 323);
            this.grdProduct.TabIndex = 6;
            // 
            // ctxgrdProductMenu
            // 
            this.ctxgrdProductMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem1,
            this.güncelleToolStripMenuItem});
            this.ctxgrdProductMenu.Name = "ctxgrdProductMenu";
            this.ctxgrdProductMenu.Size = new System.Drawing.Size(121, 48);
            // 
            // silToolStripMenuItem1
            // 
            this.silToolStripMenuItem1.Name = "silToolStripMenuItem1";
            this.silToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.silToolStripMenuItem1.Text = "Sil";
            this.silToolStripMenuItem1.Click += new System.EventHandler(this.silToolStripMenuItem1_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.satis_yap);
            this.groupBox3.Controls.Add(this.txtAdet);
            this.groupBox3.Controls.Add(this.cbbUrun);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(832, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 237);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // satis_yap
            // 
            this.satis_yap.Location = new System.Drawing.Point(258, 163);
            this.satis_yap.Name = "satis_yap";
            this.satis_yap.Size = new System.Drawing.Size(109, 38);
            this.satis_yap.TabIndex = 4;
            this.satis_yap.Text = "SATIŞ YAP";
            this.satis_yap.UseVisualStyleBackColor = true;
            this.satis_yap.Click += new System.EventHandler(this.satis_yap_Click);
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(96, 80);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(189, 23);
            this.txtAdet.TabIndex = 3;
            // 
            // cbbUrun
            // 
            this.cbbUrun.FormattingEnabled = true;
            this.cbbUrun.Location = new System.Drawing.Point(97, 33);
            this.cbbUrun.Name = "cbbUrun";
            this.cbbUrun.Size = new System.Drawing.Size(188, 23);
            this.cbbUrun.TabIndex = 2;
            this.cbbUrun.SelectedIndexChanged += new System.EventHandler(this.cbbUrun_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Satıs Adedi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Satılacak Ürün";
            // 
            // grdKasa
            // 
            this.grdKasa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdKasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdKasa.Location = new System.Drawing.Point(857, 280);
            this.grdKasa.Name = "grdKasa";
            this.grdKasa.RowHeadersVisible = false;
            this.grdKasa.RowTemplate.Height = 25;
            this.grdKasa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdKasa.Size = new System.Drawing.Size(376, 261);
            this.grdKasa.TabIndex = 8;
            this.grdKasa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdKasa_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 762);
            this.Controls.Add(this.grdKasa);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grdProduct);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gridCategory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategory)).EndInit();
            this.ctxgrdCategoryMenu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            this.ctxgrdProductMenu.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKasa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private GroupBox groupBox1;
        private Button Kaydet;
        private TextBox txtCategoryName;
        private TextBox txtCategoryId;
        private Label label3;
        private Label label2;
        private DataGridView gridCategory;
        private ContextMenuStrip ctxgrdCategoryMenu;
        private ToolStripMenuItem silToolStripMenuItem;
        private ToolStripMenuItem düzenleToolStripMenuItem;
        private GroupBox groupBox2;
        private TextBox txtBuyingPrice;
        private TextBox txtPrice;
        private TextBox txtStock;
        private TextBox txtProductName;
        private TextBox txtProductId;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private Button save_urun;
        private DataGridView grdProduct;
        private ContextMenuStrip ctxgrdProductMenu;
        private ToolStripMenuItem silToolStripMenuItem1;
        private ToolStripMenuItem güncelleToolStripMenuItem;
        private ComboBox cbbCategory;
        private Label label9;
        private GroupBox groupBox3;
        private DataGridView grdKasa;
        private Button satis_yap;
        private TextBox txtAdet;
        private ComboBox cbbUrun;
        private Label label11;
        private Label label10;
    }
}