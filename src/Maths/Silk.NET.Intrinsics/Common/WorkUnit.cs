// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;

namespace Silk.NET.Intrinsics
{
    public struct WorkUnit<T> where T:unmanaged
    {
        public WorkUnitFlags Flags { get; }
        public unsafe fixed byte Padding[32];

        internal readonly void Assert(WorkUnitFlags flag)
        {
            if (!TestFor(flag))
            {
                throw new ArgumentException($"The given work unit does not have the {flag} set");
            }
        }
        internal readonly bool TestFor(WorkUnitFlags flag) => (Flags & flag) != flag;
        internal Vector128<T> As64() => Unsafe.As<WorkUnit<T>, WorkUnit128<T>>(ref this).Vector;
        internal Vector128<T> As128() => Unsafe.As<WorkUnit<T>, WorkUnit128<T>>(ref this).Vector;
        internal Vector256<T> As256() => Unsafe.As<WorkUnit<T>, WorkUnit256<T>>(ref this).Vector;

        internal static WorkUnit<T> New64(Vector64<T> value, WorkUnitFlags flags)
        {
            var unit = new WorkUnit64<T>{Flags = flags, Vector = value};
            return Unsafe.As<WorkUnit64<T>, WorkUnit<T>>(ref unit);
        }

        internal static WorkUnit<T> New128(Vector128<T> value, WorkUnitFlags flags)
        {
            var unit = new WorkUnit128<T>{Flags = flags, Vector = value};
            return Unsafe.As<WorkUnit128<T>, WorkUnit<T>>(ref unit);
        }

        internal static WorkUnit<T> New256(Vector256<T> value, WorkUnitFlags flags)
        {
            var unit = new WorkUnit256<T>{Flags = flags, Vector = value};
            return Unsafe.As<WorkUnit256<T>, WorkUnit<T>>(ref unit);
        }
    }
}
