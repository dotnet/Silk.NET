// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CAUI.xml' path='doc/member[@name="CAUI"]/*' />
public unsafe partial struct CAUI
{
    /// <include file='CAUI.xml' path='doc/member[@name="CAUI.cElems"]/*' />
    [NativeTypeName("ULONG")]
    public uint cElems;

    /// <include file='CAUI.xml' path='doc/member[@name="CAUI.pElems"]/*' />
    public ushort* pElems;
}
