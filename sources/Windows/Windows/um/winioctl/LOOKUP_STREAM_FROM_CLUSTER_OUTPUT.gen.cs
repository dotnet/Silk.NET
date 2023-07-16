// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='LOOKUP_STREAM_FROM_CLUSTER_OUTPUT.xml' path='doc/member[@name="LOOKUP_STREAM_FROM_CLUSTER_OUTPUT"]/*'/>
public partial struct LOOKUP_STREAM_FROM_CLUSTER_OUTPUT
{
    /// <include file='LOOKUP_STREAM_FROM_CLUSTER_OUTPUT.xml' path='doc/member[@name="LOOKUP_STREAM_FROM_CLUSTER_OUTPUT.Offset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Offset;
    /// <include file='LOOKUP_STREAM_FROM_CLUSTER_OUTPUT.xml' path='doc/member[@name="LOOKUP_STREAM_FROM_CLUSTER_OUTPUT.NumberOfMatches"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfMatches;
    /// <include file='LOOKUP_STREAM_FROM_CLUSTER_OUTPUT.xml' path='doc/member[@name="LOOKUP_STREAM_FROM_CLUSTER_OUTPUT.BufferSizeRequired"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BufferSizeRequired;
}