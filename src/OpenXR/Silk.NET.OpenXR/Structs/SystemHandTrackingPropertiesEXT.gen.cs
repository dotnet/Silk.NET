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
    [NativeName("Name", "XrSystemHandTrackingPropertiesEXT")]
    public unsafe partial struct SystemHandTrackingPropertiesEXT
    {
        public SystemHandTrackingPropertiesEXT
        (
            StructureType type = StructureType.TypeSystemHandTrackingPropertiesExt,
            void* next = default,
            uint supportsHandTracking = default
        )
        {
            Type = type;
            Next = next;
            SupportsHandTracking = supportsHandTracking;
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
        [NativeName("Name", "supportsHandTracking")]
        public uint SupportsHandTracking;
    }
}
