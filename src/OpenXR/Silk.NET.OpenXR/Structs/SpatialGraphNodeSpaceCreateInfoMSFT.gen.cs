// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSpatialGraphNodeSpaceCreateInfoMSFT")]
    public unsafe partial struct SpatialGraphNodeSpaceCreateInfoMSFT
    {
        public SpatialGraphNodeSpaceCreateInfoMSFT
        (
            StructureType type = StructureType.TypeSpatialGraphNodeSpaceCreateInfoMsft,
            void* next = default,
            SpatialGraphNodeTypeMSFT nodeType = default,
            Posef pose = default
        )
        {
            Type = type;
            Next = next;
            NodeType = nodeType;
            Pose = pose;
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
        [NativeName("Type", "XrSpatialGraphNodeTypeMSFT")]
        [NativeName("Type.Name", "XrSpatialGraphNodeTypeMSFT")]
        [NativeName("Name", "nodeType")]
        public SpatialGraphNodeTypeMSFT NodeType;
        /// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "nodeId")]
        public fixed byte NodeId[16];
/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "pose")]
        public Posef Pose;
    }
}
