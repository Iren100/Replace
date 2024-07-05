namespace Replace
{
    public class ConcreteProduct2: Product
    {
        private int[] _chisl;

        public ConcreteProduct2(int[] chisl)
        {
            _chisl = chisl;
        }

        public override string[] Znach
        {
            get => new Run47new(_chisl, new Run35new(_chisl)).ActionConverter();
        }
    }
}
