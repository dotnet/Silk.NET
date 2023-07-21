// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='BP_ANIMATIONPARAMS.xml' path='doc/member[@name="BP_ANIMATIONPARAMS"]/*' />
public partial struct BP_ANIMATIONPARAMS
{
    /// <include file='BP_ANIMATIONPARAMS.xml' path='doc/member[@name="BP_ANIMATIONPARAMS.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='BP_ANIMATIONPARAMS.xml' path='doc/member[@name="BP_ANIMATIONPARAMS.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='BP_ANIMATIONPARAMS.xml' path='doc/member[@name="BP_ANIMATIONPARAMS.style"]/*' />
    public BP_ANIMATIONSTYLE style;

    /// <include file='BP_ANIMATIONPARAMS.xml' path='doc/member[@name="BP_ANIMATIONPARAMS.dwDuration"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDuration;
}
