using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableManagementPos
{
    enum enStatus{Free = 0 , Occupied = 1 , Reserved = 2};
    internal class clsTable
    {
        int _TableNumber;
        int _NumberOfSeats;
        enStatus _Status;

        public clsTable()
        {
            _TableNumber = 0;
            _NumberOfSeats = 4;
            _Status = enStatus.Free;
        }

        public clsTable(int TableNumber , int NumberOfSeats , enStatus Status)
        {
            _TableNumber = TableNumber;
            _NumberOfSeats = NumberOfSeats;
            _Status = Status;
        }




    }
}
