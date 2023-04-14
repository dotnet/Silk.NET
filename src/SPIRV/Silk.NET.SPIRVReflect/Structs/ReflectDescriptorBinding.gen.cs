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
    [NativeName("Name", "SpvReflectDescriptorBinding")]
    public unsafe partial struct ReflectDescriptorBinding
    {
        public ReflectDescriptorBinding
        (
            uint? spirvId = null,
            byte* name = null,
            uint? binding = null,
            uint? inputAttachmentIndex = null,
            uint? set = null,
            ReflectDescriptorType? descriptorType = null,
            ReflectResourceType? resourceType = null,
            ReflectImageTraits? image = null,
            ReflectBlockVariable? block = null,
            ReflectBindingArrayTraits? array = null,
            uint? count = null,
            uint? accessed = null,
            uint? uavCounterId = null,
            ReflectDescriptorBinding* uavCounterBinding = null,
            ReflectTypeDescription* typeDescription = null,
            ReflectDescriptorBindingWordOffset? wordOffset = null,
            uint? decorationFlags = null
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

            if (binding is not null)
            {
                Binding = binding.Value;
            }

            if (inputAttachmentIndex is not null)
            {
                InputAttachmentIndex = inputAttachmentIndex.Value;
            }

            if (set is not null)
            {
                Set = set.Value;
            }

            if (descriptorType is not null)
            {
                DescriptorType = descriptorType.Value;
            }

            if (resourceType is not null)
            {
                ResourceType = resourceType.Value;
            }

            if (image is not null)
            {
                Image = image.Value;
            }

            if (block is not null)
            {
                Block = block.Value;
            }

            if (array is not null)
            {
                Array = array.Value;
            }

            if (count is not null)
            {
                Count = count.Value;
            }

            if (accessed is not null)
            {
                Accessed = accessed.Value;
            }

            if (uavCounterId is not null)
            {
                UavCounterId = uavCounterId.Value;
            }

            if (uavCounterBinding is not null)
            {
                UavCounterBinding = uavCounterBinding;
            }

            if (typeDescription is not null)
            {
                TypeDescription = typeDescription;
            }

            if (wordOffset is not null)
            {
                WordOffset = wordOffset.Value;
            }

            if (decorationFlags is not null)
            {
                DecorationFlags = decorationFlags.Value;
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
        [NativeName("Name", "binding")]
        public uint Binding;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "input_attachment_index")]
        public uint InputAttachmentIndex;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "set")]
        public uint Set;

        [NativeName("Type", "SpvReflectDescriptorType")]
        [NativeName("Type.Name", "SpvReflectDescriptorType")]
        [NativeName("Name", "descriptor_type")]
        public ReflectDescriptorType DescriptorType;

        [NativeName("Type", "SpvReflectResourceType")]
        [NativeName("Type.Name", "SpvReflectResourceType")]
        [NativeName("Name", "resource_type")]
        public ReflectResourceType ResourceType;

        [NativeName("Type", "SpvReflectImageTraits")]
        [NativeName("Type.Name", "SpvReflectImageTraits")]
        [NativeName("Name", "image")]
        public ReflectImageTraits Image;

        [NativeName("Type", "SpvReflectBlockVariable")]
        [NativeName("Type.Name", "SpvReflectBlockVariable")]
        [NativeName("Name", "block")]
        public ReflectBlockVariable Block;

        [NativeName("Type", "SpvReflectBindingArrayTraits")]
        [NativeName("Type.Name", "SpvReflectBindingArrayTraits")]
        [NativeName("Name", "array")]
        public ReflectBindingArrayTraits Array;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "count")]
        public uint Count;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "accessed")]
        public uint Accessed;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "uav_counter_id")]
        public uint UavCounterId;

        [NativeName("Type", "struct SpvReflectDescriptorBinding *")]
        [NativeName("Type.Name", "struct SpvReflectDescriptorBinding *")]
        [NativeName("Name", "uav_counter_binding")]
        public ReflectDescriptorBinding* UavCounterBinding;

        [NativeName("Type", "SpvReflectTypeDescription *")]
        [NativeName("Type.Name", "SpvReflectTypeDescription *")]
        [NativeName("Name", "type_description")]
        public ReflectTypeDescription* TypeDescription;

        [NativeName("Type", "struct (unnamed struct at spirv_reflect.h:412:3)")]
        [NativeName("Type.Name", "struct (unnamed struct at spirv_reflect.h:412:3)")]
        [NativeName("Name", "word_offset")]
        public ReflectDescriptorBindingWordOffset WordOffset;

        [NativeName("Type", "SpvReflectDecorationFlags")]
        [NativeName("Type.Name", "SpvReflectDecorationFlags")]
        [NativeName("Name", "decoration_flags")]
        public uint DecorationFlags;
    }
}
