using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2_Inheritance
{
    internal class HiltonMember : Member, IHiltonMember
    {
        public override string[] Benefits { get; set; }

        public new void RandomInit()
        {
            base.RandomInit();

            Benefits = "H: Free Drinks, H: Free Parking, H: Free Roomservice, H: Late Checkout".Split(',');

            if (Level == MemberLevel.Platinum)
            {
                Benefits = "H: Free Drinks".Split(',');
            }
            if (Level == MemberLevel.Gold)
            {
                Benefits = "H: Free Parking".Split(',');
            }
            if (Level == MemberLevel.Silver)
            {
                Benefits = "H: Free Roomservice".Split(',');
            }
            if (Level == MemberLevel.Blue)
            {
                Benefits = "H: Late Checkout".Split(',');
            }
        }
        internal static class Factory
        {
            internal static IMember CreateWithRandomData()
            {
                var member = new HiltonMember();
                member.RandomInit();
                return member;
            }
        }
    }
}
