// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static TerraFX.Interop.DirectX.D3D_FEATURE_LEVEL;

namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_FEATURE_LEVEL.xml' path='doc/member[@name="D2D1_FEATURE_LEVEL"]/*'/>
public enum D2D1_FEATURE_LEVEL
{
    /// <include file='D2D1_FEATURE_LEVEL.xml' path='doc/member[@name="D2D1_FEATURE_LEVEL.D2D1_FEATURE_LEVEL_DEFAULT"]/*'/>
    D2D1_FEATURE_LEVEL_DEFAULT = 0,
    /// <include file='D2D1_FEATURE_LEVEL.xml' path='doc/member[@name="D2D1_FEATURE_LEVEL.D2D1_FEATURE_LEVEL_9"]/*'/>
    D2D1_FEATURE_LEVEL_9 = D3D_FEATURE_LEVEL_9_1,
    /// <include file='D2D1_FEATURE_LEVEL.xml' path='doc/member[@name="D2D1_FEATURE_LEVEL.D2D1_FEATURE_LEVEL_10"]/*'/>
    D2D1_FEATURE_LEVEL_10 = D3D_FEATURE_LEVEL_10_0,
    /// <include file='D2D1_FEATURE_LEVEL.xml' path='doc/member[@name="D2D1_FEATURE_LEVEL.D2D1_FEATURE_LEVEL_FORCE_DWORD"]/*'/>
    D2D1_FEATURE_LEVEL_FORCE_DWORD = unchecked((int)(0xffffffff)),
}