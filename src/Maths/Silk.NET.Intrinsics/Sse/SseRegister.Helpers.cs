// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

namespace Silk.NET.Intrinsics.Sse
{
    public partial struct SseRegister
    {
        public static WorkUnitFlags Flags { get; } = GetFlags();
        public static WorkUnitFlags Flags128F { get; } = Flags | WorkUnitFlags.Vector128 | WorkUnitFlags.TypeFloat;
        public static WorkUnitFlags Flags256D { get; } = Flags | WorkUnitFlags.Vector256 | WorkUnitFlags.TypeDouble;
        public static WorkUnitFlags Flags128I { get; } = Flags | WorkUnitFlags.Vector128 | WorkUnitFlags.TypeInt;
        public static WorkUnitFlags Flags128Ui { get; } = Flags | WorkUnitFlags.Vector128 | WorkUnitFlags.TypeUInt;
        //TODO public static WorkUnitFlags Flags128S { get; } = Flags | WorkUnitFlags.Vector128 | WorkUnitFlags.TypeShortAsInt;
        //TODO public static WorkUnitFlags Flags128Us { get; } = Flags | WorkUnitFlags.Vector128 | WorkUnitFlags.TypeUShortAsUInt;
        //TODO public static WorkUnitFlags Flags128H { get; } = Flags | WorkUnitFlags.Vector128 | WorkUnitFlags.TypeHalfAsFloat;

        private static WorkUnitFlags GetFlags()
        {
            var flags = (WorkUnitFlags)0;
            flags |= System.Runtime.Intrinsics.X86.Sse.IsSupported ? WorkUnitFlags.RegisterSse : 0;
            flags |= System.Runtime.Intrinsics.X86.Sse.X64.IsSupported ? WorkUnitFlags.RegisterSseX64 : 0;
            flags |= Sse2.IsSupported ? WorkUnitFlags.RegisterSse2 : 0;
            flags |= Sse2.X64.IsSupported ? WorkUnitFlags.RegisterSse2X64 : 0;
            flags |= Sse3.IsSupported ? WorkUnitFlags.RegisterSse3 : 0;
            flags |= Sse41.IsSupported ? WorkUnitFlags.RegisterSse41 : 0;
            flags |= Sse41.X64.IsSupported ? WorkUnitFlags.RegisterSse41X64 : 0;
            flags |= Ssse3.IsSupported ? WorkUnitFlags.RegisterSsse3 : 0;
            flags |= WorkUnitFlags.RegisterSoftware;
            return flags;
        }
        
        private static WorkUnit<float> Convert(Vector128<float> f) => WorkUnit<float>.New128(f, Flags128F);
        private static WorkUnit<double> Convert(Vector256<double> f) => WorkUnit<double>.New256(f, Flags256D);
        private static WorkUnit<int> Convert(Vector128<int> f) => WorkUnit<int>.New128(f, Flags128I);
        private static WorkUnit<uint> Convert(Vector128<uint> f) => WorkUnit<uint>.New128(f, Flags128Ui);
    }
}
