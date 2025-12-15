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
            RegistryReport? adapters = null,
            RegistryReport? devices = null,
            RegistryReport? queues = null,
            RegistryReport? pipelineLayouts = null,
            RegistryReport? shaderModules = null,
            RegistryReport? bindGroupLayouts = null,
            RegistryReport? bindGroups = null,
            RegistryReport? commandBuffers = null,
            RegistryReport? renderBundles = null,
            RegistryReport? renderPipelines = null,
            RegistryReport? computePipelines = null,
            RegistryReport? querySets = null,
            RegistryReport? buffers = null,
            RegistryReport? textures = null,
            RegistryReport? textureViews = null,
            RegistryReport? samplers = null
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

            if (queues is not null)
            {
                Queues = queues.Value;
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


        [NativeName("Type", "WGPURegistryReport")]
        [NativeName("Type.Name", "WGPURegistryReport")]
        [NativeName("Name", "adapters")]
        public RegistryReport Adapters;

        [NativeName("Type", "WGPURegistryReport")]
        [NativeName("Type.Name", "WGPURegistryReport")]
        [NativeName("Name", "devices")]
        public RegistryReport Devices;

        [NativeName("Type", "WGPURegistryReport")]
        [NativeName("Type.Name", "WGPURegistryReport")]
        [NativeName("Name", "queues")]
        public RegistryReport Queues;

        [NativeName("Type", "WGPURegistryReport")]
        [NativeName("Type.Name", "WGPURegistryReport")]
        [NativeName("Name", "pipelineLayouts")]
        public RegistryReport PipelineLayouts;

        [NativeName("Type", "WGPURegistryReport")]
        [NativeName("Type.Name", "WGPURegistryReport")]
        [NativeName("Name", "shaderModules")]
        public RegistryReport ShaderModules;

        [NativeName("Type", "WGPURegistryReport")]
        [NativeName("Type.Name", "WGPURegistryReport")]
        [NativeName("Name", "bindGroupLayouts")]
        public RegistryReport BindGroupLayouts;

        [NativeName("Type", "WGPURegistryReport")]
        [NativeName("Type.Name", "WGPURegistryReport")]
        [NativeName("Name", "bindGroups")]
        public RegistryReport BindGroups;

        [NativeName("Type", "WGPURegistryReport")]
        [NativeName("Type.Name", "WGPURegistryReport")]
        [NativeName("Name", "commandBuffers")]
        public RegistryReport CommandBuffers;

        [NativeName("Type", "WGPURegistryReport")]
        [NativeName("Type.Name", "WGPURegistryReport")]
        [NativeName("Name", "renderBundles")]
        public RegistryReport RenderBundles;

        [NativeName("Type", "WGPURegistryReport")]
        [NativeName("Type.Name", "WGPURegistryReport")]
        [NativeName("Name", "renderPipelines")]
        public RegistryReport RenderPipelines;

        [NativeName("Type", "WGPURegistryReport")]
        [NativeName("Type.Name", "WGPURegistryReport")]
        [NativeName("Name", "computePipelines")]
        public RegistryReport ComputePipelines;

        [NativeName("Type", "WGPURegistryReport")]
        [NativeName("Type.Name", "WGPURegistryReport")]
        [NativeName("Name", "querySets")]
        public RegistryReport QuerySets;

        [NativeName("Type", "WGPURegistryReport")]
        [NativeName("Type.Name", "WGPURegistryReport")]
        [NativeName("Name", "buffers")]
        public RegistryReport Buffers;

        [NativeName("Type", "WGPURegistryReport")]
        [NativeName("Type.Name", "WGPURegistryReport")]
        [NativeName("Name", "textures")]
        public RegistryReport Textures;

        [NativeName("Type", "WGPURegistryReport")]
        [NativeName("Type.Name", "WGPURegistryReport")]
        [NativeName("Name", "textureViews")]
        public RegistryReport TextureViews;

        [NativeName("Type", "WGPURegistryReport")]
        [NativeName("Type.Name", "WGPURegistryReport")]
        [NativeName("Name", "samplers")]
        public RegistryReport Samplers;
    }
}
