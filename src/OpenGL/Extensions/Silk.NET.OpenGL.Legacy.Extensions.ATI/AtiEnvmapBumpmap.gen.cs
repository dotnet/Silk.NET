// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_envmap_bumpmap")]
    public abstract unsafe partial class AtiEnvmapBumpmap : NativeExtension<GL>
    {
        public const string ExtensionName = "ATI_envmap_bumpmap";
        [NativeApi(EntryPoint = "glGetTexBumpParameterivATI")]
        public abstract unsafe void GetTexBumpParameter([Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetTexBumpParameterivATI")]
        public abstract void GetTexBumpParameter([Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int param);

        [NativeApi(EntryPoint = "glGetTexBumpParameterfvATI")]
        public abstract unsafe void GetTexBumpParameter([Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* param);

        [NativeApi(EntryPoint = "glGetTexBumpParameterfvATI")]
        public abstract void GetTexBumpParameter([Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float param);

        [NativeApi(EntryPoint = "glTexBumpParameterivATI")]
        public abstract unsafe void TexBumpParameter([Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glTexBumpParameterivATI")]
        public abstract void TexBumpParameter([Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

        [NativeApi(EntryPoint = "glTexBumpParameterfvATI")]
        public abstract unsafe void TexBumpParameter([Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glTexBumpParameterfvATI")]
        public abstract void TexBumpParameter([Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float param);

        [NativeApi(EntryPoint = "glGetTexBumpParameterivATI")]
        public abstract unsafe void GetTexBumpParameter([Flow(FlowDirection.In)] GetTexBumpParameterATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetTexBumpParameterivATI")]
        public abstract void GetTexBumpParameter([Flow(FlowDirection.In)] GetTexBumpParameterATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int param);

        [NativeApi(EntryPoint = "glGetTexBumpParameterfvATI")]
        public abstract unsafe void GetTexBumpParameter([Flow(FlowDirection.In)] GetTexBumpParameterATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* param);

        [NativeApi(EntryPoint = "glGetTexBumpParameterfvATI")]
        public abstract void GetTexBumpParameter([Flow(FlowDirection.In)] GetTexBumpParameterATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float param);

        [NativeApi(EntryPoint = "glTexBumpParameterivATI")]
        public abstract unsafe void TexBumpParameter([Flow(FlowDirection.In)] TexBumpParameterATI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glTexBumpParameterivATI")]
        public abstract void TexBumpParameter([Flow(FlowDirection.In)] TexBumpParameterATI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

        [NativeApi(EntryPoint = "glTexBumpParameterfvATI")]
        public abstract unsafe void TexBumpParameter([Flow(FlowDirection.In)] TexBumpParameterATI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glTexBumpParameterfvATI")]
        public abstract void TexBumpParameter([Flow(FlowDirection.In)] TexBumpParameterATI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float param);

        public unsafe int GetTexBumpParameter([Flow(FlowDirection.In)] ATI pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetTexBumpParameter(pname, &ret);
            return ret;
        }

        public unsafe int GetTexBumpParameter([Flow(FlowDirection.In)] GetTexBumpParameterATI pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetTexBumpParameter(pname, &ret);
            return ret;
        }

        public AtiEnvmapBumpmap(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

