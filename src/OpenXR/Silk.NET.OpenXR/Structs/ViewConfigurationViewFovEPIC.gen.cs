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
    [NativeName("Name", "XrViewConfigurationViewFovEPIC")]
    public unsafe partial struct ViewConfigurationViewFovEPIC
    {
        public ViewConfigurationViewFovEPIC
        (
            StructureType? type = StructureType.TypeViewConfigurationViewFovEpic,
            void* next = null,
            Fovf? recommendedFov = null,
            Fovf? maxMutableFov = null
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

            if (recommendedFov is not null)
            {
                RecommendedFov = recommendedFov.Value;
            }

            if (maxMutableFov is not null)
            {
                MaxMutableFov = maxMutableFov.Value;
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
