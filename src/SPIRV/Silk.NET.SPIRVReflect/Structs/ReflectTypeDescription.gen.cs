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
    [NativeName("Name", "SpvReflectTypeDescription")]
    public unsafe partial struct ReflectTypeDescription
    {
        public ReflectTypeDescription
        (
            uint? id = null,
            Silk.NET.SPIRV.Op? op = null,
            byte* typeName = null,
            byte* structMemberName = null,
            Silk.NET.SPIRV.StorageClass? storageClass = null,
            uint? typeFlags = null,
            uint? decorationFlags = null,
            Traits? traits = null,
            uint? memberCount = null,
            ReflectTypeDescription* members = null
        ) : this()
        {
            if (id is not null)
            {
                Id = id.Value;
            }

            if (op is not null)
            {
                Op = op.Value;
            }

            if (typeName is not null)
            {
                TypeName = typeName;
            }

            if (structMemberName is not null)
            {
                StructMemberName = structMemberName;
            }

            if (storageClass is not null)
            {
                StorageClass = storageClass.Value;
            }

            if (typeFlags is not null)
            {
                TypeFlags = typeFlags.Value;
            }

            if (decorationFlags is not null)
            {
                DecorationFlags = decorationFlags.Value;
            }

            if (traits is not null)
            {
                Traits = traits.Value;
            }

            if (memberCount is not null)
            {
                MemberCount = memberCount.Value;
            }

            if (members is not null)
            {
                Members = members;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "id")]
        public uint Id;

        [NativeName("Type", "SpvOp")]
        [NativeName("Type.Name", "SpvOp")]
        [NativeName("Name", "op")]
        public Silk.NET.SPIRV.Op Op;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "type_name")]
        public byte* TypeName;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "struct_member_name")]
        public byte* StructMemberName;

        [NativeName("Type", "SpvStorageClass")]
        [NativeName("Type.Name", "SpvStorageClass")]
        [NativeName("Name", "storage_class")]
        public Silk.NET.SPIRV.StorageClass StorageClass;

        [NativeName("Type", "SpvReflectTypeFlags")]
        [NativeName("Type.Name", "SpvReflectTypeFlags")]
        [NativeName("Name", "type_flags")]
        public uint TypeFlags;

        [NativeName("Type", "SpvReflectDecorationFlags")]
        [NativeName("Type.Name", "SpvReflectDecorationFlags")]
        [NativeName("Name", "decoration_flags")]
        public uint DecorationFlags;

        [NativeName("Type", "struct Traits")]
        [NativeName("Type.Name", "struct Traits")]
        [NativeName("Name", "traits")]
        public Traits Traits;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "member_count")]
        public uint MemberCount;

        [NativeName("Type", "struct SpvReflectTypeDescription *")]
        [NativeName("Type.Name", "struct SpvReflectTypeDescription *")]
        [NativeName("Name", "members")]
        public ReflectTypeDescription* Members;
    }
}
