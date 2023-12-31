using Xunit;
using Moq;
using TestPermutacionesCubanEngenier.Services;
using TestPermutacionesCubanEngenier.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;

namespace TestProjectPermutationNext
{    
    public class UnitTest1
    {
        [Fact]
        public void Test_FindNextPermutation_ValidInput1()
        {
            // Arrange
            var serviceProvider = new ServiceCollection()
                .AddMemoryCache()
                .BuildServiceProvider();

            var memoryCache = serviceProvider.GetService<IMemoryCache>();
            IPermutationService permutationService = new PermutationService(memoryCache);
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
            var serviceProvider = new ServiceCollection()
                .AddMemoryCache()
                .BuildServiceProvider();

            var memoryCache = serviceProvider.GetService<IMemoryCache>();
            IPermutationService permutationService = new PermutationService(memoryCache);
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
            var serviceProvider = new ServiceCollection()
                .AddMemoryCache()
                .BuildServiceProvider();

            var memoryCache = serviceProvider.GetService<IMemoryCache>();
            IPermutationService permutationService = new PermutationService(memoryCache);
            List<int> input = new List<int> { 1, 1, 5 };

            // Act
            List<int> result = permutationService.NextPermutation(input);

            // Assert
            List<int> expected = new List<int> { 1, 5, 1 };
            Assert.Equal(expected, result);
        }
    }
}