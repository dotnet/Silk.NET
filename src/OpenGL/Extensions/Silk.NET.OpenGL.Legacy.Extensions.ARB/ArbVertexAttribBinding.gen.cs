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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_vertex_attrib_binding")]
    public unsafe partial class ArbVertexAttribBinding : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_vertex_attrib_binding";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="bindingindex">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindVertexBuffer")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindVertexBuffer([Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] uint stride)
            => ImplBindVertexBuffer(bindingindex, buffer, offset, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="attribindex">
        /// To be added.
        /// </param>
        /// <param name="bindingindex">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribBinding")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribBinding([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] uint bindingindex)
            => ImplVertexAttribBinding(attribindex, bindingindex);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="attribindex">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="relativeoffset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribFormat")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset)
            => ImplVertexAttribFormat(attribindex, size, type, normalized, relativeoffset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="attribindex">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="relativeoffset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribIFormat")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribIFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint relativeoffset)
            => ImplVertexAttribIFormat(attribindex, size, type, relativeoffset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="attribindex">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="relativeoffset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribLFormat")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribLFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint relativeoffset)
            => ImplVertexAttribLFormat(attribindex, size, type, relativeoffset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="bindingindex">
        /// To be added.
        /// </param>
        /// <param name="divisor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexBindingDivisor")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexBindingDivisor([Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint divisor)
            => ImplVertexBindingDivisor(bindingindex, divisor);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="attribindex">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="relativeoffset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribFormat")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset)
            => ImplVertexAttribFormat(attribindex, size, type, normalized, relativeoffset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="attribindex">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="relativeoffset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribIFormat")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribIFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint relativeoffset)
            => ImplVertexAttribIFormat(attribindex, size, type, relativeoffset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="attribindex">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="relativeoffset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribLFormat")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribLFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint relativeoffset)
            => ImplVertexAttribLFormat(attribindex, size, type, relativeoffset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="bindingindex">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BindVertexBuffer([Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            BindVertexBuffer(bindingindex, buffer, new IntPtr(offset), stride);
        }

        public ArbVertexAttribBinding(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

