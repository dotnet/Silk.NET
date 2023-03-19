// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "_DXGI_RECLAIM_RESOURCE_RESULTS")]
    public enum ReclaimResourceResults : int
    {
        [Obsolete("Deprecated in favour of \"OK\"")]
        [NativeName("Name", "DXGI_RECLAIM_RESOURCE_RESULT_OK")]
        ReclaimResourceResultOK = 0x0,
        [Obsolete("Deprecated in favour of \"Discarded\"")]
        [NativeName("Name", "DXGI_RECLAIM_RESOURCE_RESULT_DISCARDED")]
        ReclaimResourceResultDiscarded = 0x1,
        [Obsolete("Deprecated in favour of \"NotCommitted\"")]
        [NativeName("Name", "DXGI_RECLAIM_RESOURCE_RESULT_NOT_COMMITTED")]
        ReclaimResourceResultNotCommitted = 0x2,
        [NativeName("Name", "DXGI_RECLAIM_RESOURCE_RESULT_OK")]
        OK = 0x0,
        [NativeName("Name", "DXGI_RECLAIM_RESOURCE_RESULT_DISCARDED")]
        Discarded = 0x1,
        [NativeName("Name", "DXGI_RECLAIM_RESOURCE_RESULT_NOT_COMMITTED")]
        NotCommitted = 0x2,
    }
}
