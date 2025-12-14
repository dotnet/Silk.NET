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
    [NativeName("Name", "XrRenderModelSpaceCreateInfoEXT")]
    public unsafe partial struct RenderModelSpaceCreateInfoEXT
    {
        public RenderModelSpaceCreateInfoEXT
        (
            StructureType? type = StructureType.TypeRenderModelSpaceCreateInfoExt,
            void* next = null,
            RenderModelEXT? renderModel = null
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

            if (renderModel is not null)
            {
                RenderModel = renderModel.Value;
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
        [NativeName("Type", "XrRenderModelEXT")]
        [NativeName("Type.Name", "XrRenderModelEXT")]
        [NativeName("Name", "renderModel")]
        public RenderModelEXT RenderModel;
    }
}
