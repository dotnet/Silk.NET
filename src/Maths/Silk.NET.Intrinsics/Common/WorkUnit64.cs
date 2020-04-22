// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Runtime.Intrinsics;

namespace Silk.NET.Intrinsics
{
    internal struct WorkUnit64<T> where T:unmanaged
    {
        public WorkUnitFlags Flags { get; set; }
        public Vector64<T> Vector { get; set; }
        public unsafe fixed byte Padding[24];
    }
}
