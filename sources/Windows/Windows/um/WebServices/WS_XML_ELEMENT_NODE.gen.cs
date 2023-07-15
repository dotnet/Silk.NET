// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_XML_ELEMENT_NODE.xml' path='doc/member[@name="WS_XML_ELEMENT_NODE"]/*'/>
public unsafe partial struct WS_XML_ELEMENT_NODE
{
    /// <include file='WS_XML_ELEMENT_NODE.xml' path='doc/member[@name="WS_XML_ELEMENT_NODE.node"]/*'/>
    public WS_XML_NODE node;
    /// <include file='WS_XML_ELEMENT_NODE.xml' path='doc/member[@name="WS_XML_ELEMENT_NODE.prefix"]/*'/>
    public WS_XML_STRING* prefix;
    /// <include file='WS_XML_ELEMENT_NODE.xml' path='doc/member[@name="WS_XML_ELEMENT_NODE.localName"]/*'/>
    public WS_XML_STRING* localName;
    /// <include file='WS_XML_ELEMENT_NODE.xml' path='doc/member[@name="WS_XML_ELEMENT_NODE.ns"]/*'/>
    public WS_XML_STRING* ns;
    /// <include file='WS_XML_ELEMENT_NODE.xml' path='doc/member[@name="WS_XML_ELEMENT_NODE.attributeCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint attributeCount;
    /// <include file='WS_XML_ELEMENT_NODE.xml' path='doc/member[@name="WS_XML_ELEMENT_NODE.attributes"]/*'/>
    public WS_XML_ATTRIBUTE** attributes;
    /// <include file='WS_XML_ELEMENT_NODE.xml' path='doc/member[@name="WS_XML_ELEMENT_NODE.isEmpty"]/*'/>
    public BOOL isEmpty;
}