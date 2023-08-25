using Microsoft.Extensions.Caching.Memory;
using TestPermutacionesCubanEngenier.Services;

namespace TestPermutacionesCubanEngenier.Services
{
    public class PermutationService : IPermutationService
    {

        private readonly IMemoryCache _memoryCache;

        public PermutationService(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public List<int> NextPermutation(List<int> numbers)
        {
            // Try to get result from cache
            string cacheKey = GetCacheKey(numbers);
            if (_memoryCache.TryGetValue(cacheKey, out List<int> cachedResult))
            {
                return cachedResult;
            }

            // Calculate next permutation
            List<int> nextPermutation = CalculateNextPermutation(numbers);

            // Store result in cache
            _memoryCache.Set(cacheKey, nextPermutation, TimeSpan.FromMinutes(10));

            return nextPermutation;
        }

        private string GetCacheKey(List<int> numbers)
        {
            return "Permutation_" + string.Join("_", numbers);
        }

        private List<int> CalculateNextPermutation(List<int> numbers)
        {
            // Your existing permutation logic here
            int i = numbers.Count - 2;
            while (i >= 0 && numbers[i] >= numbers[i + 1])
            {
                i--;
            }

            if (i >= 0)
            {
                int j = numbers.Count - 1;
                while (numbers[j] <= numbers[i])
                {
                    j--;
                }
                Swap(numbers, i, j);
            }

            Reverse(numbers, i + 1);
            // ...

            return numbers;
        }

        private void Swap(List<int> numbers, int i, int j)
        {
            int temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }

        private void Reverse(List<int> numbers, int start)
        {
            int i = start;
            int j = numbers.Count - 1;
            while (i < j)
            {
                Swap(numbers, i, j);
                i++;
                j--;
            }
        }



    }
            
    
}

