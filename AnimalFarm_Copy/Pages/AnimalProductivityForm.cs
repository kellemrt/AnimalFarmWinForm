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
using AnimalFarm.Data;

namespace AnimalFarm.Pages
{
    
    public partial class AnimalProductivityForm : Form
    {
        animalService animalService=new animalService();    
        public AnimalProductivityForm()
        {
            InitializeComponent();
        }

        private void AnimalProductivityForm_Load(object sender, EventArgs e)
        {
            dataAnimalProductivity.DataSource = animalService.GetAnimalProductivities(); 
        }

        private void AnimalProductivityForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ContinantalForm cnt = new ContinantalForm();
            //cnt.Show();
            //this.Hide();
        }
    }
}
