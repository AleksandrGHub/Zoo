using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class FemaleFactory : AbstractFactory
    {
        public override Lion CreateLion()
        {
            return new FemaleLion();
        }

        public override Bear CreateBear()
        {
            return new FemaleBear();
        }

        public override Horse CreateHorse()
        {
            return new FemaleHorse();
        }

        public override Tiger CreateTiger()
        {
            return new FemaleTiger();
        }

        public override Elephant CreateElephant()
        {
            return new FemaleElephant();
        }
    }
}