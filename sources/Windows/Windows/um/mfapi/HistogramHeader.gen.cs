// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='HistogramHeader.xml' path='doc/member[@name="HistogramHeader"]/*' />
public partial struct HistogramHeader
{
    /// <include file='HistogramHeader.xml' path='doc/member[@name="HistogramHeader.Size"]/*' />
    [NativeTypeName("ULONG")]
    public uint Size;

    /// <include file='HistogramHeader.xml' path='doc/member[@name="HistogramHeader.Bins"]/*' />
    [NativeTypeName("ULONG")]
    public uint Bins;

    /// <include file='HistogramHeader.xml' path='doc/member[@name="HistogramHeader.FourCC"]/*' />
    [NativeTypeName("ULONG")]
    public uint FourCC;

    /// <include file='HistogramHeader.xml' path='doc/member[@name="HistogramHeader.ChannelMasks"]/*' />
    [NativeTypeName("ULONG")]
    public uint ChannelMasks;

    /// <include file='HistogramHeader.xml' path='doc/member[@name="HistogramHeader.Grid"]/*' />
    public HistogramGrid Grid;
}
