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
        public unsafe partial void DebugMessageCallback([Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProcAmd callback, [Flow(FlowDirection.Out)] void* userParam);

        [NativeApi(EntryPoint = "glDebugMessageCallbackAMD", Convention = CallingConvention.Winapi)]
        public partial void DebugMessageCallback<T0>([Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProcAmd callback, [Flow(FlowDirection.Out)] out T0 userParam) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDebugMessageEnableAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugMessageEnable([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] AMD severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageEnableAMD", Convention = CallingConvention.Winapi)]
        public partial void DebugMessageEnable([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] AMD severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageEnableAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugMessageEnable([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] AMD severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] Boolean enabled);

        [NativeApi(EntryPoint = "glDebugMessageEnableAMD", Convention = CallingConvention.Winapi)]
        public partial void DebugMessageEnable([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] AMD severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint ids, [Flow(FlowDirection.In)] Boolean enabled);

        [NativeApi(EntryPoint = "glDebugMessageEnableAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugMessageEnable([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageEnableAMD", Convention = CallingConvention.Winapi)]
        public partial void DebugMessageEnable([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageEnableAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugMessageEnable([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] Boolean enabled);

        [NativeApi(EntryPoint = "glDebugMessageEnableAMD", Convention = CallingConvention.Winapi)]
        public partial void DebugMessageEnable([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint ids, [Flow(FlowDirection.In)] Boolean enabled);

        [NativeApi(EntryPoint = "glDebugMessageInsertAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugMessageInsert([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] AMD severity, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertAMD", Convention = CallingConvention.Winapi)]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] AMD severity, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] in byte buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertAMD", Convention = CallingConvention.Winapi)]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] AMD severity, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugMessageInsert([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertAMD", Convention = CallingConvention.Winapi)]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] in byte buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertAMD", Convention = CallingConvention.Winapi)]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD", Convention = CallingConvention.Winapi)]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out AMD categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string message);

        public unsafe void DebugMessageEnable([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] AMD severity, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(FlowDirection.In)] bool enabled)
        {
            // ImplicitCountSpanOverloader
            DebugMessageEnable(category, severity, (uint) ids.Length, in ids.GetPinnableReference(), enabled);
        }

        public unsafe void DebugMessageEnable([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] AMD severity, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(FlowDirection.In)] Boolean enabled)
        {
            // ImplicitCountSpanOverloader
            DebugMessageEnable(category, severity, (uint) ids.Length, in ids.GetPinnableReference(), enabled);
        }

        public unsafe void DebugMessageEnable([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] DebugSeverity severity, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(FlowDirection.In)] bool enabled)
        {
            // ImplicitCountSpanOverloader
            DebugMessageEnable(category, severity, (uint) ids.Length, in ids.GetPinnableReference(), enabled);
        }

        public unsafe void DebugMessageEnable([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] DebugSeverity severity, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> ids, [Flow(FlowDirection.In)] Boolean enabled)
        {
            // ImplicitCountSpanOverloader
            DebugMessageEnable(category, severity, (uint) ids.Length, in ids.GetPinnableReference(), enabled);
        }

        public unsafe void DebugMessageInsert([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] AMD severity, [Flow(FlowDirection.In)] uint id, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // ImplicitCountSpanOverloader
            DebugMessageInsert(category, severity, id, (uint) buf.Length, in buf.GetPinnableReference());
        }

        public unsafe void DebugMessageInsert([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint id, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<byte> buf)
        {
            // ImplicitCountSpanOverloader
            DebugMessageInsert(category, severity, id, (uint) buf.Length, in buf.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog(count, (uint) message.Length, categories, severities, ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog(count, (uint) message.Length, categories, severities, ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, categories, severities, ids, out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, severities, ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, severities, ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, bufSize, categories, severities, out ids.GetPinnableReference(), lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, categories, severities, out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, categories, severities, out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, categories, severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) severities.Length, bufSize, categories, out severities.GetPinnableReference(), ids, lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) severities.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) severities.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, categories, out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, bufSize, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) categories.Length, bufSize, out categories.GetPinnableReference(), severities, ids, lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) categories.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) categories.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, out categories.GetPinnableReference(), severities, ids, out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, bufSize, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) severities.Length, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) severities.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) severities.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog(count, (uint) message.Length, categories, severities, ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog(count, (uint) message.Length, categories, severities, ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, categories, severities, ids, out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, severities, ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, severities, ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, bufSize, categories, severities, out ids.GetPinnableReference(), lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, categories, severities, out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, categories, severities, out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, categories, severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) severities.Length, bufSize, categories, out severities.GetPinnableReference(), ids, lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) severities.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) severities.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, categories, out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, bufSize, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, categories, out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) categories.Length, bufSize, out categories.GetPinnableReference(), severities, ids, lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) categories.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) categories.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, out categories.GetPinnableReference(), severities, ids, out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, bufSize, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), severities, out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) severities.Length, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) severities.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) severities.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), ids, out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) ids.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), lengths, out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, bufSize, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), message);
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public unsafe uint GetDebugMessageLog([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> message)
        {
            // ImplicitCountSpanOverloader
            return GetDebugMessageLog((uint) lengths.Length, (uint) message.Length, out categories.GetPinnableReference(), out severities.GetPinnableReference(), out ids.GetPinnableReference(), out lengths.GetPinnableReference(), out message.GetPinnableReference());
        }

        public AmdDebugOutput(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

