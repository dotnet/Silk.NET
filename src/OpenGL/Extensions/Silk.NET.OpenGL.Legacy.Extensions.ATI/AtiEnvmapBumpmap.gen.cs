// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_envmap_bumpmap")]
    public unsafe partial class AtiEnvmapBumpmap : NativeExtension<GL>
    {
        public const string ExtensionName = "ATI_envmap_bumpmap";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexBumpParameterivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTexBumpParameter([Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* param)
            => ImplGetTexBumpParameter(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexBumpParameterivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTexBumpParameter([Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int param)
            => ImplGetTexBumpParameter(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexBumpParameterfvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTexBumpParameter([Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* param)
            => ImplGetTexBumpParameter(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexBumpParameterfvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTexBumpParameter([Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float param)
            => ImplGetTexBumpParameter(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glTexBumpParameterivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexBumpParameter([Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param)
            => ImplTexBumpParameter(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glTexBumpParameterivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexBumpParameter([Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param)
            => ImplTexBumpParameter(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glTexBumpParameterfvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexBumpParameter([Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* param)
            => ImplTexBumpParameter(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glTexBumpParameterfvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexBumpParameter([Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float param)
            => ImplTexBumpParameter(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexBumpParameterivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTexBumpParameter([Flow(FlowDirection.In)] GetTexBumpParameterATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* param)
            => ImplGetTexBumpParameter(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexBumpParameterivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTexBumpParameter([Flow(FlowDirection.In)] GetTexBumpParameterATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int param)
            => ImplGetTexBumpParameter(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexBumpParameterfvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTexBumpParameter([Flow(FlowDirection.In)] GetTexBumpParameterATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* param)
            => ImplGetTexBumpParameter(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexBumpParameterfvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTexBumpParameter([Flow(FlowDirection.In)] GetTexBumpParameterATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float param)
            => ImplGetTexBumpParameter(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetTexBumpParameter([Flow(FlowDirection.In)] ATI pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetTexBumpParameter(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetTexBumpParameter([Flow(FlowDirection.In)] GetTexBumpParameterATI pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetTexBumpParameter(pname, &ret);
            return ret;
        }

        public AtiEnvmapBumpmap(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

