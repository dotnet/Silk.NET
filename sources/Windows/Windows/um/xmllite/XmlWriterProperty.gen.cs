// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='XmlWriterProperty.xml' path='doc/member[@name="XmlWriterProperty"]/*'/>
public enum XmlWriterProperty
{
    /// <include file='XmlWriterProperty.xml' path='doc/member[@name="XmlWriterProperty.XmlWriterProperty_MultiLanguage"]/*'/>
    XmlWriterProperty_MultiLanguage = 0,
    /// <include file='XmlWriterProperty.xml' path='doc/member[@name="XmlWriterProperty.XmlWriterProperty_Indent"]/*'/>
    XmlWriterProperty_Indent = (XmlWriterProperty_MultiLanguage + 1),
    /// <include file='XmlWriterProperty.xml' path='doc/member[@name="XmlWriterProperty.XmlWriterProperty_ByteOrderMark"]/*'/>
    XmlWriterProperty_ByteOrderMark = (XmlWriterProperty_Indent + 1),
    /// <include file='XmlWriterProperty.xml' path='doc/member[@name="XmlWriterProperty.XmlWriterProperty_OmitXmlDeclaration"]/*'/>
    XmlWriterProperty_OmitXmlDeclaration = (XmlWriterProperty_ByteOrderMark + 1),
    /// <include file='XmlWriterProperty.xml' path='doc/member[@name="XmlWriterProperty.XmlWriterProperty_ConformanceLevel"]/*'/>
    XmlWriterProperty_ConformanceLevel = (XmlWriterProperty_OmitXmlDeclaration + 1),
    /// <include file='XmlWriterProperty.xml' path='doc/member[@name="XmlWriterProperty.XmlWriterProperty_CompactEmptyElement"]/*'/>
    XmlWriterProperty_CompactEmptyElement = (XmlWriterProperty_ConformanceLevel + 1),
    /// <include file='XmlWriterProperty.xml' path='doc/member[@name="XmlWriterProperty._XmlWriterProperty_Last"]/*'/>
    _XmlWriterProperty_Last = XmlWriterProperty_CompactEmptyElement,
}