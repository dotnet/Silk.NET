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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDrawMeshTasksIndirectCommandEXT")]
    public unsafe partial struct DrawMeshTasksIndirectCommandEXT
    {
        public DrawMeshTasksIndirectCommandEXT
        (
            uint? groupCountX = null,
            uint? groupCountY = null,
            uint? groupCountZ = null
        ) : this()
        {
            if (groupCountX is not null)
            {
                GroupCountX = groupCountX.Value;
            }

            if (groupCountY is not null)
            {
                GroupCountY = groupCountY.Value;
            }

            if (groupCountZ is not null)
            {
                GroupCountZ = groupCountZ.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "groupCountX")]
        public uint GroupCountX;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "groupCountY")]
        public uint GroupCountY;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "groupCountZ")]
        public uint GroupCountZ;
    }
}
