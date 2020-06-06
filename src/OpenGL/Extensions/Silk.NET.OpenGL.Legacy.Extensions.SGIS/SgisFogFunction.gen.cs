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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    [Extension("SGIS_fog_function")]
    public unsafe partial class SgisFogFunction : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIS_fog_function";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glFogFuncSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FogFunc([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* points)
            => ImplFogFunc(n, points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glFogFuncSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FogFunc([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<float> points)
            => ImplFogFunc(n, points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="points">
        /// To be added.
        /// This parameter contains 0 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetFogFuncSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFogFunc([Count(Count = 0), Flow(FlowDirection.Out)] float* points)
            => ImplGetFogFunc(points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="points">
        /// To be added.
        /// This parameter contains 0 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetFogFuncSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFogFunc([Count(Count = 0), Flow(FlowDirection.Out)] out float points)
            => ImplGetFogFunc(points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="points">
        /// To be added.
        /// This parameter contains 0 elements.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe float GetFogFunc()
        {
            // ReturnTypeOverloader
            float ret = default;
            GetFogFunc(&ret);
            return ret;
        }

        public SgisFogFunction(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

