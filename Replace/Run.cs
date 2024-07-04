namespace Replace
{
    public abstract class Run : IRun
    {
        private int[] chisl { get; set; }
        private int x { get; set; }
        private int y { get; set; }
        private string rep1 { get; set; }
        private string rep2 { get; set; }

        protected Run(int[] chisl, int x, int y, string rep1, string rep2)
        {
            this.chisl = chisl;
            this.x = x;
            this.y = y;
            this.rep1 = rep1;
            this.rep2 = rep2;
        }

        public virtual string[] ActionConverter()
        {
            return Action(chisl, x, y, rep1, rep2);
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
