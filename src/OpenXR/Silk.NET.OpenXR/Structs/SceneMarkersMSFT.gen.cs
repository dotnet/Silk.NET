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
    [NativeName("Name", "XrSceneMarkersMSFT")]
    public unsafe partial struct SceneMarkersMSFT
    {
        public SceneMarkersMSFT
        (
            StructureType? type = StructureType.TypeSceneMarkersMsft,
            void* next = null,
            uint? sceneMarkerCapacityInput = null,
            SceneMarkerMSFT* sceneMarkers = null
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

            if (sceneMarkerCapacityInput is not null)
            {
                SceneMarkerCapacityInput = sceneMarkerCapacityInput.Value;
            }

            if (sceneMarkers is not null)
            {
                SceneMarkers = sceneMarkers;
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
        [NativeName("Name", "sceneMarkerCapacityInput")]
        public uint SceneMarkerCapacityInput;
/// <summary></summary>
        [NativeName("Type", "XrSceneMarkerMSFT*")]
        [NativeName("Type.Name", "XrSceneMarkerMSFT")]
        [NativeName("Name", "sceneMarkers")]
        public SceneMarkerMSFT* SceneMarkers;
    }
}
