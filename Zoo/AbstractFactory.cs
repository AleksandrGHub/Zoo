using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    abstract class AbstractFactory
    {
        public abstract Lion CreateLion();
        public abstract Bear CreateBear();
        public abstract Horse CreateHorse();
        public abstract Tiger CreateTiger();
        public abstract Elephant CreateElephant();
    }
}