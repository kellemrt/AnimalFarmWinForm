using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimalFarm.Service;

namespace AnimalFarm.Pages
{
    public partial class AnimalWeightShowForm : Form
    {
        public int animalIdForWeightForm { get; set; }

        animalService animalService = new animalService();
        public AnimalWeightShowForm()
        {
            InitializeComponent();
        }
        private void AnimalWeightShowForm_Load(object sender, EventArgs e)
        {
            var weightList = animalService.GetAnimalWeightWhere(animalIdForWeightForm);
            animalWeightModelBindingSource.DataSource = weightList.OrderByDescending(u => u.AnimalWeightDate);
        }
        private void ıconbtnAnimalWeightSearch_Click(object sender, EventArgs e)
        {
            string code = tbxAnimalWeightSearch.Text;
            var animalId = animalService.GetAnimalID(code);
            if (animalId.Item1)
            {
                var searchList = animalService.GetAnimalWeightWhere(animalId.Item2);
                dataGridView1.DataSource = searchList;
            }
            else
            {
                MessageBox.Show(code + " 'nolu küpe numaralı hayvana ait ağırlık kaydı bulunamadı!!");
            }
        }
        private void materialPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
