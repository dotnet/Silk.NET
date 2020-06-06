// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_vertex_array_object")]
    public unsafe partial class ArbVertexArrayObject : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_vertex_array_object";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="array">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindVertexArray")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindVertexArray([Flow(FlowDirection.In)] uint array)
            => ImplBindVertexArray(array);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="arrays">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteVertexArrays")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* arrays)
            => ImplDeleteVertexArrays(n, arrays);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="arrays">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteVertexArrays")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> arrays)
            => ImplDeleteVertexArrays(n, arrays);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="arrays">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenVertexArrays")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GenVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* arrays)
            => ImplGenVertexArrays(n, arrays);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="arrays">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenVertexArrays")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> arrays)
            => ImplGenVertexArrays(n, arrays);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="array">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsVertexArray")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsVertexArray([Flow(FlowDirection.In)] uint array)
            => ImplIsVertexArray(array);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="arrays">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteVertexArray([Count(Parameter = "n"), Flow(FlowDirection.In)] uint arrays)
        {
            // ArrayParameterOverloader
            DeleteVertexArrays(1, &arrays);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="arrays">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GenVertexArray()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenVertexArrays(n, &ret);
            return ret;
        }

        public ArbVertexArrayObject(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

