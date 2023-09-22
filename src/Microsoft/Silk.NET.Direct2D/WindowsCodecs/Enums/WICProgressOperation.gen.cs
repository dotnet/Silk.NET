// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [Flags]
    [NativeName("Name", "WICProgressOperation")]
    public enum WICProgressOperation : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ProgressOperationCopyPixels\"")]
        [NativeName("Name", "WICProgressOperationCopyPixels")]
        WicprogressOperationCopyPixels = 0x1,
        [Obsolete("Deprecated in favour of \"ProgressOperationWritePixels\"")]
        [NativeName("Name", "WICProgressOperationWritePixels")]
        WicprogressOperationWritePixels = 0x2,
        [Obsolete("Deprecated in favour of \"ProgressOperationAll\"")]
        [NativeName("Name", "WICProgressOperationAll")]
        WicprogressOperationAll = 0xFFFF,
        [Obsolete("Deprecated in favour of \"RogressoperationForceDword\"")]
        [NativeName("Name", "WICPROGRESSOPERATION_FORCE_DWORD")]
        WicprogressoperationForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICProgressOperationCopyPixels")]
        ProgressOperationCopyPixels = 0x1,
        [NativeName("Name", "WICProgressOperationWritePixels")]
        ProgressOperationWritePixels = 0x2,
        [NativeName("Name", "WICProgressOperationAll")]
        ProgressOperationAll = 0xFFFF,
        [NativeName("Name", "WICPROGRESSOPERATION_FORCE_DWORD")]
        RogressoperationForceDword = 0x7FFFFFFF,
    }
}
