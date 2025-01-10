// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MF_SINK_WRITER_STATISTICS
{
    [NativeTypeName("DWORD")]
    public uint cb;

    [NativeTypeName("LONGLONG")]
    public long llLastTimestampReceived;

    [NativeTypeName("LONGLONG")]
    public long llLastTimestampEncoded;

    [NativeTypeName("LONGLONG")]
    public long llLastTimestampProcessed;

    [NativeTypeName("LONGLONG")]
    public long llLastStreamTickReceived;

    [NativeTypeName("LONGLONG")]
    public long llLastSinkSampleRequest;

    [NativeTypeName("QWORD")]
    public ulong qwNumSamplesReceived;

    [NativeTypeName("QWORD")]
    public ulong qwNumSamplesEncoded;

    [NativeTypeName("QWORD")]
    public ulong qwNumSamplesProcessed;

    [NativeTypeName("QWORD")]
    public ulong qwNumStreamTicksReceived;

    [NativeTypeName("DWORD")]
    public uint dwByteCountQueued;

    [NativeTypeName("QWORD")]
    public ulong qwByteCountProcessed;

    [NativeTypeName("DWORD")]
    public uint dwNumOutstandingSinkSampleRequests;

    [NativeTypeName("DWORD")]
    public uint dwAverageSampleRateReceived;

    [NativeTypeName("DWORD")]
    public uint dwAverageSampleRateEncoded;

    [NativeTypeName("DWORD")]
    public uint dwAverageSampleRateProcessed;
}
