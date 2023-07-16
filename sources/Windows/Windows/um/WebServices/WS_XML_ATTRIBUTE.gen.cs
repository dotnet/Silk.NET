// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_XML_ATTRIBUTE.xml' path='doc/member[@name="WS_XML_ATTRIBUTE"]/*'/>
public unsafe partial struct WS_XML_ATTRIBUTE
{
    /// <include file='WS_XML_ATTRIBUTE.xml' path='doc/member[@name="WS_XML_ATTRIBUTE.singleQuote"]/*'/>
    public byte singleQuote;
    /// <include file='WS_XML_ATTRIBUTE.xml' path='doc/member[@name="WS_XML_ATTRIBUTE.isXmlNs"]/*'/>
    public byte isXmlNs;
    /// <include file='WS_XML_ATTRIBUTE.xml' path='doc/member[@name="WS_XML_ATTRIBUTE.prefix"]/*'/>
    public WS_XML_STRING* prefix;
    /// <include file='WS_XML_ATTRIBUTE.xml' path='doc/member[@name="WS_XML_ATTRIBUTE.localName"]/*'/>
    public WS_XML_STRING* localName;
    /// <include file='WS_XML_ATTRIBUTE.xml' path='doc/member[@name="WS_XML_ATTRIBUTE.ns"]/*'/>
    public WS_XML_STRING* ns;
    /// <include file='WS_XML_ATTRIBUTE.xml' path='doc/member[@name="WS_XML_ATTRIBUTE.value"]/*'/>
    public WS_XML_TEXT* value;
}