// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='HistogramDataHeader.xml' path='doc/member[@name="HistogramDataHeader"]/*'/>
public partial struct HistogramDataHeader
{
    /// <include file='HistogramDataHeader.xml' path='doc/member[@name="HistogramDataHeader.Size"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Size;
    /// <include file='HistogramDataHeader.xml' path='doc/member[@name="HistogramDataHeader.ChannelMask"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ChannelMask;
    /// <include file='HistogramDataHeader.xml' path='doc/member[@name="HistogramDataHeader.Linear"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Linear;
}