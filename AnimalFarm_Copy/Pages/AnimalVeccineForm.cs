using AnimalFarm.Data;
using AnimalFarm.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalFarm.Pages
{
    public partial class AnimalVeccineForm : Form
    {
        VeccineService VeccineService = new VeccineService();
        public AnimalVeccineForm()
        {
            InitializeComponent();
        }
        private void AnimalVeccineForm_Load(object sender, EventArgs e)
        {
            animalVeccineListModelBindingSource.DataSource = VeccineService.GetAnimalVeccineList().OrderBy(x => x.VeccineDate);
            var list = VeccineService.GetAnimalList().Select(x => x.AnimalCode).AsEnumerable();
            foreach (var item in list)
            {
                cmbAnimalCode.Items.Add(item);
            }
        }
        private void btnVeccineSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbAnimalCode.Text))
            {
                MessageBox.Show("Küpe kodu Seçiniz!!");
                return;
            }
            string code = cmbAnimalCode.Text;
            DateTime date = monthCalendarVeccine.SelectionStart;
            string kind = tbxVeccineKind.Text;
            var animalId = VeccineService.GetAnimalID(code);

            var veccineList = new ANIMAL_VECCINE()
            {
                VECCINE_ANIMAL_ID = animalId.Item2,
                VECCINE_DATE = date,
                VECCINE_KIND = kind,
            };
            var saveresult = VeccineService.InsertAnimalVeccineList(veccineList);
            if (saveresult.Item1)
            {
                MessageBox.Show(saveresult.Item2);
                animalVeccineListModelBindingSource.DataSource = VeccineService.GetAnimalVeccineList();
            }
            else
            {
                MessageBox.Show("Hata,Kayıt Eklenemedi!", "Hata");
            }
        }
        private void btnVeccineDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kayıt Silinecektir.Emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                int delete = Convert.ToInt32(dataGridAnimalVeccine.CurrentRow.Cells[0].Value);
                bool deleteResult = VeccineService.DeleteAnimalVeccine(delete);
                if (deleteResult)
                {
                    MessageBox.Show("Kayıt Silindi.");
                    animalVeccineListModelBindingSource.DataSource = VeccineService.GetAnimalVeccineList().OrderBy(x => x.VeccineDate);
                    return;
                }
                else
                {
                    MessageBox.Show("Hata!Kayıt Silinemedi.", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }

            }
            else
            {
                return;
            }

        }
    }
}
