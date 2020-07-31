using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mexoft_site.Models
{
    public class TestClass : AbCls
    {
        public override int multiply2Numbers(int a, int b)
        {
            return a * b;
        }

        public override string funky()
        {
            return base.funky() + " show.......";
        }
    }

    public abstract class AbCls
    {
        public int Add2Numbers(int a, int b)
        {
            return a + b;
        }

        public abstract int multiply2Numbers(int a, int b);

        public virtual string funky()
        {
            return "funky";
        }
    }
}
