// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrCompositionLayerColorScaleBiasKHR")]
    public unsafe partial struct CompositionLayerColorScaleBiasKHR
    {
        public CompositionLayerColorScaleBiasKHR
        (
            StructureType? type = StructureType.TypeCompositionLayerColorScaleBiasKhr,
            void* next = null,
            Color4f? colorScale = null,
            Color4f? colorBias = null
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

            if (colorScale is not null)
            {
                ColorScale = colorScale.Value;
            }

            if (colorBias is not null)
            {
                ColorBias = colorBias.Value;
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
        [NativeName("Type", "XrColor4f")]
        [NativeName("Type.Name", "XrColor4f")]
        [NativeName("Name", "colorScale")]
        public Color4f ColorScale;
/// <summary></summary>
        [NativeName("Type", "XrColor4f")]
        [NativeName("Type.Name", "XrColor4f")]
        [NativeName("Name", "colorBias")]
        public Color4f ColorBias;
    }
}
