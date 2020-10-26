using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zelenin
{
    public class GenCard
    {
        string name;
        char gender;
        int age;
        PictureBox photo;
        string relation;

        public GenCard(string name, char gender, int age, PictureBox photo)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.photo = photo;
        }

        public void relationShips(int layer)
        {
            switch (layer)
            {
                case 1:
                    if (gender == 'М')
                    {
                        relation = "Сын";
                    }
                    else
                    {
                        relation = "Дочь";
                    };
                    break;
                case 2:
                    if (gender == 'М')
                    {
                        relation = "Отец";
                    }
                    else
                    {
                        relation = "Мать";
                    };
                    break;
                case 3:
                    if (gender == 'М')
                    {
                        relation = "Дедушка";
                    }
                    else
                    {
                        relation = "Бабушка";
                    };
                    break;
                default:
                    if (gender == 'М')
                    {
                        relation = "дедушка";
                        for (int i = layer; i > 3; i--)
                        {
                            if (i == 4)
                            {
                                relation = "Пра" + relation;
                            }
                            else
                            {
                                relation = "пра" + relation;
                            }
                        };
                    }
                    else
                    {
                        relation = "бабушка";
                        for (int i = layer; i > 3; i--)
                        {
                            if (i == 4)
                            {
                                relation = "Пра" + relation;
                            }
                            else
                            {
                                relation = "пра" + relation;
                            }
                        };
                    };
                    break;
            }
        }
    }
}
