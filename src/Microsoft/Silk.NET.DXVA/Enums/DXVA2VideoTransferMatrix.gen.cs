// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVA2_VideoTransferMatrix")]
    public enum DXVA2VideoTransferMatrix : int
    {
        [Obsolete("Deprecated in favour of \"VideoTransferMatrixMask\"")]
        [NativeName("Name", "DXVA2_VideoTransferMatrixMask")]
        DXVA2VideoTransferMatrixMask = 0x7,
        [Obsolete("Deprecated in favour of \"VideoTransferMatrixUnknown\"")]
        [NativeName("Name", "DXVA2_VideoTransferMatrix_Unknown")]
        DXVA2VideoTransferMatrixUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"VideoTransferMatrixBT709\"")]
        [NativeName("Name", "DXVA2_VideoTransferMatrix_BT709")]
        DXVA2VideoTransferMatrixBT709 = 0x1,
        [Obsolete("Deprecated in favour of \"VideoTransferMatrixBT601\"")]
        [NativeName("Name", "DXVA2_VideoTransferMatrix_BT601")]
        DXVA2VideoTransferMatrixBT601 = 0x2,
        [Obsolete("Deprecated in favour of \"VideoTransferMatrixSmpte240M\"")]
        [NativeName("Name", "DXVA2_VideoTransferMatrix_SMPTE240M")]
        DXVA2VideoTransferMatrixSmpte240M = 0x3,
        [NativeName("Name", "DXVA2_VideoTransferMatrixMask")]
        VideoTransferMatrixMask = 0x7,
        [NativeName("Name", "DXVA2_VideoTransferMatrix_Unknown")]
        VideoTransferMatrixUnknown = 0x0,
        [NativeName("Name", "DXVA2_VideoTransferMatrix_BT709")]
        VideoTransferMatrixBT709 = 0x1,
        [NativeName("Name", "DXVA2_VideoTransferMatrix_BT601")]
        VideoTransferMatrixBT601 = 0x2,
        [NativeName("Name", "DXVA2_VideoTransferMatrix_SMPTE240M")]
        VideoTransferMatrixSmpte240M = 0x3,
    }
}
