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
    [Extension("NV_explicit_multisample")]
    public unsafe partial class NVExplicitMultisample : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_explicit_multisample";
        [NativeApi(EntryPoint = "glGetMultisamplefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* val);

        [NativeApi(EntryPoint = "glGetMultisamplefvNV", Convention = CallingConvention.Winapi)]
        public partial void GetMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float val);

        [NativeApi(EntryPoint = "glGetMultisamplefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMultisamplePNameNV pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* val);

        [NativeApi(EntryPoint = "glGetMultisamplefvNV", Convention = CallingConvention.Winapi)]
        public partial void GetMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMultisamplePNameNV pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float val);

        [NativeApi(EntryPoint = "glSampleMaskIndexedNV", Convention = CallingConvention.Winapi)]
        public partial void SampleMaskIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glTexRenderbufferNV", Convention = CallingConvention.Winapi)]
        public partial void TexRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glTexRenderbufferNV", Convention = CallingConvention.Winapi)]
        public partial void TexRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        public unsafe float GetMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
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

        public NVExplicitMultisample(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

