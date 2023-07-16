// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='XmlNodeType.xml' path='doc/member[@name="XmlNodeType"]/*'/>
public enum XmlNodeType
{
    /// <include file='XmlNodeType.xml' path='doc/member[@name="XmlNodeType.XmlNodeType_None"]/*'/>
    XmlNodeType_None = 0,
    /// <include file='XmlNodeType.xml' path='doc/member[@name="XmlNodeType.XmlNodeType_Element"]/*'/>
    XmlNodeType_Element = 1,
    /// <include file='XmlNodeType.xml' path='doc/member[@name="XmlNodeType.XmlNodeType_Attribute"]/*'/>
    XmlNodeType_Attribute = 2,
    /// <include file='XmlNodeType.xml' path='doc/member[@name="XmlNodeType.XmlNodeType_Text"]/*'/>
    XmlNodeType_Text = 3,
    /// <include file='XmlNodeType.xml' path='doc/member[@name="XmlNodeType.XmlNodeType_CDATA"]/*'/>
    XmlNodeType_CDATA = 4,
    /// <include file='XmlNodeType.xml' path='doc/member[@name="XmlNodeType.XmlNodeType_ProcessingInstruction"]/*'/>
    XmlNodeType_ProcessingInstruction = 7,
    /// <include file='XmlNodeType.xml' path='doc/member[@name="XmlNodeType.XmlNodeType_Comment"]/*'/>
    XmlNodeType_Comment = 8,
    /// <include file='XmlNodeType.xml' path='doc/member[@name="XmlNodeType.XmlNodeType_DocumentType"]/*'/>
    XmlNodeType_DocumentType = 10,
    /// <include file='XmlNodeType.xml' path='doc/member[@name="XmlNodeType.XmlNodeType_Whitespace"]/*'/>
    XmlNodeType_Whitespace = 13,
    /// <include file='XmlNodeType.xml' path='doc/member[@name="XmlNodeType.XmlNodeType_EndElement"]/*'/>
    XmlNodeType_EndElement = 15,
    /// <include file='XmlNodeType.xml' path='doc/member[@name="XmlNodeType.XmlNodeType_XmlDeclaration"]/*'/>
    XmlNodeType_XmlDeclaration = 17,
    /// <include file='XmlNodeType.xml' path='doc/member[@name="XmlNodeType._XmlNodeType_Last"]/*'/>
    _XmlNodeType_Last = 17,
}