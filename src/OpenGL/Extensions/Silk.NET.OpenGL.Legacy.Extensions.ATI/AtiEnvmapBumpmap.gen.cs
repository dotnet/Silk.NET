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

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_envmap_bumpmap")]
    public unsafe partial class AtiEnvmapBumpmap : NativeExtension<GL>
    {
        public const string ExtensionName = "ATI_envmap_bumpmap";
        [NativeApi(EntryPoint = "glGetTexBumpParameterivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexBumpParameter([Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetTexBumpParameterivATI", Convention = CallingConvention.Winapi)]
        public partial void GetTexBumpParameter([Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int param);

        [NativeApi(EntryPoint = "glGetTexBumpParameterivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexBumpParameter([Flow(FlowDirection.In)] GetTexBumpParameterATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetTexBumpParameterivATI", Convention = CallingConvention.Winapi)]
        public partial void GetTexBumpParameter([Flow(FlowDirection.In)] GetTexBumpParameterATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int param);

        [NativeApi(EntryPoint = "glGetTexBumpParameterfvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexBumpParameter([Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* param);

        [NativeApi(EntryPoint = "glGetTexBumpParameterfvATI", Convention = CallingConvention.Winapi)]
        public partial void GetTexBumpParameter([Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float param);

        [NativeApi(EntryPoint = "glGetTexBumpParameterfvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexBumpParameter([Flow(FlowDirection.In)] GetTexBumpParameterATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* param);

        [NativeApi(EntryPoint = "glGetTexBumpParameterfvATI", Convention = CallingConvention.Winapi)]
        public partial void GetTexBumpParameter([Flow(FlowDirection.In)] GetTexBumpParameterATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float param);

        [NativeApi(EntryPoint = "glTexBumpParameterivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexBumpParameter([Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glTexBumpParameterivATI", Convention = CallingConvention.Winapi)]
        public partial void TexBumpParameter([Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int param);

        [NativeApi(EntryPoint = "glTexBumpParameterivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexBumpParameter([Flow(FlowDirection.In)] TexBumpParameterATI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glTexBumpParameterivATI", Convention = CallingConvention.Winapi)]
        public partial void TexBumpParameter([Flow(FlowDirection.In)] TexBumpParameterATI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int param);

        [NativeApi(EntryPoint = "glTexBumpParameterfvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexBumpParameter([Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glTexBumpParameterfvATI", Convention = CallingConvention.Winapi)]
        public partial void TexBumpParameter([Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float param);

        [NativeApi(EntryPoint = "glTexBumpParameterfvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexBumpParameter([Flow(FlowDirection.In)] TexBumpParameterATI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glTexBumpParameterfvATI", Convention = CallingConvention.Winapi)]
        public partial void TexBumpParameter([Flow(FlowDirection.In)] TexBumpParameterATI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float param);

        public unsafe int GetTexBumpParameter([Flow(FlowDirection.In)] ATI pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetTexBumpParameter(pname, &ret);
            return ret;
        }

        public AtiEnvmapBumpmap(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

