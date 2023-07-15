// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DWRITE_CARET_METRICS.xml' path='doc/member[@name="DWRITE_CARET_METRICS"]/*'/>
public partial struct DWRITE_CARET_METRICS
{
    /// <include file='DWRITE_CARET_METRICS.xml' path='doc/member[@name="DWRITE_CARET_METRICS.slopeRise"]/*'/>
    [NativeTypeName("INT16")]
    public short slopeRise;
    /// <include file='DWRITE_CARET_METRICS.xml' path='doc/member[@name="DWRITE_CARET_METRICS.slopeRun"]/*'/>
    [NativeTypeName("INT16")]
    public short slopeRun;
    /// <include file='DWRITE_CARET_METRICS.xml' path='doc/member[@name="DWRITE_CARET_METRICS.offset"]/*'/>
    [NativeTypeName("INT16")]
    public short offset;
}