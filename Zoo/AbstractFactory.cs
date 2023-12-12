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