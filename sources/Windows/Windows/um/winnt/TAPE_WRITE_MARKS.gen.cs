// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TAPE_WRITE_MARKS.xml' path='doc/member[@name="TAPE_WRITE_MARKS"]/*' />
public partial struct TAPE_WRITE_MARKS
{
    /// <include file='TAPE_WRITE_MARKS.xml' path='doc/member[@name="TAPE_WRITE_MARKS.Type"]/*' />
    [NativeTypeName("DWORD")]
    public uint Type;

    /// <include file='TAPE_WRITE_MARKS.xml' path='doc/member[@name="TAPE_WRITE_MARKS.Count"]/*' />
    [NativeTypeName("DWORD")]
    public uint Count;

    /// <include file='TAPE_WRITE_MARKS.xml' path='doc/member[@name="TAPE_WRITE_MARKS.Immediate"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte Immediate;
}
