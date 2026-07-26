// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_SHADER_VERSION_TYPE")]
    public enum ShaderVersionType : int
    {
        [Obsolete("Deprecated in favour of \"PixelShader\"")]
        [NativeName("Name", "D3D12_SHVER_PIXEL_SHADER")]
        ShverPixelShader = 0x0,
        [Obsolete("Deprecated in favour of \"VertexShader\"")]
        [NativeName("Name", "D3D12_SHVER_VERTEX_SHADER")]
        ShverVertexShader = 0x1,
        [Obsolete("Deprecated in favour of \"GeometryShader\"")]
        [NativeName("Name", "D3D12_SHVER_GEOMETRY_SHADER")]
        ShverGeometryShader = 0x2,
        [Obsolete("Deprecated in favour of \"HullShader\"")]
        [NativeName("Name", "D3D12_SHVER_HULL_SHADER")]
        ShverHullShader = 0x3,
        [Obsolete("Deprecated in favour of \"DomainShader\"")]
        [NativeName("Name", "D3D12_SHVER_DOMAIN_SHADER")]
        ShverDomainShader = 0x4,
        [Obsolete("Deprecated in favour of \"ComputeShader\"")]
        [NativeName("Name", "D3D12_SHVER_COMPUTE_SHADER")]
        ShverComputeShader = 0x5,
        [Obsolete("Deprecated in favour of \"Library\"")]
        [NativeName("Name", "D3D12_SHVER_LIBRARY")]
        ShverLibrary = 0x6,
        [Obsolete("Deprecated in favour of \"RayGenerationShader\"")]
        [NativeName("Name", "D3D12_SHVER_RAY_GENERATION_SHADER")]
        ShverRayGenerationShader = 0x7,
        [Obsolete("Deprecated in favour of \"IntersectionShader\"")]
        [NativeName("Name", "D3D12_SHVER_INTERSECTION_SHADER")]
        ShverIntersectionShader = 0x8,
        [Obsolete("Deprecated in favour of \"AnyHitShader\"")]
        [NativeName("Name", "D3D12_SHVER_ANY_HIT_SHADER")]
        ShverAnyHitShader = 0x9,
        [Obsolete("Deprecated in favour of \"ClosestHitShader\"")]
        [NativeName("Name", "D3D12_SHVER_CLOSEST_HIT_SHADER")]
        ShverClosestHitShader = 0xA,
        [Obsolete("Deprecated in favour of \"MissShader\"")]
        [NativeName("Name", "D3D12_SHVER_MISS_SHADER")]
        ShverMissShader = 0xB,
        [Obsolete("Deprecated in favour of \"CallableShader\"")]
        [NativeName("Name", "D3D12_SHVER_CALLABLE_SHADER")]
        ShverCallableShader = 0xC,
        [Obsolete("Deprecated in favour of \"MeshShader\"")]
        [NativeName("Name", "D3D12_SHVER_MESH_SHADER")]
        ShverMeshShader = 0xD,
        [Obsolete("Deprecated in favour of \"AmplificationShader\"")]
        [NativeName("Name", "D3D12_SHVER_AMPLIFICATION_SHADER")]
        ShverAmplificationShader = 0xE,
        [Obsolete("Deprecated in favour of \"NodeShader\"")]
        [NativeName("Name", "D3D12_SHVER_NODE_SHADER")]
        ShverNodeShader = 0xF,
        [Obsolete("Deprecated in favour of \"Reserved0\"")]
        [NativeName("Name", "D3D12_SHVER_RESERVED0")]
        ShverReserved0 = 0xFFF0,
        [NativeName("Name", "D3D12_SHVER_PIXEL_SHADER")]
        PixelShader = 0x0,
        [NativeName("Name", "D3D12_SHVER_VERTEX_SHADER")]
        VertexShader = 0x1,
        [NativeName("Name", "D3D12_SHVER_GEOMETRY_SHADER")]
        GeometryShader = 0x2,
        [NativeName("Name", "D3D12_SHVER_HULL_SHADER")]
        HullShader = 0x3,
        [NativeName("Name", "D3D12_SHVER_DOMAIN_SHADER")]
        DomainShader = 0x4,
        [NativeName("Name", "D3D12_SHVER_COMPUTE_SHADER")]
        ComputeShader = 0x5,
        [NativeName("Name", "D3D12_SHVER_LIBRARY")]
        Library = 0x6,
        [NativeName("Name", "D3D12_SHVER_RAY_GENERATION_SHADER")]
        RayGenerationShader = 0x7,
        [NativeName("Name", "D3D12_SHVER_INTERSECTION_SHADER")]
        IntersectionShader = 0x8,
        [NativeName("Name", "D3D12_SHVER_ANY_HIT_SHADER")]
        AnyHitShader = 0x9,
        [NativeName("Name", "D3D12_SHVER_CLOSEST_HIT_SHADER")]
        ClosestHitShader = 0xA,
        [NativeName("Name", "D3D12_SHVER_MISS_SHADER")]
        MissShader = 0xB,
        [NativeName("Name", "D3D12_SHVER_CALLABLE_SHADER")]
        CallableShader = 0xC,
        [NativeName("Name", "D3D12_SHVER_MESH_SHADER")]
        MeshShader = 0xD,
        [NativeName("Name", "D3D12_SHVER_AMPLIFICATION_SHADER")]
        AmplificationShader = 0xE,
        [NativeName("Name", "D3D12_SHVER_NODE_SHADER")]
        NodeShader = 0xF,
        [NativeName("Name", "D3D12_SHVER_RESERVED0")]
        Reserved0 = 0xFFF0,
    }
}
