using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheduleEditor_Amina
{
    class Cabinets
    {
        public int Number { get; set; }
        public int AComputer { get; set; }
        public bool Board { get; set; }
        public int CountOfSeats { get; set; }
        public int CountOfTables { get; set; }
        public bool Projector { get; set; }
        public Cabinets(int number, int aComputer, bool board, int countOfSeats, int countOfTables, bool projector)
        {
            Number = number;
            AComputer = aComputer;
            Board = board;
            CountOfSeats = countOfSeats;
            CountOfTables = countOfTables;
            Projector = projector;
        }
        public override string ToString()
        {
            return Number + " кабинет:" + " кoмпьютеров: " + AComputer + ", доска: " + Board
                + ", посадочные места: " + CountOfSeats + ", кол-во парт: " + CountOfTables +
                ", проектор: " + Projector;
        }
    }
}
