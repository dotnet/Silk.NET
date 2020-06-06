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
    [Extension("ARB_vertex_type_2_10_10_10_rev")]
    public unsafe partial class ArbVertexType2101010Rev : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_vertex_type_2_10_10_10_rev";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP1ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value)
            => ImplVertexAttribP1(index, type, normalized, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value)
            => ImplVertexAttribP1(index, type, normalized, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value)
            => ImplVertexAttribP1(index, type, normalized, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP2ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value)
            => ImplVertexAttribP2(index, type, normalized, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value)
            => ImplVertexAttribP2(index, type, normalized, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value)
            => ImplVertexAttribP2(index, type, normalized, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP3ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value)
            => ImplVertexAttribP3(index, type, normalized, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value)
            => ImplVertexAttribP3(index, type, normalized, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value)
            => ImplVertexAttribP3(index, type, normalized, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP4ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value)
            => ImplVertexAttribP4(index, type, normalized, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value)
            => ImplVertexAttribP4(index, type, normalized, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value)
            => ImplVertexAttribP4(index, type, normalized, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP1ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value)
            => ImplVertexAttribP1(index, type, normalized, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value)
            => ImplVertexAttribP1(index, type, normalized, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value)
            => ImplVertexAttribP1(index, type, normalized, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP2ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value)
            => ImplVertexAttribP2(index, type, normalized, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value)
            => ImplVertexAttribP2(index, type, normalized, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value)
            => ImplVertexAttribP2(index, type, normalized, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP3ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value)
            => ImplVertexAttribP3(index, type, normalized, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value)
            => ImplVertexAttribP3(index, type, normalized, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value)
            => ImplVertexAttribP3(index, type, normalized, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP4ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value)
            => ImplVertexAttribP4(index, type, normalized, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value)
            => ImplVertexAttribP4(index, type, normalized, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value)
            => ImplVertexAttribP4(index, type, normalized, value);

        public ArbVertexType2101010Rev(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

