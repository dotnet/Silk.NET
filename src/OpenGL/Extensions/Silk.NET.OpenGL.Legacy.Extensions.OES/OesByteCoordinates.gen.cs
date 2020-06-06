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

namespace Silk.NET.OpenGL.Legacy.Extensions.OES
{
    [Extension("OES_byte_coordinates")]
    public unsafe partial class OesByteCoordinates : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_byte_coordinates";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1bOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1([Flow(FlowDirection.In)] OES texture, [Flow(FlowDirection.In)] sbyte s)
            => ImplMultiTexCoord1(texture, s);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord1([Flow(FlowDirection.In)] OES texture, [Count(Count = 1), Flow(FlowDirection.In)] sbyte* coords)
            => ImplMultiTexCoord1(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1([Flow(FlowDirection.In)] OES texture, [Count(Count = 1), Flow(FlowDirection.In)] ref sbyte coords)
            => ImplMultiTexCoord1(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2bOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2([Flow(FlowDirection.In)] OES texture, [Flow(FlowDirection.In)] sbyte s, [Flow(FlowDirection.In)] sbyte t)
            => ImplMultiTexCoord2(texture, s, t);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord2([Flow(FlowDirection.In)] OES texture, [Count(Count = 2), Flow(FlowDirection.In)] sbyte* coords)
            => ImplMultiTexCoord2(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2([Flow(FlowDirection.In)] OES texture, [Count(Count = 2), Flow(FlowDirection.In)] Span<sbyte> coords)
            => ImplMultiTexCoord2(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        /// <param name="r">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3bOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3([Flow(FlowDirection.In)] OES texture, [Flow(FlowDirection.In)] sbyte s, [Flow(FlowDirection.In)] sbyte t, [Flow(FlowDirection.In)] sbyte r)
            => ImplMultiTexCoord3(texture, s, t, r);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord3([Flow(FlowDirection.In)] OES texture, [Count(Count = 3), Flow(FlowDirection.In)] sbyte* coords)
            => ImplMultiTexCoord3(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3([Flow(FlowDirection.In)] OES texture, [Count(Count = 3), Flow(FlowDirection.In)] Span<sbyte> coords)
            => ImplMultiTexCoord3(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        /// <param name="r">
        /// To be added.
        /// </param>
        /// <param name="q">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4bOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4([Flow(FlowDirection.In)] OES texture, [Flow(FlowDirection.In)] sbyte s, [Flow(FlowDirection.In)] sbyte t, [Flow(FlowDirection.In)] sbyte r, [Flow(FlowDirection.In)] sbyte q)
            => ImplMultiTexCoord4(texture, s, t, r, q);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord4([Flow(FlowDirection.In)] OES texture, [Count(Count = 4), Flow(FlowDirection.In)] sbyte* coords)
            => ImplMultiTexCoord4(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4([Flow(FlowDirection.In)] OES texture, [Count(Count = 4), Flow(FlowDirection.In)] Span<sbyte> coords)
            => ImplMultiTexCoord4(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="s">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord1bOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoord1([Flow(FlowDirection.In)] sbyte s)
            => ImplTexCoord1(s);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord1bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoord1([Count(Count = 1), Flow(FlowDirection.In)] sbyte* coords)
            => ImplTexCoord1(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord1bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoord1([Count(Count = 1), Flow(FlowDirection.In)] ref sbyte coords)
            => ImplTexCoord1(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord2bOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoord2([Flow(FlowDirection.In)] sbyte s, [Flow(FlowDirection.In)] sbyte t)
            => ImplTexCoord2(s, t);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord2bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoord2([Count(Count = 2), Flow(FlowDirection.In)] sbyte* coords)
            => ImplTexCoord2(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord2bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoord2([Count(Count = 2), Flow(FlowDirection.In)] Span<sbyte> coords)
            => ImplTexCoord2(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        /// <param name="r">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord3bOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoord3([Flow(FlowDirection.In)] sbyte s, [Flow(FlowDirection.In)] sbyte t, [Flow(FlowDirection.In)] sbyte r)
            => ImplTexCoord3(s, t, r);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord3bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoord3([Count(Count = 3), Flow(FlowDirection.In)] sbyte* coords)
            => ImplTexCoord3(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord3bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoord3([Count(Count = 3), Flow(FlowDirection.In)] Span<sbyte> coords)
            => ImplTexCoord3(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        /// <param name="r">
        /// To be added.
        /// </param>
        /// <param name="q">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord4bOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoord4([Flow(FlowDirection.In)] sbyte s, [Flow(FlowDirection.In)] sbyte t, [Flow(FlowDirection.In)] sbyte r, [Flow(FlowDirection.In)] sbyte q)
            => ImplTexCoord4(s, t, r, q);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord4bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoord4([Count(Count = 4), Flow(FlowDirection.In)] sbyte* coords)
            => ImplTexCoord4(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord4bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoord4([Count(Count = 4), Flow(FlowDirection.In)] Span<sbyte> coords)
            => ImplTexCoord4(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertex2bOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Vertex2([Flow(FlowDirection.In)] sbyte x, [Flow(FlowDirection.In)] sbyte y)
            => ImplVertex2(x, y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertex2bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Vertex2([Count(Count = 2), Flow(FlowDirection.In)] sbyte* coords)
            => ImplVertex2(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertex2bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Vertex2([Count(Count = 2), Flow(FlowDirection.In)] Span<sbyte> coords)
            => ImplVertex2(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertex3bOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Vertex3([Flow(FlowDirection.In)] sbyte x, [Flow(FlowDirection.In)] sbyte y, [Flow(FlowDirection.In)] sbyte z)
            => ImplVertex3(x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertex3bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Vertex3([Count(Count = 3), Flow(FlowDirection.In)] sbyte* coords)
            => ImplVertex3(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertex3bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Vertex3([Count(Count = 3), Flow(FlowDirection.In)] Span<sbyte> coords)
            => ImplVertex3(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="w">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertex4bOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Vertex4([Flow(FlowDirection.In)] sbyte x, [Flow(FlowDirection.In)] sbyte y, [Flow(FlowDirection.In)] sbyte z, [Flow(FlowDirection.In)] sbyte w)
            => ImplVertex4(x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertex4bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Vertex4([Count(Count = 4), Flow(FlowDirection.In)] sbyte* coords)
            => ImplVertex4(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertex4bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Vertex4([Count(Count = 4), Flow(FlowDirection.In)] Span<sbyte> coords)
            => ImplVertex4(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1bOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] sbyte s)
            => ImplMultiTexCoord1(texture, s);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 1), Flow(FlowDirection.In)] sbyte* coords)
            => ImplMultiTexCoord1(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 1), Flow(FlowDirection.In)] ref sbyte coords)
            => ImplMultiTexCoord1(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2bOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] sbyte s, [Flow(FlowDirection.In)] sbyte t)
            => ImplMultiTexCoord2(texture, s, t);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 2), Flow(FlowDirection.In)] sbyte* coords)
            => ImplMultiTexCoord2(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 2), Flow(FlowDirection.In)] Span<sbyte> coords)
            => ImplMultiTexCoord2(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        /// <param name="r">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3bOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] sbyte s, [Flow(FlowDirection.In)] sbyte t, [Flow(FlowDirection.In)] sbyte r)
            => ImplMultiTexCoord3(texture, s, t, r);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 3), Flow(FlowDirection.In)] sbyte* coords)
            => ImplMultiTexCoord3(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 3), Flow(FlowDirection.In)] Span<sbyte> coords)
            => ImplMultiTexCoord3(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        /// <param name="r">
        /// To be added.
        /// </param>
        /// <param name="q">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4bOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] sbyte s, [Flow(FlowDirection.In)] sbyte t, [Flow(FlowDirection.In)] sbyte r, [Flow(FlowDirection.In)] sbyte q)
            => ImplMultiTexCoord4(texture, s, t, r, q);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 4), Flow(FlowDirection.In)] sbyte* coords)
            => ImplMultiTexCoord4(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4bvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 4), Flow(FlowDirection.In)] Span<sbyte> coords)
            => ImplMultiTexCoord4(texture, coords);

        public OesByteCoordinates(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

