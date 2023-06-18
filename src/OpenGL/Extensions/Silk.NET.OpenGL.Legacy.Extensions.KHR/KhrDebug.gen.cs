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

namespace Silk.NET.OpenGL.Legacy.Extensions.KHR
{
    [Extension("KHR_debug")]
    public unsafe partial class KhrDebug : NativeExtension<GL>
    {
        public const string ExtensionName = "KHR_debug";
        [NativeApi(EntryPoint = "glDebugMessageCallback", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugMessageCallback([Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProc callback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* userParam);

        [NativeApi(EntryPoint = "glDebugMessageControl", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugMessageControl([Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageInsert", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugMessageInsert([Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glGetDebugMessageLog", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetObjectLabel", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetObjectLabel([Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR identifier, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* label);

        [NativeApi(EntryPoint = "glGetObjectPtrLabel", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetObjectPtrLabel([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* label);

        [System.Obsolete("Deprecated in version ")]
        [NativeApi(EntryPoint = "glGetPointerv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glObjectLabel", Convention = CallingConvention.Winapi)]
        public unsafe partial void ObjectLabel([Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR identifier, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        [NativeApi(EntryPoint = "glObjectPtrLabel", Convention = CallingConvention.Winapi)]
        public unsafe partial void ObjectPtrLabel([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        [NativeApi(EntryPoint = "glPopDebugGroup", Convention = CallingConvention.Winapi)]
        public partial void PopDebugGroup();

        [NativeApi(EntryPoint = "glPushDebugGroup", Convention = CallingConvention.Winapi)]
        public unsafe partial void PushDebugGroup([Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Computed = "message, length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* message);

        public KhrDebug(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

