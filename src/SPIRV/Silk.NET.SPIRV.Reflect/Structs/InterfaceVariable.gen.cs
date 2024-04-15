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

namespace Silk.NET.SPIRV.Reflect
{
    [NativeName("Name", "SpvReflectInterfaceVariable")]
    public unsafe partial struct InterfaceVariable
    {
        public InterfaceVariable
        (
            uint? spirvId = null,
            byte* name = null,
            uint? location = null,
            uint? component = null,
            Silk.NET.SPIRV.StorageClass? storageClass = null,
            byte* semantic = null,
            uint? decorationFlags = null,
            Silk.NET.SPIRV.BuiltIn? builtIn = null,
            NumericTraits? numeric = null,
            ArrayTraits? array = null,
            uint? memberCount = null,
            InterfaceVariable* members = null,
            Format? format = null,
            TypeDescription* typeDescription = null,
            InterfaceVariableWordOffset? wordOffset = null
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

            if (location is not null)
            {
                Location = location.Value;
            }

            if (component is not null)
            {
                Component = component.Value;
            }

            if (storageClass is not null)
            {
                StorageClass = storageClass.Value;
            }

            if (semantic is not null)
            {
                Semantic = semantic;
            }

            if (decorationFlags is not null)
            {
                DecorationFlags = decorationFlags.Value;
            }

            if (builtIn is not null)
            {
                BuiltIn = builtIn.Value;
            }

            if (numeric is not null)
            {
                Numeric = numeric.Value;
            }

            if (array is not null)
            {
                Array = array.Value;
            }

            if (memberCount is not null)
            {
                MemberCount = memberCount.Value;
            }

            if (members is not null)
            {
                Members = members;
            }

            if (format is not null)
            {
                Format = format.Value;
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
        [NativeName("Name", "location")]
        public uint Location;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "component")]
        public uint Component;

        [NativeName("Type", "SpvStorageClass")]
        [NativeName("Type.Name", "SpvStorageClass")]
        [NativeName("Name", "storage_class")]
        public Silk.NET.SPIRV.StorageClass StorageClass;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "semantic")]
        public byte* Semantic;

        [NativeName("Type", "SpvReflectDecorationFlags")]
        [NativeName("Type.Name", "SpvReflectDecorationFlags")]
        [NativeName("Name", "decoration_flags")]
        public uint DecorationFlags;

        [NativeName("Type", "SpvBuiltIn")]
        [NativeName("Type.Name", "SpvBuiltIn")]
        [NativeName("Name", "built_in")]
        public Silk.NET.SPIRV.BuiltIn BuiltIn;

        [NativeName("Type", "SpvReflectNumericTraits")]
        [NativeName("Type.Name", "SpvReflectNumericTraits")]
        [NativeName("Name", "numeric")]
        public NumericTraits Numeric;

        [NativeName("Type", "SpvReflectArrayTraits")]
        [NativeName("Type.Name", "SpvReflectArrayTraits")]
        [NativeName("Name", "array")]
        public ArrayTraits Array;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "member_count")]
        public uint MemberCount;

        [NativeName("Type", "struct SpvReflectInterfaceVariable *")]
        [NativeName("Type.Name", "struct SpvReflectInterfaceVariable *")]
        [NativeName("Name", "members")]
        public InterfaceVariable* Members;

        [NativeName("Type", "SpvReflectFormat")]
        [NativeName("Type.Name", "SpvReflectFormat")]
        [NativeName("Name", "format")]
        public Format Format;

        [NativeName("Type", "SpvReflectTypeDescription *")]
        [NativeName("Type.Name", "SpvReflectTypeDescription *")]
        [NativeName("Name", "type_description")]
        public TypeDescription* TypeDescription;

        [NativeName("Type", "struct (unnamed struct at spirv_reflect.h:447:3)")]
        [NativeName("Type.Name", "struct (unnamed struct at spirv_reflect.h:447:3)")]
        [NativeName("Name", "word_offset")]
        public InterfaceVariableWordOffset WordOffset;
    }
}
