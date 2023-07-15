// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_SVG_ASPECT_SCALING.xml' path='doc/member[@name="D2D1_SVG_ASPECT_SCALING"]/*'/>
public enum D2D1_SVG_ASPECT_SCALING
{
    /// <include file='D2D1_SVG_ASPECT_SCALING.xml' path='doc/member[@name="D2D1_SVG_ASPECT_SCALING.D2D1_SVG_ASPECT_SCALING_MEET"]/*'/>
    D2D1_SVG_ASPECT_SCALING_MEET = 0,
    /// <include file='D2D1_SVG_ASPECT_SCALING.xml' path='doc/member[@name="D2D1_SVG_ASPECT_SCALING.D2D1_SVG_ASPECT_SCALING_SLICE"]/*'/>
    D2D1_SVG_ASPECT_SCALING_SLICE = 1,
    /// <include file='D2D1_SVG_ASPECT_SCALING.xml' path='doc/member[@name="D2D1_SVG_ASPECT_SCALING.D2D1_SVG_ASPECT_SCALING_FORCE_DWORD"]/*'/>
    D2D1_SVG_ASPECT_SCALING_FORCE_DWORD = unchecked((int)(0xffffffff)),
}