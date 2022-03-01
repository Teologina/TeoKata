using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2_Inheritance
{
    internal class RadissonMember: Member, IRadissonMember
    {
        public override string[] Benefits { get; set; }

        public new void RandomInit()
        {
            base.RandomInit();

            Benefits = "R: Free Drinks, R: Free Parking, R: Free Roomservice, R: Late Checkout".Split(',');

            if (Level == MemberLevel.Platinum)
            {
                Benefits = "R: Free Drinks".Split(',');
            }
            if (Level == MemberLevel.Gold)
            {
                Benefits = "R: Free Parking".Split(',');
            }
            if (Level == MemberLevel.Silver)
            {
                Benefits = "R: Free Roomservice".Split(',');
            }
            if (Level == MemberLevel.Blue)
            {
                Benefits = "R: Late Checkout".Split(',');
            }
        }
        internal static class Factory
        {
            internal static IMember CreateWithRandomData()
            {
                var member = new RadissonMember();
                member.RandomInit();
                return member;
            }
        }
    }
}
