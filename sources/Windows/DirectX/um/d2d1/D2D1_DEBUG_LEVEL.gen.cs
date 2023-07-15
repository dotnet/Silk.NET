// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_DEBUG_LEVEL.xml' path='doc/member[@name="D2D1_DEBUG_LEVEL"]/*'/>
public enum D2D1_DEBUG_LEVEL
{
    /// <include file='D2D1_DEBUG_LEVEL.xml' path='doc/member[@name="D2D1_DEBUG_LEVEL.D2D1_DEBUG_LEVEL_NONE"]/*'/>
    D2D1_DEBUG_LEVEL_NONE = 0,
    /// <include file='D2D1_DEBUG_LEVEL.xml' path='doc/member[@name="D2D1_DEBUG_LEVEL.D2D1_DEBUG_LEVEL_ERROR"]/*'/>
    D2D1_DEBUG_LEVEL_ERROR = 1,
    /// <include file='D2D1_DEBUG_LEVEL.xml' path='doc/member[@name="D2D1_DEBUG_LEVEL.D2D1_DEBUG_LEVEL_WARNING"]/*'/>
    D2D1_DEBUG_LEVEL_WARNING = 2,
    /// <include file='D2D1_DEBUG_LEVEL.xml' path='doc/member[@name="D2D1_DEBUG_LEVEL.D2D1_DEBUG_LEVEL_INFORMATION"]/*'/>
    D2D1_DEBUG_LEVEL_INFORMATION = 3,
    /// <include file='D2D1_DEBUG_LEVEL.xml' path='doc/member[@name="D2D1_DEBUG_LEVEL.D2D1_DEBUG_LEVEL_FORCE_DWORD"]/*'/>
    D2D1_DEBUG_LEVEL_FORCE_DWORD = unchecked((int)(0xffffffff)),
}