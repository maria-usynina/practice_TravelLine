using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOlympiadLib
{
    public interface IOlympiad
    {
        void add(string name, string lastname, string middlename, int score);
        void delete(string name, string lastname, string middlename);
        int maximum(int score);
        int winner(int score);
    }
}
