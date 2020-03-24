// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Runtime.Intrinsics.Arm;

namespace Silk.NET.Intrinsics.Arm
{
    public struct ArmIntrinsicContext : IIntrinsicContext<float>
    {
        public static ArmIntrinsicContext Instance { get; } = new ArmIntrinsicContext();
        public bool IsSupported => AdvSimd.Arm64.IsSupported;
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
