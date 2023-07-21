// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ANIMATIONINFO.xml' path='doc/member[@name="ANIMATIONINFO"]/*' />
public partial struct ANIMATIONINFO
{
    /// <include file='ANIMATIONINFO.xml' path='doc/member[@name="ANIMATIONINFO.cbSize"]/*' />
    public uint cbSize;

    /// <include file='ANIMATIONINFO.xml' path='doc/member[@name="ANIMATIONINFO.iMinAnimate"]/*' />
    public int iMinAnimate;
}
