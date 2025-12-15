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
    [NativeName("Name", "WGPUAdapterInfo")]
    public unsafe partial struct AdapterInfo
    {
        public AdapterInfo
        (
            byte* vendor = null,
            byte* architecture = null,
            byte* device = null,
            byte* description = null
        ) : this()
        {
            if (vendor is not null)
            {
                Vendor = vendor;
            }

            if (architecture is not null)
            {
                Architecture = architecture;
            }

            if (device is not null)
            {
                Device = device;
            }

            if (description is not null)
            {
                Description = description;
            }
        }


        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "vendor")]
        public byte* Vendor;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "architecture")]
        public byte* Architecture;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "device")]
        public byte* Device;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "description")]
        public byte* Description;
    }
}
