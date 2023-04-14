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

namespace Silk.NET.SPIRVReflect
{
    [NativeName("Name", "SpvReflectBlockVariable")]
    public unsafe partial struct ReflectBlockVariable
    {
        public ReflectBlockVariable
        (
            uint? spirvId = null,
            byte* name = null,
            uint? offset = null,
            uint? absoluteOffset = null,
            uint? size = null,
            uint? paddedSize = null,
            uint? decorationFlags = null,
            ReflectNumericTraits? numeric = null,
            ReflectArrayTraits? array = null,
            uint? flags = null,
            uint? memberCount = null,
            ReflectBlockVariable* members = null,
            ReflectTypeDescription* typeDescription = null,
            ReflectBlockVariableWordOffset? wordOffset = null
        ) : this()
        {
            if (spirvId is not null)
            {
                SpirvId = spirvId.Value;
            }

            if (name is not null)
            {
                Name = name;
            }

            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (absoluteOffset is not null)
            {
                AbsoluteOffset = absoluteOffset.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (paddedSize is not null)
            {
                PaddedSize = paddedSize.Value;
            }

            if (decorationFlags is not null)
            {
                DecorationFlags = decorationFlags.Value;
            }

            if (numeric is not null)
            {
                Numeric = numeric.Value;
            }

            if (array is not null)
            {
                Array = array.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (memberCount is not null)
            {
                MemberCount = memberCount.Value;
            }

            if (members is not null)
            {
                Members = members;
            }

            if (typeDescription is not null)
            {
                TypeDescription = typeDescription;
            }

            if (wordOffset is not null)
            {
                WordOffset = wordOffset.Value;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "spirv_id")]
        public uint SpirvId;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "name")]
        public byte* Name;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "offset")]
        public uint Offset;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "absolute_offset")]
        public uint AbsoluteOffset;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "size")]
        public uint Size;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "padded_size")]
        public uint PaddedSize;

        [NativeName("Type", "SpvReflectDecorationFlags")]
        [NativeName("Type.Name", "SpvReflectDecorationFlags")]
        [NativeName("Name", "decoration_flags")]
        public uint DecorationFlags;

        [NativeName("Type", "SpvReflectNumericTraits")]
        [NativeName("Type.Name", "SpvReflectNumericTraits")]
        [NativeName("Name", "numeric")]
        public ReflectNumericTraits Numeric;

        [NativeName("Type", "SpvReflectArrayTraits")]
        [NativeName("Type.Name", "SpvReflectArrayTraits")]
        [NativeName("Name", "array")]
        public ReflectArrayTraits Array;

        [NativeName("Type", "SpvReflectVariableFlags")]
        [NativeName("Type.Name", "SpvReflectVariableFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "member_count")]
        public uint MemberCount;

        [NativeName("Type", "struct SpvReflectBlockVariable *")]
        [NativeName("Type.Name", "struct SpvReflectBlockVariable *")]
        [NativeName("Name", "members")]
        public ReflectBlockVariable* Members;

        [NativeName("Type", "SpvReflectTypeDescription *")]
        [NativeName("Type.Name", "SpvReflectTypeDescription *")]
        [NativeName("Name", "type_description")]
        public ReflectTypeDescription* TypeDescription;

        [NativeName("Type", "struct (unnamed struct at spirv_reflect.h:385:3)")]
        [NativeName("Type.Name", "struct (unnamed struct at spirv_reflect.h:385:3)")]
        [NativeName("Name", "word_offset")]
        public ReflectBlockVariableWordOffset WordOffset;
    }
}
