// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "XrEventDataDisplayRefreshRateChangedFB")]
    public unsafe partial struct EventDataDisplayRefreshRateChangedFB
    {
        public EventDataDisplayRefreshRateChangedFB
        (
            StructureType? type = StructureType.TypeEventDataDisplayRefreshRateChangedFB,
            void* next = null,
            float? fromDisplayRefreshRate = null,
            float? toDisplayRefreshRate = null
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

            if (fromDisplayRefreshRate is not null)
            {
                FromDisplayRefreshRate = fromDisplayRefreshRate.Value;
            }

            if (toDisplayRefreshRate is not null)
            {
                ToDisplayRefreshRate = toDisplayRefreshRate.Value;
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
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "fromDisplayRefreshRate")]
        public float FromDisplayRefreshRate;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "toDisplayRefreshRate")]
        public float ToDisplayRefreshRate;
    }
}
