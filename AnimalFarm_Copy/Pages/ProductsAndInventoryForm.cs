using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimalFarm.Data;
using AnimalFarm.Service;
using AnimalFarm.Services;

namespace AnimalFarm.Pages
{
    public partial class ProductsAndInventoryForm : Form
    {
        ProductsService ProductsService = new ProductsService();
        public ProductsAndInventoryForm()
        {
            InitializeComponent();
        }
        private void ProductsAndInventoryForm_Load(object sender, EventArgs e)
        {
            dataGridProducts.DataSource = ProductsService.GetProductsAndInventories();
            cmbUnit.Items.Add("KG");
            cmbUnit.Items.Add("M3");
        }
        private void btnProductInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxProduct.Text))
            {
                MessageBox.Show("Yem Adı Boş Geçilemez!");
                return;
            }
            if (string.IsNullOrEmpty(tbxQuantity.Text))
            {
                MessageBox.Show("Miktar Alanı Boş Geçilemez!");
                return;
            }
            string name = tbxProduct.Text;
            string unit = cmbUnit.Text;
            string quantity = tbxQuantity.Text;

            var list = new PRODUCT()
            {
                PRODUCTS_NAME = name,
                PRODUCTS_UNIT = unit,
                PRODUCTS_QUANTITY = int.Parse(quantity)
            };

            var returnProduct = ProductsService.InsertProductAndInventories(list);
            if (returnProduct.Item1)
            {
                MessageBox.Show(returnProduct.Item2, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridProducts.DataSource = ProductsService.GetProductsAndInventories();
                tbxProduct.Clear();
                tbxQuantity.Clear();
                cmbUnit.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Hata , Kayıt Eklenemedi!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kayıt Silinecektir.Emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                int id = Convert.ToInt32(dataGridProducts.CurrentRow.Cells[0].Value.ToString());
                var saveResult = ProductsService.DeleteProductAndInventories(id);

                if (saveResult.Item1)
                {
                    MessageBox.Show(saveResult.Item2, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridProducts.DataSource = ProductsService.GetProductsAndInventories();
                }
                else
                {
                    MessageBox.Show(saveResult.Item2, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
