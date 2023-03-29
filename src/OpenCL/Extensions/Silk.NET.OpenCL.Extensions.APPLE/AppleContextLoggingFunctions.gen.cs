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

namespace Silk.NET.OpenCL.Extensions.APPLE
{
    [Extension("APPLE_ContextLoggingFunctions")]
    public unsafe partial class AppleContextLoggingFunctions : NativeExtension<CL>
    {
        public const string ExtensionName = "APPLE_ContextLoggingFunctions";
        [NativeApi(EntryPoint = "clLogMessagesToStderrAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToStderr([Flow(FlowDirection.In)] byte* errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] nuint cb, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clLogMessagesToStderrAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToStderr([Flow(FlowDirection.In)] in byte errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] nuint cb, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clLogMessagesToStderrAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToStderr([Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] nuint cb, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clLogMessagesToStdoutAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToStdout([Flow(FlowDirection.In)] byte* errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] nuint cb, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clLogMessagesToStdoutAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToStdout([Flow(FlowDirection.In)] in byte errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] nuint cb, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clLogMessagesToStdoutAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToStdout([Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] nuint cb, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clLogMessagesToSystemLogAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToSystemLog([Flow(FlowDirection.In)] byte* errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] nuint cb, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clLogMessagesToSystemLogAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToSystemLog([Flow(FlowDirection.In)] in byte errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] nuint cb, [Flow(FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clLogMessagesToSystemLogAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToSystemLog([Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] nuint cb, [Flow(FlowDirection.Out)] void* user_data);

        public AppleContextLoggingFunctions(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

