// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct HTTP_QUIC_STREAM_REQUEST_STATS
{
    [NativeTypeName("ULONGLONG")]
    public ulong StreamWaitStart;

    [NativeTypeName("ULONGLONG")]
    public ulong StreamWaitEnd;

    [NativeTypeName("ULONGLONG")]
    public ulong RequestHeadersCompressionStart;

    [NativeTypeName("ULONGLONG")]
    public ulong RequestHeadersCompressionEnd;

    [NativeTypeName("ULONGLONG")]
    public ulong ResponseHeadersDecompressionStart;

    [NativeTypeName("ULONGLONG")]
    public ulong ResponseHeadersDecompressionEnd;

    [NativeTypeName("ULONGLONG")]
    public ulong RequestHeadersCompressedSize;

    [NativeTypeName("ULONGLONG")]
    public ulong ResponseHeadersCompressedSize;
}
