// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_WRITEBUFFERIMMEDIATE_MODE")]
    public enum WritebufferimmediateMode
    {
        [NativeName("Name", "D3D12_WRITEBUFFERIMMEDIATE_MODE_DEFAULT")]
        WritebufferimmediateModeDefault = 0x0,
        [NativeName("Name", "D3D12_WRITEBUFFERIMMEDIATE_MODE_MARKER_IN")]
        WritebufferimmediateModeMarkerIn = 0x1,
        [NativeName("Name", "D3D12_WRITEBUFFERIMMEDIATE_MODE_MARKER_OUT")]
        WritebufferimmediateModeMarkerOut = 0x2,
    }
}
