// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;

namespace Silk.NET.Gdiplus;

/// <include file='RedEyeCorrectionParams.xml' path='doc/member[@name="RedEyeCorrectionParams"]/*' />
public unsafe partial struct RedEyeCorrectionParams
{
    /// <include file='RedEyeCorrectionParams.xml' path='doc/member[@name="RedEyeCorrectionParams.numberOfAreas"]/*' />
    public uint numberOfAreas;

    /// <include file='RedEyeCorrectionParams.xml' path='doc/member[@name="RedEyeCorrectionParams.areas"]/*' />
    public RECT* areas;
}
