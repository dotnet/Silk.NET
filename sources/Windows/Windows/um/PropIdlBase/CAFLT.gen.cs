// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CAFLT.xml' path='doc/member[@name="CAFLT"]/*' />
public unsafe partial struct CAFLT
{
    /// <include file='CAFLT.xml' path='doc/member[@name="CAFLT.cElems"]/*' />
    [NativeTypeName("ULONG")]
    public uint cElems;

    /// <include file='CAFLT.xml' path='doc/member[@name="CAFLT.pElems"]/*' />
    public float* pElems;
}
