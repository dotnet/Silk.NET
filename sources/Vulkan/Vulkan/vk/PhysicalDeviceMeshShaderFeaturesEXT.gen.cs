// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceMeshShaderFeaturesEXT")]
public unsafe partial struct PhysicalDeviceMeshShaderFeaturesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceMeshShaderFeaturesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("taskShader")]
    public MaybeBool<uint> TaskShader;

    [NativeName("meshShader")]
    public MaybeBool<uint> MeshShader;

    [NativeName("multiviewMeshShader")]
    public MaybeBool<uint> MultiviewMeshShader;

    [NativeName("primitiveFragmentShadingRateMeshShader")]
    public MaybeBool<uint> PrimitiveFragmentShadingRateMeshShader;

    [NativeName("meshShaderQueries")]
    public MaybeBool<uint> MeshShaderQueries;

    public PhysicalDeviceMeshShaderFeaturesEXT() { }
}
