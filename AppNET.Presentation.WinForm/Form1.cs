using AppNET.App;
using AppNET.Domain.Entities;
using AppNET.Domain.Interfaces;
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
        IProductService productService = IOCContainer.Resolve<IProductService>();
        ISalesService salesService= IOCContainer.Resolve<ISalesService>();
        
   
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
        private void FillCategoryCbb()
        {
            cbbCategory.DataSource=categoryService.GetAll(); ;
            cbbCategory.DisplayMember = nameof(Category.Name);
            cbbCategory.ValueMember=nameof(Category.Id);

        }
        private void FillUrunCbb()
        {
            cbbUrun.DataSource=productService.GetAll();
            cbbUrun.DisplayMember=nameof(Product.Name);
            cbbUrun.ValueMember=nameof(Product.Id);
        }
        private void FillVaultGrid()
        {
            grdKasa.DataSource = salesService.GetAll();
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
            FillProductGrid();
            FillCategoryCbb();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillCategoryGrid();
            FillProductGrid();
            FillCategoryCbb();
            FillVaultGrid();
            FillUrunCbb();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = gridCategory.CurrentRow.Cells["Name"].Value.ToString();
            int id = Convert.ToInt32(gridCategory.CurrentRow.Cells["Id"].Value);

            //var products = productService.GetAll().Where(x => x.CategoryId == id);
            var category = categoryService.GetAllByProducts(id);

            DialogResult result =MessageBox.Show($"{name} kategorisini silmek istediðinize emin misiniz?",
                            "Silme Onayý",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                if (category.Products.Any())
                {
                    DialogResult result1 = MessageBox.Show("Bu kategoride ürünler vardýr, Silmek istediðinize emin misiniz?", "Ürün silme", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        categoryService.Delete(id);
                        foreach (var item in category.Products)
                        {
                            productService.Delete(item.Id);
                        }
                    }
                    else
                        return;
                }
                else
                    categoryService.Delete(id);
            }
            else
                return;




            
            FillCategoryGrid();
            FillProductGrid();
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

            FillCategoryGrid();
            FillProductGrid();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        
        
        private void save_urun_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            if (save_urun.Text=="URUN KAYDET")
            {
                productService.Create(Convert.ToInt32(txtProductId.Text),
                                      txtProductName.Text,
                                      Convert.ToInt32(txtStock.Text),
                                      Convert.ToDecimal(txtPrice.Text),
                                      Convert.ToDecimal(txtBuyingPrice.Text),
                                      Convert.ToInt32(cbbCategory.SelectedValue)
                                      //DateTime.Now
                                      );
                

                
                transaction.Total = Convert.ToInt32(txtStock.Text) * Convert.ToDecimal(txtBuyingPrice.Text); ;
                transaction.Comment = $"{txtProductName.Text} ürününden {txtStock.Text} satýn alindi";
                transaction.TransactionDate = DateTime.Now;

                salesService.Create(0, gelir: null, transaction);
                Temizle();
            }
            else
            {
                //productService.Update(Convert.ToInt32(txtProductId.Text),
                //                  txtProductName.Text,
                //                  Convert.ToInt32(txtStock.Text),
                //                  Convert.ToDecimal(txtPrice.Text),
                //                  Convert.ToInt32(txtCtgryId.Text),
                //                  Convert.ToDateTime(grdProduct.CurrentRow.Cells["CreatedDate"].Value)
                //                  //DateTime.Now
                //                  ); 
                
                int id = Convert.ToInt32(txtProductId.Text);
                Product newProduct = productService.GetAll().FirstOrDefault(x=>x.Id==id);
                newProduct.Name = txtProductName.Text;
                newProduct.SalePrice = Convert.ToDecimal(txtPrice.Text);
                newProduct.Stock = Convert.ToInt32(txtStock.Text);
                newProduct.BuyingPrice = Convert.ToDecimal(txtBuyingPrice.Text);
                newProduct.CategoryId = Convert.ToInt32(cbbCategory.SelectedValue);
                productService.Update(Convert.ToInt32(txtProductId.Text), newProduct);

                txtProductId.Enabled = true;
                save_urun.Text = "URUN KAYDET";
                groupBox2.Text = "Yeni Ürün";


                Temizle();
            }
            FillProductGrid();
            FillVaultGrid();
            FillUrunCbb();
        }
        private void Temizle()
        {
            txtProductId.Text = "";
            txtProductName.Text = "";
            txtStock.Text = "";
            txtPrice.Text = "";
            txtBuyingPrice.Text = "";
            cbbCategory.SelectedIndex= 0;
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
            txtProductId.Text = grdProduct.CurrentRow.Cells[nameof(Product.Id)].Value.ToString();
            txtProductName.Text = grdProduct.CurrentRow.Cells["Name"].Value.ToString();
            txtPrice.Text = grdProduct.CurrentRow.Cells[nameof(Product.SalePrice)].Value.ToString();
            txtBuyingPrice.Text = grdProduct.CurrentRow.Cells[nameof(Product.BuyingPrice)].Value.ToString();
            txtStock.Text = grdProduct.CurrentRow.Cells["Stock"].Value.ToString();
            txtBuyingPrice.Text = grdProduct.CurrentRow.Cells["CategoryId"].Value.ToString();
            cbbCategory.SelectedValue = Convert.ToInt32(grdProduct.CurrentRow.Cells[nameof(Product.CategoryId)].Value);

            txtProductId.Enabled = false;
            save_urun.Text = "Güncelle";
            groupBox2.Text = "Ürün Güncelle";
            FillProductGrid();
        }

        private void txtCtgryId_TextChanged(object sender, EventArgs e)
        {

        }

        private void grdKasa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void satis_yap_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            int id= Convert.ToInt32(cbbUrun.SelectedValue);
            Product product= productService.GetById(id);



            if (txtAdet.Text == "")
            {
                MessageBox.Show("Yapýlacak Satýþ adedi giriniz:", "Dikkat", MessageBoxButtons.OK);
                return;

            }
            else if (Convert.ToInt32(txtAdet.Text) > product.Stock)
            {
                MessageBox.Show($"En fazla {product.Stock} adet ürün satýlabilir ");
                return;
            }
            else
            {
                transaction.Total = Convert.ToInt32(txtAdet.Text) * product.SalePrice;
                transaction.Comment = $"{product.Name} ürününden {txtAdet.Text} ürün satýldý";
                transaction.TransactionDate = DateTime.Now;
                product.Stock = product.Stock - Convert.ToInt32(txtAdet.Text);
                productService.Update(product.Id, product);
                salesService.Create(0, transaction, null);
            }
            FillVaultGrid();
            FillProductGrid();
            
        }
    }
}