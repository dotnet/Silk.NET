// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static TerraFX.Interop.DirectX.D2D1_INTERPOLATION_MODE_DEFINITION;

namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_BITMAP_INTERPOLATION_MODE.xml' path='doc/member[@name="D2D1_BITMAP_INTERPOLATION_MODE"]/*'/>
public enum D2D1_BITMAP_INTERPOLATION_MODE
{
    /// <include file='D2D1_BITMAP_INTERPOLATION_MODE.xml' path='doc/member[@name="D2D1_BITMAP_INTERPOLATION_MODE.D2D1_BITMAP_INTERPOLATION_MODE_NEAREST_NEIGHBOR"]/*'/>
    D2D1_BITMAP_INTERPOLATION_MODE_NEAREST_NEIGHBOR = D2D1_INTERPOLATION_MODE_DEFINITION_NEAREST_NEIGHBOR,
    /// <include file='D2D1_BITMAP_INTERPOLATION_MODE.xml' path='doc/member[@name="D2D1_BITMAP_INTERPOLATION_MODE.D2D1_BITMAP_INTERPOLATION_MODE_LINEAR"]/*'/>
    D2D1_BITMAP_INTERPOLATION_MODE_LINEAR = D2D1_INTERPOLATION_MODE_DEFINITION_LINEAR,
    /// <include file='D2D1_BITMAP_INTERPOLATION_MODE.xml' path='doc/member[@name="D2D1_BITMAP_INTERPOLATION_MODE.D2D1_BITMAP_INTERPOLATION_MODE_FORCE_DWORD"]/*'/>
    D2D1_BITMAP_INTERPOLATION_MODE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}