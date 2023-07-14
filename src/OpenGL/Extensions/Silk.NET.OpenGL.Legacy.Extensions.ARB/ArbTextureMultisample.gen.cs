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
    [Extension("ARB_texture_multisample")]
    public unsafe partial class ArbTextureMultisample : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_texture_multisample";
        [NativeApi(EntryPoint = "glGetMultisamplefv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* val);

        [NativeApi(EntryPoint = "glGetMultisamplefv", Convention = CallingConvention.Winapi)]
        public partial void GetMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float val);

        [NativeApi(EntryPoint = "glGetMultisamplefv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMultisamplePNameNV pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* val);

        [NativeApi(EntryPoint = "glGetMultisamplefv", Convention = CallingConvention.Winapi)]
        public partial void GetMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMultisamplePNameNV pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float val);

        [NativeApi(EntryPoint = "glSampleMaski", Convention = CallingConvention.Winapi)]
        public partial void SampleMask([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maskNumber, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glTexImage2DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TexImage2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexImage2DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TexImage2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexImage2DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TexImage2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexImage2DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TexImage2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexImage3DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TexImage3DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexImage3DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TexImage3DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexImage3DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TexImage3DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexImage3DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TexImage3DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedsamplelocations);

        public unsafe float GetMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetMultisample(pname, index, out float silkRet);
            return silkRet;
        }

        public unsafe float GetMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMultisamplePNameNV pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetMultisample(pname, index, out float silkRet);
            return silkRet;
        }

        public ArbTextureMultisample(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

