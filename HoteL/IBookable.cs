using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoteL
{
    public interface IBookable
    {
        void Reserve();
        void Cancel();
        void ShowEmptyRooms();
    }
}
