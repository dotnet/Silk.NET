// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D11_AUTHENTICATED_CHANNEL_TYPE.xml' path='doc/member[@name="D3D11_AUTHENTICATED_CHANNEL_TYPE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum D3D11_AUTHENTICATED_CHANNEL_TYPE
{
    /// <include file='D3D11_AUTHENTICATED_CHANNEL_TYPE.xml' path='doc/member[@name="D3D11_AUTHENTICATED_CHANNEL_TYPE.D3D11_AUTHENTICATED_CHANNEL_D3D11"]/*'/>
    D3D11_AUTHENTICATED_CHANNEL_D3D11 = 1,
    /// <include file='D3D11_AUTHENTICATED_CHANNEL_TYPE.xml' path='doc/member[@name="D3D11_AUTHENTICATED_CHANNEL_TYPE.D3D11_AUTHENTICATED_CHANNEL_DRIVER_SOFTWARE"]/*'/>
    D3D11_AUTHENTICATED_CHANNEL_DRIVER_SOFTWARE = 2,
    /// <include file='D3D11_AUTHENTICATED_CHANNEL_TYPE.xml' path='doc/member[@name="D3D11_AUTHENTICATED_CHANNEL_TYPE.D3D11_AUTHENTICATED_CHANNEL_DRIVER_HARDWARE"]/*'/>
    D3D11_AUTHENTICATED_CHANNEL_DRIVER_HARDWARE = 3,
}