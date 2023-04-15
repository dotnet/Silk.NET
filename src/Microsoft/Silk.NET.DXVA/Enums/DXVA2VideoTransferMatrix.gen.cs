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
        [Obsolete("Deprecated in favour of \"Mask\"")]
        [NativeName("Name", "DXVA2_VideoTransferMatrixMask")]
        DXVA2VideoTransferMatrixMask = 0x7,
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "DXVA2_VideoTransferMatrix_Unknown")]
        DXVA2VideoTransferMatrixUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"BT709\"")]
        [NativeName("Name", "DXVA2_VideoTransferMatrix_BT709")]
        DXVA2VideoTransferMatrixBT709 = 0x1,
        [Obsolete("Deprecated in favour of \"BT601\"")]
        [NativeName("Name", "DXVA2_VideoTransferMatrix_BT601")]
        DXVA2VideoTransferMatrixBT601 = 0x2,
        [Obsolete("Deprecated in favour of \"Smpte240M\"")]
        [NativeName("Name", "DXVA2_VideoTransferMatrix_SMPTE240M")]
        DXVA2VideoTransferMatrixSmpte240M = 0x3,
        [NativeName("Name", "DXVA2_VideoTransferMatrixMask")]
        Mask = 0x7,
        [NativeName("Name", "DXVA2_VideoTransferMatrix_Unknown")]
        Unknown = 0x0,
        [NativeName("Name", "DXVA2_VideoTransferMatrix_BT709")]
        BT709 = 0x1,
        [NativeName("Name", "DXVA2_VideoTransferMatrix_BT601")]
        BT601 = 0x2,
        [NativeName("Name", "DXVA2_VideoTransferMatrix_SMPTE240M")]
        Smpte240M = 0x3,
    }
}
