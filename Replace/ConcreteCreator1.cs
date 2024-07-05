namespace Replace
{
    class ConcreteCreator1 : Creator
    {
        private int[] _chisl;

        public ConcreteCreator1(int[] chisl)
        {
            _chisl = chisl;
        }

        public override Product FactoryMethod() { return new ConcreteProduct1(_chisl); }
    }
}
