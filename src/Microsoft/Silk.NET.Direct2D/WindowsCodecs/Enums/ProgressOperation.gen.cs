// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [Flags]
    [NativeName("Name", "WICProgressOperation")]
    public enum ProgressOperation : int
    {
        [NativeName("Name", "")]
        None = 0,
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
