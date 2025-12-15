// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_PROTECTED_SESSION_STATUS")]
    public enum ProtectedSessionStatus : int
    {
        [Obsolete("Deprecated in favour of \"OK\"")]
        [NativeName("Name", "D3D12_PROTECTED_SESSION_STATUS_OK")]
        ProtectedSessionStatusOK = 0x0,
        [Obsolete("Deprecated in favour of \"Invalid\"")]
        [NativeName("Name", "D3D12_PROTECTED_SESSION_STATUS_INVALID")]
        ProtectedSessionStatusInvalid = 0x1,
        [NativeName("Name", "D3D12_PROTECTED_SESSION_STATUS_OK")]
        OK = 0x0,
        [NativeName("Name", "D3D12_PROTECTED_SESSION_STATUS_INVALID")]
        Invalid = 0x1,
    }
}
