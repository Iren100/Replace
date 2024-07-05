namespace Replace
{
    class ConcreteCreator2 : Creator
    {
        private int[] _chisl;

        public ConcreteCreator2(int[] chisl)
        {
            _chisl = chisl;
        }

        public override Product FactoryMethod() { return new ConcreteProduct2(_chisl); }
    }
}
