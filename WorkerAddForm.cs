using Airport_v2.Entities;
using Airport_v2.Data;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airport_v2.Services;

namespace Airport_v2
{
    partial class WorkerAddForm : MaterialForm
    {
        public OtherWorker OtherWorker { get; set; }
        IOtherWorkerService _worker = new OtherWorkerService();
        public WorkerAddForm()
        {
            InitializeComponent();
        }

        private void ageBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ageBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var id = _worker.GetMaxId();
            OtherWorker = new OtherWorker
            {
                Id = id + 1,
                Firstname = firstNameBox.Text,
                Lastname = lastNameBox.Text,
                Age = ageBox.Text,
                Experience = expBox.Text,
                Position = positionComboBox.Text,
            };
            DialogResult = DialogResult.OK;
        }

        private void photoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();// создаем диалоговое окно
            openFile.ShowDialog();// открываем окно
            string FileName = openFile.FileName;// берем полный адрес картинки            
            pictureBox1.ImageLocation = FileName;// грузим картинку в pictureBox


            //FolderBrowserDialog fbd = new FolderBrowserDialog();
            //fbd.ShowDialog();
        }
    }
}
