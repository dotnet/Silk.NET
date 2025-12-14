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
    [NativeName("Name", "XrFaceStateANDROID")]
    public unsafe partial struct FaceStateANDROID
    {
        public FaceStateANDROID
        (
            StructureType? type = StructureType.TypeFaceStateAndroid,
            void* next = null,
            uint? parametersCapacityInput = null,
            uint? parametersCountOutput = null,
            float* parameters = null,
            FaceTrackingStateANDROID? faceTrackingState = null,
            long? sampleTime = null,
            uint? isValid = null,
            uint? regionConfidencesCapacityInput = null,
            uint? regionConfidencesCountOutput = null,
            float* regionConfidences = null
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

            if (parametersCapacityInput is not null)
            {
                ParametersCapacityInput = parametersCapacityInput.Value;
            }

            if (parametersCountOutput is not null)
            {
                ParametersCountOutput = parametersCountOutput.Value;
            }

            if (parameters is not null)
            {
                Parameters = parameters;
            }

            if (faceTrackingState is not null)
            {
                FaceTrackingState = faceTrackingState.Value;
            }

            if (sampleTime is not null)
            {
                SampleTime = sampleTime.Value;
            }

            if (isValid is not null)
            {
                IsValid = isValid.Value;
            }

            if (regionConfidencesCapacityInput is not null)
            {
                RegionConfidencesCapacityInput = regionConfidencesCapacityInput.Value;
            }

            if (regionConfidencesCountOutput is not null)
            {
                RegionConfidencesCountOutput = regionConfidencesCountOutput.Value;
            }

            if (regionConfidences is not null)
            {
                RegionConfidences = regionConfidences;
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
        [NativeName("Name", "parametersCapacityInput")]
        public uint ParametersCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "parametersCountOutput")]
        public uint ParametersCountOutput;
/// <summary></summary>
        [NativeName("Type", "float*")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "parameters")]
        public float* Parameters;
/// <summary></summary>
        [NativeName("Type", "XrFaceTrackingStateANDROID")]
        [NativeName("Type.Name", "XrFaceTrackingStateANDROID")]
        [NativeName("Name", "faceTrackingState")]
        public FaceTrackingStateANDROID FaceTrackingState;
/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "sampleTime")]
        public long SampleTime;
/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "isValid")]
        public uint IsValid;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "regionConfidencesCapacityInput")]
        public uint RegionConfidencesCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "regionConfidencesCountOutput")]
        public uint RegionConfidencesCountOutput;
/// <summary></summary>
        [NativeName("Type", "float*")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "regionConfidences")]
        public float* RegionConfidences;
    }
}
