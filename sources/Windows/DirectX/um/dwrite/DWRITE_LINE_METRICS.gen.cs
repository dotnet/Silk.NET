// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;

namespace Silk.NET.DirectX;
/// <include file='DWRITE_LINE_METRICS.xml' path='doc/member[@name="DWRITE_LINE_METRICS"]/*'/>
public partial struct DWRITE_LINE_METRICS
{
    /// <include file='DWRITE_LINE_METRICS.xml' path='doc/member[@name="DWRITE_LINE_METRICS.length"]/*'/>
    [NativeTypeName("UINT32")]
    public uint length;
    /// <include file='DWRITE_LINE_METRICS.xml' path='doc/member[@name="DWRITE_LINE_METRICS.trailingWhitespaceLength"]/*'/>
    [NativeTypeName("UINT32")]
    public uint trailingWhitespaceLength;
    /// <include file='DWRITE_LINE_METRICS.xml' path='doc/member[@name="DWRITE_LINE_METRICS.newlineLength"]/*'/>
    [NativeTypeName("UINT32")]
    public uint newlineLength;
    /// <include file='DWRITE_LINE_METRICS.xml' path='doc/member[@name="DWRITE_LINE_METRICS.height"]/*'/>
    public float height;
    /// <include file='DWRITE_LINE_METRICS.xml' path='doc/member[@name="DWRITE_LINE_METRICS.baseline"]/*'/>
    public float baseline;
    /// <include file='DWRITE_LINE_METRICS.xml' path='doc/member[@name="DWRITE_LINE_METRICS.isTrimmed"]/*'/>
    public BOOL isTrimmed;
}