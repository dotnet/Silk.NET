// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WGLSWAP.xml' path='doc/member[@name="WGLSWAP"]/*'/>
public partial struct WGLSWAP
{
    /// <include file='WGLSWAP.xml' path='doc/member[@name="WGLSWAP.hdc"]/*'/>
    public HDC hdc;
    /// <include file='WGLSWAP.xml' path='doc/member[@name="WGLSWAP.uiFlags"]/*'/>
    public uint uiFlags;
}