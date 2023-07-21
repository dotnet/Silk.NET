// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TAPE_SET_POSITION.xml' path='doc/member[@name="TAPE_SET_POSITION"]/*' />
public partial struct TAPE_SET_POSITION
{
    /// <include file='TAPE_SET_POSITION.xml' path='doc/member[@name="TAPE_SET_POSITION.Method"]/*' />
    [NativeTypeName("DWORD")]
    public uint Method;

    /// <include file='TAPE_SET_POSITION.xml' path='doc/member[@name="TAPE_SET_POSITION.Partition"]/*' />
    [NativeTypeName("DWORD")]
    public uint Partition;

    /// <include file='TAPE_SET_POSITION.xml' path='doc/member[@name="TAPE_SET_POSITION.Offset"]/*' />
    public LARGE_INTEGER Offset;

    /// <include file='TAPE_SET_POSITION.xml' path='doc/member[@name="TAPE_SET_POSITION.Immediate"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte Immediate;
}
