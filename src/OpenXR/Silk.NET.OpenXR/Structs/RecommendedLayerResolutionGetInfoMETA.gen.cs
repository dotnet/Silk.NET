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
    [NativeName("Name", "XrRecommendedLayerResolutionGetInfoMETA")]
    public unsafe partial struct RecommendedLayerResolutionGetInfoMETA
    {
        public RecommendedLayerResolutionGetInfoMETA
        (
            StructureType? type = StructureType.TypeRecommendedLayerResolutionGetInfoMeta,
            void* next = null,
            CompositionLayerBaseHeader* layer = null,
            long? predictedDisplayTime = null
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

            if (layer is not null)
            {
                Layer = layer;
            }

            if (predictedDisplayTime is not null)
            {
                PredictedDisplayTime = predictedDisplayTime.Value;
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
        [NativeName("Type", "XrCompositionLayerBaseHeader*")]
        [NativeName("Type.Name", "XrCompositionLayerBaseHeader")]
        [NativeName("Name", "layer")]
        public CompositionLayerBaseHeader* Layer;
/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "predictedDisplayTime")]
        public long PredictedDisplayTime;
    }
}
