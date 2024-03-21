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

        [NativeApi(EntryPoint = "glDebugMessageCallbackAMD", Convention = CallingConvention.Winapi)]
        public partial void DebugMessageCallback<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProcAmd callback, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 userParam) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDebugMessageEnableAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugMessageEnable([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageEnableAMD", Convention = CallingConvention.Winapi)]
        public partial void DebugMessageEnable([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageEnableAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugMessageEnable([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSeverity severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageEnableAMD", Convention = CallingConvention.Winapi)]
        public partial void DebugMessageEnable([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSeverity severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageInsertAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugMessageInsert([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertAMD", Convention = CallingConvention.Winapi)]
        public partial void DebugMessageInsert([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertAMD", Convention = CallingConvention.Winapi)]
        public partial void DebugMessageInsert([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugMessageInsert([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSeverity severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertAMD", Convention = CallingConvention.Winapi)]
        public partial void DebugMessageInsert([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSeverity severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertAMD", Convention = CallingConvention.Winapi)]
        public partial void DebugMessageInsert([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSeverity severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public partial uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        public unsafe void DebugMessageEnable([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD severity, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled)
        {
            // ImplicitCountSpanOverloader
            DebugMessageEnable(category, severity, (uint) ids.Length, in ids.GetPinnableReference(), enabled);
        }

        public unsafe void DebugMessageEnable([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSeverity severity, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool enabled)
        {
            // ImplicitCountSpanOverloader
            DebugMessageEnable(category, severity, (uint) ids.Length, in ids.GetPinnableReference(), enabled);
        }

        public unsafe void DebugMessageInsert([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // ImplicitCountSpanOverloader
            DebugMessageInsert(category, severity, id, (uint) buf.Length, in buf.GetPinnableReference());
        }

        public unsafe void DebugMessageInsert([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugSeverity severity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // ImplicitCountSpanOverloader
            DebugMessageInsert(category, severity, id, (uint) buf.Length, in buf.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog(count, (uint) message.Length, categories, severities, ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog(count, (uint) message.Length, categories, severities, ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, categories, severities, ids, out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, severities, ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, severities, ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, bufSize, categories, severities, out ids.GetPinnableReference(), lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, categories, severities, out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, categories, severities, out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, categories, severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) severities.Length, bufSize, categories, out severities.GetPinnableReference(), ids, lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) severities.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) severities.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, categories, out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, bufSize, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) categories.Length, bufSize, out categories.GetPinnableReference(), severities, ids, lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) categories.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) categories.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, out categories.GetPinnableReference(), severities, ids, out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, bufSize, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) severities.Length, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) severities.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) severities.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog(count, (uint) message.Length, categories, severities, ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog(count, (uint) message.Length, categories, severities, ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, categories, severities, ids, out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, severities, ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, severities, ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, bufSize, categories, severities, out ids.GetPinnableReference(), lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, categories, severities, out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, categories, severities, out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, categories, severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) severities.Length, bufSize, categories, out severities.GetPinnableReference(), ids, lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) severities.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) severities.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, categories, out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, bufSize, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) categories.Length, bufSize, out categories.GetPinnableReference(), severities, ids, lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) categories.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) categories.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, out categories.GetPinnableReference(), severities, ids, out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, bufSize, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) severities.Length, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) severities.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) severities.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe T0 DebugMessageCallback<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProcAmd callback) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            DebugMessageCallback(callback, out T0 silkRet);
            return silkRet;
        }

        public AmdDebugOutput(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

