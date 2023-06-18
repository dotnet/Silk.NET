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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_debug_output")]
    public unsafe partial class ArbDebugOutput : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_debug_output";
        [NativeApi(EntryPoint = "glDebugMessageCallbackARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugMessageCallback([Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProcArb callback, [Count(Computed = "callback"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* userParam);

        [NativeApi(EntryPoint = "glDebugMessageControlARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugMessageControl([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageInsertARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugMessageInsert([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glGetDebugMessageLogARB", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog);

        public ArbDebugOutput(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

