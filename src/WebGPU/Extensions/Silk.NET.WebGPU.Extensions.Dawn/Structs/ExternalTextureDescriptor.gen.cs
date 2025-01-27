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
    [NativeName("Name", "WGPUExternalTextureDescriptor")]
    public unsafe partial struct ExternalTextureDescriptor
    {
        public ExternalTextureDescriptor
        (
            ChainedStruct* nextInChain = null,
            byte* label = null,
            TextureView* plane0 = null,
            TextureView* plane1 = null,
            Origin2D? visibleOrigin = null,
            Extent2D? visibleSize = null,
            Silk.NET.Core.Bool32? doYuvToRgbConversionOnly = null,
            float* yuvToRgbConversionMatrix = null,
            float* srcTransferFunctionParameters = null,
            float* dstTransferFunctionParameters = null,
            float* gamutConversionMatrix = null,
            Silk.NET.Core.Bool32? mirrored = null,
            ExternalTextureRotation? rotation = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (label is not null)
            {
                Label = label;
            }

            if (plane0 is not null)
            {
                Plane0 = plane0;
            }

            if (plane1 is not null)
            {
                Plane1 = plane1;
            }

            if (visibleOrigin is not null)
            {
                VisibleOrigin = visibleOrigin.Value;
            }

            if (visibleSize is not null)
            {
                VisibleSize = visibleSize.Value;
            }

            if (doYuvToRgbConversionOnly is not null)
            {
                DoYuvToRgbConversionOnly = doYuvToRgbConversionOnly.Value;
            }

            if (yuvToRgbConversionMatrix is not null)
            {
                YuvToRgbConversionMatrix = yuvToRgbConversionMatrix;
            }

            if (srcTransferFunctionParameters is not null)
            {
                SrcTransferFunctionParameters = srcTransferFunctionParameters;
            }

            if (dstTransferFunctionParameters is not null)
            {
                DstTransferFunctionParameters = dstTransferFunctionParameters;
            }

            if (gamutConversionMatrix is not null)
            {
                GamutConversionMatrix = gamutConversionMatrix;
            }

            if (mirrored is not null)
            {
                Mirrored = mirrored.Value;
            }

            if (rotation is not null)
            {
                Rotation = rotation.Value;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "label")]
        public byte* Label;

        [NativeName("Type", "WGPUTextureView")]
        [NativeName("Type.Name", "WGPUTextureView")]
        [NativeName("Name", "plane0")]
        public TextureView* Plane0;

        [NativeName("Type", "WGPUTextureView")]
        [NativeName("Type.Name", "WGPUTextureView")]
        [NativeName("Name", "plane1")]
        public TextureView* Plane1;

        [NativeName("Type", "WGPUOrigin2D")]
        [NativeName("Type.Name", "WGPUOrigin2D")]
        [NativeName("Name", "visibleOrigin")]
        public Origin2D VisibleOrigin;

        [NativeName("Type", "WGPUExtent2D")]
        [NativeName("Type.Name", "WGPUExtent2D")]
        [NativeName("Name", "visibleSize")]
        public Extent2D VisibleSize;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "doYuvToRgbConversionOnly")]
        public Silk.NET.Core.Bool32 DoYuvToRgbConversionOnly;

        [NativeName("Type", "const float *")]
        [NativeName("Type.Name", "const float *")]
        [NativeName("Name", "yuvToRgbConversionMatrix")]
        public float* YuvToRgbConversionMatrix;

        [NativeName("Type", "const float *")]
        [NativeName("Type.Name", "const float *")]
        [NativeName("Name", "srcTransferFunctionParameters")]
        public float* SrcTransferFunctionParameters;

        [NativeName("Type", "const float *")]
        [NativeName("Type.Name", "const float *")]
        [NativeName("Name", "dstTransferFunctionParameters")]
        public float* DstTransferFunctionParameters;

        [NativeName("Type", "const float *")]
        [NativeName("Type.Name", "const float *")]
        [NativeName("Name", "gamutConversionMatrix")]
        public float* GamutConversionMatrix;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "mirrored")]
        public Silk.NET.Core.Bool32 Mirrored;

        [NativeName("Type", "WGPUExternalTextureRotation")]
        [NativeName("Type.Name", "WGPUExternalTextureRotation")]
        [NativeName("Name", "rotation")]
        public ExternalTextureRotation Rotation;
    }
}
