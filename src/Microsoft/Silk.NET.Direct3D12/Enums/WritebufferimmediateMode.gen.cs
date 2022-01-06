// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_WRITEBUFFERIMMEDIATE_MODE")]
    public enum WritebufferimmediateMode : int
    {
        [NativeName("Name", "D3D12_WRITEBUFFERIMMEDIATE_MODE_DEFAULT")]
        WritebufferimmediateModeDefault = 0x0,
        [NativeName("Name", "D3D12_WRITEBUFFERIMMEDIATE_MODE_MARKER_IN")]
        WritebufferimmediateModeMarkerIn = 0x1,
        [NativeName("Name", "D3D12_WRITEBUFFERIMMEDIATE_MODE_MARKER_OUT")]
        WritebufferimmediateModeMarkerOut = 0x2,
    }
}
