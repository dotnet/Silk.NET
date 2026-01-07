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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrFrameSynthesisInfoEXT")]
    public unsafe partial struct FrameSynthesisInfoEXT
    {
        public FrameSynthesisInfoEXT
        (
            StructureType? type = StructureType.TypeFrameSynthesisInfoExt,
            void* next = null,
            FrameSynthesisInfoFlagsEXT? layerFlags = null,
            SwapchainSubImage? motionVectorSubImage = null,
            Vector4f? motionVectorScale = null,
            Vector4f? motionVectorOffset = null,
            Posef? appSpaceDeltaPose = null,
            SwapchainSubImage? depthSubImage = null,
            float? minDepth = null,
            float? maxDepth = null,
            float? nearZ = null,
            float? farZ = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (layerFlags is not null)
            {
                LayerFlags = layerFlags.Value;
            }

            if (motionVectorSubImage is not null)
            {
                MotionVectorSubImage = motionVectorSubImage.Value;
            }

            if (motionVectorScale is not null)
            {
                MotionVectorScale = motionVectorScale.Value;
            }

            if (motionVectorOffset is not null)
            {
                MotionVectorOffset = motionVectorOffset.Value;
            }

            if (appSpaceDeltaPose is not null)
            {
                AppSpaceDeltaPose = appSpaceDeltaPose.Value;
            }

            if (depthSubImage is not null)
            {
                DepthSubImage = depthSubImage.Value;
            }

            if (minDepth is not null)
            {
                MinDepth = minDepth.Value;
            }

            if (maxDepth is not null)
            {
                MaxDepth = maxDepth.Value;
            }

            if (nearZ is not null)
            {
                NearZ = nearZ.Value;
            }

            if (farZ is not null)
            {
                FarZ = farZ.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "XrFrameSynthesisInfoFlagsEXT")]
        [NativeName("Type.Name", "XrFrameSynthesisInfoFlagsEXT")]
        [NativeName("Name", "layerFlags")]
        public FrameSynthesisInfoFlagsEXT LayerFlags;
/// <summary></summary>
        [NativeName("Type", "XrSwapchainSubImage")]
        [NativeName("Type.Name", "XrSwapchainSubImage")]
        [NativeName("Name", "motionVectorSubImage")]
        public SwapchainSubImage MotionVectorSubImage;
/// <summary></summary>
        [NativeName("Type", "XrVector4f")]
        [NativeName("Type.Name", "XrVector4f")]
        [NativeName("Name", "motionVectorScale")]
        public Vector4f MotionVectorScale;
/// <summary></summary>
        [NativeName("Type", "XrVector4f")]
        [NativeName("Type.Name", "XrVector4f")]
        [NativeName("Name", "motionVectorOffset")]
        public Vector4f MotionVectorOffset;
/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "appSpaceDeltaPose")]
        public Posef AppSpaceDeltaPose;
/// <summary></summary>
        [NativeName("Type", "XrSwapchainSubImage")]
        [NativeName("Type.Name", "XrSwapchainSubImage")]
        [NativeName("Name", "depthSubImage")]
        public SwapchainSubImage DepthSubImage;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "minDepth")]
        public float MinDepth;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "maxDepth")]
        public float MaxDepth;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "nearZ")]
        public float NearZ;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "farZ")]
        public float FarZ;
    }
}
