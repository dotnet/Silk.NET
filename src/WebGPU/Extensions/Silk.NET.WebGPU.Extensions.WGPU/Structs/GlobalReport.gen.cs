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
            HubReport? hub = null
        ) : this()
        {
            if (surfaces is not null)
            {
                Surfaces = surfaces.Value;
            }

            if (hub is not null)
            {
                Hub = hub.Value;
            }
        }


        [NativeName("Type", "WGPURegistryReport")]
        [NativeName("Type.Name", "WGPURegistryReport")]
        [NativeName("Name", "surfaces")]
        public RegistryReport Surfaces;

        [NativeName("Type", "WGPUHubReport")]
        [NativeName("Type.Name", "WGPUHubReport")]
        [NativeName("Name", "hub")]
        public HubReport Hub;
    }
}
