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
    [NativeName("Name", "XrSecondaryViewConfigurationFrameEndInfoMSFT")]
    public unsafe partial struct SecondaryViewConfigurationFrameEndInfoMSFT
    {
        public SecondaryViewConfigurationFrameEndInfoMSFT
        (
            StructureType? type = StructureType.TypeSecondaryViewConfigurationFrameEndInfoMsft,
            void* next = null,
            uint? viewConfigurationCount = null,
            SecondaryViewConfigurationLayerInfoMSFT* viewConfigurationLayersInfo = null
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

            if (viewConfigurationCount is not null)
            {
                ViewConfigurationCount = viewConfigurationCount.Value;
            }

            if (viewConfigurationLayersInfo is not null)
            {
                ViewConfigurationLayersInfo = viewConfigurationLayersInfo;
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
        [NativeName("Name", "viewConfigurationCount")]
        public uint ViewConfigurationCount;
/// <summary></summary>
        [NativeName("Type", "XrSecondaryViewConfigurationLayerInfoMSFT*")]
        [NativeName("Type.Name", "XrSecondaryViewConfigurationLayerInfoMSFT")]
        [NativeName("Name", "viewConfigurationLayersInfo")]
        public SecondaryViewConfigurationLayerInfoMSFT* ViewConfigurationLayersInfo;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
