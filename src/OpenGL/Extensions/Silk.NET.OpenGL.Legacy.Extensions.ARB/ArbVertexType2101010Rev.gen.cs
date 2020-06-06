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
    [Extension("ARB_vertex_type_2_10_10_10_rev")]
    public unsafe partial class ArbVertexType2101010Rev : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_vertex_type_2_10_10_10_rev";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColorP3ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorP3([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint color)
            => ImplColorP3(type, color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColorP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ColorP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color)
            => ImplColorP3(type, color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColorP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color)
            => ImplColorP3(type, color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColorP4ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorP4([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint color)
            => ImplColorP4(type, color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColorP4uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ColorP4([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color)
            => ImplColorP4(type, color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColorP4uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorP4([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color)
            => ImplColorP4(type, color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP1ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoordP1([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords)
            => ImplMultiTexCoordP1(texture, type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoordP1([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords)
            => ImplMultiTexCoordP1(texture, type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoordP1([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords)
            => ImplMultiTexCoordP1(texture, type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP2ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoordP2([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords)
            => ImplMultiTexCoordP2(texture, type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoordP2([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords)
            => ImplMultiTexCoordP2(texture, type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoordP2([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords)
            => ImplMultiTexCoordP2(texture, type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP3ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoordP3([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords)
            => ImplMultiTexCoordP3(texture, type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoordP3([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords)
            => ImplMultiTexCoordP3(texture, type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoordP3([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords)
            => ImplMultiTexCoordP3(texture, type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP4ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoordP4([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords)
            => ImplMultiTexCoordP4(texture, type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoordP4([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords)
            => ImplMultiTexCoordP4(texture, type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoordP4([Flow(FlowDirection.In)] ARB texture, [Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords)
            => ImplMultiTexCoordP4(texture, type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNormalP3ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalP3([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords)
            => ImplNormalP3(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NormalP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords)
            => ImplNormalP3(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords)
            => ImplNormalP3(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColorP3ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColorP3([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint color)
            => ImplSecondaryColorP3(type, color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColorP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SecondaryColorP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color)
            => ImplSecondaryColorP3(type, color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColorP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColorP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color)
            => ImplSecondaryColorP3(type, color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP1ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoordP1([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords)
            => ImplTexCoordP1(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP1uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoordP1([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords)
            => ImplTexCoordP1(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP1uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoordP1([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords)
            => ImplTexCoordP1(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP2ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoordP2([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords)
            => ImplTexCoordP2(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP2uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoordP2([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords)
            => ImplTexCoordP2(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP2uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoordP2([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords)
            => ImplTexCoordP2(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP3ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoordP3([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords)
            => ImplTexCoordP3(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoordP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords)
            => ImplTexCoordP3(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoordP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords)
            => ImplTexCoordP3(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP4ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoordP4([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint coords)
            => ImplTexCoordP4(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP4uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoordP4([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords)
            => ImplTexCoordP4(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP4uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoordP4([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords)
            => ImplTexCoordP4(type, coords);

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
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP2ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexP2([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint value)
            => ImplVertexP2(type, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP2uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexP2([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value)
            => ImplVertexP2(type, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP2uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexP2([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value)
            => ImplVertexP2(type, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP3ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexP3([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint value)
            => ImplVertexP3(type, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value)
            => ImplVertexP3(type, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexP3([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value)
            => ImplVertexP3(type, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP4ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexP4([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint value)
            => ImplVertexP4(type, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP4uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexP4([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value)
            => ImplVertexP4(type, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP4uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexP4([Flow(FlowDirection.In)] ARB type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value)
            => ImplVertexP4(type, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColorP3ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint color)
            => ImplColorP3(type, color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColorP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color)
            => ImplColorP3(type, color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColorP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color)
            => ImplColorP3(type, color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColorP4ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorP4([Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint color)
            => ImplColorP4(type, color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColorP4uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ColorP4([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color)
            => ImplColorP4(type, color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColorP4uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorP4([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color)
            => ImplColorP4(type, color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP1ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoordP1([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords)
            => ImplMultiTexCoordP1(texture, type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoordP1([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords)
            => ImplMultiTexCoordP1(texture, type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoordP1([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords)
            => ImplMultiTexCoordP1(texture, type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP2ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoordP2([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords)
            => ImplMultiTexCoordP2(texture, type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoordP2([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords)
            => ImplMultiTexCoordP2(texture, type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoordP2([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords)
            => ImplMultiTexCoordP2(texture, type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP3ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoordP3([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords)
            => ImplMultiTexCoordP3(texture, type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoordP3([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords)
            => ImplMultiTexCoordP3(texture, type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoordP3([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords)
            => ImplMultiTexCoordP3(texture, type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP4ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoordP4([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords)
            => ImplMultiTexCoordP4(texture, type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoordP4([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords)
            => ImplMultiTexCoordP4(texture, type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoordP4([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords)
            => ImplMultiTexCoordP4(texture, type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNormalP3ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalP3([Flow(FlowDirection.In)] NormalPointerType type, [Flow(FlowDirection.In)] uint coords)
            => ImplNormalP3(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NormalP3([Flow(FlowDirection.In)] NormalPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords)
            => ImplNormalP3(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalP3([Flow(FlowDirection.In)] NormalPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords)
            => ImplNormalP3(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColorP3ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint color)
            => ImplSecondaryColorP3(type, color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColorP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SecondaryColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color)
            => ImplSecondaryColorP3(type, color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColorP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color)
            => ImplSecondaryColorP3(type, color);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP1ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoordP1([Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords)
            => ImplTexCoordP1(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP1uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoordP1([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords)
            => ImplTexCoordP1(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP1uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoordP1([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords)
            => ImplTexCoordP1(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP2ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoordP2([Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords)
            => ImplTexCoordP2(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP2uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoordP2([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords)
            => ImplTexCoordP2(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP2uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoordP2([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords)
            => ImplTexCoordP2(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP3ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoordP3([Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords)
            => ImplTexCoordP3(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoordP3([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords)
            => ImplTexCoordP3(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoordP3([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords)
            => ImplTexCoordP3(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP4ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoordP4([Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords)
            => ImplTexCoordP4(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP4uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoordP4([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords)
            => ImplTexCoordP4(type, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordP4uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoordP4([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords)
            => ImplTexCoordP4(type, coords);

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

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP2ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexP2([Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint value)
            => ImplVertexP2(type, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP2uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexP2([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value)
            => ImplVertexP2(type, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP2uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexP2([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value)
            => ImplVertexP2(type, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP3ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexP3([Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint value)
            => ImplVertexP3(type, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexP3([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value)
            => ImplVertexP3(type, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP3uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexP3([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value)
            => ImplVertexP3(type, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP4ui")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexP4([Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint value)
            => ImplVertexP4(type, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP4uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexP4([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value)
            => ImplVertexP4(type, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexP4uiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexP4([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value)
            => ImplVertexP4(type, value);

        public ArbVertexType2101010Rev(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

