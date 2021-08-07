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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPipelineCacheHeaderVersionOne")]
    public unsafe partial struct PipelineCacheHeaderVersionOne
    {
        public PipelineCacheHeaderVersionOne
        (
            uint? headerSize = null,
            PipelineCacheHeaderVersion? headerVersion = null,
            uint? vendorID = null,
            uint? deviceID = null
        ) : this()
        {
            if (headerSize is not null)
            {
                HeaderSize = headerSize.Value;
            }

            if (headerVersion is not null)
            {
                HeaderVersion = headerVersion.Value;
            }

            if (vendorID is not null)
            {
                VendorID = vendorID.Value;
            }

            if (deviceID is not null)
            {
                DeviceID = deviceID.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "headerSize")]
        public uint HeaderSize;
/// <summary></summary>
        [NativeName("Type", "VkPipelineCacheHeaderVersion")]
        [NativeName("Type.Name", "VkPipelineCacheHeaderVersion")]
        [NativeName("Name", "headerVersion")]
        public PipelineCacheHeaderVersion HeaderVersion;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vendorID")]
        public uint VendorID;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "deviceID")]
        public uint DeviceID;
        /// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "pipelineCacheUUID")]
        public fixed byte PipelineCacheUuid[16];
    }
}
