// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='HistogramBlobHeader.xml' path='doc/member[@name="HistogramBlobHeader"]/*'/>
public partial struct HistogramBlobHeader
{
    /// <include file='HistogramBlobHeader.xml' path='doc/member[@name="HistogramBlobHeader.Size"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Size;
    /// <include file='HistogramBlobHeader.xml' path='doc/member[@name="HistogramBlobHeader.Histograms"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Histograms;
}