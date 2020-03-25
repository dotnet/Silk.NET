// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Runtime.Intrinsics;

namespace Silk.NET.Intrinsics.Software
{
    public struct SoftwareIntrinsicContext : IIntrinsicContext<float>
    {
        public static SoftwareIntrinsicContext Instance { get; } = new SoftwareIntrinsicContext();
        public bool IsSupported => true;
        public unsafe IWorkUnit<float> LoadScalar(float* ptr) => new SoftwareWorkUnit128F(Vector128.CreateScalar(*ptr));

        public unsafe IWorkUnit<float> LoadVector2(float* ptr)
            => new SoftwareWorkUnit128F(Vector128.Create(ptr[0], ptr[1], 0f, 0f));

        public unsafe IWorkUnit<float> LoadVector3(float* ptr)
            => new SoftwareWorkUnit128F(Vector128.Create(ptr[0], ptr[1], ptr[2], 0f));

        public unsafe IWorkUnit<float> LoadVector4(float* ptr)
            => new SoftwareWorkUnit128F(Vector128.Create(ptr[0], ptr[1], ptr[2], ptr[3]));
    }
}
