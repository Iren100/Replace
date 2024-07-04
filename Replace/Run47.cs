namespace Replace
{
    public class Run47 : Run, IRun
    {
        private int[] chisl { get; set; }

        private IRun run;

        public Run47(int[] chisl, IRun run) : base(chisl, 4, 7, "muzz", "guzz")
        {
            this.chisl = chisl;
            this.run = run;
        }

        public override string[] ActionConverter()
        {
            var s1 = run.ActionConverter();

            var s2 = base.ActionConverter();

            int c = 0;

            for (int i = 0; i < chisl.Length; i++)
            {
                if (s1[i] == s2[i])
                {
                    continue;
                }
                else if (int.TryParse(s1[i], out c) && !int.TryParse(s2[i], out c))
                {
                    s1[i] = s2[i];
                    continue;
                }
                else if (!int.TryParse(s1[i], out c) && int.TryParse(s2[i], out c))
                {
                    continue;
                }
                else
                {
                    s1[i] = s1[i] + "-" + s2[i];
                }
            }

            return s1;
        }
    }
}
