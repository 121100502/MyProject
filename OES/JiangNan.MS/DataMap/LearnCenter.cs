using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JiangNan.MS.DataMap
{
    [Serializable]
    public class LearnCenter
    {
        public int LearnCenterId { get; set; }
        public string CenterName { get; set; }
        public LearnCenter()
        {
        }

        public LearnCenter(int id, string centerName)
        {
            LearnCenterId = id;
            CenterName = centerName;
        }

    }
}
