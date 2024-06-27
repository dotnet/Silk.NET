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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_texture_border_clamp")]
    public unsafe partial class ExtTextureBorderClamp : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_texture_border_clamp";
        [NativeApi(EntryPoint = "glGetSamplerParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetSamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetSamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetSamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetSamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glSamplerParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int param);

        [NativeApi(EntryPoint = "glSamplerParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int param);

        [NativeApi(EntryPoint = "glSamplerParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* param);

        [NativeApi(EntryPoint = "glSamplerParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint param);

        [NativeApi(EntryPoint = "glSamplerParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* param);

        [NativeApi(EntryPoint = "glSamplerParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void SamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint param);

        [NativeApi(EntryPoint = "glTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void TexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void TexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void TexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void TexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void TexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint @params);

        [NativeApi(EntryPoint = "glTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void TexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint @params);

        [NativeApi(EntryPoint = "glTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void TexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint @params);

        [NativeApi(EntryPoint = "glTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void TexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint @params);

        public unsafe int GetSamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetSamplerParameterI(sampler, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetSamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerParameterI pname)
        {
            // NonKhrReturnTypeOverloader
            GetSamplerParameterI(sampler, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetTexParameterI(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname)
        {
            // NonKhrReturnTypeOverloader
            GetTexParameterI(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetTexParameterI(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname)
        {
            // NonKhrReturnTypeOverloader
            GetTexParameterI(target, pname, out int silkRet);
            return silkRet;
        }

        public ExtTextureBorderClamp(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

