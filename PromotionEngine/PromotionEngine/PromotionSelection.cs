using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromotionEngine.Promotions;

namespace PromotionEngine
{
    public class PromotionSelection
    {
        private int _totalOrderValue;
        private List<char> _cartList;
        private Dictionary<char, int> _cartListModified; // stores the cart items along with respective counts

        public PromotionSelection(List<char> CartList)
        {
            this._totalOrderValue = 0;
            this._cartList = CartList;
        }

        private void arrangeCart()
        {
            _cartListModified = new Dictionary<char, int>();

            foreach(char ch in _cartList)
            {
                if (_cartListModified.ContainsKey(ch))
                    _cartListModified[ch]++;
                else
                    _cartListModified[ch] = 1;
            }
        }

        private int calculateOrderValueWithoutPromotions()
        {
            int orderValue = 0;
            // calculation logic on "_cartListModified" depending upon the price
            return orderValue;
        }

        public int selectPromotionType(Promotion objProm)
        {
            // considered only one promotion is applied at a time on full orders.
            // can also be applied for all promotions at a time, tweaking the if..else and calculation logic

            if(_cartListModified.ContainsKey('A'))
            {
                if(_cartListModified['A'] >= 3)
                {
                    objProm = new ThreeAPromotion(_cartListModified);
                    _totalOrderValue = objProm.calculateOrderValue();
                }
            }
            else if (_cartListModified.ContainsKey('B'))
            {
                if (_cartListModified['B'] >= 2)
                {
                    objProm = new TwoBPromotion(_cartListModified);
                    _totalOrderValue = objProm.calculateOrderValue();
                }
            }
            else if (_cartListModified.ContainsKey('C') && _cartListModified.ContainsKey('D'))
            {
                if (_cartListModified['C'] > 0 && _cartListModified['D'] > 0)
                {
                    objProm = new CPlusD(_cartListModified);
                    _totalOrderValue = objProm.calculateOrderValue();
                }
            }
            else
                _totalOrderValue = calculateOrderValueWithoutPromotions(); // when no promotion applied

            return _totalOrderValue;
        }
    }
}
