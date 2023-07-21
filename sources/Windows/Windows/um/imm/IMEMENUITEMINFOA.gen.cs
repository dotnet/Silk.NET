// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IMEMENUITEMINFOA.xml' path='doc/member[@name="IMEMENUITEMINFOA"]/*' />
public unsafe partial struct IMEMENUITEMINFOA
{
    /// <include file='IMEMENUITEMINFOA.xml' path='doc/member[@name="IMEMENUITEMINFOA.cbSize"]/*' />
    public uint cbSize;

    /// <include file='IMEMENUITEMINFOA.xml' path='doc/member[@name="IMEMENUITEMINFOA.fType"]/*' />
    public uint fType;

    /// <include file='IMEMENUITEMINFOA.xml' path='doc/member[@name="IMEMENUITEMINFOA.fState"]/*' />
    public uint fState;

    /// <include file='IMEMENUITEMINFOA.xml' path='doc/member[@name="IMEMENUITEMINFOA.wID"]/*' />
    public uint wID;

    /// <include file='IMEMENUITEMINFOA.xml' path='doc/member[@name="IMEMENUITEMINFOA.hbmpChecked"]/*' />
    public HBITMAP hbmpChecked;

    /// <include file='IMEMENUITEMINFOA.xml' path='doc/member[@name="IMEMENUITEMINFOA.hbmpUnchecked"]/*' />
    public HBITMAP hbmpUnchecked;

    /// <include file='IMEMENUITEMINFOA.xml' path='doc/member[@name="IMEMENUITEMINFOA.dwItemData"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwItemData;

    /// <include file='IMEMENUITEMINFOA.xml' path='doc/member[@name="IMEMENUITEMINFOA.szString"]/*' />
    [NativeTypeName("CHAR[80]")]
    public fixed sbyte szString[80];

    /// <include file='IMEMENUITEMINFOA.xml' path='doc/member[@name="IMEMENUITEMINFOA.hbmpItem"]/*' />
    public HBITMAP hbmpItem;
}
