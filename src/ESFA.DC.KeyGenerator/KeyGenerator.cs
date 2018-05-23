using ESFA.DC.KeyGenerator.Interface;

namespace ESFA.DC.KeyGenerator
{
    public sealed class KeyGenerator : IKeyGenerator
    {
        public string GenerateKey(int ukPrn, int jobId, TaskKeys task, string separator = "/")
        {
            return $"{ukPrn}{separator}{jobId}{separator}{task}";
        }
    }
}
