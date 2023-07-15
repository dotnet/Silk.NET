// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msxml.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DOMNodeType.xml' path='doc/member[@name="DOMNodeType"]/*'/>
public enum DOMNodeType
{
    /// <include file='DOMNodeType.xml' path='doc/member[@name="DOMNodeType.NODE_INVALID"]/*'/>
    NODE_INVALID = 0,
    /// <include file='DOMNodeType.xml' path='doc/member[@name="DOMNodeType.NODE_ELEMENT"]/*'/>
    NODE_ELEMENT = (NODE_INVALID + 1),
    /// <include file='DOMNodeType.xml' path='doc/member[@name="DOMNodeType.NODE_ATTRIBUTE"]/*'/>
    NODE_ATTRIBUTE = (NODE_ELEMENT + 1),
    /// <include file='DOMNodeType.xml' path='doc/member[@name="DOMNodeType.NODE_TEXT"]/*'/>
    NODE_TEXT = (NODE_ATTRIBUTE + 1),
    /// <include file='DOMNodeType.xml' path='doc/member[@name="DOMNodeType.NODE_CDATA_SECTION"]/*'/>
    NODE_CDATA_SECTION = (NODE_TEXT + 1),
    /// <include file='DOMNodeType.xml' path='doc/member[@name="DOMNodeType.NODE_ENTITY_REFERENCE"]/*'/>
    NODE_ENTITY_REFERENCE = (NODE_CDATA_SECTION + 1),
    /// <include file='DOMNodeType.xml' path='doc/member[@name="DOMNodeType.NODE_ENTITY"]/*'/>
    NODE_ENTITY = (NODE_ENTITY_REFERENCE + 1),
    /// <include file='DOMNodeType.xml' path='doc/member[@name="DOMNodeType.NODE_PROCESSING_INSTRUCTION"]/*'/>
    NODE_PROCESSING_INSTRUCTION = (NODE_ENTITY + 1),
    /// <include file='DOMNodeType.xml' path='doc/member[@name="DOMNodeType.NODE_COMMENT"]/*'/>
    NODE_COMMENT = (NODE_PROCESSING_INSTRUCTION + 1),
    /// <include file='DOMNodeType.xml' path='doc/member[@name="DOMNodeType.NODE_DOCUMENT"]/*'/>
    NODE_DOCUMENT = (NODE_COMMENT + 1),
    /// <include file='DOMNodeType.xml' path='doc/member[@name="DOMNodeType.NODE_DOCUMENT_TYPE"]/*'/>
    NODE_DOCUMENT_TYPE = (NODE_DOCUMENT + 1),
    /// <include file='DOMNodeType.xml' path='doc/member[@name="DOMNodeType.NODE_DOCUMENT_FRAGMENT"]/*'/>
    NODE_DOCUMENT_FRAGMENT = (NODE_DOCUMENT_TYPE + 1),
    /// <include file='DOMNodeType.xml' path='doc/member[@name="DOMNodeType.NODE_NOTATION"]/*'/>
    NODE_NOTATION = (NODE_DOCUMENT_FRAGMENT + 1),
}