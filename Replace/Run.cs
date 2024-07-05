namespace Replace
{
    public abstract class Run : IRun
    {
        private int[] _chisl;
        private int _x;
        private int _y;
        private string _rep1;
        private string _rep2;

        protected Run(int[] chisl, int x, int y, string rep1, string rep2)
        {
            _chisl = chisl;
            _x = x;
            _y = y;
            _rep1 = rep1;
            _rep2 = rep2;
        }

        public virtual string[] ActionConverter()
        {
            return Action(_chisl, _x, _y, _rep1, _rep2);
        }

        private string[] Action(int[] chisl, int x, int y, string rep1, string rep2)
        {
            var arr = new String[chisl.Length];

            for (int i = 0; i < chisl.Length; i++)
            {
                arr[i] = chisl[i].ToString();

                if (chisl[i] % x == 0)
                {
                    arr[i] = rep1;
                }
                if (chisl[i] % y == 0)
                {
                    arr[i] = rep2;
                }
                if ((chisl[i] % x == 0) && (chisl[i] % y == 0))
                {
                    arr[i] = String.Join("-", rep1, rep2);
                }
            }

            return arr;
        }
    }
}
