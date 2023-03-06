using AppNET.App;
using AppNET.Domain.Entities;
using AppNET.Infrastructure;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace AppNET.Presentation.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var tip = typeof(Category);
            //label1.Text=tip.FullName;
            //IOC containera 4 farklý þey kaydetmiþ olduk


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // var data = IOCContainer.Resolve("bir");
            var data = IOCContainer.Resolve<ICategoryService>();
            label1.Text = data.ToString();
        }


        ICategoryService categoryService = IOCContainer.Resolve<ICategoryService>();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void FillCategoryGrid()
        {
            gridCategory.DataSource = categoryService.GetAll();
        }

        private void FillProductGrid()
        {
            grdProduct.DataSource = productService.GetAll();
        }
        private void Kaydet_Click(object sender, EventArgs e)
        {
            if (Kaydet.Text=="KAYDET")
            {
                int id = Convert.ToInt32(txtCategoryId.Text);
                categoryService.Create(id, txtCategoryName.Text);

            }
            else
            {
                categoryService.Update(Convert.ToInt32(txtCategoryId.Text), txtCategoryName.Text);
                Kaydet.Text = "KAYDET";
                groupBox1.Text = "Yeni Kategori";
                txtCategoryId.Enabled = true;
            }
            FillCategoryGrid();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillCategoryGrid();
            FillProductGrid();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = gridCategory.CurrentRow.Cells["Name"].Value.ToString();
            DialogResult result=MessageBox.Show($"{name} kategorisini silmek istediðinize emin misiniz?",
                            "Silme Onayý",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            int id = Convert.ToInt32(gridCategory.CurrentRow.Cells["Id"].Value);
            
            categoryService.Delete(id);
            FillCategoryGrid();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = gridCategory.CurrentRow.Cells["Id"].Value.ToString();
            string categoryName = gridCategory.CurrentRow.Cells["Name"].Value.ToString();
            txtCategoryId.Text = id;
            txtCategoryName.Text = categoryName;

            txtCategoryId.Enabled = false;
            Kaydet.Text = "Güncelle";
            groupBox1.Text = "Kategori Güncelle";

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        IProductService productService= IOCContainer.Resolve<IProductService>();
        
        private void save_urun_Click(object sender, EventArgs e)
        {
            if (save_urun.Text=="URUN KAYDET")
            {
                productService.Create(Convert.ToInt32(txtProductId.Text),
                                      txtProductName.Text,
                                      Convert.ToInt32(txtStock.Text),
                                      Convert.ToDecimal(txtPrice.Text),
                                      Convert.ToInt32(txtCtgryId.Text),
                                      DateTime.Now
                                      );
                Temizle();
            }
            else
            {
                productService.Update(Convert.ToInt32(txtProductId.Text),
                                  txtProductName.Text,
                                  Convert.ToInt32(txtStock.Text),
                                  Convert.ToDecimal(txtPrice.Text),
                                  Convert.ToInt32(txtCtgryId.Text),
                                  Convert.ToDateTime(grdProduct.CurrentRow.Cells["CreatedDate"].Value),
                                  DateTime.Now); 
                txtProductId.Enabled = true;
                save_urun.Text = "URUN KAYDET";
                groupBox2.Text = "Yeni Ürün";

                Temizle();
            }
            FillProductGrid();
        }
        private void Temizle()
        {
            txtProductId.Text = "";
            txtProductName.Text = "";
            txtStock.Text = "";
            txtPrice.Text = "";
            txtCtgryId.Text = "";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string name = grdProduct.CurrentRow.Cells["Name"].Value.ToString();
            DialogResult result= MessageBox.Show($"{Name} adlý ürünü silmek istediðinizden emin misiniz", "Ürün Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            int id = Convert.ToInt32(grdProduct.CurrentRow.Cells["Id"].Value);
            productService.Delete(id);
            FillProductGrid();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(txtProductId.Text);
            //string name=txtProductName.Text;
            //decimal price=Convert.ToDecimal(txtPrice.Text);
            //int stok = Convert.ToInt32(txtStock.Text);
            //int ctgry_id = Convert.ToInt32(txtCtgryId.Text);

            string id = grdProduct.CurrentRow.Cells["Id"].Value.ToString();
            string name = grdProduct.CurrentRow.Cells["Name"].Value.ToString();
            string price = grdProduct.CurrentRow.Cells["Price"].Value.ToString();
            string stok = grdProduct.CurrentRow.Cells["Stock"].Value.ToString();
            string ctgry_id = grdProduct.CurrentRow.Cells["CategoryId"].Value.ToString();

            txtProductId.Text = id;
            txtProductName.Text=name;
            txtPrice.Text = price;
            txtStock.Text = stok;
            txtCtgryId.Text = ctgry_id;

            txtProductId.Enabled = false;
            save_urun.Text = "Güncelle";
            groupBox2.Text = "Ürün Güncelle";
        }
    }
}