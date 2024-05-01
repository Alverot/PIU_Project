using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForProject
{
    public class MapGenerator
    {
        private int size;//poate o sa fac si optiunea sa creezi 3 feluri de harti( 10/10 ,20/20,30/30)

        private Tile[,] MAP = new Tile[10,10];

        public MapGenerator(int size=10)
        {
            this.size = size;
            int[] rndm = new int[size*10];
            rndm = RandomGeneratorForMultipleUses.RandomArrayGenerator(size*10);
            int k = 0;
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    MAP[i,j] = new Tile(rndm[k],k);
                    k++;
                }
            }
        }
        public void SetTyle(int i, int j,int t, int s, int l, int p, int an,int ao)
        {
            
            MAP[i, j].TerrainType = t;
            MAP[i,j].SettlementType = s;
            MAP[i, j].SettlementLevel = l;
            MAP[i, j].PlayerControl = p;
            MAP[i, j].ArmyNumber = an;
            MAP[i, j].ArmyOwner = ao;

        }
        public void SetTylePlayer(int i, int j, int p)
        {
            MAP[i, j].PlayerControl = p;
        }

        public string PrintMAP()
        {
            string mapp = String.Format("MAP : \n");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mapp = mapp + MAP[i,j].PrintTile();
                }
                mapp = mapp + String.Format("\n__________________________________________" +
                    "_____________________________________\n");
            }
            return mapp;
        }
        public string ConvertMAPForSave()
        {
            string mapp = String.Format("{0}\n",size);
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mapp = mapp + MAP[i, j].PrintTile();
                }
                mapp = mapp + String.Format("\n");
            }
            return mapp;
        }
        public string SearchAndReturn(int player) 
        {
            string st = String.Format("Playerul {0} detine teritoriile cu coordonatele:",player);
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (MAP[i, j].PlayerControl == player)
                    {
                        st = st + String.Format("{0} {1} ,",i,j);
                    }
                }
            }
            return st;
        }
    }
}
