using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ContosoContext())
            {
                var p = db.People;
                Person myRoomMate = new Person();
                myRoomMate.FirstName = "Yaozi";
                myRoomMate.LastName = "HuShuoBaDao";
            }
        }
    }
}
