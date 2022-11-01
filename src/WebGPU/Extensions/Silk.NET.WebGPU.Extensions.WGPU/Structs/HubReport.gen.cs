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

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUHubReport")]
    public unsafe partial struct HubReport
    {
        public HubReport
        (
            StorageReport? adapters = null,
            StorageReport? devices = null,
            StorageReport? pipelineLayouts = null,
            StorageReport? shaderModules = null,
            StorageReport? bindGroupLayouts = null,
            StorageReport? bindGroups = null,
            StorageReport? commandBuffers = null,
            StorageReport? renderBundles = null,
            StorageReport? renderPipelines = null,
            StorageReport? computePipelines = null,
            StorageReport? querySets = null,
            StorageReport? buffers = null,
            StorageReport? textures = null,
            StorageReport? textureViews = null,
            StorageReport? samplers = null
        ) : this()
        {
            if (adapters is not null)
            {
                Adapters = adapters.Value;
            }

            if (devices is not null)
            {
                Devices = devices.Value;
            }

            if (pipelineLayouts is not null)
            {
                PipelineLayouts = pipelineLayouts.Value;
            }

            if (shaderModules is not null)
            {
                ShaderModules = shaderModules.Value;
            }

            if (bindGroupLayouts is not null)
            {
                BindGroupLayouts = bindGroupLayouts.Value;
            }

            if (bindGroups is not null)
            {
                BindGroups = bindGroups.Value;
            }

            if (commandBuffers is not null)
            {
                CommandBuffers = commandBuffers.Value;
            }

            if (renderBundles is not null)
            {
                RenderBundles = renderBundles.Value;
            }

            if (renderPipelines is not null)
            {
                RenderPipelines = renderPipelines.Value;
            }

            if (computePipelines is not null)
            {
                ComputePipelines = computePipelines.Value;
            }

            if (querySets is not null)
            {
                QuerySets = querySets.Value;
            }

            if (buffers is not null)
            {
                Buffers = buffers.Value;
            }

            if (textures is not null)
            {
                Textures = textures.Value;
            }

            if (textureViews is not null)
            {
                TextureViews = textureViews.Value;
            }

            if (samplers is not null)
            {
                Samplers = samplers.Value;
            }
        }


        [NativeName("Type", "WGPUStorageReport")]
        [NativeName("Type.Name", "WGPUStorageReport")]
        [NativeName("Name", "adapters")]
        public StorageReport Adapters;

        [NativeName("Type", "WGPUStorageReport")]
        [NativeName("Type.Name", "WGPUStorageReport")]
        [NativeName("Name", "devices")]
        public StorageReport Devices;

        [NativeName("Type", "WGPUStorageReport")]
        [NativeName("Type.Name", "WGPUStorageReport")]
        [NativeName("Name", "pipelineLayouts")]
        public StorageReport PipelineLayouts;

        [NativeName("Type", "WGPUStorageReport")]
        [NativeName("Type.Name", "WGPUStorageReport")]
        [NativeName("Name", "shaderModules")]
        public StorageReport ShaderModules;

        [NativeName("Type", "WGPUStorageReport")]
        [NativeName("Type.Name", "WGPUStorageReport")]
        [NativeName("Name", "bindGroupLayouts")]
        public StorageReport BindGroupLayouts;

        [NativeName("Type", "WGPUStorageReport")]
        [NativeName("Type.Name", "WGPUStorageReport")]
        [NativeName("Name", "bindGroups")]
        public StorageReport BindGroups;

        [NativeName("Type", "WGPUStorageReport")]
        [NativeName("Type.Name", "WGPUStorageReport")]
        [NativeName("Name", "commandBuffers")]
        public StorageReport CommandBuffers;

        [NativeName("Type", "WGPUStorageReport")]
        [NativeName("Type.Name", "WGPUStorageReport")]
        [NativeName("Name", "renderBundles")]
        public StorageReport RenderBundles;

        [NativeName("Type", "WGPUStorageReport")]
        [NativeName("Type.Name", "WGPUStorageReport")]
        [NativeName("Name", "renderPipelines")]
        public StorageReport RenderPipelines;

        [NativeName("Type", "WGPUStorageReport")]
        [NativeName("Type.Name", "WGPUStorageReport")]
        [NativeName("Name", "computePipelines")]
        public StorageReport ComputePipelines;

        [NativeName("Type", "WGPUStorageReport")]
        [NativeName("Type.Name", "WGPUStorageReport")]
        [NativeName("Name", "querySets")]
        public StorageReport QuerySets;

        [NativeName("Type", "WGPUStorageReport")]
        [NativeName("Type.Name", "WGPUStorageReport")]
        [NativeName("Name", "buffers")]
        public StorageReport Buffers;

        [NativeName("Type", "WGPUStorageReport")]
        [NativeName("Type.Name", "WGPUStorageReport")]
        [NativeName("Name", "textures")]
        public StorageReport Textures;

        [NativeName("Type", "WGPUStorageReport")]
        [NativeName("Type.Name", "WGPUStorageReport")]
        [NativeName("Name", "textureViews")]
        public StorageReport TextureViews;

        [NativeName("Type", "WGPUStorageReport")]
        [NativeName("Type.Name", "WGPUStorageReport")]
        [NativeName("Name", "samplers")]
        public StorageReport Samplers;
    }
}
