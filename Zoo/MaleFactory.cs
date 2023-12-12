namespace Zoo
{
    class MaleFactory : AbstractFactory
    {
        public override Lion CreateLion()
        {
            return new MaleLion();
        }

        public override Bear CreateBear()
        {
            return new MaleBear();
        }

        public override Horse CreateHorse()
        {
            return new MaleHorse();
        }

        public override Tiger CreateTiger()
        {
            return new MaleTiger();
        }

        public override Elephant CreateElephant()
        {
            return new MaleElephant();
        }
    }
}