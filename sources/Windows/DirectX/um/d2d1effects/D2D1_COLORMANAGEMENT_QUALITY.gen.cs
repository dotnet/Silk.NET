// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_COLORMANAGEMENT_QUALITY.xml' path='doc/member[@name="D2D1_COLORMANAGEMENT_QUALITY"]/*'/>
public enum D2D1_COLORMANAGEMENT_QUALITY
{
    /// <include file='D2D1_COLORMANAGEMENT_QUALITY.xml' path='doc/member[@name="D2D1_COLORMANAGEMENT_QUALITY.D2D1_COLORMANAGEMENT_QUALITY_PROOF"]/*'/>
    D2D1_COLORMANAGEMENT_QUALITY_PROOF = 0,
    /// <include file='D2D1_COLORMANAGEMENT_QUALITY.xml' path='doc/member[@name="D2D1_COLORMANAGEMENT_QUALITY.D2D1_COLORMANAGEMENT_QUALITY_NORMAL"]/*'/>
    D2D1_COLORMANAGEMENT_QUALITY_NORMAL = 1,
    /// <include file='D2D1_COLORMANAGEMENT_QUALITY.xml' path='doc/member[@name="D2D1_COLORMANAGEMENT_QUALITY.D2D1_COLORMANAGEMENT_QUALITY_BEST"]/*'/>
    D2D1_COLORMANAGEMENT_QUALITY_BEST = 2,
    /// <include file='D2D1_COLORMANAGEMENT_QUALITY.xml' path='doc/member[@name="D2D1_COLORMANAGEMENT_QUALITY.D2D1_COLORMANAGEMENT_QUALITY_FORCE_DWORD"]/*'/>
    D2D1_COLORMANAGEMENT_QUALITY_FORCE_DWORD = unchecked((int)(0xffffffff)),
}