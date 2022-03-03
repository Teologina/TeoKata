using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2_Inheritance
{
    internal class ScandicMember: Member, IScandicMember
    {
        public override string[] Benefits { get; set; }

        public new void RandomInit()
        {
            base.RandomInit();

            Benefits = "S: Free Drinks, S: Free Parking, S: Free Roomservice, S: Late Checkout".Split(',');

            if (Level == MemberLevel.Platinum)
            {
                Benefits = "S: Free Drinks".Split(',');
            }
            if (Level == MemberLevel.Gold)
            {
                Benefits = "S: Free Parking".Split(',');
            }
            if (Level == MemberLevel.Silver)
            {
                Benefits = "S: Free Roomservice".Split(',');
            }
            if (Level == MemberLevel.Blue)
            {
                Benefits = "S: Late Checkout".Split(',');
            }
        }
        internal static class Factory
        {
            internal static IMember CreateWithRandomData()
            {
                var member = new ScandicMember();
                member.RandomInit();
                return member;
            }
        }
    }
}
