// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DXGI_ALPHA_MODE.xml' path='doc/member[@name="DXGI_ALPHA_MODE"]/*'/>
public enum DXGI_ALPHA_MODE
{
    /// <include file='DXGI_ALPHA_MODE.xml' path='doc/member[@name="DXGI_ALPHA_MODE.DXGI_ALPHA_MODE_UNSPECIFIED"]/*'/>
    DXGI_ALPHA_MODE_UNSPECIFIED = 0,
    /// <include file='DXGI_ALPHA_MODE.xml' path='doc/member[@name="DXGI_ALPHA_MODE.DXGI_ALPHA_MODE_PREMULTIPLIED"]/*'/>
    DXGI_ALPHA_MODE_PREMULTIPLIED = 1,
    /// <include file='DXGI_ALPHA_MODE.xml' path='doc/member[@name="DXGI_ALPHA_MODE.DXGI_ALPHA_MODE_STRAIGHT"]/*'/>
    DXGI_ALPHA_MODE_STRAIGHT = 2,
    /// <include file='DXGI_ALPHA_MODE.xml' path='doc/member[@name="DXGI_ALPHA_MODE.DXGI_ALPHA_MODE_IGNORE"]/*'/>
    DXGI_ALPHA_MODE_IGNORE = 3,
    /// <include file='DXGI_ALPHA_MODE.xml' path='doc/member[@name="DXGI_ALPHA_MODE.DXGI_ALPHA_MODE_FORCE_DWORD"]/*'/>
    DXGI_ALPHA_MODE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}