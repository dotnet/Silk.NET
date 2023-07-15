// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_RENDER_TARGET_TYPE.xml' path='doc/member[@name="D2D1_RENDER_TARGET_TYPE"]/*'/>
public enum D2D1_RENDER_TARGET_TYPE
{
    /// <include file='D2D1_RENDER_TARGET_TYPE.xml' path='doc/member[@name="D2D1_RENDER_TARGET_TYPE.D2D1_RENDER_TARGET_TYPE_DEFAULT"]/*'/>
    D2D1_RENDER_TARGET_TYPE_DEFAULT = 0,
    /// <include file='D2D1_RENDER_TARGET_TYPE.xml' path='doc/member[@name="D2D1_RENDER_TARGET_TYPE.D2D1_RENDER_TARGET_TYPE_SOFTWARE"]/*'/>
    D2D1_RENDER_TARGET_TYPE_SOFTWARE = 1,
    /// <include file='D2D1_RENDER_TARGET_TYPE.xml' path='doc/member[@name="D2D1_RENDER_TARGET_TYPE.D2D1_RENDER_TARGET_TYPE_HARDWARE"]/*'/>
    D2D1_RENDER_TARGET_TYPE_HARDWARE = 2,
    /// <include file='D2D1_RENDER_TARGET_TYPE.xml' path='doc/member[@name="D2D1_RENDER_TARGET_TYPE.D2D1_RENDER_TARGET_TYPE_FORCE_DWORD"]/*'/>
    D2D1_RENDER_TARGET_TYPE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}