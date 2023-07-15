// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MF_SINK_WRITER_STATISTICS.xml' path='doc/member[@name="MF_SINK_WRITER_STATISTICS"]/*'/>
public partial struct MF_SINK_WRITER_STATISTICS
{
    /// <include file='MF_SINK_WRITER_STATISTICS.xml' path='doc/member[@name="MF_SINK_WRITER_STATISTICS.cb"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cb;
    /// <include file='MF_SINK_WRITER_STATISTICS.xml' path='doc/member[@name="MF_SINK_WRITER_STATISTICS.llLastTimestampReceived"]/*'/>
    [NativeTypeName("LONGLONG")]
    public long llLastTimestampReceived;
    /// <include file='MF_SINK_WRITER_STATISTICS.xml' path='doc/member[@name="MF_SINK_WRITER_STATISTICS.llLastTimestampEncoded"]/*'/>
    [NativeTypeName("LONGLONG")]
    public long llLastTimestampEncoded;
    /// <include file='MF_SINK_WRITER_STATISTICS.xml' path='doc/member[@name="MF_SINK_WRITER_STATISTICS.llLastTimestampProcessed"]/*'/>
    [NativeTypeName("LONGLONG")]
    public long llLastTimestampProcessed;
    /// <include file='MF_SINK_WRITER_STATISTICS.xml' path='doc/member[@name="MF_SINK_WRITER_STATISTICS.llLastStreamTickReceived"]/*'/>
    [NativeTypeName("LONGLONG")]
    public long llLastStreamTickReceived;
    /// <include file='MF_SINK_WRITER_STATISTICS.xml' path='doc/member[@name="MF_SINK_WRITER_STATISTICS.llLastSinkSampleRequest"]/*'/>
    [NativeTypeName("LONGLONG")]
    public long llLastSinkSampleRequest;
    /// <include file='MF_SINK_WRITER_STATISTICS.xml' path='doc/member[@name="MF_SINK_WRITER_STATISTICS.qwNumSamplesReceived"]/*'/>
    [NativeTypeName("QWORD")]
    public ulong qwNumSamplesReceived;
    /// <include file='MF_SINK_WRITER_STATISTICS.xml' path='doc/member[@name="MF_SINK_WRITER_STATISTICS.qwNumSamplesEncoded"]/*'/>
    [NativeTypeName("QWORD")]
    public ulong qwNumSamplesEncoded;
    /// <include file='MF_SINK_WRITER_STATISTICS.xml' path='doc/member[@name="MF_SINK_WRITER_STATISTICS.qwNumSamplesProcessed"]/*'/>
    [NativeTypeName("QWORD")]
    public ulong qwNumSamplesProcessed;
    /// <include file='MF_SINK_WRITER_STATISTICS.xml' path='doc/member[@name="MF_SINK_WRITER_STATISTICS.qwNumStreamTicksReceived"]/*'/>
    [NativeTypeName("QWORD")]
    public ulong qwNumStreamTicksReceived;
    /// <include file='MF_SINK_WRITER_STATISTICS.xml' path='doc/member[@name="MF_SINK_WRITER_STATISTICS.dwByteCountQueued"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwByteCountQueued;
    /// <include file='MF_SINK_WRITER_STATISTICS.xml' path='doc/member[@name="MF_SINK_WRITER_STATISTICS.qwByteCountProcessed"]/*'/>
    [NativeTypeName("QWORD")]
    public ulong qwByteCountProcessed;
    /// <include file='MF_SINK_WRITER_STATISTICS.xml' path='doc/member[@name="MF_SINK_WRITER_STATISTICS.dwNumOutstandingSinkSampleRequests"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNumOutstandingSinkSampleRequests;
    /// <include file='MF_SINK_WRITER_STATISTICS.xml' path='doc/member[@name="MF_SINK_WRITER_STATISTICS.dwAverageSampleRateReceived"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAverageSampleRateReceived;
    /// <include file='MF_SINK_WRITER_STATISTICS.xml' path='doc/member[@name="MF_SINK_WRITER_STATISTICS.dwAverageSampleRateEncoded"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAverageSampleRateEncoded;
    /// <include file='MF_SINK_WRITER_STATISTICS.xml' path='doc/member[@name="MF_SINK_WRITER_STATISTICS.dwAverageSampleRateProcessed"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAverageSampleRateProcessed;
}