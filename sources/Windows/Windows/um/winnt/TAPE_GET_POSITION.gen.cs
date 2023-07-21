// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TAPE_GET_POSITION.xml' path='doc/member[@name="TAPE_GET_POSITION"]/*' />
public partial struct TAPE_GET_POSITION
{
    /// <include file='TAPE_GET_POSITION.xml' path='doc/member[@name="TAPE_GET_POSITION.Type"]/*' />
    [NativeTypeName("DWORD")]
    public uint Type;

    /// <include file='TAPE_GET_POSITION.xml' path='doc/member[@name="TAPE_GET_POSITION.Partition"]/*' />
    [NativeTypeName("DWORD")]
    public uint Partition;

    /// <include file='TAPE_GET_POSITION.xml' path='doc/member[@name="TAPE_GET_POSITION.Offset"]/*' />
    public LARGE_INTEGER Offset;
}
