using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingSytem
{
    interface IBusinessRules
    {
        void generatePackingSlip();
        void createDuplicatePackingSlip();
        void activateMembership();
        void upgradeMembership();
        void addFirstAidVideo();

    }
}
