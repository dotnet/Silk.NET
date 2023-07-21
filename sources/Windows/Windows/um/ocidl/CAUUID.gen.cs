// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='CAUUID.xml' path='doc/member[@name="CAUUID"]/*' />
public unsafe partial struct CAUUID
{
    /// <include file='CAUUID.xml' path='doc/member[@name="CAUUID.cElems"]/*' />
    [NativeTypeName("ULONG")]
    public uint cElems;

    /// <include file='CAUUID.xml' path='doc/member[@name="CAUUID.pElems"]/*' />
    public Guid* pElems;
}
