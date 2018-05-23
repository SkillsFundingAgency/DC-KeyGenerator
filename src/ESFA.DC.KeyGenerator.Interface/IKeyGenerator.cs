namespace ESFA.DC.KeyGenerator.Interface
{
    public interface IKeyGenerator
    {
        string GenerateKey(int ukPrn, int jobId, TaskKeys task, string separator = @"/");
    }
}
