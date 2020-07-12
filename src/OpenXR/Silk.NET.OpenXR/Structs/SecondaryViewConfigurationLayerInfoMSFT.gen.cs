// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSecondaryViewConfigurationLayerInfoMSFT")]
    public unsafe partial struct SecondaryViewConfigurationLayerInfoMSFT
    {
        public SecondaryViewConfigurationLayerInfoMSFT
        (
            StructureType type = StructureType.TypeSecondaryViewConfigurationLayerInfoMsft,
            void* next = default,
            ViewConfigurationType viewConfigurationType = default,
            EnvironmentBlendMode environmentBlendMode = default,
            uint layerCount = default,
            CompositionLayerBaseHeader** layers = default
        )
        {
            Type = type;
            Next = next;
            ViewConfigurationType = viewConfigurationType;
            EnvironmentBlendMode = environmentBlendMode;
            LayerCount = layerCount;
            Layers = layers;
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
        [NativeName("Type", "XrViewConfigurationType")]
        [NativeName("Type.Name", "XrViewConfigurationType")]
        [NativeName("Name", "viewConfigurationType")]
        public ViewConfigurationType ViewConfigurationType;
/// <summary></summary>
        [NativeName("Type", "XrEnvironmentBlendMode")]
        [NativeName("Type.Name", "XrEnvironmentBlendMode")]
        [NativeName("Name", "environmentBlendMode")]
        public EnvironmentBlendMode EnvironmentBlendMode;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "layerCount")]
        public uint LayerCount;
/// <summary></summary>
        [NativeName("Type", "XrCompositionLayerBaseHeader**")]
        [NativeName("Type.Name", "XrCompositionLayerBaseHeader")]
        [NativeName("Name", "layers")]
        public CompositionLayerBaseHeader** Layers;
    }
}
