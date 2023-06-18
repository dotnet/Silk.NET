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
        public partial void BeginTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT primitiveMode);

        [NativeApi(EntryPoint = "glBindBufferBaseEXT", Convention = CallingConvention.Winapi)]
        public partial void BindBufferBase([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBindBufferOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void BindBufferOffset([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glBindBufferRangeEXT", Convention = CallingConvention.Winapi)]
        public partial void BindBufferRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glEndTransformFeedbackEXT", Convention = CallingConvention.Winapi)]
        public partial void EndTransformFeedback();

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] EXT* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glTransformFeedbackVaryingsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformFeedbackVaryings([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** varyings, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT bufferMode);

        public ExtTransformFeedback(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

