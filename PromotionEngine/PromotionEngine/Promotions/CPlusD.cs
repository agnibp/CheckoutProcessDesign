using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Promotions
{
    public class CPlusD : Promotion
    {
        public CPlusD(Dictionary<char, int> CartList) : base(CartList)
        {
            _promotionTypeDesc = "1 C plus 1 D for 30";
            this._cartList = CartList;
        }

        public override int calculateOrderValue()
        {
            return 0;
        }
    }
}
