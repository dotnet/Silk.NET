// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msxml.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum XMLELEM_TYPE
{
    XMLELEMTYPE_ELEMENT = 0,
    XMLELEMTYPE_TEXT = (XMLELEMTYPE_ELEMENT + 1),
    XMLELEMTYPE_COMMENT = (XMLELEMTYPE_TEXT + 1),
    XMLELEMTYPE_DOCUMENT = (XMLELEMTYPE_COMMENT + 1),
    XMLELEMTYPE_DTD = (XMLELEMTYPE_DOCUMENT + 1),
    XMLELEMTYPE_PI = (XMLELEMTYPE_DTD + 1),
    XMLELEMTYPE_OTHER = (XMLELEMTYPE_PI + 1),
}
