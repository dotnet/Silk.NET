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
        [NativeName("Name", "DXVA_VideoTransferMatrixShift")]
        VideoTransferMatrixShift = 0xF,
        [NativeName("Name", "DXVA_VideoTransferMatrixMask")]
        VideoTransferMatrixMask = 0x38000,
        [NativeName("Name", "DXVA_VideoTransferMatrix_Unknown")]
        VideoTransferMatrixUnknown = 0x0,
        [NativeName("Name", "DXVA_VideoTransferMatrix_BT709")]
        VideoTransferMatrixBT709 = 0x1,
        [NativeName("Name", "DXVA_VideoTransferMatrix_BT601")]
        VideoTransferMatrixBT601 = 0x2,
        [NativeName("Name", "DXVA_VideoTransferMatrix_SMPTE240M")]
        VideoTransferMatrixSmpte240M = 0x3,
    }
}
