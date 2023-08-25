using Xunit;
using Moq;
using TestPermutacionesCubanEngenier.Services;
using TestPermutacionesCubanEngenier.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace TestProjectPermutationNext
{    
    public class UnitTest1
    {
        [Fact]
        public void Test_FindNextPermutation_ValidInput1()
        {
            // Arrange
            IPermutationService permutationService = new PermutationService();
            List<int> input = new List<int> { 1, 2, 3 };

            // Act
            List<int> result = permutationService.NextPermutation(input);

            // Assert
            List<int> expected = new List<int> { 1, 3, 2 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_FindNextPermutation_ValidInput2()
        {
            // Arrange
            IPermutationService permutationService = new PermutationService();
            List<int> input = new List<int> { 3, 2, 1 };

            // Act
            List<int> result = permutationService.NextPermutation(input);

            // Assert
            List<int> expected = new List<int> { 1, 2, 3 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_FindNextPermutation_ValidInput3()
        {
            // Arrange
            IPermutationService permutationService = new PermutationService();
            List<int> input = new List<int> { 1, 1, 5 };

            // Act
            List<int> result = permutationService.NextPermutation(input);

            // Assert
            List<int> expected = new List<int> { 1, 5, 1 };
            Assert.Equal(expected, result);
        }
    }
}