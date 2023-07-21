// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluscolor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Gdiplus;

/// <include file='ColorChannelFlags.xml' path='doc/member[@name="ColorChannelFlags"]/*' />
[Flags]
public enum ColorChannelFlags
{
    /// <include file='ColorChannelFlags.xml' path='doc/member[@name="ColorChannelFlags.ColorChannelFlagsC"]/*' />
    ColorChannelFlagsC = 0,

    /// <include file='ColorChannelFlags.xml' path='doc/member[@name="ColorChannelFlags.ColorChannelFlagsM"]/*' />
    ColorChannelFlagsM,

    /// <include file='ColorChannelFlags.xml' path='doc/member[@name="ColorChannelFlags.ColorChannelFlagsY"]/*' />
    ColorChannelFlagsY,

    /// <include file='ColorChannelFlags.xml' path='doc/member[@name="ColorChannelFlags.ColorChannelFlagsK"]/*' />
    ColorChannelFlagsK,

    /// <include file='ColorChannelFlags.xml' path='doc/member[@name="ColorChannelFlags.ColorChannelFlagsLast"]/*' />
    ColorChannelFlagsLast,
}
