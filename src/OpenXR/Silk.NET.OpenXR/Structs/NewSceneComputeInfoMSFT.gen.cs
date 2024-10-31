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
    [NativeName("Name", "XrNewSceneComputeInfoMSFT")]
    public unsafe partial struct NewSceneComputeInfoMSFT
    {
        public NewSceneComputeInfoMSFT
        (
            StructureType? type = StructureType.TypeNewSceneComputeInfoMsft,
            void* next = null,
            uint? requestedFeatureCount = null,
            SceneComputeFeatureMSFT* requestedFeatures = null,
            SceneComputeConsistencyMSFT? consistency = null,
            SceneBoundsMSFT? bounds = null
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

            if (requestedFeatureCount is not null)
            {
                RequestedFeatureCount = requestedFeatureCount.Value;
            }

            if (requestedFeatures is not null)
            {
                RequestedFeatures = requestedFeatures;
            }

            if (consistency is not null)
            {
                Consistency = consistency.Value;
            }

            if (bounds is not null)
            {
                Bounds = bounds.Value;
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
        [NativeName("Name", "requestedFeatureCount")]
        public uint RequestedFeatureCount;
/// <summary></summary>
        [NativeName("Type", "XrSceneComputeFeatureMSFT*")]
        [NativeName("Type.Name", "XrSceneComputeFeatureMSFT")]
        [NativeName("Name", "requestedFeatures")]
        public SceneComputeFeatureMSFT* RequestedFeatures;
/// <summary></summary>
        [NativeName("Type", "XrSceneComputeConsistencyMSFT")]
        [NativeName("Type.Name", "XrSceneComputeConsistencyMSFT")]
        [NativeName("Name", "consistency")]
        public SceneComputeConsistencyMSFT Consistency;
/// <summary></summary>
        [NativeName("Type", "XrSceneBoundsMSFT")]
        [NativeName("Type.Name", "XrSceneBoundsMSFT")]
        [NativeName("Name", "bounds")]
        public SceneBoundsMSFT Bounds;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
