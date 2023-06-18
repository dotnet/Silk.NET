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

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Extension("INTEL_program_scope_host_pipe")]
    public unsafe partial class IntelProgramScopeHostPipe : NativeExtension<CL>
    {
        public const string ExtensionName = "INTEL_program_scope_host_pipe";
        [NativeApi(EntryPoint = "clEnqueueReadHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadHostPipe([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_read, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteHostPipe([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pipe_symbol, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool blocking_write, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        public IntelProgramScopeHostPipe(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

