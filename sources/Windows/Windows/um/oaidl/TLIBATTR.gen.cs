// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='TLIBATTR.xml' path='doc/member[@name="TLIBATTR"]/*' />
public partial struct TLIBATTR
{
    /// <include file='TLIBATTR.xml' path='doc/member[@name="TLIBATTR.guid"]/*' />
    public Guid guid;

    /// <include file='TLIBATTR.xml' path='doc/member[@name="TLIBATTR.lcid"]/*' />
    [NativeTypeName("LCID")]
    public uint lcid;

    /// <include file='TLIBATTR.xml' path='doc/member[@name="TLIBATTR.syskind"]/*' />
    public SYSKIND syskind;

    /// <include file='TLIBATTR.xml' path='doc/member[@name="TLIBATTR.wMajorVerNum"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMajorVerNum;

    /// <include file='TLIBATTR.xml' path='doc/member[@name="TLIBATTR.wMinorVerNum"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMinorVerNum;

    /// <include file='TLIBATTR.xml' path='doc/member[@name="TLIBATTR.wLibFlags"]/*' />
    [NativeTypeName("WORD")]
    public ushort wLibFlags;
}
