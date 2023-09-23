// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPULimits")]
    public unsafe partial struct Limits
    {
        public Limits
        (
            uint? maxTextureDimension1D = null,
            uint? maxTextureDimension2D = null,
            uint? maxTextureDimension3D = null,
            uint? maxTextureArrayLayers = null,
            uint? maxBindGroups = null,
            uint? maxBindGroupsPlusVertexBuffers = null,
            uint? maxBindingsPerBindGroup = null,
            uint? maxDynamicUniformBuffersPerPipelineLayout = null,
            uint? maxDynamicStorageBuffersPerPipelineLayout = null,
            uint? maxSampledTexturesPerShaderStage = null,
            uint? maxSamplersPerShaderStage = null,
            uint? maxStorageBuffersPerShaderStage = null,
            uint? maxStorageTexturesPerShaderStage = null,
            uint? maxUniformBuffersPerShaderStage = null,
            ulong? maxUniformBufferBindingSize = null,
            ulong? maxStorageBufferBindingSize = null,
            uint? minUniformBufferOffsetAlignment = null,
            uint? minStorageBufferOffsetAlignment = null,
            uint? maxVertexBuffers = null,
            ulong? maxBufferSize = null,
            uint? maxVertexAttributes = null,
            uint? maxVertexBufferArrayStride = null,
            uint? maxInterStageShaderComponents = null,
            uint? maxInterStageShaderVariables = null,
            uint? maxColorAttachments = null,
            uint? maxColorAttachmentBytesPerSample = null,
            uint? maxComputeWorkgroupStorageSize = null,
            uint? maxComputeInvocationsPerWorkgroup = null,
            uint? maxComputeWorkgroupSizeX = null,
            uint? maxComputeWorkgroupSizeY = null,
            uint? maxComputeWorkgroupSizeZ = null,
            uint? maxComputeWorkgroupsPerDimension = null
        ) : this()
        {
            if (maxTextureDimension1D is not null)
            {
                MaxTextureDimension1D = maxTextureDimension1D.Value;
            }

            if (maxTextureDimension2D is not null)
            {
                MaxTextureDimension2D = maxTextureDimension2D.Value;
            }

            if (maxTextureDimension3D is not null)
            {
                MaxTextureDimension3D = maxTextureDimension3D.Value;
            }

            if (maxTextureArrayLayers is not null)
            {
                MaxTextureArrayLayers = maxTextureArrayLayers.Value;
            }

            if (maxBindGroups is not null)
            {
                MaxBindGroups = maxBindGroups.Value;
            }

            if (maxBindGroupsPlusVertexBuffers is not null)
            {
                MaxBindGroupsPlusVertexBuffers = maxBindGroupsPlusVertexBuffers.Value;
            }

            if (maxBindingsPerBindGroup is not null)
            {
                MaxBindingsPerBindGroup = maxBindingsPerBindGroup.Value;
            }

            if (maxDynamicUniformBuffersPerPipelineLayout is not null)
            {
                MaxDynamicUniformBuffersPerPipelineLayout = maxDynamicUniformBuffersPerPipelineLayout.Value;
            }

            if (maxDynamicStorageBuffersPerPipelineLayout is not null)
            {
                MaxDynamicStorageBuffersPerPipelineLayout = maxDynamicStorageBuffersPerPipelineLayout.Value;
            }

            if (maxSampledTexturesPerShaderStage is not null)
            {
                MaxSampledTexturesPerShaderStage = maxSampledTexturesPerShaderStage.Value;
            }

            if (maxSamplersPerShaderStage is not null)
            {
                MaxSamplersPerShaderStage = maxSamplersPerShaderStage.Value;
            }

            if (maxStorageBuffersPerShaderStage is not null)
            {
                MaxStorageBuffersPerShaderStage = maxStorageBuffersPerShaderStage.Value;
            }

            if (maxStorageTexturesPerShaderStage is not null)
            {
                MaxStorageTexturesPerShaderStage = maxStorageTexturesPerShaderStage.Value;
            }

            if (maxUniformBuffersPerShaderStage is not null)
            {
                MaxUniformBuffersPerShaderStage = maxUniformBuffersPerShaderStage.Value;
            }

            if (maxUniformBufferBindingSize is not null)
            {
                MaxUniformBufferBindingSize = maxUniformBufferBindingSize.Value;
            }

            if (maxStorageBufferBindingSize is not null)
            {
                MaxStorageBufferBindingSize = maxStorageBufferBindingSize.Value;
            }

            if (minUniformBufferOffsetAlignment is not null)
            {
                MinUniformBufferOffsetAlignment = minUniformBufferOffsetAlignment.Value;
            }

            if (minStorageBufferOffsetAlignment is not null)
            {
                MinStorageBufferOffsetAlignment = minStorageBufferOffsetAlignment.Value;
            }

            if (maxVertexBuffers is not null)
            {
                MaxVertexBuffers = maxVertexBuffers.Value;
            }

            if (maxBufferSize is not null)
            {
                MaxBufferSize = maxBufferSize.Value;
            }

            if (maxVertexAttributes is not null)
            {
                MaxVertexAttributes = maxVertexAttributes.Value;
            }

            if (maxVertexBufferArrayStride is not null)
            {
                MaxVertexBufferArrayStride = maxVertexBufferArrayStride.Value;
            }

            if (maxInterStageShaderComponents is not null)
            {
                MaxInterStageShaderComponents = maxInterStageShaderComponents.Value;
            }

            if (maxInterStageShaderVariables is not null)
            {
                MaxInterStageShaderVariables = maxInterStageShaderVariables.Value;
            }

            if (maxColorAttachments is not null)
            {
                MaxColorAttachments = maxColorAttachments.Value;
            }

            if (maxColorAttachmentBytesPerSample is not null)
            {
                MaxColorAttachmentBytesPerSample = maxColorAttachmentBytesPerSample.Value;
            }

            if (maxComputeWorkgroupStorageSize is not null)
            {
                MaxComputeWorkgroupStorageSize = maxComputeWorkgroupStorageSize.Value;
            }

            if (maxComputeInvocationsPerWorkgroup is not null)
            {
                MaxComputeInvocationsPerWorkgroup = maxComputeInvocationsPerWorkgroup.Value;
            }

            if (maxComputeWorkgroupSizeX is not null)
            {
                MaxComputeWorkgroupSizeX = maxComputeWorkgroupSizeX.Value;
            }

            if (maxComputeWorkgroupSizeY is not null)
            {
                MaxComputeWorkgroupSizeY = maxComputeWorkgroupSizeY.Value;
            }

            if (maxComputeWorkgroupSizeZ is not null)
            {
                MaxComputeWorkgroupSizeZ = maxComputeWorkgroupSizeZ.Value;
            }

            if (maxComputeWorkgroupsPerDimension is not null)
            {
                MaxComputeWorkgroupsPerDimension = maxComputeWorkgroupsPerDimension.Value;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTextureDimension1D")]
        public uint MaxTextureDimension1D;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTextureDimension2D")]
        public uint MaxTextureDimension2D;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTextureDimension3D")]
        public uint MaxTextureDimension3D;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTextureArrayLayers")]
        public uint MaxTextureArrayLayers;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxBindGroups")]
        public uint MaxBindGroups;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxBindGroupsPlusVertexBuffers")]
        public uint MaxBindGroupsPlusVertexBuffers;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxBindingsPerBindGroup")]
        public uint MaxBindingsPerBindGroup;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDynamicUniformBuffersPerPipelineLayout")]
        public uint MaxDynamicUniformBuffersPerPipelineLayout;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDynamicStorageBuffersPerPipelineLayout")]
        public uint MaxDynamicStorageBuffersPerPipelineLayout;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxSampledTexturesPerShaderStage")]
        public uint MaxSampledTexturesPerShaderStage;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxSamplersPerShaderStage")]
        public uint MaxSamplersPerShaderStage;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxStorageBuffersPerShaderStage")]
        public uint MaxStorageBuffersPerShaderStage;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxStorageTexturesPerShaderStage")]
        public uint MaxStorageTexturesPerShaderStage;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxUniformBuffersPerShaderStage")]
        public uint MaxUniformBuffersPerShaderStage;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "maxUniformBufferBindingSize")]
        public ulong MaxUniformBufferBindingSize;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "maxStorageBufferBindingSize")]
        public ulong MaxStorageBufferBindingSize;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minUniformBufferOffsetAlignment")]
        public uint MinUniformBufferOffsetAlignment;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minStorageBufferOffsetAlignment")]
        public uint MinStorageBufferOffsetAlignment;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxVertexBuffers")]
        public uint MaxVertexBuffers;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "maxBufferSize")]
        public ulong MaxBufferSize;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxVertexAttributes")]
        public uint MaxVertexAttributes;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxVertexBufferArrayStride")]
        public uint MaxVertexBufferArrayStride;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxInterStageShaderComponents")]
        public uint MaxInterStageShaderComponents;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxInterStageShaderVariables")]
        public uint MaxInterStageShaderVariables;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxColorAttachments")]
        public uint MaxColorAttachments;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxColorAttachmentBytesPerSample")]
        public uint MaxColorAttachmentBytesPerSample;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxComputeWorkgroupStorageSize")]
        public uint MaxComputeWorkgroupStorageSize;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxComputeInvocationsPerWorkgroup")]
        public uint MaxComputeInvocationsPerWorkgroup;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxComputeWorkgroupSizeX")]
        public uint MaxComputeWorkgroupSizeX;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxComputeWorkgroupSizeY")]
        public uint MaxComputeWorkgroupSizeY;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxComputeWorkgroupSizeZ")]
        public uint MaxComputeWorkgroupSizeZ;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxComputeWorkgroupsPerDimension")]
        public uint MaxComputeWorkgroupsPerDimension;
    }
}
