// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
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
