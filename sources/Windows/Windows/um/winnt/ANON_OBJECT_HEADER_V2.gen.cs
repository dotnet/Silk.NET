// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='ANON_OBJECT_HEADER_V2.xml' path='doc/member[@name="ANON_OBJECT_HEADER_V2"]/*' />
public partial struct ANON_OBJECT_HEADER_V2
{
    /// <include file='ANON_OBJECT_HEADER_V2.xml' path='doc/member[@name="ANON_OBJECT_HEADER_V2.Sig1"]/*' />
    [NativeTypeName("WORD")]
    public ushort Sig1;

    /// <include file='ANON_OBJECT_HEADER_V2.xml' path='doc/member[@name="ANON_OBJECT_HEADER_V2.Sig2"]/*' />
    [NativeTypeName("WORD")]
    public ushort Sig2;

    /// <include file='ANON_OBJECT_HEADER_V2.xml' path='doc/member[@name="ANON_OBJECT_HEADER_V2.Version"]/*' />
    [NativeTypeName("WORD")]
    public ushort Version;

    /// <include file='ANON_OBJECT_HEADER_V2.xml' path='doc/member[@name="ANON_OBJECT_HEADER_V2.Machine"]/*' />
    [NativeTypeName("WORD")]
    public ushort Machine;

    /// <include file='ANON_OBJECT_HEADER_V2.xml' path='doc/member[@name="ANON_OBJECT_HEADER_V2.TimeDateStamp"]/*' />
    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;

    /// <include file='ANON_OBJECT_HEADER_V2.xml' path='doc/member[@name="ANON_OBJECT_HEADER_V2.ClassID"]/*' />
    [NativeTypeName("CLSID")]
    public Guid ClassID;

    /// <include file='ANON_OBJECT_HEADER_V2.xml' path='doc/member[@name="ANON_OBJECT_HEADER_V2.SizeOfData"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfData;

    /// <include file='ANON_OBJECT_HEADER_V2.xml' path='doc/member[@name="ANON_OBJECT_HEADER_V2.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='ANON_OBJECT_HEADER_V2.xml' path='doc/member[@name="ANON_OBJECT_HEADER_V2.MetaDataSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint MetaDataSize;

    /// <include file='ANON_OBJECT_HEADER_V2.xml' path='doc/member[@name="ANON_OBJECT_HEADER_V2.MetaDataOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint MetaDataOffset;
}
