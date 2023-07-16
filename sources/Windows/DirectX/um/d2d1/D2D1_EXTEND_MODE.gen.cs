// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D2D1_EXTEND_MODE.xml' path='doc/member[@name="D2D1_EXTEND_MODE"]/*'/>
public enum D2D1_EXTEND_MODE
{
    /// <include file='D2D1_EXTEND_MODE.xml' path='doc/member[@name="D2D1_EXTEND_MODE.D2D1_EXTEND_MODE_CLAMP"]/*'/>
    D2D1_EXTEND_MODE_CLAMP = 0,
    /// <include file='D2D1_EXTEND_MODE.xml' path='doc/member[@name="D2D1_EXTEND_MODE.D2D1_EXTEND_MODE_WRAP"]/*'/>
    D2D1_EXTEND_MODE_WRAP = 1,
    /// <include file='D2D1_EXTEND_MODE.xml' path='doc/member[@name="D2D1_EXTEND_MODE.D2D1_EXTEND_MODE_MIRROR"]/*'/>
    D2D1_EXTEND_MODE_MIRROR = 2,
    /// <include file='D2D1_EXTEND_MODE.xml' path='doc/member[@name="D2D1_EXTEND_MODE.D2D1_EXTEND_MODE_FORCE_DWORD"]/*'/>
    D2D1_EXTEND_MODE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}