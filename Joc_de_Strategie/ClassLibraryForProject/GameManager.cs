using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





//this class will be responsibale for ussing all the clases and get all the parameters needed for runnig the match


namespace ClassLibraryForProject
{
    public class GameManager
    {

        protected static int PlayerNumber = 0;
        protected static int MapNumber = 0;
        protected static int Savefile = 0;
        protected static int LoadOrNew = 0;//0 new game 1,2,3 load game from file 1, 2 or 3
        GameManager()
        {
            LoadOrNew = 1 + 0;
        }



    }
}
