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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_transform_feedback")]
    public unsafe partial class NVTransformFeedback : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_transform_feedback";
        [NativeApi(EntryPoint = "glActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glBeginTransformFeedbackNV", Convention = CallingConvention.Winapi)]
        public partial void BeginTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV primitiveMode);

        [NativeApi(EntryPoint = "glBindBufferBaseNV", Convention = CallingConvention.Winapi)]
        public partial void BindBufferBase([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBindBufferOffsetNV", Convention = CallingConvention.Winapi)]
        public partial void BindBufferOffset([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glBindBufferRangeNV", Convention = CallingConvention.Winapi)]
        public partial void BindBufferRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glEndTransformFeedbackNV", Convention = CallingConvention.Winapi)]
        public partial void EndTransformFeedback();

        [NativeApi(EntryPoint = "glGetActiveVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVaryingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbackVarying([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* location);

        [NativeApi(EntryPoint = "glGetVaryingLocationNV", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetVaryingLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glTransformFeedbackAttribsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformFeedbackAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attribs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackStreamAttribsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformFeedbackStreamAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attribs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nbuffers, [Count(Parameter = "nbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* bufstreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackVaryingsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformFeedbackVaryings([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* locations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bufferMode);

        public NVTransformFeedback(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

