// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D3D10_CULL_MODE.xml' path='doc/member[@name="D3D10_CULL_MODE"]/*'/>
public enum D3D10_CULL_MODE
{
    /// <include file='D3D10_CULL_MODE.xml' path='doc/member[@name="D3D10_CULL_MODE.D3D10_CULL_NONE"]/*'/>
    D3D10_CULL_NONE = 1,
    /// <include file='D3D10_CULL_MODE.xml' path='doc/member[@name="D3D10_CULL_MODE.D3D10_CULL_FRONT"]/*'/>
    D3D10_CULL_FRONT = 2,
    /// <include file='D3D10_CULL_MODE.xml' path='doc/member[@name="D3D10_CULL_MODE.D3D10_CULL_BACK"]/*'/>
    D3D10_CULL_BACK = 3,
}