using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingSytem
{
    public class BusinessRules : IBusinessRules
    {
        public void generatePackingSlip()
        {
            // generate packing slip.
            Console.WriteLine("Packing slip generated successfully.");
            CommonUtility.generateCommissionToAgent();
        }

        public void createDuplicatePackingSlip()
        {
            // generate duplicate packing slip.
            Console.WriteLine("Duplicate Packing slip generated successfully.");
            CommonUtility.generateCommissionToAgent();
        }

        public void activateMembership()
        {
            // activate membership.
            Console.WriteLine("Membership activated successfully.");
            CommonUtility.sendEmail();
        }

        public void upgradeMembership()
        {
            // upgrade membership.
            Console.WriteLine("Membership upgraded successfully.");
            CommonUtility.sendEmail();
        }

        public void addFirstAidVideo()
        {
            // generate video.
            Console.WriteLine("First Aid Video generated successfully.");
        }
    }
}
