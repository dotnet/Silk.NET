// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum XmlNodeType
{
    XmlNodeType_None = 0,
    XmlNodeType_Element = 1,
    XmlNodeType_Attribute = 2,
    XmlNodeType_Text = 3,
    XmlNodeType_CDATA = 4,
    XmlNodeType_ProcessingInstruction = 7,
    XmlNodeType_Comment = 8,
    XmlNodeType_DocumentType = 10,
    XmlNodeType_Whitespace = 13,
    XmlNodeType_EndElement = 15,
    XmlNodeType_XmlDeclaration = 17,
    _XmlNodeType_Last = 17,
}
