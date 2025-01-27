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
    [NativeName("Name", "SpvReflectDescriptorBinding")]
    public unsafe partial struct DescriptorBinding
    {
        public DescriptorBinding
        (
            uint? spirvId = null,
            byte* name = null,
            uint? binding = null,
            uint? inputAttachmentIndex = null,
            uint? set = null,
            DescriptorType? descriptorType = null,
            ResourceType? resourceType = null,
            ImageTraits? image = null,
            BlockVariable? block = null,
            BindingArrayTraits? array = null,
            uint? count = null,
            uint? accessed = null,
            uint? uavCounterId = null,
            DescriptorBinding* uavCounterBinding = null,
            uint? byteAddressBufferOffsetCount = null,
            uint* byteAddressBufferOffsets = null,
            TypeDescription* typeDescription = null,
            DescriptorBindingWordOffset? wordOffset = null,
            uint? decorationFlags = null,
            UserType? userType = null
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

            if (byteAddressBufferOffsetCount is not null)
            {
                ByteAddressBufferOffsetCount = byteAddressBufferOffsetCount.Value;
            }

            if (byteAddressBufferOffsets is not null)
            {
                ByteAddressBufferOffsets = byteAddressBufferOffsets;
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

            if (userType is not null)
            {
                UserType = userType.Value;
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
        public DescriptorType DescriptorType;

        [NativeName("Type", "SpvReflectResourceType")]
        [NativeName("Type.Name", "SpvReflectResourceType")]
        [NativeName("Name", "resource_type")]
        public ResourceType ResourceType;

        [NativeName("Type", "SpvReflectImageTraits")]
        [NativeName("Type.Name", "SpvReflectImageTraits")]
        [NativeName("Name", "image")]
        public ImageTraits Image;

        [NativeName("Type", "SpvReflectBlockVariable")]
        [NativeName("Type.Name", "SpvReflectBlockVariable")]
        [NativeName("Name", "block")]
        public BlockVariable Block;

        [NativeName("Type", "SpvReflectBindingArrayTraits")]
        [NativeName("Type.Name", "SpvReflectBindingArrayTraits")]
        [NativeName("Name", "array")]
        public BindingArrayTraits Array;

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
        public DescriptorBinding* UavCounterBinding;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "byte_address_buffer_offset_count")]
        public uint ByteAddressBufferOffsetCount;

        [NativeName("Type", "uint32_t *")]
        [NativeName("Type.Name", "uint32_t *")]
        [NativeName("Name", "byte_address_buffer_offsets")]
        public uint* ByteAddressBufferOffsets;

        [NativeName("Type", "SpvReflectTypeDescription *")]
        [NativeName("Type.Name", "SpvReflectTypeDescription *")]
        [NativeName("Name", "type_description")]
        public TypeDescription* TypeDescription;

        [NativeName("Type", "struct (unnamed struct at spirv_reflect.h:502:3)")]
        [NativeName("Type.Name", "struct (unnamed struct at spirv_reflect.h:502:3)")]
        [NativeName("Name", "word_offset")]
        public DescriptorBindingWordOffset WordOffset;

        [NativeName("Type", "SpvReflectDecorationFlags")]
        [NativeName("Type.Name", "SpvReflectDecorationFlags")]
        [NativeName("Name", "decoration_flags")]
        public uint DecorationFlags;

        [NativeName("Type", "SpvReflectUserType")]
        [NativeName("Type.Name", "SpvReflectUserType")]
        [NativeName("Name", "user_type")]
        public UserType UserType;
    }
}
