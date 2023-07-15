// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MFBYTESTREAM_BUFFERING_PARAMS.xml' path='doc/member[@name="MFBYTESTREAM_BUFFERING_PARAMS"]/*'/>
public unsafe partial struct MFBYTESTREAM_BUFFERING_PARAMS
{
    /// <include file='MFBYTESTREAM_BUFFERING_PARAMS.xml' path='doc/member[@name="MFBYTESTREAM_BUFFERING_PARAMS.cbTotalFileSize"]/*'/>
    [NativeTypeName("QWORD")]
    public ulong cbTotalFileSize;
    /// <include file='MFBYTESTREAM_BUFFERING_PARAMS.xml' path='doc/member[@name="MFBYTESTREAM_BUFFERING_PARAMS.cbPlayableDataSize"]/*'/>
    [NativeTypeName("QWORD")]
    public ulong cbPlayableDataSize;
    /// <include file='MFBYTESTREAM_BUFFERING_PARAMS.xml' path='doc/member[@name="MFBYTESTREAM_BUFFERING_PARAMS.prgBuckets"]/*'/>
    public MF_LEAKY_BUCKET_PAIR* prgBuckets;
    /// <include file='MFBYTESTREAM_BUFFERING_PARAMS.xml' path='doc/member[@name="MFBYTESTREAM_BUFFERING_PARAMS.cBuckets"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cBuckets;
    /// <include file='MFBYTESTREAM_BUFFERING_PARAMS.xml' path='doc/member[@name="MFBYTESTREAM_BUFFERING_PARAMS.qwNetBufferingTime"]/*'/>
    [NativeTypeName("QWORD")]
    public ulong qwNetBufferingTime;
    /// <include file='MFBYTESTREAM_BUFFERING_PARAMS.xml' path='doc/member[@name="MFBYTESTREAM_BUFFERING_PARAMS.qwExtraBufferingTimeDuringSeek"]/*'/>
    [NativeTypeName("QWORD")]
    public ulong qwExtraBufferingTimeDuringSeek;
    /// <include file='MFBYTESTREAM_BUFFERING_PARAMS.xml' path='doc/member[@name="MFBYTESTREAM_BUFFERING_PARAMS.qwPlayDuration"]/*'/>
    [NativeTypeName("QWORD")]
    public ulong qwPlayDuration;
    /// <include file='MFBYTESTREAM_BUFFERING_PARAMS.xml' path='doc/member[@name="MFBYTESTREAM_BUFFERING_PARAMS.dRate"]/*'/>
    public float dRate;
}