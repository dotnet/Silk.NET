// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_XML_WRITER_ENCODING_TYPE.xml' path='doc/member[@name="WS_XML_WRITER_ENCODING_TYPE"]/*'/>
public enum WS_XML_WRITER_ENCODING_TYPE
{
    /// <include file='WS_XML_WRITER_ENCODING_TYPE.xml' path='doc/member[@name="WS_XML_WRITER_ENCODING_TYPE.WS_XML_WRITER_ENCODING_TYPE_TEXT"]/*'/>
    WS_XML_WRITER_ENCODING_TYPE_TEXT = 1,
    /// <include file='WS_XML_WRITER_ENCODING_TYPE.xml' path='doc/member[@name="WS_XML_WRITER_ENCODING_TYPE.WS_XML_WRITER_ENCODING_TYPE_BINARY"]/*'/>
    WS_XML_WRITER_ENCODING_TYPE_BINARY = 2,
    /// <include file='WS_XML_WRITER_ENCODING_TYPE.xml' path='doc/member[@name="WS_XML_WRITER_ENCODING_TYPE.WS_XML_WRITER_ENCODING_TYPE_MTOM"]/*'/>
    WS_XML_WRITER_ENCODING_TYPE_MTOM = 3,
    /// <include file='WS_XML_WRITER_ENCODING_TYPE.xml' path='doc/member[@name="WS_XML_WRITER_ENCODING_TYPE.WS_XML_WRITER_ENCODING_TYPE_RAW"]/*'/>
    WS_XML_WRITER_ENCODING_TYPE_RAW = 4,
}