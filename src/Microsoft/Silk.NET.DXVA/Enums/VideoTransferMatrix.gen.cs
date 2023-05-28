// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVA_VideoTransferMatrix")]
    public enum VideoTransferMatrix : int
    {
        [Obsolete("Deprecated in favour of \"Shift\"")]
        [NativeName("Name", "DXVA_VideoTransferMatrixShift")]
        VideoTransferMatrixShift = 0xF,
        [Obsolete("Deprecated in favour of \"Mask\"")]
        [NativeName("Name", "DXVA_VideoTransferMatrixMask")]
        VideoTransferMatrixMask = 0x38000,
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "DXVA_VideoTransferMatrix_Unknown")]
        VideoTransferMatrixUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"BT709\"")]
        [NativeName("Name", "DXVA_VideoTransferMatrix_BT709")]
        VideoTransferMatrixBT709 = 0x1,
        [Obsolete("Deprecated in favour of \"BT601\"")]
        [NativeName("Name", "DXVA_VideoTransferMatrix_BT601")]
        VideoTransferMatrixBT601 = 0x2,
        [Obsolete("Deprecated in favour of \"Smpte240M\"")]
        [NativeName("Name", "DXVA_VideoTransferMatrix_SMPTE240M")]
        VideoTransferMatrixSmpte240M = 0x3,
        [NativeName("Name", "DXVA_VideoTransferMatrixShift")]
        Shift = 0xF,
        [NativeName("Name", "DXVA_VideoTransferMatrixMask")]
        Mask = 0x38000,
        [NativeName("Name", "DXVA_VideoTransferMatrix_Unknown")]
        Unknown = 0x0,
        [NativeName("Name", "DXVA_VideoTransferMatrix_BT709")]
        BT709 = 0x1,
        [NativeName("Name", "DXVA_VideoTransferMatrix_BT601")]
        BT601 = 0x2,
        [NativeName("Name", "DXVA_VideoTransferMatrix_SMPTE240M")]
        Smpte240M = 0x3,
    }
}
