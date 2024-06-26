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
    [NativeName("Name", "WGPUGlobalReport")]
    public unsafe partial struct GlobalReport
    {
        public GlobalReport
        (
            RegistryReport? surfaces = null,
            BackendType? backendType = null,
            HubReport? vulkan = null,
            HubReport? metal = null,
            HubReport? dx12 = null,
            HubReport? gl = null
        ) : this()
        {
            if (surfaces is not null)
            {
                Surfaces = surfaces.Value;
            }

            if (backendType is not null)
            {
                BackendType = backendType.Value;
            }

            if (vulkan is not null)
            {
                Vulkan = vulkan.Value;
            }

            if (metal is not null)
            {
                Metal = metal.Value;
            }

            if (dx12 is not null)
            {
                Dx12 = dx12.Value;
            }

            if (gl is not null)
            {
                Gl = gl.Value;
            }
        }


        [NativeName("Type", "WGPURegistryReport")]
        [NativeName("Type.Name", "WGPURegistryReport")]
        [NativeName("Name", "surfaces")]
        public RegistryReport Surfaces;

        [NativeName("Type", "WGPUBackendType")]
        [NativeName("Type.Name", "WGPUBackendType")]
        [NativeName("Name", "backendType")]
        public BackendType BackendType;

        [NativeName("Type", "WGPUHubReport")]
        [NativeName("Type.Name", "WGPUHubReport")]
        [NativeName("Name", "vulkan")]
        public HubReport Vulkan;

        [NativeName("Type", "WGPUHubReport")]
        [NativeName("Type.Name", "WGPUHubReport")]
        [NativeName("Name", "metal")]
        public HubReport Metal;

        [NativeName("Type", "WGPUHubReport")]
        [NativeName("Type.Name", "WGPUHubReport")]
        [NativeName("Name", "dx12")]
        public HubReport Dx12;

        [NativeName("Type", "WGPUHubReport")]
        [NativeName("Type.Name", "WGPUHubReport")]
        [NativeName("Name", "gl")]
        public HubReport Gl;
    }
}
