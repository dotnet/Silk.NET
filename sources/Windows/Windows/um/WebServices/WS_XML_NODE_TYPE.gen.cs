// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_XML_NODE_TYPE.xml' path='doc/member[@name="WS_XML_NODE_TYPE"]/*'/>
public enum WS_XML_NODE_TYPE
{
    /// <include file='WS_XML_NODE_TYPE.xml' path='doc/member[@name="WS_XML_NODE_TYPE.WS_XML_NODE_TYPE_ELEMENT"]/*'/>
    WS_XML_NODE_TYPE_ELEMENT = 1,
    /// <include file='WS_XML_NODE_TYPE.xml' path='doc/member[@name="WS_XML_NODE_TYPE.WS_XML_NODE_TYPE_TEXT"]/*'/>
    WS_XML_NODE_TYPE_TEXT = 2,
    /// <include file='WS_XML_NODE_TYPE.xml' path='doc/member[@name="WS_XML_NODE_TYPE.WS_XML_NODE_TYPE_END_ELEMENT"]/*'/>
    WS_XML_NODE_TYPE_END_ELEMENT = 3,
    /// <include file='WS_XML_NODE_TYPE.xml' path='doc/member[@name="WS_XML_NODE_TYPE.WS_XML_NODE_TYPE_COMMENT"]/*'/>
    WS_XML_NODE_TYPE_COMMENT = 4,
    /// <include file='WS_XML_NODE_TYPE.xml' path='doc/member[@name="WS_XML_NODE_TYPE.WS_XML_NODE_TYPE_CDATA"]/*'/>
    WS_XML_NODE_TYPE_CDATA = 6,
    /// <include file='WS_XML_NODE_TYPE.xml' path='doc/member[@name="WS_XML_NODE_TYPE.WS_XML_NODE_TYPE_END_CDATA"]/*'/>
    WS_XML_NODE_TYPE_END_CDATA = 7,
    /// <include file='WS_XML_NODE_TYPE.xml' path='doc/member[@name="WS_XML_NODE_TYPE.WS_XML_NODE_TYPE_EOF"]/*'/>
    WS_XML_NODE_TYPE_EOF = 8,
    /// <include file='WS_XML_NODE_TYPE.xml' path='doc/member[@name="WS_XML_NODE_TYPE.WS_XML_NODE_TYPE_BOF"]/*'/>
    WS_XML_NODE_TYPE_BOF = 9,
}