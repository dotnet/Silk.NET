// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10misc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D3D10_DRIVER_TYPE.xml' path='doc/member[@name="D3D10_DRIVER_TYPE"]/*'/>
public enum D3D10_DRIVER_TYPE
{
    /// <include file='D3D10_DRIVER_TYPE.xml' path='doc/member[@name="D3D10_DRIVER_TYPE.D3D10_DRIVER_TYPE_HARDWARE"]/*'/>
    D3D10_DRIVER_TYPE_HARDWARE = 0,
    /// <include file='D3D10_DRIVER_TYPE.xml' path='doc/member[@name="D3D10_DRIVER_TYPE.D3D10_DRIVER_TYPE_REFERENCE"]/*'/>
    D3D10_DRIVER_TYPE_REFERENCE = 1,
    /// <include file='D3D10_DRIVER_TYPE.xml' path='doc/member[@name="D3D10_DRIVER_TYPE.D3D10_DRIVER_TYPE_NULL"]/*'/>
    D3D10_DRIVER_TYPE_NULL = 2,
    /// <include file='D3D10_DRIVER_TYPE.xml' path='doc/member[@name="D3D10_DRIVER_TYPE.D3D10_DRIVER_TYPE_SOFTWARE"]/*'/>
    D3D10_DRIVER_TYPE_SOFTWARE = 3,
    /// <include file='D3D10_DRIVER_TYPE.xml' path='doc/member[@name="D3D10_DRIVER_TYPE.D3D10_DRIVER_TYPE_WARP"]/*'/>
    D3D10_DRIVER_TYPE_WARP = 5,
}