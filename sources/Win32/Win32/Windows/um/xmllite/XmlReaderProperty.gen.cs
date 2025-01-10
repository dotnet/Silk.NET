// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum XmlReaderProperty
{
    XmlReaderProperty_MultiLanguage = 0,
    XmlReaderProperty_ConformanceLevel = (XmlReaderProperty_MultiLanguage + 1),
    XmlReaderProperty_RandomAccess = (XmlReaderProperty_ConformanceLevel + 1),
    XmlReaderProperty_XmlResolver = (XmlReaderProperty_RandomAccess + 1),
    XmlReaderProperty_DtdProcessing = (XmlReaderProperty_XmlResolver + 1),
    XmlReaderProperty_ReadState = (XmlReaderProperty_DtdProcessing + 1),
    XmlReaderProperty_MaxElementDepth = (XmlReaderProperty_ReadState + 1),
    XmlReaderProperty_MaxEntityExpansion = (XmlReaderProperty_MaxElementDepth + 1),
    _XmlReaderProperty_Last = XmlReaderProperty_MaxEntityExpansion,
}
