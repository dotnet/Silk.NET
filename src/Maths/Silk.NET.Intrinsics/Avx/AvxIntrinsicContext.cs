// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Intrinsics.Avx
{
    public struct AvxIntrinsicContext : IIntrinsicContext<float>
    {
        public static AvxIntrinsicContext Instance { get; } = new AvxIntrinsicContext();
        public bool IsSupported => System.Runtime.Intrinsics.X86.Avx.IsSupported;
        public unsafe IWorkUnit<float> LoadScalar(float* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe IWorkUnit<float> LoadVector2(float* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe IWorkUnit<float> LoadVector3(float* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe IWorkUnit<float> LoadVector4(float* ptr)
        {
            throw new System.NotImplementedException();
        }
    }
}
