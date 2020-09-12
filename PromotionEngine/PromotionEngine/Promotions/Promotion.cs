using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Promotions
{
    public abstract class Promotion
    {
        protected string _promotionTypeDesc;
        protected Dictionary<char, int> _cartList;

        protected Promotion(Dictionary<char, int> CartList)
        {}

        public abstract int calculateOrderValue();
    }
}
