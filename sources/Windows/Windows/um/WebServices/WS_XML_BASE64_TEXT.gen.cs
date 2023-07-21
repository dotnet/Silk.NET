// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_XML_BASE64_TEXT.xml' path='doc/member[@name="WS_XML_BASE64_TEXT"]/*' />
public unsafe partial struct WS_XML_BASE64_TEXT
{
    /// <include file='WS_XML_BASE64_TEXT.xml' path='doc/member[@name="WS_XML_BASE64_TEXT.text"]/*' />
    public WS_XML_TEXT text;

    /// <include file='WS_XML_BASE64_TEXT.xml' path='doc/member[@name="WS_XML_BASE64_TEXT.bytes"]/*' />
    public byte* bytes;

    /// <include file='WS_XML_BASE64_TEXT.xml' path='doc/member[@name="WS_XML_BASE64_TEXT.length"]/*' />
    [NativeTypeName("ULONG")]
    public uint length;
}
