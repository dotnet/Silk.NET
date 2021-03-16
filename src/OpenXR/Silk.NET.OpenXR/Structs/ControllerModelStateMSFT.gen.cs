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
    [NativeName("Name", "XrControllerModelStateMSFT")]
    public unsafe partial struct ControllerModelStateMSFT
    {
        public ControllerModelStateMSFT
        (
            StructureType? type = StructureType.TypeControllerModelStateMsft,
            void* next = null,
            uint? nodeCapacityInput = null,
            uint? nodeCountOutput = null,
            ControllerModelNodeStateMSFT* nodeStates = null
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

            if (nodeCapacityInput is not null)
            {
                NodeCapacityInput = nodeCapacityInput.Value;
            }

            if (nodeCountOutput is not null)
            {
                NodeCountOutput = nodeCountOutput.Value;
            }

            if (nodeStates is not null)
            {
                NodeStates = nodeStates;
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
        [NativeName("Name", "nodeCapacityInput")]
        public uint NodeCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "nodeCountOutput")]
        public uint NodeCountOutput;
/// <summary></summary>
        [NativeName("Type", "XrControllerModelNodeStateMSFT*")]
        [NativeName("Type.Name", "XrControllerModelNodeStateMSFT")]
        [NativeName("Name", "nodeStates")]
        public ControllerModelNodeStateMSFT* NodeStates;
    }
}
