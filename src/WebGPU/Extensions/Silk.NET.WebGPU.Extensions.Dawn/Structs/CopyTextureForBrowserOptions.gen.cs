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

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [NativeName("Name", "WGPUCopyTextureForBrowserOptions")]
    public unsafe partial struct CopyTextureForBrowserOptions
    {
        public CopyTextureForBrowserOptions
        (
            ChainedStruct* nextInChain = null,
            Silk.NET.Core.Bool32? flipY = null,
            Silk.NET.Core.Bool32? needsColorSpaceConversion = null,
            AlphaMode? srcAlphaMode = null,
            float* srcTransferFunctionParameters = null,
            float* conversionMatrix = null,
            float* dstTransferFunctionParameters = null,
            AlphaMode? dstAlphaMode = null,
            Silk.NET.Core.Bool32? internalUsage = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (flipY is not null)
            {
                FlipY = flipY.Value;
            }

            if (needsColorSpaceConversion is not null)
            {
                NeedsColorSpaceConversion = needsColorSpaceConversion.Value;
            }

            if (srcAlphaMode is not null)
            {
                SrcAlphaMode = srcAlphaMode.Value;
            }

            if (srcTransferFunctionParameters is not null)
            {
                SrcTransferFunctionParameters = srcTransferFunctionParameters;
            }

            if (conversionMatrix is not null)
            {
                ConversionMatrix = conversionMatrix;
            }

            if (dstTransferFunctionParameters is not null)
            {
                DstTransferFunctionParameters = dstTransferFunctionParameters;
            }

            if (dstAlphaMode is not null)
            {
                DstAlphaMode = dstAlphaMode.Value;
            }

            if (internalUsage is not null)
            {
                InternalUsage = internalUsage.Value;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "flipY")]
        public Silk.NET.Core.Bool32 FlipY;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "needsColorSpaceConversion")]
        public Silk.NET.Core.Bool32 NeedsColorSpaceConversion;

        [NativeName("Type", "WGPUAlphaMode")]
        [NativeName("Type.Name", "WGPUAlphaMode")]
        [NativeName("Name", "srcAlphaMode")]
        public AlphaMode SrcAlphaMode;

        [NativeName("Type", "const float *")]
        [NativeName("Type.Name", "const float *")]
        [NativeName("Name", "srcTransferFunctionParameters")]
        public float* SrcTransferFunctionParameters;

        [NativeName("Type", "const float *")]
        [NativeName("Type.Name", "const float *")]
        [NativeName("Name", "conversionMatrix")]
        public float* ConversionMatrix;

        [NativeName("Type", "const float *")]
        [NativeName("Type.Name", "const float *")]
        [NativeName("Name", "dstTransferFunctionParameters")]
        public float* DstTransferFunctionParameters;

        [NativeName("Type", "WGPUAlphaMode")]
        [NativeName("Type.Name", "WGPUAlphaMode")]
        [NativeName("Name", "dstAlphaMode")]
        public AlphaMode DstAlphaMode;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "internalUsage")]
        public Silk.NET.Core.Bool32 InternalUsage;
    }
}
