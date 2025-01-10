// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct WS_XML_WRITER_MTOM_ENCODING
{
    public WS_XML_WRITER_ENCODING encoding;
    public WS_XML_WRITER_ENCODING* textEncoding;
    public BOOL writeMimeHeader;
    public WS_STRING boundary;
    public WS_STRING startInfo;
    public WS_STRING startUri;

    [NativeTypeName("ULONG")]
    public uint maxInlineByteCount;
}
