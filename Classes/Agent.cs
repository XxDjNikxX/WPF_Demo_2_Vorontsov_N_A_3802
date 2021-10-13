using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Demo_1_Vorontsov_N_A_3802
{
    partial class Agent
    {
        public string EmptyStringToLogo
        {
            get
            {
                if (string.IsNullOrEmpty(Logo) || string.IsNullOrWhiteSpace(Logo))
                {
                    return @"\img\picture.png";
                }
                else return Logo;
            }
        }
    }
}
