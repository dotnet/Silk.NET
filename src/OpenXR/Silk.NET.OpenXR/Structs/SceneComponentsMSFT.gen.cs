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
    [NativeName("Name", "XrSceneComponentsMSFT")]
    public unsafe partial struct SceneComponentsMSFT
    {
        public SceneComponentsMSFT
        (
            StructureType? type = StructureType.TypeSceneComponentsMsft,
            void* next = null,
            uint? componentCapacityInput = null,
            uint? componentCountOutput = null,
            SceneComponentMSFT* components = null
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

            if (componentCapacityInput is not null)
            {
                ComponentCapacityInput = componentCapacityInput.Value;
            }

            if (componentCountOutput is not null)
            {
                ComponentCountOutput = componentCountOutput.Value;
            }

            if (components is not null)
            {
                Components = components;
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
        [NativeName("Name", "componentCapacityInput")]
        public uint ComponentCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "componentCountOutput")]
        public uint ComponentCountOutput;
/// <summary></summary>
        [NativeName("Type", "XrSceneComponentMSFT*")]
        [NativeName("Type.Name", "XrSceneComponentMSFT")]
        [NativeName("Name", "components")]
        public SceneComponentMSFT* Components;
    }
}
