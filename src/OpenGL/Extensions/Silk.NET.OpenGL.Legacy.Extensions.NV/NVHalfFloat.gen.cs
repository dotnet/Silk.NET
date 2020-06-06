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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_half_float")]
    public unsafe partial class NVHalfFloat : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_half_float";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="red">
        /// To be added.
        /// </param>
        /// <param name="green">
        /// To be added.
        /// </param>
        /// <param name="blue">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColor3hNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Color3h([Flow(FlowDirection.In)] Silk.NET.Core.Math.Half red, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half green, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half blue)
            => ImplColor3h(red, green, blue);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColor3hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Color3h([Count(Count = 3), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplColor3h(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColor3hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Color3h([Count(Count = 3), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v)
            => ImplColor3h(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="red">
        /// To be added.
        /// </param>
        /// <param name="green">
        /// To be added.
        /// </param>
        /// <param name="blue">
        /// To be added.
        /// </param>
        /// <param name="alpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColor4hNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Color4h([Flow(FlowDirection.In)] Silk.NET.Core.Math.Half red, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half green, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half blue, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half alpha)
            => ImplColor4h(red, green, blue, alpha);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColor4hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Color4h([Count(Count = 4), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplColor4h(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColor4hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Color4h([Count(Count = 4), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v)
            => ImplColor4h(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="fog">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFogCoordhNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FogCoordh([Flow(FlowDirection.In)] Silk.NET.Core.Math.Half fog)
            => ImplFogCoordh(fog);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="fog">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glFogCoordhvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FogCoordh([Count(Count = 1), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* fog)
            => ImplFogCoordh(fog);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="fog">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glFogCoordhvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FogCoordh([Count(Count = 1), Flow(FlowDirection.In)] ref Silk.NET.Core.Math.Half fog)
            => ImplFogCoordh(fog);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1hNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1h([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half s)
            => ImplMultiTexCoord1h(target, s);

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
        [NativeApi(EntryPoint = "glMultiTexCoord1hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord1h([Flow(FlowDirection.In)] NV target, [Count(Count = 1), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplMultiTexCoord1h(target, v);

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
        [NativeApi(EntryPoint = "glMultiTexCoord1hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1h([Flow(FlowDirection.In)] NV target, [Count(Count = 1), Flow(FlowDirection.In)] ref Silk.NET.Core.Math.Half v)
            => ImplMultiTexCoord1h(target, v);

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
        [NativeApi(EntryPoint = "glMultiTexCoord2hNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2h([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half s, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half t)
            => ImplMultiTexCoord2h(target, s, t);

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
        [NativeApi(EntryPoint = "glMultiTexCoord2hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord2h([Flow(FlowDirection.In)] NV target, [Count(Count = 2), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplMultiTexCoord2h(target, v);

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
        [NativeApi(EntryPoint = "glMultiTexCoord2hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2h([Flow(FlowDirection.In)] NV target, [Count(Count = 2), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v)
            => ImplMultiTexCoord2h(target, v);

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
        [NativeApi(EntryPoint = "glMultiTexCoord3hNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3h([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half s, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half t, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half r)
            => ImplMultiTexCoord3h(target, s, t, r);

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
        [NativeApi(EntryPoint = "glMultiTexCoord3hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord3h([Flow(FlowDirection.In)] NV target, [Count(Count = 3), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplMultiTexCoord3h(target, v);

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
        [NativeApi(EntryPoint = "glMultiTexCoord3hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3h([Flow(FlowDirection.In)] NV target, [Count(Count = 3), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v)
            => ImplMultiTexCoord3h(target, v);

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
        [NativeApi(EntryPoint = "glMultiTexCoord4hNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4h([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half s, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half t, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half r, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half q)
            => ImplMultiTexCoord4h(target, s, t, r, q);

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
        [NativeApi(EntryPoint = "glMultiTexCoord4hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord4h([Flow(FlowDirection.In)] NV target, [Count(Count = 4), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplMultiTexCoord4h(target, v);

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
        [NativeApi(EntryPoint = "glMultiTexCoord4hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4h([Flow(FlowDirection.In)] NV target, [Count(Count = 4), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v)
            => ImplMultiTexCoord4h(target, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="nx">
        /// To be added.
        /// </param>
        /// <param name="ny">
        /// To be added.
        /// </param>
        /// <param name="nz">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNormal3hNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Normal3h([Flow(FlowDirection.In)] Silk.NET.Core.Math.Half nx, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half ny, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half nz)
            => ImplNormal3h(nx, ny, nz);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormal3hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Normal3h([Count(Count = 3), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplNormal3h(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormal3hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Normal3h([Count(Count = 3), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v)
            => ImplNormal3h(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="red">
        /// To be added.
        /// </param>
        /// <param name="green">
        /// To be added.
        /// </param>
        /// <param name="blue">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3hNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColor3h([Flow(FlowDirection.In)] Silk.NET.Core.Math.Half red, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half green, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half blue)
            => ImplSecondaryColor3h(red, green, blue);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SecondaryColor3h([Count(Count = 3), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplSecondaryColor3h(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColor3h([Count(Count = 3), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v)
            => ImplSecondaryColor3h(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="s">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord1hNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoord1h([Flow(FlowDirection.In)] Silk.NET.Core.Math.Half s)
            => ImplTexCoord1h(s);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord1hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoord1h([Count(Count = 1), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplTexCoord1h(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord1hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoord1h([Count(Count = 1), Flow(FlowDirection.In)] ref Silk.NET.Core.Math.Half v)
            => ImplTexCoord1h(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord2hNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoord2h([Flow(FlowDirection.In)] Silk.NET.Core.Math.Half s, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half t)
            => ImplTexCoord2h(s, t);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord2hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoord2h([Count(Count = 2), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplTexCoord2h(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord2hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoord2h([Count(Count = 2), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v)
            => ImplTexCoord2h(v);

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
        [NativeApi(EntryPoint = "glTexCoord3hNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoord3h([Flow(FlowDirection.In)] Silk.NET.Core.Math.Half s, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half t, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half r)
            => ImplTexCoord3h(s, t, r);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord3hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoord3h([Count(Count = 3), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplTexCoord3h(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord3hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoord3h([Count(Count = 3), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v)
            => ImplTexCoord3h(v);

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
        [NativeApi(EntryPoint = "glTexCoord4hNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoord4h([Flow(FlowDirection.In)] Silk.NET.Core.Math.Half s, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half t, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half r, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half q)
            => ImplTexCoord4h(s, t, r, q);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord4hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoord4h([Count(Count = 4), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplTexCoord4h(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord4hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoord4h([Count(Count = 4), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v)
            => ImplTexCoord4h(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertex2hNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Vertex2h([Flow(FlowDirection.In)] Silk.NET.Core.Math.Half x, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half y)
            => ImplVertex2h(x, y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertex2hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Vertex2h([Count(Count = 2), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplVertex2h(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertex2hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Vertex2h([Count(Count = 2), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v)
            => ImplVertex2h(v);

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
        [NativeApi(EntryPoint = "glVertex3hNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Vertex3h([Flow(FlowDirection.In)] Silk.NET.Core.Math.Half x, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half y, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half z)
            => ImplVertex3h(x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertex3hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Vertex3h([Count(Count = 3), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplVertex3h(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertex3hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Vertex3h([Count(Count = 3), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v)
            => ImplVertex3h(v);

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
        [NativeApi(EntryPoint = "glVertex4hNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Vertex4h([Flow(FlowDirection.In)] Silk.NET.Core.Math.Half x, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half y, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half z, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half w)
            => ImplVertex4h(x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertex4hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Vertex4h([Count(Count = 4), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplVertex4h(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertex4hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Vertex4h([Count(Count = 4), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v)
            => ImplVertex4h(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib1hNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib1h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half x)
            => ImplVertexAttrib1h(index, x);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib1hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttrib1h([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplVertexAttrib1h(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib1hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib1h([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref Silk.NET.Core.Math.Half v)
            => ImplVertexAttrib1h(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib2hNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib2h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half x, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half y)
            => ImplVertexAttrib2h(index, x, y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib2hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttrib2h([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplVertexAttrib2h(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib2hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib2h([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v)
            => ImplVertexAttrib2h(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib3hNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib3h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half x, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half y, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half z)
            => ImplVertexAttrib3h(index, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib3hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttrib3h([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplVertexAttrib3h(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib3hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib3h([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v)
            => ImplVertexAttrib3h(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
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
        [NativeApi(EntryPoint = "glVertexAttrib4hNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib4h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half x, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half y, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half z, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half w)
            => ImplVertexAttrib4h(index, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib4hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttrib4h([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplVertexAttrib4h(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttrib4hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttrib4h([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v)
            => ImplVertexAttrib4h(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs1hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribs1h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplVertexAttribs1h(index, n, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs1hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribs1h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v)
            => ImplVertexAttribs1h(index, n, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs2hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribs2h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplVertexAttribs2h(index, n, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs2hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribs2h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v)
            => ImplVertexAttribs2h(index, n, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs3hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribs3h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplVertexAttribs3h(index, n, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs3hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribs3h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v)
            => ImplVertexAttribs3h(index, n, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs4hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribs4h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplVertexAttribs4h(index, n, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribs4hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribs4h([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v)
            => ImplVertexAttribs4h(index, n, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="weight">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexWeighthNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexWeighth([Flow(FlowDirection.In)] Silk.NET.Core.Math.Half weight)
            => ImplVertexWeighth(weight);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="weight">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexWeighthvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexWeighth([Count(Count = 1), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* weight)
            => ImplVertexWeighth(weight);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="weight">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexWeighthvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexWeighth([Count(Count = 1), Flow(FlowDirection.In)] ref Silk.NET.Core.Math.Half weight)
            => ImplVertexWeighth(weight);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1hNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1h([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half s)
            => ImplMultiTexCoord1h(target, s);

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
        [NativeApi(EntryPoint = "glMultiTexCoord1hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord1h([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplMultiTexCoord1h(target, v);

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
        [NativeApi(EntryPoint = "glMultiTexCoord1hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1h([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] ref Silk.NET.Core.Math.Half v)
            => ImplMultiTexCoord1h(target, v);

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
        [NativeApi(EntryPoint = "glMultiTexCoord2hNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2h([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half s, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half t)
            => ImplMultiTexCoord2h(target, s, t);

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
        [NativeApi(EntryPoint = "glMultiTexCoord2hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord2h([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplMultiTexCoord2h(target, v);

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
        [NativeApi(EntryPoint = "glMultiTexCoord2hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2h([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v)
            => ImplMultiTexCoord2h(target, v);

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
        [NativeApi(EntryPoint = "glMultiTexCoord3hNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3h([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half s, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half t, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half r)
            => ImplMultiTexCoord3h(target, s, t, r);

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
        [NativeApi(EntryPoint = "glMultiTexCoord3hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord3h([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplMultiTexCoord3h(target, v);

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
        [NativeApi(EntryPoint = "glMultiTexCoord3hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3h([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v)
            => ImplMultiTexCoord3h(target, v);

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
        [NativeApi(EntryPoint = "glMultiTexCoord4hNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4h([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half s, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half t, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half r, [Flow(FlowDirection.In)] Silk.NET.Core.Math.Half q)
            => ImplMultiTexCoord4h(target, s, t, r, q);

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
        [NativeApi(EntryPoint = "glMultiTexCoord4hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord4h([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] Silk.NET.Core.Math.Half* v)
            => ImplMultiTexCoord4h(target, v);

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
        [NativeApi(EntryPoint = "glMultiTexCoord4hvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4h([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] Span<Silk.NET.Core.Math.Half> v)
            => ImplMultiTexCoord4h(target, v);

        public NVHalfFloat(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

