﻿namespace ESFA.DC.KeyGenerator.Interface
{
    public interface IKeyGenerator
    {
        string GenerateKey(long ukPrn, long jobId, TaskKeys task, string separator = @"/");
    }
}
