// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='CACLSID.xml' path='doc/member[@name="CACLSID"]/*' />
public unsafe partial struct CACLSID
{
    /// <include file='CACLSID.xml' path='doc/member[@name="CACLSID.cElems"]/*' />
    [NativeTypeName("ULONG")]
    public uint cElems;

    /// <include file='CACLSID.xml' path='doc/member[@name="CACLSID.pElems"]/*' />
    [NativeTypeName("CLSID *")]
    public Guid* pElems;
}
