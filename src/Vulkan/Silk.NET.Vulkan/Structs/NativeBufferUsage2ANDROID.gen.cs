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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkNativeBufferUsage2ANDROID")]
    public unsafe partial struct NativeBufferUsage2ANDROID
    {
        public NativeBufferUsage2ANDROID
        (
            ulong? consumer = null,
            ulong? producer = null
        ) : this()
        {
            if (consumer is not null)
            {
                Consumer = consumer.Value;
            }

            if (producer is not null)
            {
                Producer = producer.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "consumer")]
        public ulong Consumer;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "producer")]
        public ulong Producer;
    }
}
