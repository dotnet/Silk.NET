// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='CONFIRMSAFETY.xml' path='doc/member[@name="CONFIRMSAFETY"]/*' />
public unsafe partial struct CONFIRMSAFETY
{
    /// <include file='CONFIRMSAFETY.xml' path='doc/member[@name="CONFIRMSAFETY.clsid"]/*' />
    [NativeTypeName("CLSID")]
    public Guid clsid;

    /// <include file='CONFIRMSAFETY.xml' path='doc/member[@name="CONFIRMSAFETY.pUnk"]/*' />
    public IUnknown* pUnk;

    /// <include file='CONFIRMSAFETY.xml' path='doc/member[@name="CONFIRMSAFETY.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}
