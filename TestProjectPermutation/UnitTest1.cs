namespace TestProjectPermutation
{
    public class Tests
    {
        [Fact]
        public void TestNextPermutation_Example1()
        {
            int[] input = { 1, 2, 3 };
            int[] expected = { 1, 3, 2 };
            PermutationSolution.NextPermutation(input);
            Assert.True(input.SequenceEqual(expected));
        }

        [Fact]
        public void TestNextPermutation_Example2()
        {
            int[] input = { 3, 2, 1 };
            int[] expected = { 1, 2, 3 };
            PermutationSolution.NextPermutation(input);
            Assert.True(input.SequenceEqual(expected));
        }
    }
}