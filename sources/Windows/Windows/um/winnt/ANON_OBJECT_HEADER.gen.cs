// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='ANON_OBJECT_HEADER.xml' path='doc/member[@name="ANON_OBJECT_HEADER"]/*' />
public partial struct ANON_OBJECT_HEADER
{
    /// <include file='ANON_OBJECT_HEADER.xml' path='doc/member[@name="ANON_OBJECT_HEADER.Sig1"]/*' />
    [NativeTypeName("WORD")]
    public ushort Sig1;

    /// <include file='ANON_OBJECT_HEADER.xml' path='doc/member[@name="ANON_OBJECT_HEADER.Sig2"]/*' />
    [NativeTypeName("WORD")]
    public ushort Sig2;

    /// <include file='ANON_OBJECT_HEADER.xml' path='doc/member[@name="ANON_OBJECT_HEADER.Version"]/*' />
    [NativeTypeName("WORD")]
    public ushort Version;

    /// <include file='ANON_OBJECT_HEADER.xml' path='doc/member[@name="ANON_OBJECT_HEADER.Machine"]/*' />
    [NativeTypeName("WORD")]
    public ushort Machine;

    /// <include file='ANON_OBJECT_HEADER.xml' path='doc/member[@name="ANON_OBJECT_HEADER.TimeDateStamp"]/*' />
    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;

    /// <include file='ANON_OBJECT_HEADER.xml' path='doc/member[@name="ANON_OBJECT_HEADER.ClassID"]/*' />
    [NativeTypeName("CLSID")]
    public Guid ClassID;

    /// <include file='ANON_OBJECT_HEADER.xml' path='doc/member[@name="ANON_OBJECT_HEADER.SizeOfData"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfData;
}
