// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='BP_PAINTPARAMS.xml' path='doc/member[@name="BP_PAINTPARAMS"]/*' />
public unsafe partial struct BP_PAINTPARAMS
{
    /// <include file='BP_PAINTPARAMS.xml' path='doc/member[@name="BP_PAINTPARAMS.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='BP_PAINTPARAMS.xml' path='doc/member[@name="BP_PAINTPARAMS.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='BP_PAINTPARAMS.xml' path='doc/member[@name="BP_PAINTPARAMS.prcExclude"]/*' />
    [NativeTypeName("const RECT *")]
    public RECT* prcExclude;

    /// <include file='BP_PAINTPARAMS.xml' path='doc/member[@name="BP_PAINTPARAMS.pBlendFunction"]/*' />
    [NativeTypeName("const BLENDFUNCTION *")]
    public BLENDFUNCTION* pBlendFunction;
}
