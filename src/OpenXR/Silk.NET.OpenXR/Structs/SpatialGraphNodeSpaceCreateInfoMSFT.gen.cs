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
    [NativeName("Name", "XrSpatialGraphNodeSpaceCreateInfoMSFT")]
    public unsafe partial struct SpatialGraphNodeSpaceCreateInfoMSFT
    {
        public SpatialGraphNodeSpaceCreateInfoMSFT
        (
            StructureType? type = StructureType.TypeSpatialGraphNodeSpaceCreateInfoMsft,
            void* next = null,
            SpatialGraphNodeTypeMSFT? nodeType = null,
            Posef? pose = null
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

            if (nodeType is not null)
            {
                NodeType = nodeType.Value;
            }

            if (pose is not null)
            {
                Pose = pose.Value;
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
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
