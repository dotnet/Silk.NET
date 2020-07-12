// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    public unsafe struct SecondaryViewConfigurationLayerInfoMSFT
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
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public ViewConfigurationType ViewConfigurationType;
/// <summary></summary>
        public EnvironmentBlendMode EnvironmentBlendMode;
/// <summary></summary>
        public uint LayerCount;
/// <summary></summary>
        public CompositionLayerBaseHeader** Layers;
    }
}
