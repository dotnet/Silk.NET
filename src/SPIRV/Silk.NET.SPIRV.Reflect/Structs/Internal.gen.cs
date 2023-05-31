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
    [NativeName("Name", "Internal")]
    public unsafe partial struct Internal
    {
        public Internal
        (
            uint? moduleFlags = null,
            nuint? spirvSize = null,
            uint* spirvCode = null,
            uint? spirvWordCount = null,
            nuint? typeDescriptionCount = null,
            TypeDescription* typeDescriptions = null
        ) : this()
        {
            if (moduleFlags is not null)
            {
                ModuleFlags = moduleFlags.Value;
            }

            if (spirvSize is not null)
            {
                SpirvSize = spirvSize.Value;
            }

            if (spirvCode is not null)
            {
                SpirvCode = spirvCode;
            }

            if (spirvWordCount is not null)
            {
                SpirvWordCount = spirvWordCount.Value;
            }

            if (typeDescriptionCount is not null)
            {
                TypeDescriptionCount = typeDescriptionCount.Value;
            }

            if (typeDescriptions is not null)
            {
                TypeDescriptions = typeDescriptions;
            }
        }


        [NativeName("Type", "SpvReflectModuleFlags")]
        [NativeName("Type.Name", "SpvReflectModuleFlags")]
        [NativeName("Name", "module_flags")]
        public uint ModuleFlags;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "spirv_size")]
        public nuint SpirvSize;

        [NativeName("Type", "uint32_t *")]
        [NativeName("Type.Name", "uint32_t *")]
        [NativeName("Name", "spirv_code")]
        public uint* SpirvCode;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "spirv_word_count")]
        public uint SpirvWordCount;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "type_description_count")]
        public nuint TypeDescriptionCount;

        [NativeName("Type", "SpvReflectTypeDescription *")]
        [NativeName("Type.Name", "SpvReflectTypeDescription *")]
        [NativeName("Name", "type_descriptions")]
        public TypeDescription* TypeDescriptions;
    }
}
