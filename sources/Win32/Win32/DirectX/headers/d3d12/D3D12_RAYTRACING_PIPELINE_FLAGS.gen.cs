// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_RAYTRACING_PIPELINE_FLAGS.xml' path='doc/member[@name="D3D12_RAYTRACING_PIPELINE_FLAGS"]/*'/>
public enum D3D12_RAYTRACING_PIPELINE_FLAGS
{
    /// <include file='D3D12_RAYTRACING_PIPELINE_FLAGS.xml' path='doc/member[@name="D3D12_RAYTRACING_PIPELINE_FLAGS.D3D12_RAYTRACING_PIPELINE_FLAG_NONE"]/*'/>

    D3D12_RAYTRACING_PIPELINE_FLAG_NONE = 0,

    /// <include file='D3D12_RAYTRACING_PIPELINE_FLAGS.xml' path='doc/member[@name="D3D12_RAYTRACING_PIPELINE_FLAGS.D3D12_RAYTRACING_PIPELINE_FLAG_SKIP_TRIANGLES"]/*'/>

    D3D12_RAYTRACING_PIPELINE_FLAG_SKIP_TRIANGLES = 0x100,

    /// <include file='D3D12_RAYTRACING_PIPELINE_FLAGS.xml' path='doc/member[@name="D3D12_RAYTRACING_PIPELINE_FLAGS.D3D12_RAYTRACING_PIPELINE_FLAG_SKIP_PROCEDURAL_PRIMITIVES"]/*'/>

    D3D12_RAYTRACING_PIPELINE_FLAG_SKIP_PROCEDURAL_PRIMITIVES = 0x200,
}
