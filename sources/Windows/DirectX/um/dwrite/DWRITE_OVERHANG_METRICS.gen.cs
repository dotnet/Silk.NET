// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DWRITE_OVERHANG_METRICS.xml' path='doc/member[@name="DWRITE_OVERHANG_METRICS"]/*'/>
public partial struct DWRITE_OVERHANG_METRICS
{
    /// <include file='DWRITE_OVERHANG_METRICS.xml' path='doc/member[@name="DWRITE_OVERHANG_METRICS.left"]/*'/>
    public float left;
    /// <include file='DWRITE_OVERHANG_METRICS.xml' path='doc/member[@name="DWRITE_OVERHANG_METRICS.top"]/*'/>
    public float top;
    /// <include file='DWRITE_OVERHANG_METRICS.xml' path='doc/member[@name="DWRITE_OVERHANG_METRICS.right"]/*'/>
    public float right;
    /// <include file='DWRITE_OVERHANG_METRICS.xml' path='doc/member[@name="DWRITE_OVERHANG_METRICS.bottom"]/*'/>
    public float bottom;
}