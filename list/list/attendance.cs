using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class attendance
    {
        int tardies=0;
        int absent=0;

        public void markTardy(string username) //adds 1 to the students tardy count
        {
            tardies++;
        }
        public void markAbsent(string username) //adds 1 to the students absent count
        {
            absent++;
        }
        public int GetTardyCount(string username)  //returns number of times student was tardy
        {
            return tardies;
        }
        public int getAbsentCount(String username) //returns number of times student was absent
        {
            return absent;
        }
    }
}
