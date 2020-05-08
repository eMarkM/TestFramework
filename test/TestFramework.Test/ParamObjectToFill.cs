namespace TestFramework.Test
{
    class ParamObjectToFill
    {
        public ParamObjectToFill(string test, string notTest)
        {
            Test = test;
            NotTest = notTest;
        }

        public string Test { get; }

        public string NotTest { get; }
    }

}
