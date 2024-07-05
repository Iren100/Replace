namespace Replace
{
    public class ConcreteProduct1: Product
    {
        private int[] _chisl;

        public ConcreteProduct1(int[] chisl)
        {
            _chisl = chisl;
        }

        public override string[] Znach
        {
            get => new Run47(_chisl, new Run35(_chisl)).ActionConverter();
        }
    }
}
