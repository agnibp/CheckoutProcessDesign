using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Promotions
{
    public class ThreeAPromotion : Promotion
    {
        public ThreeAPromotion(Dictionary<char, int> CartList) : base(CartList)
        {
            _promotionTypeDesc = "3 A's for 130";
            this._cartList = CartList;
        }

        public override int calculateOrderValue()
        {
            // calculation logic
            return 0;
        }
    }
}
