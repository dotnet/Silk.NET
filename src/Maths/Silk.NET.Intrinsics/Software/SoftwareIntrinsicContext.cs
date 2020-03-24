// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Intrinsics.Software
{
    public struct SoftwareIntrinsicContext : IIntrinsicContext<float>
    {
        public static SoftwareIntrinsicContext Instance { get; } = new SoftwareIntrinsicContext();
        public bool IsSupported => true;
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
