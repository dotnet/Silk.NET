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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_sampler_objects")]
    public unsafe partial class ArbSamplerObjects : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_sampler_objects";
        [NativeApi(EntryPoint = "glBindSampler", Convention = CallingConvention.Winapi)]
        public partial void BindSampler([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint unit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler);

        [NativeApi(EntryPoint = "glDeleteSamplers", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteSamplers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* samplers);

        [NativeApi(EntryPoint = "glGenSamplers", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenSamplers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* samplers);

        [NativeApi(EntryPoint = "glGetSamplerParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glIsSampler", Convention = CallingConvention.Winapi)]
        public partial bool IsSampler([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler);

        [NativeApi(EntryPoint = "glSamplerParameteri", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glSamplerParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void SamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameterf", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glSamplerParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void SamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glSamplerParameterIiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void SamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameterIuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void SamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* param);

        public ArbSamplerObjects(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

