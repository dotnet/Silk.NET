// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_XML_WRITER_MTOM_ENCODING.xml' path='doc/member[@name="WS_XML_WRITER_MTOM_ENCODING"]/*'/>
public unsafe partial struct WS_XML_WRITER_MTOM_ENCODING
{
    /// <include file='WS_XML_WRITER_MTOM_ENCODING.xml' path='doc/member[@name="WS_XML_WRITER_MTOM_ENCODING.encoding"]/*'/>
    public WS_XML_WRITER_ENCODING encoding;
    /// <include file='WS_XML_WRITER_MTOM_ENCODING.xml' path='doc/member[@name="WS_XML_WRITER_MTOM_ENCODING.textEncoding"]/*'/>
    public WS_XML_WRITER_ENCODING* textEncoding;
    /// <include file='WS_XML_WRITER_MTOM_ENCODING.xml' path='doc/member[@name="WS_XML_WRITER_MTOM_ENCODING.writeMimeHeader"]/*'/>
    public BOOL writeMimeHeader;
    /// <include file='WS_XML_WRITER_MTOM_ENCODING.xml' path='doc/member[@name="WS_XML_WRITER_MTOM_ENCODING.boundary"]/*'/>
    public WS_STRING boundary;
    /// <include file='WS_XML_WRITER_MTOM_ENCODING.xml' path='doc/member[@name="WS_XML_WRITER_MTOM_ENCODING.startInfo"]/*'/>
    public WS_STRING startInfo;
    /// <include file='WS_XML_WRITER_MTOM_ENCODING.xml' path='doc/member[@name="WS_XML_WRITER_MTOM_ENCODING.startUri"]/*'/>
    public WS_STRING startUri;
    /// <include file='WS_XML_WRITER_MTOM_ENCODING.xml' path='doc/member[@name="WS_XML_WRITER_MTOM_ENCODING.maxInlineByteCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint maxInlineByteCount;
}