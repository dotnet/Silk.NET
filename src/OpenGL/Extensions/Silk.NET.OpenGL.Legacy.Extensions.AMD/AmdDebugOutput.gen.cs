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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_debug_output")]
    public unsafe partial class AmdDebugOutput : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_debug_output";
        [NativeApi(EntryPoint = "glDebugMessageCallbackAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugMessageCallback([Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProcAmd callback, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* userParam);

        [NativeApi(EntryPoint = "glDebugMessageEnableAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugMessageEnable([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageInsertAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugMessageInsert([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        public AmdDebugOutput(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

