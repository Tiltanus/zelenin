using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zelenin
{
    public partial class Form1 : Form
    {
        int layerCounter=0; //количество "слоёв"
        List<GenCard> cards = new List<GenCard>(); //динамический массив с карточками личностей

        public Form1()
        {
            InitializeComponent();
        }
        


        private void addLayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 load_form = new Form2(); //загружаем форму
            load_form.ShowDialog(); //показываем форму
            GenCard gencard = new GenCard(load_form.CardName, load_form.CardGender, load_form.CardAge, load_form.CardPhoto); //создаём карточку личности
            layerCounter++; //увеличиваем счётчик "слоёв"
            gencard.relationShips(layerCounter); //вычисляем степень родства
            cards.Add(gencard); //добавляем карточку в список            
        }
    }
}
