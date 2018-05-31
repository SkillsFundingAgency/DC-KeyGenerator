using ESFA.DC.KeyGenerator.Interface;

namespace ESFA.DC.KeyGenerator
{
    public sealed class KeyGenerator : IKeyGenerator
    {
        private const string Separator = "_";

        public string GenerateKey(long ukPrn, long jobId, TaskKeys task)
        {
            return $"{ukPrn}{Separator}{jobId}{Separator}{task}";
        }
    }
}
