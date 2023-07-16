// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D3D11_CONTEXT_TYPE.xml' path='doc/member[@name="D3D11_CONTEXT_TYPE"]/*'/>
public enum D3D11_CONTEXT_TYPE
{
    /// <include file='D3D11_CONTEXT_TYPE.xml' path='doc/member[@name="D3D11_CONTEXT_TYPE.D3D11_CONTEXT_TYPE_ALL"]/*'/>
    D3D11_CONTEXT_TYPE_ALL = 0,
    /// <include file='D3D11_CONTEXT_TYPE.xml' path='doc/member[@name="D3D11_CONTEXT_TYPE.D3D11_CONTEXT_TYPE_3D"]/*'/>
    D3D11_CONTEXT_TYPE_3D = 1,
    /// <include file='D3D11_CONTEXT_TYPE.xml' path='doc/member[@name="D3D11_CONTEXT_TYPE.D3D11_CONTEXT_TYPE_COMPUTE"]/*'/>
    D3D11_CONTEXT_TYPE_COMPUTE = 2,
    /// <include file='D3D11_CONTEXT_TYPE.xml' path='doc/member[@name="D3D11_CONTEXT_TYPE.D3D11_CONTEXT_TYPE_COPY"]/*'/>
    D3D11_CONTEXT_TYPE_COPY = 3,
    /// <include file='D3D11_CONTEXT_TYPE.xml' path='doc/member[@name="D3D11_CONTEXT_TYPE.D3D11_CONTEXT_TYPE_VIDEO"]/*'/>
    D3D11_CONTEXT_TYPE_VIDEO = 4,
}