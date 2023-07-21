// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_ENCODING.xml' path='doc/member[@name="WS_ENCODING"]/*' />
public enum WS_ENCODING
{
    /// <include file='WS_ENCODING.xml' path='doc/member[@name="WS_ENCODING.WS_ENCODING_XML_BINARY_1"]/*' />
    WS_ENCODING_XML_BINARY_1 = 0,

    /// <include file='WS_ENCODING.xml' path='doc/member[@name="WS_ENCODING.WS_ENCODING_XML_BINARY_SESSION_1"]/*' />
    WS_ENCODING_XML_BINARY_SESSION_1 = 1,

    /// <include file='WS_ENCODING.xml' path='doc/member[@name="WS_ENCODING.WS_ENCODING_XML_MTOM_UTF8"]/*' />
    WS_ENCODING_XML_MTOM_UTF8 = 2,

    /// <include file='WS_ENCODING.xml' path='doc/member[@name="WS_ENCODING.WS_ENCODING_XML_MTOM_UTF16BE"]/*' />
    WS_ENCODING_XML_MTOM_UTF16BE = 3,

    /// <include file='WS_ENCODING.xml' path='doc/member[@name="WS_ENCODING.WS_ENCODING_XML_MTOM_UTF16LE"]/*' />
    WS_ENCODING_XML_MTOM_UTF16LE = 4,

    /// <include file='WS_ENCODING.xml' path='doc/member[@name="WS_ENCODING.WS_ENCODING_XML_UTF8"]/*' />
    WS_ENCODING_XML_UTF8 = 5,

    /// <include file='WS_ENCODING.xml' path='doc/member[@name="WS_ENCODING.WS_ENCODING_XML_UTF16BE"]/*' />
    WS_ENCODING_XML_UTF16BE = 6,

    /// <include file='WS_ENCODING.xml' path='doc/member[@name="WS_ENCODING.WS_ENCODING_XML_UTF16LE"]/*' />
    WS_ENCODING_XML_UTF16LE = 7,

    /// <include file='WS_ENCODING.xml' path='doc/member[@name="WS_ENCODING.WS_ENCODING_RAW"]/*' />
    WS_ENCODING_RAW = 8,
}
