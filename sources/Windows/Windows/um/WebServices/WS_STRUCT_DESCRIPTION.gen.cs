// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_STRUCT_DESCRIPTION.xml' path='doc/member[@name="WS_STRUCT_DESCRIPTION"]/*' />
public unsafe partial struct WS_STRUCT_DESCRIPTION
{
    /// <include file='WS_STRUCT_DESCRIPTION.xml' path='doc/member[@name="WS_STRUCT_DESCRIPTION.size"]/*' />
    [NativeTypeName("ULONG")]
    public uint size;

    /// <include file='WS_STRUCT_DESCRIPTION.xml' path='doc/member[@name="WS_STRUCT_DESCRIPTION.alignment"]/*' />
    [NativeTypeName("ULONG")]
    public uint alignment;

    /// <include file='WS_STRUCT_DESCRIPTION.xml' path='doc/member[@name="WS_STRUCT_DESCRIPTION.fields"]/*' />
    public WS_FIELD_DESCRIPTION** fields;

    /// <include file='WS_STRUCT_DESCRIPTION.xml' path='doc/member[@name="WS_STRUCT_DESCRIPTION.fieldCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint fieldCount;

    /// <include file='WS_STRUCT_DESCRIPTION.xml' path='doc/member[@name="WS_STRUCT_DESCRIPTION.typeLocalName"]/*' />
    public WS_XML_STRING* typeLocalName;

    /// <include file='WS_STRUCT_DESCRIPTION.xml' path='doc/member[@name="WS_STRUCT_DESCRIPTION.typeNs"]/*' />
    public WS_XML_STRING* typeNs;

    /// <include file='WS_STRUCT_DESCRIPTION.xml' path='doc/member[@name="WS_STRUCT_DESCRIPTION.parentType"]/*' />
    public WS_STRUCT_DESCRIPTION* parentType;

    /// <include file='WS_STRUCT_DESCRIPTION.xml' path='doc/member[@name="WS_STRUCT_DESCRIPTION.subTypes"]/*' />
    public WS_STRUCT_DESCRIPTION** subTypes;

    /// <include file='WS_STRUCT_DESCRIPTION.xml' path='doc/member[@name="WS_STRUCT_DESCRIPTION.subTypeCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint subTypeCount;

    /// <include file='WS_STRUCT_DESCRIPTION.xml' path='doc/member[@name="WS_STRUCT_DESCRIPTION.structOptions"]/*' />
    [NativeTypeName("ULONG")]
    public uint structOptions;
}
