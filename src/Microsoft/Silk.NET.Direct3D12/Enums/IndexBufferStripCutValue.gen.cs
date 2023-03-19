// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_INDEX_BUFFER_STRIP_CUT_VALUE")]
    public enum IndexBufferStripCutValue : int
    {
        [Obsolete("Deprecated in favour of \"ValueDisabled\"")]
        [NativeName("Name", "D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_DISABLED")]
        IndexBufferStripCutValueDisabled = 0x0,
        [Obsolete("Deprecated in favour of \"Value0xFfff\"")]
        [NativeName("Name", "D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_0xFFFF")]
        IndexBufferStripCutValue0xFfff = 0x1,
        [Obsolete("Deprecated in favour of \"Value0xFfffffff\"")]
        [NativeName("Name", "D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_0xFFFFFFFF")]
        IndexBufferStripCutValue0xFfffffff = 0x2,
        [NativeName("Name", "D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_DISABLED")]
        ValueDisabled = 0x0,
        [NativeName("Name", "D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_0xFFFF")]
        Value0xFfff = 0x1,
        [NativeName("Name", "D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_0xFFFFFFFF")]
        Value0xFfffffff = 0x2,
    }
}
