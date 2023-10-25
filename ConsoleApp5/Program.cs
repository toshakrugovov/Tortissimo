using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Threading.Tasks;

namespace Tortiki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int position;
            UUU tortiki = new UUU();
            List<Tort> forma = new List<Tort>();
            Tort kvardrat = new Tort("Квадрат, цена - ", 500);
            forma.Add(kvardrat);
            Tort zvezda = new Tort("Звезда, цена - ", 800);
            forma.Add(zvezda);
            Tort oval = new Tort("Овал, цена - ", 454);
            forma.Add(oval);

            List<Tort> ves = new List<Tort>();
            Tort onekg = new Tort("1 кг, цена -", 1000);
            ves.Add(onekg);
            Tort fivekg = new Tort("5 кг, цена -", 2100);
            ves.Add(fivekg);
            Tort tenkg = new Tort("10 кг, цена -", 4000);
            ves.Add(tenkg);

            List<Tort> nach = new List<Tort>();
            Tort med = new Tort("Медовая, цена -", 1400);
            nach.Add(med);
            Tort muss = new Tort("Муссовая, цена -", 1450);
            nach.Add(muss);
            Tort oreo = new Tort("OREO USA, цена -", 2500);
            nach.Add(oreo);

            List<Tort> colvo = new List<Tort>();
            Tort tenkus = new Tort("10 кусочков, цена-", 450);
            colvo.Add(tenkus);
            Tort twentykus = new Tort("20 кусочков, цена-", 800);
            colvo.Add(twentykus);
            Tort thirtykus = new Tort("30 кусочков, цена-", 1000);
            colvo.Add(thirtykus);

            List<Tort> glaz = new List<Tort>();
            Tort shoc = new Tort("Шоколадная глазурь, цена-", 250);
            glaz.Add(shoc);
            Tort bel = new Tort("Белая глазурь, цена-", 150);
            glaz.Add(bel);
            Tort karamel = new Tort("Карамельная глазурь, цена-", 500);
            glaz.Add(karamel);



            do
            {
                position = tortiki.Menu();
                if (position == 3)
                {
                    tortiki.Dop(forma);

                }
                else if (position == 4)
                {
                    tortiki.Dop(ves);

                }
                else if (position == 5)
                {
                    tortiki.Dop(nach);

                }
                else if (position == 6)
                {
                    tortiki.Dop(colvo);

                }
                else if (position == 7)
                {
                    tortiki.Dop(glaz);

                }

            } while (true);








        }
    }
}