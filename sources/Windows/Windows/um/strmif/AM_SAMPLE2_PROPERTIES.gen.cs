// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='AM_SAMPLE2_PROPERTIES.xml' path='doc/member[@name="AM_SAMPLE2_PROPERTIES"]/*' />
public unsafe partial struct AM_SAMPLE2_PROPERTIES
{
    /// <include file='AM_SAMPLE2_PROPERTIES.xml' path='doc/member[@name="AM_SAMPLE2_PROPERTIES.cbData"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbData;

    /// <include file='AM_SAMPLE2_PROPERTIES.xml' path='doc/member[@name="AM_SAMPLE2_PROPERTIES.dwTypeSpecificFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwTypeSpecificFlags;

    /// <include file='AM_SAMPLE2_PROPERTIES.xml' path='doc/member[@name="AM_SAMPLE2_PROPERTIES.dwSampleFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSampleFlags;

    /// <include file='AM_SAMPLE2_PROPERTIES.xml' path='doc/member[@name="AM_SAMPLE2_PROPERTIES.lActual"]/*' />
    [NativeTypeName("LONG")]
    public int lActual;

    /// <include file='AM_SAMPLE2_PROPERTIES.xml' path='doc/member[@name="AM_SAMPLE2_PROPERTIES.tStart"]/*' />
    [NativeTypeName("REFERENCE_TIME")]
    public long tStart;

    /// <include file='AM_SAMPLE2_PROPERTIES.xml' path='doc/member[@name="AM_SAMPLE2_PROPERTIES.tStop"]/*' />
    [NativeTypeName("REFERENCE_TIME")]
    public long tStop;

    /// <include file='AM_SAMPLE2_PROPERTIES.xml' path='doc/member[@name="AM_SAMPLE2_PROPERTIES.dwStreamId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStreamId;

    /// <include file='AM_SAMPLE2_PROPERTIES.xml' path='doc/member[@name="AM_SAMPLE2_PROPERTIES.pMediaType"]/*' />
    public AM_MEDIA_TYPE* pMediaType;

    /// <include file='AM_SAMPLE2_PROPERTIES.xml' path='doc/member[@name="AM_SAMPLE2_PROPERTIES.pbBuffer"]/*' />
    public byte* pbBuffer;

    /// <include file='AM_SAMPLE2_PROPERTIES.xml' path='doc/member[@name="AM_SAMPLE2_PROPERTIES.cbBuffer"]/*' />
    [NativeTypeName("LONG")]
    public int cbBuffer;
}
