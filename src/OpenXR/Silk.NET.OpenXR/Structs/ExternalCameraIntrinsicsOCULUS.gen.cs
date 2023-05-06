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
    [NativeName("Name", "XrExternalCameraIntrinsicsOCULUS")]
    public unsafe partial struct ExternalCameraIntrinsicsOCULUS
    {
        public ExternalCameraIntrinsicsOCULUS
        (
            long? lastChangeTime = null,
            Fovf? fov = null,
            float? virtualNearPlaneDistance = null,
            float? virtualFarPlaneDistance = null,
            Extent2Di? imageSensorPixelResolution = null
        ) : this()
        {
            if (lastChangeTime is not null)
            {
                LastChangeTime = lastChangeTime.Value;
            }

            if (fov is not null)
            {
                Fov = fov.Value;
            }

            if (virtualNearPlaneDistance is not null)
            {
                VirtualNearPlaneDistance = virtualNearPlaneDistance.Value;
            }

            if (virtualFarPlaneDistance is not null)
            {
                VirtualFarPlaneDistance = virtualFarPlaneDistance.Value;
            }

            if (imageSensorPixelResolution is not null)
            {
                ImageSensorPixelResolution = imageSensorPixelResolution.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "lastChangeTime")]
        public long LastChangeTime;
/// <summary></summary>
        [NativeName("Type", "XrFovf")]
        [NativeName("Type.Name", "XrFovf")]
        [NativeName("Name", "fov")]
        public Fovf Fov;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "virtualNearPlaneDistance")]
        public float VirtualNearPlaneDistance;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "virtualFarPlaneDistance")]
        public float VirtualFarPlaneDistance;
/// <summary></summary>
        [NativeName("Type", "XrExtent2Di")]
        [NativeName("Type.Name", "XrExtent2Di")]
        [NativeName("Name", "imageSensorPixelResolution")]
        public Extent2Di ImageSensorPixelResolution;
    }
}
