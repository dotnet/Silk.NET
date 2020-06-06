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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_cull_vertex")]
    public unsafe partial class ExtCullVertex : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_cull_vertex";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glCullParameterdvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CullParameter([Flow(FlowDirection.In)] EXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params)
            => ImplCullParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glCullParameterdvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CullParameter([Flow(FlowDirection.In)] EXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params)
            => ImplCullParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glCullParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CullParameter([Flow(FlowDirection.In)] EXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params)
            => ImplCullParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glCullParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CullParameter([Flow(FlowDirection.In)] EXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
            => ImplCullParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glCullParameterdvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CullParameter([Flow(FlowDirection.In)] CullParameterEXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params)
            => ImplCullParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glCullParameterdvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CullParameter([Flow(FlowDirection.In)] CullParameterEXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params)
            => ImplCullParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glCullParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CullParameter([Flow(FlowDirection.In)] CullParameterEXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params)
            => ImplCullParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glCullParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CullParameter([Flow(FlowDirection.In)] CullParameterEXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
            => ImplCullParameter(pname, @params);

        public ExtCullVertex(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

