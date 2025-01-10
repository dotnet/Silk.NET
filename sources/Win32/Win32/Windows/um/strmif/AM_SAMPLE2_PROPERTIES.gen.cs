// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct AM_SAMPLE2_PROPERTIES
{
    [NativeTypeName("DWORD")]
    public uint cbData;

    [NativeTypeName("DWORD")]
    public uint dwTypeSpecificFlags;

    [NativeTypeName("DWORD")]
    public uint dwSampleFlags;

    [NativeTypeName("LONG")]
    public int lActual;

    [NativeTypeName("REFERENCE_TIME")]
    public long tStart;

    [NativeTypeName("REFERENCE_TIME")]
    public long tStop;

    [NativeTypeName("DWORD")]
    public uint dwStreamId;
    public AM_MEDIA_TYPE* pMediaType;
    public byte* pbBuffer;

    [NativeTypeName("LONG")]
    public int cbBuffer;
}
