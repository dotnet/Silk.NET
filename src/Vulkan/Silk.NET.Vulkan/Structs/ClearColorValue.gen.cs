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

namespace Silk.NET.Vulkan
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "VkClearColorValue")]
    public unsafe partial struct ClearColorValue
    {
        public ClearColorValue
        (
            float? float32_0 = null,
            float? float32_1 = null,
            float? float32_2 = null,
            float? float32_3 = null,
            int? int32_0 = null,
            int? int32_1 = null,
            int? int32_2 = null,
            int? int32_3 = null,
            uint? uint32_0 = null,
            uint? uint32_1 = null,
            uint? uint32_2 = null,
            uint? uint32_3 = null
        ) : this()
        {
            if (float32_0 is not null)
            {
                Float32_0 = float32_0.Value;
            }

            if (float32_1 is not null)
            {
                Float32_1 = float32_1.Value;
            }

            if (float32_2 is not null)
            {
                Float32_2 = float32_2.Value;
            }

            if (float32_3 is not null)
            {
                Float32_3 = float32_3.Value;
            }

            if (int32_0 is not null)
            {
                Int32_0 = int32_0.Value;
            }

            if (int32_1 is not null)
            {
                Int32_1 = int32_1.Value;
            }

            if (int32_2 is not null)
            {
                Int32_2 = int32_2.Value;
            }

            if (int32_3 is not null)
            {
                Int32_3 = int32_3.Value;
            }

            if (uint32_0 is not null)
            {
                Uint32_0 = uint32_0.Value;
            }

            if (uint32_1 is not null)
            {
                Uint32_1 = uint32_1.Value;
            }

            if (uint32_2 is not null)
            {
                Uint32_2 = uint32_2.Value;
            }

            if (uint32_3 is not null)
            {
                Uint32_3 = uint32_3.Value;
            }
        }

/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "float32")]
        public float Float32_0;
/// <summary></summary>
        [FieldOffset(4)]
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "float32")]
        public float Float32_1;
/// <summary></summary>
        [FieldOffset(8)]
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "float32")]
        public float Float32_2;
/// <summary></summary>
        [FieldOffset(12)]
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "float32")]
        public float Float32_3;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "int32")]
        public int Int32_0;
/// <summary></summary>
        [FieldOffset(4)]
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "int32")]
        public int Int32_1;
/// <summary></summary>
        [FieldOffset(8)]
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "int32")]
        public int Int32_2;
/// <summary></summary>
        [FieldOffset(12)]
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "int32")]
        public int Int32_3;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "uint32")]
        public uint Uint32_0;
/// <summary></summary>
        [FieldOffset(4)]
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "uint32")]
        public uint Uint32_1;
/// <summary></summary>
        [FieldOffset(8)]
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "uint32")]
        public uint Uint32_2;
/// <summary></summary>
        [FieldOffset(12)]
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "uint32")]
        public uint Uint32_3;
    }
}
