// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CALPWSTR.xml' path='doc/member[@name="CALPWSTR"]/*' />
public unsafe partial struct CALPWSTR
{
    /// <include file='CALPWSTR.xml' path='doc/member[@name="CALPWSTR.cElems"]/*' />
    [NativeTypeName("ULONG")]
    public uint cElems;

    /// <include file='CALPWSTR.xml' path='doc/member[@name="CALPWSTR.pElems"]/*' />
    [NativeTypeName("LPWSTR *")]
    public ushort** pElems;
}
