// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_XML_STRING.xml' path='doc/member[@name="WS_XML_STRING"]/*' />
public unsafe partial struct WS_XML_STRING
{
    /// <include file='WS_XML_STRING.xml' path='doc/member[@name="WS_XML_STRING.length"]/*' />
    [NativeTypeName("ULONG")]
    public uint length;

    /// <include file='WS_XML_STRING.xml' path='doc/member[@name="WS_XML_STRING.bytes"]/*' />
    public byte* bytes;

    /// <include file='WS_XML_STRING.xml' path='doc/member[@name="WS_XML_STRING.dictionary"]/*' />
    public WS_XML_DICTIONARY* dictionary;

    /// <include file='WS_XML_STRING.xml' path='doc/member[@name="WS_XML_STRING.id"]/*' />
    [NativeTypeName("ULONG")]
    public uint id;
}
