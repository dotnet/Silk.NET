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
    [NativeName("Name", "XrSenseDataFilterPlaneOrientationBD")]
    public unsafe partial struct SenseDataFilterPlaneOrientationBD
    {
        public SenseDataFilterPlaneOrientationBD
        (
            StructureType? type = StructureType.TypeSenseDataFilterPlaneOrientationBD,
            void* next = null,
            uint? orientationCount = null,
            PlaneOrientationBD* orientations = null
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

            if (orientationCount is not null)
            {
                OrientationCount = orientationCount.Value;
            }

            if (orientations is not null)
            {
                Orientations = orientations;
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
        [NativeName("Name", "orientationCount")]
        public uint OrientationCount;
/// <summary></summary>
        [NativeName("Type", "XrPlaneOrientationBD*")]
        [NativeName("Type.Name", "XrPlaneOrientationBD")]
        [NativeName("Name", "orientations")]
        public PlaneOrientationBD* Orientations;
    }
}
