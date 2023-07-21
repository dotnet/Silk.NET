// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CAFILETIME.xml' path='doc/member[@name="CAFILETIME"]/*' />
public unsafe partial struct CAFILETIME
{
    /// <include file='CAFILETIME.xml' path='doc/member[@name="CAFILETIME.cElems"]/*' />
    [NativeTypeName("ULONG")]
    public uint cElems;

    /// <include file='CAFILETIME.xml' path='doc/member[@name="CAFILETIME.pElems"]/*' />
    public FILETIME* pElems;
}
