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
    [NativeName("Name", "XrExternalCameraExtrinsicsOCULUS")]
    public unsafe partial struct ExternalCameraExtrinsicsOCULUS
    {
        public ExternalCameraExtrinsicsOCULUS
        (
            long? lastChangeTime = null,
            ExternalCameraStatusFlagsOCULUS? cameraStatusFlags = null,
            ExternalCameraAttachedToDeviceOCULUS? attachedToDevice = null,
            Posef? relativePose = null
        ) : this()
        {
            if (lastChangeTime is not null)
            {
                LastChangeTime = lastChangeTime.Value;
            }

            if (cameraStatusFlags is not null)
            {
                CameraStatusFlags = cameraStatusFlags.Value;
            }

            if (attachedToDevice is not null)
            {
                AttachedToDevice = attachedToDevice.Value;
            }

            if (relativePose is not null)
            {
                RelativePose = relativePose.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "lastChangeTime")]
        public long LastChangeTime;
/// <summary></summary>
        [NativeName("Type", "XrExternalCameraStatusFlagsOCULUS")]
        [NativeName("Type.Name", "XrExternalCameraStatusFlagsOCULUS")]
        [NativeName("Name", "cameraStatusFlags")]
        public ExternalCameraStatusFlagsOCULUS CameraStatusFlags;
/// <summary></summary>
        [NativeName("Type", "XrExternalCameraAttachedToDeviceOCULUS")]
        [NativeName("Type.Name", "XrExternalCameraAttachedToDeviceOCULUS")]
        [NativeName("Name", "attachedToDevice")]
        public ExternalCameraAttachedToDeviceOCULUS AttachedToDevice;
/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "relativePose")]
        public Posef RelativePose;
    }
}
