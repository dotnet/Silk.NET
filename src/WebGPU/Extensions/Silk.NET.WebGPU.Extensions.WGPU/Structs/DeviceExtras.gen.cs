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
    [NativeName("Name", "WGPUDeviceExtras")]
    public unsafe partial struct DeviceExtras
    {
        public DeviceExtras
        (
            ChainedStruct? chain = null,
            uint? maxTextureDimension1D = null,
            uint? maxTextureDimension2D = null,
            uint? maxTextureDimension3D = null,
            uint? maxTextureArrayLayers = null,
            uint? maxBindGroups = null,
            uint? maxDynamicStorageBuffersPerPipelineLayout = null,
            uint? maxStorageBuffersPerShaderStage = null,
            uint? maxStorageBufferBindingSize = null,
            NativeFeature? nativeFeatures = null,
            byte* label = null,
            byte* tracePath = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

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

            if (maxDynamicStorageBuffersPerPipelineLayout is not null)
            {
                MaxDynamicStorageBuffersPerPipelineLayout = maxDynamicStorageBuffersPerPipelineLayout.Value;
            }

            if (maxStorageBuffersPerShaderStage is not null)
            {
                MaxStorageBuffersPerShaderStage = maxStorageBuffersPerShaderStage.Value;
            }

            if (maxStorageBufferBindingSize is not null)
            {
                MaxStorageBufferBindingSize = maxStorageBufferBindingSize.Value;
            }

            if (nativeFeatures is not null)
            {
                NativeFeatures = nativeFeatures.Value;
            }

            if (label is not null)
            {
                Label = label;
            }

            if (tracePath is not null)
            {
                TracePath = tracePath;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

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
        [NativeName("Name", "maxDynamicStorageBuffersPerPipelineLayout")]
        public uint MaxDynamicStorageBuffersPerPipelineLayout;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxStorageBuffersPerShaderStage")]
        public uint MaxStorageBuffersPerShaderStage;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxStorageBufferBindingSize")]
        public uint MaxStorageBufferBindingSize;

        [NativeName("Type", "WGPUNativeFeature")]
        [NativeName("Type.Name", "WGPUNativeFeature")]
        [NativeName("Name", "nativeFeatures")]
        public NativeFeature NativeFeatures;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "label")]
        public byte* Label;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "tracePath")]
        public byte* TracePath;
    }
}
