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
    [Extension("ARB_multitexture")]
    public unsafe partial class ArbMultitexture : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_multitexture";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glActiveTextureARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ActiveTexture([Flow(FlowDirection.In)] ARB texture)
            => ImplActiveTexture(texture);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClientActiveTextureARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClientActiveTexture([Flow(FlowDirection.In)] ARB texture)
            => ImplClientActiveTexture(texture);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1dARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] double s)
            => ImplMultiTexCoord1(target, s);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1dvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] double* v)
            => ImplMultiTexCoord1(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1dvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] ref double v)
            => ImplMultiTexCoord1(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1fARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] float s)
            => ImplMultiTexCoord1(target, s);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] float* v)
            => ImplMultiTexCoord1(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] ref float v)
            => ImplMultiTexCoord1(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1iARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int s)
            => ImplMultiTexCoord1(target, s);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1ivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] int* v)
            => ImplMultiTexCoord1(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1ivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] ref int v)
            => ImplMultiTexCoord1(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1sARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] short s)
            => ImplMultiTexCoord1(target, s);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1svARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] short* v)
            => ImplMultiTexCoord1(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1svARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] ref short v)
            => ImplMultiTexCoord1(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2dARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t)
            => ImplMultiTexCoord2(target, s, t);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2dvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] double* v)
            => ImplMultiTexCoord2(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2dvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] Span<double> v)
            => ImplMultiTexCoord2(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2fARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t)
            => ImplMultiTexCoord2(target, s, t);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] float* v)
            => ImplMultiTexCoord2(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] Span<float> v)
            => ImplMultiTexCoord2(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2iARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t)
            => ImplMultiTexCoord2(target, s, t);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2ivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] int* v)
            => ImplMultiTexCoord2(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2ivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] Span<int> v)
            => ImplMultiTexCoord2(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2sARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t)
            => ImplMultiTexCoord2(target, s, t);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2svARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] short* v)
            => ImplMultiTexCoord2(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2svARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] Span<short> v)
            => ImplMultiTexCoord2(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glMultiTexCoord3dARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t, [Flow(FlowDirection.In)] double r)
            => ImplMultiTexCoord3(target, s, t, r);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3dvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] double* v)
            => ImplMultiTexCoord3(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3dvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] Span<double> v)
            => ImplMultiTexCoord3(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glMultiTexCoord3fARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float r)
            => ImplMultiTexCoord3(target, s, t, r);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] float* v)
            => ImplMultiTexCoord3(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v)
            => ImplMultiTexCoord3(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glMultiTexCoord3iARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r)
            => ImplMultiTexCoord3(target, s, t, r);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3ivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] int* v)
            => ImplMultiTexCoord3(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3ivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] Span<int> v)
            => ImplMultiTexCoord3(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glMultiTexCoord3sARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t, [Flow(FlowDirection.In)] short r)
            => ImplMultiTexCoord3(target, s, t, r);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3svARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] short* v)
            => ImplMultiTexCoord3(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3svARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] Span<short> v)
            => ImplMultiTexCoord3(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glMultiTexCoord4dARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t, [Flow(FlowDirection.In)] double r, [Flow(FlowDirection.In)] double q)
            => ImplMultiTexCoord4(target, s, t, r, q);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4dvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] double* v)
            => ImplMultiTexCoord4(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4dvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> v)
            => ImplMultiTexCoord4(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glMultiTexCoord4fARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float q)
            => ImplMultiTexCoord4(target, s, t, r, q);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] float* v)
            => ImplMultiTexCoord4(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> v)
            => ImplMultiTexCoord4(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glMultiTexCoord4iARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int q)
            => ImplMultiTexCoord4(target, s, t, r, q);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4ivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] int* v)
            => ImplMultiTexCoord4(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4ivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> v)
            => ImplMultiTexCoord4(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glMultiTexCoord4sARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t, [Flow(FlowDirection.In)] short r, [Flow(FlowDirection.In)] short q)
            => ImplMultiTexCoord4(target, s, t, r, q);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4svARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] short* v)
            => ImplMultiTexCoord4(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4svARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] Span<short> v)
            => ImplMultiTexCoord4(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glActiveTextureARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ActiveTexture([Flow(FlowDirection.In)] TextureUnit texture)
            => ImplActiveTexture(texture);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClientActiveTextureARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClientActiveTexture([Flow(FlowDirection.In)] TextureUnit texture)
            => ImplClientActiveTexture(texture);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1dARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] double s)
            => ImplMultiTexCoord1(target, s);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1dvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] double* v)
            => ImplMultiTexCoord1(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1dvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] ref double v)
            => ImplMultiTexCoord1(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1fARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] float s)
            => ImplMultiTexCoord1(target, s);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] float* v)
            => ImplMultiTexCoord1(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] ref float v)
            => ImplMultiTexCoord1(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1iARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] int s)
            => ImplMultiTexCoord1(target, s);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1ivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] int* v)
            => ImplMultiTexCoord1(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1ivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] ref int v)
            => ImplMultiTexCoord1(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1sARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] short s)
            => ImplMultiTexCoord1(target, s);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1svARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] short* v)
            => ImplMultiTexCoord1(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1svARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] ref short v)
            => ImplMultiTexCoord1(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2dARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t)
            => ImplMultiTexCoord2(target, s, t);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2dvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] double* v)
            => ImplMultiTexCoord2(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2dvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] Span<double> v)
            => ImplMultiTexCoord2(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2fARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t)
            => ImplMultiTexCoord2(target, s, t);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] float* v)
            => ImplMultiTexCoord2(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] Span<float> v)
            => ImplMultiTexCoord2(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2iARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t)
            => ImplMultiTexCoord2(target, s, t);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2ivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] int* v)
            => ImplMultiTexCoord2(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2ivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] Span<int> v)
            => ImplMultiTexCoord2(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2sARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t)
            => ImplMultiTexCoord2(target, s, t);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2svARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] short* v)
            => ImplMultiTexCoord2(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2svARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] Span<short> v)
            => ImplMultiTexCoord2(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glMultiTexCoord3dARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t, [Flow(FlowDirection.In)] double r)
            => ImplMultiTexCoord3(target, s, t, r);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3dvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] double* v)
            => ImplMultiTexCoord3(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3dvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] Span<double> v)
            => ImplMultiTexCoord3(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glMultiTexCoord3fARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float r)
            => ImplMultiTexCoord3(target, s, t, r);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] float* v)
            => ImplMultiTexCoord3(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v)
            => ImplMultiTexCoord3(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glMultiTexCoord3iARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r)
            => ImplMultiTexCoord3(target, s, t, r);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3ivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] int* v)
            => ImplMultiTexCoord3(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3ivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] Span<int> v)
            => ImplMultiTexCoord3(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glMultiTexCoord3sARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t, [Flow(FlowDirection.In)] short r)
            => ImplMultiTexCoord3(target, s, t, r);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3svARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] short* v)
            => ImplMultiTexCoord3(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3svARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] Span<short> v)
            => ImplMultiTexCoord3(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glMultiTexCoord4dARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t, [Flow(FlowDirection.In)] double r, [Flow(FlowDirection.In)] double q)
            => ImplMultiTexCoord4(target, s, t, r, q);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4dvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] double* v)
            => ImplMultiTexCoord4(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4dvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> v)
            => ImplMultiTexCoord4(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glMultiTexCoord4fARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float q)
            => ImplMultiTexCoord4(target, s, t, r, q);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] float* v)
            => ImplMultiTexCoord4(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> v)
            => ImplMultiTexCoord4(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glMultiTexCoord4iARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int q)
            => ImplMultiTexCoord4(target, s, t, r, q);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4ivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] int* v)
            => ImplMultiTexCoord4(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4ivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> v)
            => ImplMultiTexCoord4(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        [NativeApi(EntryPoint = "glMultiTexCoord4sARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t, [Flow(FlowDirection.In)] short r, [Flow(FlowDirection.In)] short q)
            => ImplMultiTexCoord4(target, s, t, r, q);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4svARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] short* v)
            => ImplMultiTexCoord4(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4svARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] Span<short> v)
            => ImplMultiTexCoord4(target, v);

        public ArbMultitexture(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

