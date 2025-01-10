// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WS_ENCODING
{
    WS_ENCODING_XML_BINARY_1 = 0,
    WS_ENCODING_XML_BINARY_SESSION_1 = 1,
    WS_ENCODING_XML_MTOM_UTF8 = 2,
    WS_ENCODING_XML_MTOM_UTF16BE = 3,
    WS_ENCODING_XML_MTOM_UTF16LE = 4,
    WS_ENCODING_XML_UTF8 = 5,
    WS_ENCODING_XML_UTF16BE = 6,
    WS_ENCODING_XML_UTF16LE = 7,
    WS_ENCODING_RAW = 8,
}
