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

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoAV1Quantization")]
    public unsafe partial struct StdVideoAV1Quantization
    {
        public StdVideoAV1Quantization
        (
            StdVideoAV1QuantizationFlags? flags = null,
            byte? baseQIdx = null,
            byte? deltaQYDc = null,
            byte? deltaQUDc = null,
            byte? deltaQUAc = null,
            byte? deltaQVDc = null,
            byte? deltaQVAc = null,
            byte? qmY = null,
            byte? qmU = null,
            byte? qmV = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (baseQIdx is not null)
            {
                BaseQIdx = baseQIdx.Value;
            }

            if (deltaQYDc is not null)
            {
                DeltaQYDc = deltaQYDc.Value;
            }

            if (deltaQUDc is not null)
            {
                DeltaQUDc = deltaQUDc.Value;
            }

            if (deltaQUAc is not null)
            {
                DeltaQUAc = deltaQUAc.Value;
            }

            if (deltaQVDc is not null)
            {
                DeltaQVDc = deltaQVDc.Value;
            }

            if (deltaQVAc is not null)
            {
                DeltaQVAc = deltaQVAc.Value;
            }

            if (qmY is not null)
            {
                QmY = qmY.Value;
            }

            if (qmU is not null)
            {
                QmU = qmU.Value;
            }

            if (qmV is not null)
            {
                QmV = qmV.Value;
            }
        }


        [NativeName("Type", "StdVideoAV1QuantizationFlags")]
        [NativeName("Type.Name", "StdVideoAV1QuantizationFlags")]
        [NativeName("Name", "flags")]
        public StdVideoAV1QuantizationFlags Flags;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "base_q_idx")]
        public byte BaseQIdx;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "DeltaQYDc")]
        public byte DeltaQYDc;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "DeltaQUDc")]
        public byte DeltaQUDc;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "DeltaQUAc")]
        public byte DeltaQUAc;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "DeltaQVDc")]
        public byte DeltaQVDc;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "DeltaQVAc")]
        public byte DeltaQVAc;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "qm_y")]
        public byte QmY;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "qm_u")]
        public byte QmU;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "qm_v")]
        public byte QmV;
    }
}
