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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.MESA
{
    [Extension("MESA_sampler_objects")]
    public unsafe partial class MesaSamplerObjects : NativeExtension<GL>
    {
        public const string ExtensionName = "MESA_sampler_objects";
        [NativeApi(EntryPoint = "glBindSampler", Convention = CallingConvention.Winapi)]
        public partial void BindSampler([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint unit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler);

        [NativeApi(EntryPoint = "glDeleteSamplers", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteSamplers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* samplers);

        [NativeApi(EntryPoint = "glDeleteSamplers", Convention = CallingConvention.Winapi)]
        public partial void DeleteSamplers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint samplers);

        [NativeApi(EntryPoint = "glDeleteSamplers", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteSamplers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Sampler* samplers);

        [NativeApi(EntryPoint = "glDeleteSamplers", Convention = CallingConvention.Winapi)]
        public partial void DeleteSamplers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Sampler samplers);

        [NativeApi(EntryPoint = "glGenSamplers", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenSamplers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* samplers);

        [NativeApi(EntryPoint = "glGenSamplers", Convention = CallingConvention.Winapi)]
        public partial void GenSamplers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint samplers);

        [NativeApi(EntryPoint = "glGenSamplers", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenSamplers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Sampler* samplers);

        [NativeApi(EntryPoint = "glGenSamplers", Convention = CallingConvention.Winapi)]
        public partial void GenSamplers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Sampler samplers);

        [NativeApi(EntryPoint = "glGetSamplerParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetSamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSamplerParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetSamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetSamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetSamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glIsSampler", Convention = CallingConvention.Winapi)]
        public partial bool IsSampler([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler);

        [NativeApi(EntryPoint = "glSamplerParameteri", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glSamplerParameteri", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerParameterI pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glSamplerParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void SamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameteriv", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int param);

        [NativeApi(EntryPoint = "glSamplerParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void SamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameteriv", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int param);

        [NativeApi(EntryPoint = "glSamplerParameterf", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glSamplerParameterf", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerParameterF pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glSamplerParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void SamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glSamplerParameterfv", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float param);

        [NativeApi(EntryPoint = "glSamplerParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void SamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glSamplerParameterfv", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float param);

        public unsafe void DeleteSampler([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samplers)
        {
            // ArrayParameterOverloader
            DeleteSamplers(1, &samplers);
        }

        public unsafe void DeleteSamplers([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> samplers)
        {
            // ImplicitCountSpanOverloader
            DeleteSamplers((uint) samplers.Length, in samplers.GetPinnableReference());
        }

        public unsafe void DeleteSamplers([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Sampler> samplers)
        {
            // ImplicitCountSpanOverloader
            DeleteSamplers((uint) samplers.Length, in samplers.GetPinnableReference());
        }

        public unsafe uint GenSampler()
        {
            const uint count = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenSamplers(count, &ret);
            return ret;
        }

        public unsafe void GenSamplers([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> samplers)
        {
            // ImplicitCountSpanOverloader
            GenSamplers((uint) samplers.Length, out samplers.GetPinnableReference());
        }

        public unsafe void GenSamplers([Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Sampler> samplers)
        {
            // ImplicitCountSpanOverloader
            GenSamplers((uint) samplers.Length, out samplers.GetPinnableReference());
        }

        public unsafe uint GenSamplers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // NonKhrReturnTypeOverloader
            GenSamplers(count, out uint silkRet);
            return silkRet;
        }

        public unsafe int GetSamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MESA pname)
        {
            // NonKhrReturnTypeOverloader
            GetSamplerParameter(sampler, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetSamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerParameterI pname)
        {
            // NonKhrReturnTypeOverloader
            GetSamplerParameter(sampler, pname, out int silkRet);
            return silkRet;
        }

        public unsafe float GetSamplerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerParameterF pname)
        {
            // NonKhrReturnTypeOverloader
            GetSamplerParameter(sampler, pname, out float silkRet);
            return silkRet;
        }

        public MesaSamplerObjects(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

