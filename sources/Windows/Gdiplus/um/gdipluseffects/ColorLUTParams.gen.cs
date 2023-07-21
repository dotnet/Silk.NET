// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Gdiplus;

/// <include file='ColorLUTParams.xml' path='doc/member[@name="ColorLUTParams"]/*' />
public unsafe partial struct ColorLUTParams
{
    /// <include file='ColorLUTParams.xml' path='doc/member[@name="ColorLUTParams.lutB"]/*' />
    [NativeTypeName("Gdiplus::ColorChannelLUT")]
    public fixed byte lutB[256];

    /// <include file='ColorLUTParams.xml' path='doc/member[@name="ColorLUTParams.lutG"]/*' />
    [NativeTypeName("Gdiplus::ColorChannelLUT")]
    public fixed byte lutG[256];

    /// <include file='ColorLUTParams.xml' path='doc/member[@name="ColorLUTParams.lutR"]/*' />
    [NativeTypeName("Gdiplus::ColorChannelLUT")]
    public fixed byte lutR[256];

    /// <include file='ColorLUTParams.xml' path='doc/member[@name="ColorLUTParams.lutA"]/*' />
    [NativeTypeName("Gdiplus::ColorChannelLUT")]
    public fixed byte lutA[256];
}
