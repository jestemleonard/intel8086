using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Intel8086
{
    class methods
    {
        //wartosci rejestrów
        public static int SelectedOperation = -1;
        public static int SelectedFirstRegister = -1;
        public static int SelectedSecondRegister = -1;
        public static ushort AX = 0x2B67; //11111
        public static ushort BX = 0x56CE; //22222
        public static ushort CX = 0x8235; //33333
        public static ushort DX = 0xAD9C; //44444

        /// <summary>
        /// Zwraca wskaznik do rejestru
        /// </summary>
        /// <param name="register"></param>
        /// <returns></returns>
        public static ref ushort GetPointer(int register)
        {
            switch (register)
            {
                case 0:
                    return ref AX;
                case 1:
                    return ref BX;
                case 2:
                    return ref CX;
                case 3:
                    return ref DX;
                default:
                    MessageBox.Show("Proszę wybrać rejestr");
                    return ref AX;
            }
        }

        /// <summary>
        /// Kopiuje pierwszy rejestr w miejsce drugiego
        /// </summary>
        public static void MOV()
        {
            GetPointer(SelectedSecondRegister) = GetPointer(SelectedFirstRegister);
        }
        /// <summary>
        /// Zmienia wartości pierwszego i drugiego rejestru
        /// </summary>
        public static void SWAP()
        {
            ushort c = GetPointer(SelectedFirstRegister);
            GetPointer(SelectedFirstRegister) = GetPointer(SelectedSecondRegister);
            GetPointer(SelectedSecondRegister) = c;
        }
        /// <summary>
        /// Dodaje do pierwszego rejestru wartosc drugiego rejestru
        /// </summary>
        public static void ADD()
        {
            GetPointer(SelectedFirstRegister) += GetPointer(SelectedSecondRegister);
        }
        /// <summary>
        /// Odejmuje od pierwszego rejestru wartosc drugiego rejestru
        /// </summary>
        public static void SUB()
        {
            GetPointer(SelectedFirstRegister) -= GetPointer(SelectedSecondRegister);
        }
    }
}
