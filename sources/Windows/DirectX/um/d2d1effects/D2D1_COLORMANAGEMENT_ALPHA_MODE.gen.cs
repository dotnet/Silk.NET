// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_COLORMANAGEMENT_ALPHA_MODE.xml' path='doc/member[@name="D2D1_COLORMANAGEMENT_ALPHA_MODE"]/*'/>
public enum D2D1_COLORMANAGEMENT_ALPHA_MODE
{
    /// <include file='D2D1_COLORMANAGEMENT_ALPHA_MODE.xml' path='doc/member[@name="D2D1_COLORMANAGEMENT_ALPHA_MODE.D2D1_COLORMANAGEMENT_ALPHA_MODE_PREMULTIPLIED"]/*'/>
    D2D1_COLORMANAGEMENT_ALPHA_MODE_PREMULTIPLIED = 1,
    /// <include file='D2D1_COLORMANAGEMENT_ALPHA_MODE.xml' path='doc/member[@name="D2D1_COLORMANAGEMENT_ALPHA_MODE.D2D1_COLORMANAGEMENT_ALPHA_MODE_STRAIGHT"]/*'/>
    D2D1_COLORMANAGEMENT_ALPHA_MODE_STRAIGHT = 2,
    /// <include file='D2D1_COLORMANAGEMENT_ALPHA_MODE.xml' path='doc/member[@name="D2D1_COLORMANAGEMENT_ALPHA_MODE.D2D1_COLORMANAGEMENT_ALPHA_MODE_FORCE_DWORD"]/*'/>
    D2D1_COLORMANAGEMENT_ALPHA_MODE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}