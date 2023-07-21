// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/libloaderapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ENUMUILANG.xml' path='doc/member[@name="ENUMUILANG"]/*' />
public unsafe partial struct ENUMUILANG
{
    /// <include file='ENUMUILANG.xml' path='doc/member[@name="ENUMUILANG.NumOfEnumUILang"]/*' />
    [NativeTypeName("ULONG")]
    public uint NumOfEnumUILang;

    /// <include file='ENUMUILANG.xml' path='doc/member[@name="ENUMUILANG.SizeOfEnumUIBuffer"]/*' />
    [NativeTypeName("ULONG")]
    public uint SizeOfEnumUIBuffer;

    /// <include file='ENUMUILANG.xml' path='doc/member[@name="ENUMUILANG.pEnumUIBuffer"]/*' />
    [NativeTypeName("LANGID *")]
    public ushort* pEnumUIBuffer;
}
