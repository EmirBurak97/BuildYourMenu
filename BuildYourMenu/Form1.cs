using BuildYourMenu.Business.Abstract;
using BuildYourMenu.Business.DependencyResolvers.Ninject;
using BuildYourMenu.Entities.ComplexTypes;
using BuildYourMenu.Entities.Concrete;

namespace BuildYourMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private IProductService _productService;
        private ICategoryService _categoryService;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadProducts()
        {          
            dgwProducts.DataSource = _productService.GetProductDetails();
            dgwProducts.Columns[0].HeaderText = "ID";
            dgwProducts.Columns[1].HeaderText = "Ürün Adý";
            dgwProducts.Columns[2].HeaderText = "Ürün Kategorisi";
            dgwProducts.Columns[3].HeaderText = "Ürün Fiyatý";
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxAddCategory.DataSource = _categoryService.GetAll();
            cbxAddCategory.DisplayMember = "CategoryName";
            cbxAddCategory.ValueMember = "CategoryId";

            cbxUpdateCategory.DataSource = _categoryService.GetAll();
            cbxUpdateCategory.DisplayMember = "CategoryName";
            cbxUpdateCategory.ValueMember = "CategoryId";
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProducts.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch (Exception)
            {

            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProducts.DataSource = _productService.GetProductsByName(tbxProductName.Text);
            }
            catch (Exception)
            {

            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbxAddCategory.SelectedValue),
                    ProductName = tbxAddProductName.Text,
                    UnitPrice = Convert.ToDecimal(tbxAddUnitPrice.Text),
                });
                MessageBox.Show("Ürün Kaydedildi.");
                LoadProducts();
            }
            catch (Exception)
            {


            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                    CategoryId = Convert.ToInt32(cbxUpdateCategory.SelectedValue),
                    ProductName = tbxUpdateProductName.Text,
                    UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text),
                });
                MessageBox.Show("Ürün Güncellendi.");
                LoadProducts();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProducts.CurrentRow;
            tbxUpdateProductName.Text = row.Cells[2].Value.ToString();
            cbxUpdateCategory.SelectedValue = row.Cells[1].Value;
            tbxUpdateUnitPrice.Text = row.Cells[3].Value.ToString();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgwProducts.CurrentRow!=null)
            {
                _productService.Delete(new Product
                {
                    ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
                });
                MessageBox.Show("Ürün Silindi.");
                LoadProducts();
            }
        }
    }
}