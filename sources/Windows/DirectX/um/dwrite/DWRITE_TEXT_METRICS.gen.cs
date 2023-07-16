// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DWRITE_TEXT_METRICS.xml' path='doc/member[@name="DWRITE_TEXT_METRICS"]/*'/>
public partial struct DWRITE_TEXT_METRICS
{
    /// <include file='DWRITE_TEXT_METRICS.xml' path='doc/member[@name="DWRITE_TEXT_METRICS.left"]/*'/>
    public float left;
    /// <include file='DWRITE_TEXT_METRICS.xml' path='doc/member[@name="DWRITE_TEXT_METRICS.top"]/*'/>
    public float top;
    /// <include file='DWRITE_TEXT_METRICS.xml' path='doc/member[@name="DWRITE_TEXT_METRICS.width"]/*'/>
    public float width;
    /// <include file='DWRITE_TEXT_METRICS.xml' path='doc/member[@name="DWRITE_TEXT_METRICS.widthIncludingTrailingWhitespace"]/*'/>
    public float widthIncludingTrailingWhitespace;
    /// <include file='DWRITE_TEXT_METRICS.xml' path='doc/member[@name="DWRITE_TEXT_METRICS.height"]/*'/>
    public float height;
    /// <include file='DWRITE_TEXT_METRICS.xml' path='doc/member[@name="DWRITE_TEXT_METRICS.layoutWidth"]/*'/>
    public float layoutWidth;
    /// <include file='DWRITE_TEXT_METRICS.xml' path='doc/member[@name="DWRITE_TEXT_METRICS.layoutHeight"]/*'/>
    public float layoutHeight;
    /// <include file='DWRITE_TEXT_METRICS.xml' path='doc/member[@name="DWRITE_TEXT_METRICS.maxBidiReorderingDepth"]/*'/>
    [NativeTypeName("UINT32")]
    public uint maxBidiReorderingDepth;
    /// <include file='DWRITE_TEXT_METRICS.xml' path='doc/member[@name="DWRITE_TEXT_METRICS.lineCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint lineCount;
}