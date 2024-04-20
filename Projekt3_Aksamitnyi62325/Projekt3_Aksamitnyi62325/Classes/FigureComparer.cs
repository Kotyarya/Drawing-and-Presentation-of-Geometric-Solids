using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3_Aksamitnyi62325.Classes
{
    public class FigureComparer : IComparer<Figure>
    {


        bool isASC;
        string SortBy;

        public FigureComparer(bool isASC = true, string sortBy = "Volume")
        {
            this.isASC = isASC;
            SortBy = sortBy;
        }
        public int Compare(Figure x, Figure y)
        {
            int propX;
            int propY;

            switch (SortBy)
            {
                case "Width":
                    propX = x.width;
                    propY = y.width;
                    break;
                case "Height":
                    propX = x.height;
                    propY = y.height;
                    break;
                case "Volume":
                    propX = x.volume;
                    propY = y.volume;
                    break;
                case "Surface Area":
                    propX = x.surfaceArea;
                    propY = y.surfaceArea;
                    break;
                case "ID":
                    propX = x.ID;
                    propY = y.ID;   
                    break;
                default:
                    propX = x.width;
                    propY = y.width;
                    break;
            }

            if (propX > propY)
            {
                return isASC ? 1 : -1;
            }
            else if (propX < propY)
            {
                return isASC ? -1 : 1;
            } else
            {
                return 0;
            }
        }
    }
}
