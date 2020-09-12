using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Promotions
{
    public class TwoBPromotion : Promotion
    {
        public TwoBPromotion(Dictionary<char, int> CartList) : base(CartList)
        {
            _promotionTypeDesc = "2 B's for 45";
            this._cartList = CartList;
        }

        public override int calculateOrderValue()
        {
            return 0;
        }
    }
}
