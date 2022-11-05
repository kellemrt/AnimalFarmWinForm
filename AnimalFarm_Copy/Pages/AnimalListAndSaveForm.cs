using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimalFarm.Service;
using AnimalFarm.Data;
using AnimalFarm.Pages;

namespace AnimalFarm
{
    public partial class AnimalListAndSaveForm : Form
    {
        animalService animalService = new animalService();
        public AnimalListAndSaveForm()
        {
            InitializeComponent();
        }
        private void AnimalListAndSaveForm_Load(object sender, EventArgs e)
        {
            animalListModelBindingSource.DataSource = animalService.GetAnimalList();
        }
        private void AnimalListAndSaveForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ContinantalForm cnt = new ContinantalForm();
            //cnt.Show();
        }
        private void dataGridAnimalList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var datagridId = dataGridAnimalList.CurrentRow.Cells[0].Value?.ToString();
            tbxAnimalCode.Text = dataGridAnimalList.CurrentRow.Cells[1].Value?.ToString();
            tbxAnimalKind.Text = dataGridAnimalList.CurrentRow.Cells[2].Value?.ToString();
            tbxAniamalNote.Text = dataGridAnimalList.CurrentRow.Cells[3].Value?.ToString();
        }
        private void btnInsert1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxAnimalWeight.Text))
            {
                MessageBox.Show("Hayvan ağırlığı boş geçilemez!");
                return;
            }
            string animalCode = tbxAnimalCode.Text;
            string animalKind = tbxAnimalKind.Text;

            bool IsNumeric(string p)
            {
                foreach (char c in p)
                {
                    if (char.IsNumber(c) == false)
                        return false;
                }
                return true;
            }
            if (!IsNumeric(tbxAnimalWeight.Text))
            {
                MessageBox.Show("Hayvanın ağırlığı sayı değeri olmalı!!");
                return;
            }
            decimal animalWeight = Convert.ToDecimal(tbxAnimalWeight.Text);
            string animalNote = tbxAniamalNote.Text;
            if (string.IsNullOrEmpty(animalCode))
            {
                MessageBox.Show("Küpe kodu boş geçilemez!");
                return;
            }
            else
            {
                var anlist = new ANIMAL_LIST()
                {
                    ANIMAL_CODE = animalCode,
                    ANIMAL_KIND = animalKind,
                    ANIMAL_NOTE = animalNote,
                    ANIMAL_SAVEDATE = System.DateTime.Now,

                };
                var saveResult = animalService.InsertAnimalList(anlist);
                if (saveResult.Item1)
                {
                    {
                        int animalID = saveResult.Item2;
                        var anbehave = new ANIMAL_WEIGHT_BEHAVE()
                        {
                            ANIMAL_ID = animalID,
                            ANIMAL_WEIGHT = animalWeight,
                            ANIMAL_WEIGHT_DATE = System.DateTime.Now,
                        };
                        var saveResultBehave = animalService.InsertAnimalBehave(anbehave);
                        if (saveResultBehave.Item1)
                        {
                            MessageBox.Show("Kayıt Eklendi.");
                            dataGridAnimalList.DataSource = animalService.GetAnimalList();
                            tbxAniamalNote.Text = "";
                            tbxAnimalCode.Text = "";
                            tbxAnimalKind.Text = "";
                            tbxAnimalWeight.Text = "";
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Hata-Kayıt Eklenemedi!!!!");
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hata-Kayıt Eklenemedi!!!!");
                    return;
                }
            }

        }
        private void btnUpdate1_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrEmpty(tbxAnimalWeight.Text))
            {
                MessageBox.Show("Hayvan ağırlığı boş geçilemez!");
                return;
            }
            string animalCode = tbxAnimalCode.Text;
            string animalKind = tbxAnimalKind.Text;

            bool IsNumeric(string p)
            {
                foreach (char c in p)
                {
                    if (char.IsNumber(c) == false)
                        return false;
                }
                return true;
            }
            if (!IsNumeric(tbxAnimalWeight.Text))
            {
                MessageBox.Show("Hayvanın ağırlığı sayı değeri olmalı!!");
                return;
            }
            decimal animalWeight = Convert.ToDecimal(tbxAnimalWeight.Text);
            string animalNote = tbxAniamalNote.Text;
            if (string.IsNullOrEmpty(animalCode))
            {
                MessageBox.Show("Küpe kodu boş geçilemez!");
                return;
            }
            else
            {
                int id = animalService.GetAnimalID(animalCode).Item2;
                var anlist = new ANIMAL_LIST()
                {
                    ANIMAL_ID = id,
                    ANIMAL_CODE = animalCode,
                    ANIMAL_KIND = animalKind,
                    ANIMAL_NOTE = animalNote,
                    ANIMAL_SAVEDATE = System.DateTime.Now,

                };
                var saveResult = animalService.UpdateAnimalList(anlist);
                if (saveResult)
                {

                    var anbehave = new ANIMAL_WEIGHT_BEHAVE()
                    {
                        ANIMAL_ID = id,
                        ANIMAL_WEIGHT = animalWeight,
                        ANIMAL_WEIGHT_DATE = System.DateTime.Now,
                    };
                    var saveResultBehave = animalService.InsertAnimalBehave(anbehave);
                    if (saveResultBehave.Item1)
                    {
                        MessageBox.Show("Kayıt Güncellendi.");
                        dataGridAnimalList.DataSource = animalService.GetAnimalList();
                        tbxAniamalNote.Text = "";
                        tbxAnimalCode.Text = "";
                        tbxAnimalKind.Text = "";
                        tbxAnimalWeight.Text = "";
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Hata-Kayıt Güncellenemedi!!!!");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Hata-Kayıt Güncellenemedi!!!!");
                    return;
                }
            }
        }
        private void btnDelete1_Click(object sender, EventArgs e)

        {
            DialogResult dialogResult = MessageBox.Show("Kayıt Silinecektir.Emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                int id = Convert.ToInt32(dataGridAnimalList.CurrentRow.Cells[0].Value.ToString());
                var saveResult = animalService.DeleteAnimalList(id);

                if (saveResult)
                {
                    var saveResultBehave = animalService.DeleteAnimalBehave(id);
                    if (saveResultBehave.Item1)
                    {
                        MessageBox.Show(saveResultBehave.Item2);
                        dataGridAnimalList.DataSource = animalService.GetAnimalList();
                        return;
                    }
                    else
                    {
                        MessageBox.Show(saveResultBehave.Item2);
                        dataGridAnimalList.DataSource = animalService.GetAnimalList();
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Hata-Kayıt silinemedi!!!!!");
                    return;
                }
            }
        }
        private void btnWeightShow_Click_1(object sender, EventArgs e)

        {
            int count = dataGridAnimalList.RowCount;
            if (count > 0)
            {
                int animalId = Convert.ToInt32(dataGridAnimalList.CurrentRow.Cells[0].Value);
                AnimalWeightShowForm showForm = new AnimalWeightShowForm();
                showForm.animalIdForWeightForm = animalId;
                showForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Listede Kayıt yok!!");
            }
        }
    }
}
