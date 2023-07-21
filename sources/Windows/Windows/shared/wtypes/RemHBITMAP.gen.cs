// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='RemHBITMAP.xml' path='doc/member[@name="RemHBITMAP"]/*' />
public unsafe partial struct RemHBITMAP
{
    /// <include file='RemHBITMAP.xml' path='doc/member[@name="RemHBITMAP.cbData"]/*' />
    [NativeTypeName("ULONG")]
    public uint cbData;

    /// <include file='RemHBITMAP.xml' path='doc/member[@name="RemHBITMAP.data"]/*' />
    [NativeTypeName("byte[1]")]
    public fixed byte data[1];
}
