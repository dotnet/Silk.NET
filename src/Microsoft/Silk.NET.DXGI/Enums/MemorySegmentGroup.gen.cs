// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_MEMORY_SEGMENT_GROUP")]
    public enum MemorySegmentGroup : int
    {
        [NativeName("Name", "DXGI_MEMORY_SEGMENT_GROUP_LOCAL")]
        MemorySegmentGroupLocal = 0x0,
        [NativeName("Name", "DXGI_MEMORY_SEGMENT_GROUP_NON_LOCAL")]
        MemorySegmentGroupNonLocal = 0x1,
    }
}
