// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_XML_QNAME_DESCRIPTION.xml' path='doc/member[@name="WS_XML_QNAME_DESCRIPTION"]/*' />
public partial struct WS_XML_QNAME_DESCRIPTION
{
    /// <include file='WS_XML_QNAME_DESCRIPTION.xml' path='doc/member[@name="WS_XML_QNAME_DESCRIPTION.minLocalNameByteCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint minLocalNameByteCount;

    /// <include file='WS_XML_QNAME_DESCRIPTION.xml' path='doc/member[@name="WS_XML_QNAME_DESCRIPTION.maxLocalNameByteCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint maxLocalNameByteCount;

    /// <include file='WS_XML_QNAME_DESCRIPTION.xml' path='doc/member[@name="WS_XML_QNAME_DESCRIPTION.minNsByteCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint minNsByteCount;

    /// <include file='WS_XML_QNAME_DESCRIPTION.xml' path='doc/member[@name="WS_XML_QNAME_DESCRIPTION.maxNsByteCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint maxNsByteCount;
}
