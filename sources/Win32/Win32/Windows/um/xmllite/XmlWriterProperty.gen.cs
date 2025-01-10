// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum XmlWriterProperty
{
    XmlWriterProperty_MultiLanguage = 0,
    XmlWriterProperty_Indent = (XmlWriterProperty_MultiLanguage + 1),
    XmlWriterProperty_ByteOrderMark = (XmlWriterProperty_Indent + 1),
    XmlWriterProperty_OmitXmlDeclaration = (XmlWriterProperty_ByteOrderMark + 1),
    XmlWriterProperty_ConformanceLevel = (XmlWriterProperty_OmitXmlDeclaration + 1),
    XmlWriterProperty_CompactEmptyElement = (XmlWriterProperty_ConformanceLevel + 1),
    _XmlWriterProperty_Last = XmlWriterProperty_CompactEmptyElement,
}
