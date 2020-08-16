// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrViewConfigurationViewFovEPIC")]
    public unsafe partial struct ViewConfigurationViewFovEPIC
    {
        public ViewConfigurationViewFovEPIC
        (
            StructureType type = StructureType.TypeViewConfigurationViewFovEpic,
            void* next = default,
            Fovf recommendedFov = default,
            Fovf maxMutableFov = default
        )
        {
            Type = type;
            Next = next;
            RecommendedFov = recommendedFov;
            MaxMutableFov = maxMutableFov;
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
        [NativeName("Type", "XrFovf")]
        [NativeName("Type.Name", "XrFovf")]
        [NativeName("Name", "recommendedFov")]
        public Fovf RecommendedFov;
/// <summary></summary>
        [NativeName("Type", "XrFovf")]
        [NativeName("Type.Name", "XrFovf")]
        [NativeName("Name", "maxMutableFov")]
        public Fovf MaxMutableFov;
    }
}
