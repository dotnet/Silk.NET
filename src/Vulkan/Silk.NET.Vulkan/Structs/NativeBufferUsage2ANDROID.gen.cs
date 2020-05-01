// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct NativeBufferUsage2ANDROID
    {
        public NativeBufferUsage2ANDROID
        (
            ulong consumer = default,
            ulong producer = default
        )
        {
           Consumer = consumer;
           Producer = producer;
        }

/// <summary></summary>
        public ulong Consumer;
/// <summary></summary>
        public ulong Producer;
    }
}
