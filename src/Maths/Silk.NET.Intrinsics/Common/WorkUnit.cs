// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Intrinsics
{
    public struct WorkUnit<T> where T:unmanaged
    {
        public WorkUnitFlags Flags { get; set; }
    }
}
