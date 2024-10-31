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
    [NativeName("Name", "XrPlaneDetectorLocationsEXT")]
    public unsafe partial struct PlaneDetectorLocationsEXT
    {
        public PlaneDetectorLocationsEXT
        (
            StructureType? type = StructureType.TypePlaneDetectorLocationsExt,
            void* next = null,
            uint? planeLocationCapacityInput = null,
            uint? planeLocationCountOutput = null,
            PlaneDetectorLocationEXT* planeLocations = null
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

            if (planeLocationCapacityInput is not null)
            {
                PlaneLocationCapacityInput = planeLocationCapacityInput.Value;
            }

            if (planeLocationCountOutput is not null)
            {
                PlaneLocationCountOutput = planeLocationCountOutput.Value;
            }

            if (planeLocations is not null)
            {
                PlaneLocations = planeLocations;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "planeLocationCapacityInput")]
        public uint PlaneLocationCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "planeLocationCountOutput")]
        public uint PlaneLocationCountOutput;
/// <summary></summary>
        [NativeName("Type", "XrPlaneDetectorLocationEXT*")]
        [NativeName("Type.Name", "XrPlaneDetectorLocationEXT")]
        [NativeName("Name", "planeLocations")]
        public PlaneDetectorLocationEXT* PlaneLocations;
    }
}
