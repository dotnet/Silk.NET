// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_TEXT_ANTIALIAS_MODE.xml' path='doc/member[@name="D2D1_TEXT_ANTIALIAS_MODE"]/*'/>
public enum D2D1_TEXT_ANTIALIAS_MODE
{
    /// <include file='D2D1_TEXT_ANTIALIAS_MODE.xml' path='doc/member[@name="D2D1_TEXT_ANTIALIAS_MODE.D2D1_TEXT_ANTIALIAS_MODE_DEFAULT"]/*'/>
    D2D1_TEXT_ANTIALIAS_MODE_DEFAULT = 0,
    /// <include file='D2D1_TEXT_ANTIALIAS_MODE.xml' path='doc/member[@name="D2D1_TEXT_ANTIALIAS_MODE.D2D1_TEXT_ANTIALIAS_MODE_CLEARTYPE"]/*'/>
    D2D1_TEXT_ANTIALIAS_MODE_CLEARTYPE = 1,
    /// <include file='D2D1_TEXT_ANTIALIAS_MODE.xml' path='doc/member[@name="D2D1_TEXT_ANTIALIAS_MODE.D2D1_TEXT_ANTIALIAS_MODE_GRAYSCALE"]/*'/>
    D2D1_TEXT_ANTIALIAS_MODE_GRAYSCALE = 2,
    /// <include file='D2D1_TEXT_ANTIALIAS_MODE.xml' path='doc/member[@name="D2D1_TEXT_ANTIALIAS_MODE.D2D1_TEXT_ANTIALIAS_MODE_ALIASED"]/*'/>
    D2D1_TEXT_ANTIALIAS_MODE_ALIASED = 3,
    /// <include file='D2D1_TEXT_ANTIALIAS_MODE.xml' path='doc/member[@name="D2D1_TEXT_ANTIALIAS_MODE.D2D1_TEXT_ANTIALIAS_MODE_FORCE_DWORD"]/*'/>
    D2D1_TEXT_ANTIALIAS_MODE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}