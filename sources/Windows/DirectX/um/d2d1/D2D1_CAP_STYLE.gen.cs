// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D2D1_CAP_STYLE.xml' path='doc/member[@name="D2D1_CAP_STYLE"]/*'/>
public enum D2D1_CAP_STYLE
{
    /// <include file='D2D1_CAP_STYLE.xml' path='doc/member[@name="D2D1_CAP_STYLE.D2D1_CAP_STYLE_FLAT"]/*'/>
    D2D1_CAP_STYLE_FLAT = 0,
    /// <include file='D2D1_CAP_STYLE.xml' path='doc/member[@name="D2D1_CAP_STYLE.D2D1_CAP_STYLE_SQUARE"]/*'/>
    D2D1_CAP_STYLE_SQUARE = 1,
    /// <include file='D2D1_CAP_STYLE.xml' path='doc/member[@name="D2D1_CAP_STYLE.D2D1_CAP_STYLE_ROUND"]/*'/>
    D2D1_CAP_STYLE_ROUND = 2,
    /// <include file='D2D1_CAP_STYLE.xml' path='doc/member[@name="D2D1_CAP_STYLE.D2D1_CAP_STYLE_TRIANGLE"]/*'/>
    D2D1_CAP_STYLE_TRIANGLE = 3,
    /// <include file='D2D1_CAP_STYLE.xml' path='doc/member[@name="D2D1_CAP_STYLE.D2D1_CAP_STYLE_FORCE_DWORD"]/*'/>
    D2D1_CAP_STYLE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}