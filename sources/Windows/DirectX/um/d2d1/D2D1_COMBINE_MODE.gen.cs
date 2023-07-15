// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_COMBINE_MODE.xml' path='doc/member[@name="D2D1_COMBINE_MODE"]/*'/>
public enum D2D1_COMBINE_MODE
{
    /// <include file='D2D1_COMBINE_MODE.xml' path='doc/member[@name="D2D1_COMBINE_MODE.D2D1_COMBINE_MODE_UNION"]/*'/>
    D2D1_COMBINE_MODE_UNION = 0,
    /// <include file='D2D1_COMBINE_MODE.xml' path='doc/member[@name="D2D1_COMBINE_MODE.D2D1_COMBINE_MODE_INTERSECT"]/*'/>
    D2D1_COMBINE_MODE_INTERSECT = 1,
    /// <include file='D2D1_COMBINE_MODE.xml' path='doc/member[@name="D2D1_COMBINE_MODE.D2D1_COMBINE_MODE_XOR"]/*'/>
    D2D1_COMBINE_MODE_XOR = 2,
    /// <include file='D2D1_COMBINE_MODE.xml' path='doc/member[@name="D2D1_COMBINE_MODE.D2D1_COMBINE_MODE_EXCLUDE"]/*'/>
    D2D1_COMBINE_MODE_EXCLUDE = 3,
    /// <include file='D2D1_COMBINE_MODE.xml' path='doc/member[@name="D2D1_COMBINE_MODE.D2D1_COMBINE_MODE_FORCE_DWORD"]/*'/>
    D2D1_COMBINE_MODE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}