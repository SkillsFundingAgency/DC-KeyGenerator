using ESFA.DC.KeyGenerator.Interface;

namespace ESFA.DC.KeyGenerator
{
    public sealed class KeyGenerator : IKeyGenerator
    {
        public string GenerateKey(long ukPrn, long jobId, TaskKeys task, string separator = "/")
        {
            return $"{ukPrn}{separator}{jobId}{separator}{task}";
        }
    }
}
