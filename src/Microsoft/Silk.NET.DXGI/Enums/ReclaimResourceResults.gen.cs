// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [Flags]
    [NativeName("Name", "_DXGI_RECLAIM_RESOURCE_RESULTS")]
    public enum ReclaimResourceResults : int
    {
        [NativeName("Name", "DXGI_RECLAIM_RESOURCE_RESULT_OK")]
        ReclaimResourceResultOK = 0x0,
        [NativeName("Name", "DXGI_RECLAIM_RESOURCE_RESULT_DISCARDED")]
        ReclaimResourceResultDiscarded = 0x1,
        [NativeName("Name", "DXGI_RECLAIM_RESOURCE_RESULT_NOT_COMMITTED")]
        ReclaimResourceResultNotCommitted = 0x2,
    }
}
