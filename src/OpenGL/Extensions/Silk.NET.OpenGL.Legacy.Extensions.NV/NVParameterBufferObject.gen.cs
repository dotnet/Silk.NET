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
    [Extension("NV_parameter_buffer_object")]
    public unsafe partial class NVParameterBufferObject : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_parameter_buffer_object";
        [NativeApi(EntryPoint = "glProgramBufferParametersfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramBufferParameters([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glProgramBufferParametersfvNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramBufferParameters([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glProgramBufferParametersfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramBufferParameters([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glProgramBufferParametersfvNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramBufferParameters([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glProgramBufferParametersIivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramBufferParametersI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramBufferParametersIivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramBufferParametersI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glProgramBufferParametersIivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramBufferParametersI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramBufferParametersIivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramBufferParametersI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glProgramBufferParametersIuivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramBufferParametersI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramBufferParametersIuivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramBufferParametersI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glProgramBufferParametersIuivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramBufferParametersI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramBufferParametersIuivNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramBufferParametersI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint @params);

        public unsafe void ProgramBufferParameters([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramBufferParameters(target, bindingIndex, wordIndex, (uint) @params.Length, in @params.GetPinnableReference());
        }

        public unsafe void ProgramBufferParameters([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramBufferParameters(target, bindingIndex, wordIndex, (uint) @params.Length, in @params.GetPinnableReference());
        }

        public unsafe void ProgramBufferParametersI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramBufferParametersI(target, bindingIndex, wordIndex, (uint) @params.Length, in @params.GetPinnableReference());
        }

        public unsafe void ProgramBufferParametersI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramBufferParametersI(target, bindingIndex, wordIndex, (uint) @params.Length, in @params.GetPinnableReference());
        }

        public unsafe void ProgramBufferParametersI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramBufferParametersI(target, bindingIndex, wordIndex, (uint) @params.Length, in @params.GetPinnableReference());
        }

        public unsafe void ProgramBufferParametersI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // ImplicitCountSpanOverloader
            ProgramBufferParametersI(target, bindingIndex, wordIndex, (uint) @params.Length, in @params.GetPinnableReference());
        }

        public NVParameterBufferObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

