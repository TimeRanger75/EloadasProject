using System;

namespace EloadasProject
{
    public class Eloadas
    {
        bool[,] foglalasok;

        public Eloadas(int sorokSzama, int helyekSzama)
        {

            if (sorokSzama < 1 || helyekSzama < 1)
            {
                throw new ArgumentException("Érvénytelen érték");
            }
            foglalasok = new bool[sorokSzama, helyekSzama];
        }

        public bool lefoglal()
        {
            for (int i = 1; i < foglalasok.GetLength(0); i++)
            {
                for (int j = 1; j < foglalasok.GetLength(1); j++)
                {
                    if (foglalasok[i, j] == false)
                    {
                        foglalasok[i, j] = true;
                        return true;
                    }
                }
            }
            return false;
            //return foglalasok[0, 0];
        }

        public int SzabadHelyek()
        {
            int szabadHelyek = 0;
            for (int i = 1; i < foglalasok.GetLength(0); i++)
            {
                for (int j = 1; j < foglalasok.GetLength(1); j++)
                {
                    if (foglalasok[i, j] == false)
                    {
                        szabadHelyek++;
                    }
                }
            }
            return szabadHelyek;
        }


        public bool Teli()
        {
            if (SzabadHelyek() == 0)
            {
                return true;
            }
            return false;
        }

        public bool Foglalt(int sorSzam, int helySzam)
        {
            if (sorSzam > foglalasok.GetLength(0) && helySzam > foglalasok.GetLength(1) || sorSzam < 0 || helySzam < 0)
            {
                throw new ArgumentException("Érvénytelen érték");
            }

            if (foglalasok[sorSzam, helySzam] == true)
            {
                return true;
            }
            return false;
        }
    }
}
