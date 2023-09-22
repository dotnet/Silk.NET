// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICJpegTransferMatrix")]
    public enum WICJpegTransferMatrix : int
    {
        [Obsolete("Deprecated in favour of \"Identity\"")]
        [NativeName("Name", "WICJpegTransferMatrixIdentity")]
        WicjpegTransferMatrixIdentity = 0x0,
        [Obsolete("Deprecated in favour of \"BT601\"")]
        [NativeName("Name", "WICJpegTransferMatrixBT601")]
        WicjpegTransferMatrixBT601 = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "WICJpegTransferMatrix_FORCE_DWORD")]
        WicjpegTransferMatrixForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICJpegTransferMatrixIdentity")]
        Identity = 0x0,
        [NativeName("Name", "WICJpegTransferMatrixBT601")]
        BT601 = 0x1,
        [NativeName("Name", "WICJpegTransferMatrix_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
