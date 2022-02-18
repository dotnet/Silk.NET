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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_sampler_objects")]
    public unsafe partial class ArbSamplerObjects : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_sampler_objects";
        [NativeApi(EntryPoint = "glBindSampler", Convention = CallingConvention.Winapi)]
        public partial void BindSampler([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint sampler);

        [NativeApi(EntryPoint = "glDeleteSamplers", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* samplers);

        [NativeApi(EntryPoint = "glDeleteSamplers", Convention = CallingConvention.Winapi)]
        public partial void DeleteSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint samplers);

        [NativeApi(EntryPoint = "glDeleteSamplers", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Sampler* samplers);

        [NativeApi(EntryPoint = "glDeleteSamplers", Convention = CallingConvention.Winapi)]
        public partial void DeleteSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Sampler samplers);

        [NativeApi(EntryPoint = "glGenSamplers", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* samplers);

        [NativeApi(EntryPoint = "glGenSamplers", Convention = CallingConvention.Winapi)]
        public partial void GenSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint samplers);

        [NativeApi(EntryPoint = "glGenSamplers", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Sampler* samplers);

        [NativeApi(EntryPoint = "glGenSamplers", Convention = CallingConvention.Winapi)]
        public partial void GenSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out Sampler samplers);

        [NativeApi(EntryPoint = "glGetSamplerParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSamplerParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIiv", Convention = CallingConvention.Winapi)]
        public partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIiv", Convention = CallingConvention.Winapi)]
        public partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv", Convention = CallingConvention.Winapi)]
        public partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv", Convention = CallingConvention.Winapi)]
        public partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glIsSampler", Convention = CallingConvention.Winapi)]
        public partial bool IsSampler([Flow(FlowDirection.In)] uint sampler);

        [NativeApi(EntryPoint = "glSamplerParameteri", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glSamplerParameteri", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glSamplerParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameteriv", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int param);

        [NativeApi(EntryPoint = "glSamplerParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameteriv", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int param);

        [NativeApi(EntryPoint = "glSamplerParameterf", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glSamplerParameterf", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glSamplerParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glSamplerParameterfv", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float param);

        [NativeApi(EntryPoint = "glSamplerParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glSamplerParameterfv", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float param);

        [NativeApi(EntryPoint = "glSamplerParameterIiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameterIiv", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int param);

        [NativeApi(EntryPoint = "glSamplerParameterIiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameterIiv", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int param);

        [NativeApi(EntryPoint = "glSamplerParameterIuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* param);

        [NativeApi(EntryPoint = "glSamplerParameterIuiv", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in uint param);

        [NativeApi(EntryPoint = "glSamplerParameterIuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* param);

        [NativeApi(EntryPoint = "glSamplerParameterIuiv", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in uint param);

        public unsafe void DeleteSampler([Count(Parameter = "count"), Flow(FlowDirection.In)] uint samplers)
        {
            // ArrayParameterOverloader
            DeleteSamplers(1, &samplers);
        }

        public unsafe void DeleteSamplers([Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> samplers)
        {
            // ImplicitCountSpanOverloader
            DeleteSamplers((uint) samplers.Length, in samplers.GetPinnableReference());
        }

        public unsafe void DeleteSamplers([Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Sampler> samplers)
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

        public unsafe void GenSamplers([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> samplers)
        {
            // ImplicitCountSpanOverloader
            GenSamplers((uint) samplers.Length, out samplers.GetPinnableReference());
        }

        public unsafe void GenSamplers([Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<Sampler> samplers)
        {
            // ImplicitCountSpanOverloader
            GenSamplers((uint) samplers.Length, out samplers.GetPinnableReference());
        }

        public ArbSamplerObjects(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

