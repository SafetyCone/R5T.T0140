using System;

using R5T.F0000;


namespace R5T.T0140.Z001
{
    public static class Instances
    {
        public static ITypeOperations TypeOperations { get; } = Z001.TypeOperations.Instance;
        public static ITypeOperator TypeOperator { get; } = F0000.TypeOperator.Instance;
    }
}