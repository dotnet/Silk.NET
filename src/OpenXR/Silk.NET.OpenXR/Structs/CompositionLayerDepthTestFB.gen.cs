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
    [NativeName("Name", "XrCompositionLayerDepthTestFB")]
    public unsafe partial struct CompositionLayerDepthTestFB
    {
        public CompositionLayerDepthTestFB
        (
            StructureType? type = StructureType.TypeCompositionLayerDepthTestFB,
            void* next = null,
            uint? depthMask = null,
            CompareOpFB? compareOp = null
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

            if (depthMask is not null)
            {
                DepthMask = depthMask.Value;
            }

            if (compareOp is not null)
            {
                CompareOp = compareOp.Value;
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
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "depthMask")]
        public uint DepthMask;
/// <summary></summary>
        [NativeName("Type", "XrCompareOpFB")]
        [NativeName("Type.Name", "XrCompareOpFB")]
        [NativeName("Name", "compareOp")]
        public CompareOpFB CompareOp;
    }
}
