namespace Replace
{
    public class Run47new : Run47, IRun
    {
        private const string RemoveFrom = "dog-cat";

        private const string RemoveTo = "good-boy";

        public Run47new(int[] chisl, IRun run) : base(chisl, run) { }

        public override string[] ActionConverter()
        {
            var s1 = base.ActionConverter();

            string[] s2 = new string[s1.Length];

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i].Contains(RemoveFrom))
                {
                    s2[i] = s1[i].Replace(RemoveFrom, RemoveTo);
                    continue;
                }

                s2[i] = s1[i];
            }

            return s2;
        }
    }
}
