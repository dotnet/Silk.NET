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
    [NativeName("Name", "XrPassthroughBrightnessContrastSaturationFB")]
    public unsafe partial struct PassthroughBrightnessContrastSaturationFB
    {
        public PassthroughBrightnessContrastSaturationFB
        (
            StructureType? type = StructureType.TypePassthroughBrightnessContrastSaturationFB,
            void* next = null,
            float? brightness = null,
            float? contrast = null,
            float? saturation = null
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

            if (brightness is not null)
            {
                Brightness = brightness.Value;
            }

            if (contrast is not null)
            {
                Contrast = contrast.Value;
            }

            if (saturation is not null)
            {
                Saturation = saturation.Value;
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
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "brightness")]
        public float Brightness;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "contrast")]
        public float Contrast;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "saturation")]
        public float Saturation;
    }
}
