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
using Silk.NET.OpenCL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [Extension("KHR_command_buffer_multi_device")]
    public unsafe partial class KhrCommandBufferMultiDevice : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_command_buffer_multi_device";
        [NativeApi(EntryPoint = "clRemapCommandBufferKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint RemapCommandBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clRemapCommandBufferKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint RemapCommandBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clRemapCommandBufferKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint RemapCommandBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clRemapCommandBufferKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint RemapCommandBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clRemapCommandBufferKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint RemapCommandBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clRemapCommandBufferKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint RemapCommandBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clRemapCommandBufferKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint RemapCommandBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clRemapCommandBufferKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint RemapCommandBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clRemapCommandBufferKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint RemapCommandBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clRemapCommandBufferKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint RemapCommandBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clRemapCommandBufferKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint RemapCommandBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clRemapCommandBufferKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint RemapCommandBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clRemapCommandBufferKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint RemapCommandBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clRemapCommandBufferKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint RemapCommandBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clRemapCommandBufferKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint RemapCommandBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clRemapCommandBufferKHR", Convention = CallingConvention.Winapi)]
        public partial nint RemapCommandBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool automatic, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_handles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint handles, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint handles_ret, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        public KhrCommandBufferMultiDevice(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

