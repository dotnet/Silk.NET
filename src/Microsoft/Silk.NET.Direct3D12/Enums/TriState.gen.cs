// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_TRI_STATE")]
    public enum TriState : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "D3D12_TRI_STATE_UNKNOWN")]
        TriStateUnknown = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [Obsolete("Deprecated in favour of \"False\"")]
        [NativeName("Name", "D3D12_TRI_STATE_FALSE")]
        TriStateFalse = 0x0,
        [Obsolete("Deprecated in favour of \"True\"")]
        [NativeName("Name", "D3D12_TRI_STATE_TRUE")]
        TriStateTrue = 0x1,
        [NativeName("Name", "D3D12_TRI_STATE_UNKNOWN")]
        Unknown = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D3D12_TRI_STATE_FALSE")]
        False = 0x0,
        [NativeName("Name", "D3D12_TRI_STATE_TRUE")]
        True = 0x1,
    }
}
