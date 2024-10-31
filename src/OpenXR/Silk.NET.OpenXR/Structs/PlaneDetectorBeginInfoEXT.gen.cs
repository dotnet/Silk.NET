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
    [NativeName("Name", "XrPlaneDetectorBeginInfoEXT")]
    public unsafe partial struct PlaneDetectorBeginInfoEXT
    {
        public PlaneDetectorBeginInfoEXT
        (
            StructureType? type = StructureType.TypePlaneDetectorBeginInfoExt,
            void* next = null,
            Space? baseSpace = null,
            long? time = null,
            uint? orientationCount = null,
            PlaneDetectorOrientationEXT* orientations = null,
            uint? semanticTypeCount = null,
            PlaneDetectorSemanticTypeEXT* semanticTypes = null,
            uint? maxPlanes = null,
            float? minArea = null,
            Posef? boundingBoxPose = null,
            Extent3DfEXT? boundingBoxExtent = null
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

            if (baseSpace is not null)
            {
                BaseSpace = baseSpace.Value;
            }

            if (time is not null)
            {
                Time = time.Value;
            }

            if (orientationCount is not null)
            {
                OrientationCount = orientationCount.Value;
            }

            if (orientations is not null)
            {
                Orientations = orientations;
            }

            if (semanticTypeCount is not null)
            {
                SemanticTypeCount = semanticTypeCount.Value;
            }

            if (semanticTypes is not null)
            {
                SemanticTypes = semanticTypes;
            }

            if (maxPlanes is not null)
            {
                MaxPlanes = maxPlanes.Value;
            }

            if (minArea is not null)
            {
                MinArea = minArea.Value;
            }

            if (boundingBoxPose is not null)
            {
                BoundingBoxPose = boundingBoxPose.Value;
            }

            if (boundingBoxExtent is not null)
            {
                BoundingBoxExtent = boundingBoxExtent.Value;
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
        [NativeName("Type", "XrSpace")]
        [NativeName("Type.Name", "XrSpace")]
        [NativeName("Name", "baseSpace")]
        public Space BaseSpace;
/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "time")]
        public long Time;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "orientationCount")]
        public uint OrientationCount;
/// <summary></summary>
        [NativeName("Type", "XrPlaneDetectorOrientationEXT*")]
        [NativeName("Type.Name", "XrPlaneDetectorOrientationEXT")]
        [NativeName("Name", "orientations")]
        public PlaneDetectorOrientationEXT* Orientations;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "semanticTypeCount")]
        public uint SemanticTypeCount;
/// <summary></summary>
        [NativeName("Type", "XrPlaneDetectorSemanticTypeEXT*")]
        [NativeName("Type.Name", "XrPlaneDetectorSemanticTypeEXT")]
        [NativeName("Name", "semanticTypes")]
        public PlaneDetectorSemanticTypeEXT* SemanticTypes;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPlanes")]
        public uint MaxPlanes;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "minArea")]
        public float MinArea;
/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "boundingBoxPose")]
        public Posef BoundingBoxPose;
/// <summary></summary>
        [NativeName("Type", "XrExtent3DfEXT")]
        [NativeName("Type.Name", "XrExtent3DfEXT")]
        [NativeName("Name", "boundingBoxExtent")]
        public Extent3DfEXT BoundingBoxExtent;
    }
}
