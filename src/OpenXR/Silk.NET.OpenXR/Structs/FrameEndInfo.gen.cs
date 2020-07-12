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
    public unsafe struct FrameEndInfo
    {
        public FrameEndInfo
        (
            StructureType type = StructureType.TypeFrameEndInfo,
            void* next = default,
            long displayTime = default,
            EnvironmentBlendMode environmentBlendMode = default,
            uint layerCount = default,
            CompositionLayerBaseHeader** layers = default
        )
        {
           Type = type;
           Next = next;
           DisplayTime = displayTime;
           EnvironmentBlendMode = environmentBlendMode;
           LayerCount = layerCount;
           Layers = layers;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public long DisplayTime;
/// <summary></summary>
        public EnvironmentBlendMode EnvironmentBlendMode;
/// <summary></summary>
        public uint LayerCount;
/// <summary></summary>
        public CompositionLayerBaseHeader** Layers;
    }
}
