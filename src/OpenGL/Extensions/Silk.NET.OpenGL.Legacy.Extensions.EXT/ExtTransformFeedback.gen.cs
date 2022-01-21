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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_transform_feedback")]
    public unsafe partial class ExtTransformFeedback : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_transform_feedback";
        [NativeApi(EntryPoint = "glBeginTransformFeedbackEXT", Convention = CallingConvention.Winapi)]
        public partial void BeginTransformFeedback([Flow(FlowDirection.In)] EXT primitiveMode);

        [NativeApi(EntryPoint = "glBeginTransformFeedbackEXT", Convention = CallingConvention.Winapi)]
        public partial void BeginTransformFeedback([Flow(FlowDirection.In)] PrimitiveType primitiveMode);

        [NativeApi(EntryPoint = "glBindBufferBaseEXT", Convention = CallingConvention.Winapi)]
        public partial void BindBufferBase([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBindBufferBaseEXT", Convention = CallingConvention.Winapi)]
        public partial void BindBufferBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBindBufferOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void BindBufferOffset([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glBindBufferOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void BindBufferOffset([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glBindBufferRangeEXT", Convention = CallingConvention.Winapi)]
        public partial void BindBufferRange([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glBindBufferRangeEXT", Convention = CallingConvention.Winapi)]
        public partial void BindBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glEndTransformFeedbackEXT", Convention = CallingConvention.Winapi)]
        public partial void EndTransformFeedback();

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out EXT type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out EXT type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out EXT type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out EXT type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out EXT type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out EXT type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out EXT type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out EXT type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out EXT type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out EXT type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out EXT type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out EXT type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glTransformFeedbackVaryingsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** varyings, [Flow(FlowDirection.In)] EXT bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackVaryingsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in byte* varyings, [Flow(FlowDirection.In)] EXT bufferMode);

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out EXT type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out EXT type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out EXT type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out EXT type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, out length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, out length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out EXT type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, out length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out EXT type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, out length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, out length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, out length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out EXT type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, out length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out EXT type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, out length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, out length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, out length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, out length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, out length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, out length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, out length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, out length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetTransformFeedbackVarying(program, index, (uint) name.Length, out length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] varyingsSa, [Flow(FlowDirection.In)] EXT bufferMode)
        {
            // StringArrayOverloader
            var varyings = (byte**) SilkMarshal.StringArrayToPtr(varyingsSa);
            TransformFeedbackVaryings(program, count, varyings, bufferMode);
            SilkMarshal.CopyPtrToStringArray((nint) varyings, varyingsSa);
            SilkMarshal.Free((nint) varyings);
        }

        public ExtTransformFeedback(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

