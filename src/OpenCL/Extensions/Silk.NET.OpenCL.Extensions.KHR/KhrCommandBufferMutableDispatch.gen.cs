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
    [Extension("KHR_command_buffer_mutable_dispatch")]
    public unsafe partial class KhrCommandBufferMutableDispatch : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_command_buffer_mutable_dispatch";
        [NativeApi(EntryPoint = "clGetMutableCommandInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetMutableCommandInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MutableCommandInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clUpdateMutableCommandsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int UpdateMutableCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MutableBaseConfigKhr* mutable_config);

        public KhrCommandBufferMutableDispatch(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

