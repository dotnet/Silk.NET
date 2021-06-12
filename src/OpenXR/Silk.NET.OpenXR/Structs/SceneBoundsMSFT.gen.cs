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
    [NativeName("Name", "XrSceneBoundsMSFT")]
    public unsafe partial struct SceneBoundsMSFT
    {
        public SceneBoundsMSFT
        (
            Space? space = null,
            long? time = null,
            uint? sphereCount = null,
            Silk.NET.Maths.Sphere<float>* spheres = null,
            uint? boxCount = null,
            SceneOrientedBoxBoundMSFT* boxes = null,
            uint? frustumCount = null,
            SceneFrustumBoundMSFT* frustums = null
        ) : this()
        {
            if (space is not null)
            {
                Space = space.Value;
            }

            if (time is not null)
            {
                Time = time.Value;
            }

            if (sphereCount is not null)
            {
                SphereCount = sphereCount.Value;
            }

            if (spheres is not null)
            {
                Spheres = spheres;
            }

            if (boxCount is not null)
            {
                BoxCount = boxCount.Value;
            }

            if (boxes is not null)
            {
                Boxes = boxes;
            }

            if (frustumCount is not null)
            {
                FrustumCount = frustumCount.Value;
            }

            if (frustums is not null)
            {
                Frustums = frustums;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrSpace")]
        [NativeName("Type.Name", "XrSpace")]
        [NativeName("Name", "space")]
        public Space Space;
/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "time")]
        public long Time;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sphereCount")]
        public uint SphereCount;
/// <summary></summary>
        [NativeName("Type", "XrSceneSphereBoundMSFT*")]
        [NativeName("Type.Name", "XrSceneSphereBoundMSFT")]
        [NativeName("Name", "spheres")]
        public Silk.NET.Maths.Sphere<float>* Spheres;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "boxCount")]
        public uint BoxCount;
/// <summary></summary>
        [NativeName("Type", "XrSceneOrientedBoxBoundMSFT*")]
        [NativeName("Type.Name", "XrSceneOrientedBoxBoundMSFT")]
        [NativeName("Name", "boxes")]
        public SceneOrientedBoxBoundMSFT* Boxes;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "frustumCount")]
        public uint FrustumCount;
/// <summary></summary>
        [NativeName("Type", "XrSceneFrustumBoundMSFT*")]
        [NativeName("Type.Name", "XrSceneFrustumBoundMSFT")]
        [NativeName("Name", "frustums")]
        public SceneFrustumBoundMSFT* Frustums;
    }
}
