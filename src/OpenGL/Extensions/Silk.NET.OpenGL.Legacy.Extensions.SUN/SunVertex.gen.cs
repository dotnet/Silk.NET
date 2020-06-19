// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SUN
{
    [Extension("SUN_vertex")]
    public abstract unsafe partial class SunVertex : NativeExtension<GL>
    {
        public const string ExtensionName = "SUN_vertex";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="r">
        /// To be added.
        /// </param>
        /// <param name="g">
        /// To be added.
        /// </param>
        /// <param name="b">
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
        [NativeApi(EntryPoint = "glColor3fVertex3fSUN")]
        public abstract void Color3fVertex3([Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float g, [Flow(FlowDirection.In)] float b, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="c">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColor3fVertex3fvSUN")]
        public abstract unsafe void Color3fVertex3([Count(Count = 3), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="c">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColor3fVertex3fvSUN")]
        public abstract void Color3fVertex3([Count(Count = 3), Flow(FlowDirection.In)] Span<float> c, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="r">
        /// To be added.
        /// </param>
        /// <param name="g">
        /// To be added.
        /// </param>
        /// <param name="b">
        /// To be added.
        /// </param>
        /// <param name="a">
        /// To be added.
        /// </param>
        /// <param name="nx">
        /// To be added.
        /// </param>
        /// <param name="ny">
        /// To be added.
        /// </param>
        /// <param name="nz">
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
        [NativeApi(EntryPoint = "glColor4fNormal3fVertex3fSUN")]
        public abstract void Color4fNormal3fVertex3([Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float g, [Flow(FlowDirection.In)] float b, [Flow(FlowDirection.In)] float a, [Flow(FlowDirection.In)] float nx, [Flow(FlowDirection.In)] float ny, [Flow(FlowDirection.In)] float nz, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="c">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColor4fNormal3fVertex3fvSUN")]
        public abstract unsafe void Color4fNormal3fVertex3([Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="c">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColor4fNormal3fVertex3fvSUN")]
        public abstract void Color4fNormal3fVertex3([Count(Count = 4), Flow(FlowDirection.In)] Span<float> c, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> n, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="r">
        /// To be added.
        /// </param>
        /// <param name="g">
        /// To be added.
        /// </param>
        /// <param name="b">
        /// To be added.
        /// </param>
        /// <param name="a">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColor4ubVertex2fSUN")]
        public abstract void Color4ubVertex2([Flow(FlowDirection.In)] byte r, [Flow(FlowDirection.In)] byte g, [Flow(FlowDirection.In)] byte b, [Flow(FlowDirection.In)] byte a, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="c">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColor4ubVertex2fvSUN")]
        public abstract unsafe void Color4ubVertex2([Count(Count = 4), Flow(FlowDirection.In)] byte* c, [Count(Count = 2), Flow(FlowDirection.In)] float* v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="c">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColor4ubVertex2fvSUN")]
        public abstract void Color4ubVertex2([Count(Count = 4), Flow(FlowDirection.In)] Span<byte> c, [Count(Count = 2), Flow(FlowDirection.In)] Span<float> v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="r">
        /// To be added.
        /// </param>
        /// <param name="g">
        /// To be added.
        /// </param>
        /// <param name="b">
        /// To be added.
        /// </param>
        /// <param name="a">
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
        [NativeApi(EntryPoint = "glColor4ubVertex3fSUN")]
        public abstract void Color4ubVertex3([Flow(FlowDirection.In)] byte r, [Flow(FlowDirection.In)] byte g, [Flow(FlowDirection.In)] byte b, [Flow(FlowDirection.In)] byte a, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="c">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColor4ubVertex3fvSUN")]
        public abstract unsafe void Color4ubVertex3([Count(Count = 4), Flow(FlowDirection.In)] byte* c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="c">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColor4ubVertex3fvSUN")]
        public abstract void Color4ubVertex3([Count(Count = 4), Flow(FlowDirection.In)] Span<byte> c, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

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
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNormal3fVertex3fSUN")]
        public abstract void Normal3fVertex3([Flow(FlowDirection.In)] float nx, [Flow(FlowDirection.In)] float ny, [Flow(FlowDirection.In)] float nz, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormal3fVertex3fvSUN")]
        public abstract unsafe void Normal3fVertex3([Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormal3fVertex3fvSUN")]
        public abstract void Normal3fVertex3([Count(Count = 3), Flow(FlowDirection.In)] Span<float> n, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rc">
        /// To be added.
        /// </param>
        /// <param name="r">
        /// To be added.
        /// </param>
        /// <param name="g">
        /// To be added.
        /// </param>
        /// <param name="b">
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
        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fSUN")]
        public abstract void ReplacementCodeuiColor3fVertex3([Flow(FlowDirection.In)] uint rc, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float g, [Flow(FlowDirection.In)] float b, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rc">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="c">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN")]
        public abstract unsafe void ReplacementCodeuiColor3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rc">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="c">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN")]
        public abstract void ReplacementCodeuiColor3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] ref uint rc, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> c, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rc">
        /// To be added.
        /// </param>
        /// <param name="r">
        /// To be added.
        /// </param>
        /// <param name="g">
        /// To be added.
        /// </param>
        /// <param name="b">
        /// To be added.
        /// </param>
        /// <param name="a">
        /// To be added.
        /// </param>
        /// <param name="nx">
        /// To be added.
        /// </param>
        /// <param name="ny">
        /// To be added.
        /// </param>
        /// <param name="nz">
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
        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fSUN")]
        public abstract void ReplacementCodeuiColor4fNormal3fVertex3([Flow(FlowDirection.In)] uint rc, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float g, [Flow(FlowDirection.In)] float b, [Flow(FlowDirection.In)] float a, [Flow(FlowDirection.In)] float nx, [Flow(FlowDirection.In)] float ny, [Flow(FlowDirection.In)] float nz, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rc">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="c">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN")]
        public abstract unsafe void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rc">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="c">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN")]
        public abstract void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] ref uint rc, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> c, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> n, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rc">
        /// To be added.
        /// </param>
        /// <param name="r">
        /// To be added.
        /// </param>
        /// <param name="g">
        /// To be added.
        /// </param>
        /// <param name="b">
        /// To be added.
        /// </param>
        /// <param name="a">
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
        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fSUN")]
        public abstract void ReplacementCodeuiColor4ubVertex3([Flow(FlowDirection.In)] uint rc, [Flow(FlowDirection.In)] byte r, [Flow(FlowDirection.In)] byte g, [Flow(FlowDirection.In)] byte b, [Flow(FlowDirection.In)] byte a, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rc">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="c">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN")]
        public abstract unsafe void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(FlowDirection.In)] byte* c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rc">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="c">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN")]
        public abstract void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(FlowDirection.In)] ref uint rc, [Count(Count = 4), Flow(FlowDirection.In)] Span<byte> c, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rc">
        /// To be added.
        /// </param>
        /// <param name="nx">
        /// To be added.
        /// </param>
        /// <param name="ny">
        /// To be added.
        /// </param>
        /// <param name="nz">
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
        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fSUN")]
        public abstract void ReplacementCodeuiNormal3fVertex3([Flow(FlowDirection.In)] uint rc, [Flow(FlowDirection.In)] float nx, [Flow(FlowDirection.In)] float ny, [Flow(FlowDirection.In)] float nz, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rc">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN")]
        public abstract unsafe void ReplacementCodeuiNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rc">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN")]
        public abstract void ReplacementCodeuiNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] ref uint rc, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> n, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rc">
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
        /// <param name="g">
        /// To be added.
        /// </param>
        /// <param name="b">
        /// To be added.
        /// </param>
        /// <param name="a">
        /// To be added.
        /// </param>
        /// <param name="nx">
        /// To be added.
        /// </param>
        /// <param name="ny">
        /// To be added.
        /// </param>
        /// <param name="nz">
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
        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN")]
        public abstract void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Flow(FlowDirection.In)] uint rc, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float g, [Flow(FlowDirection.In)] float b, [Flow(FlowDirection.In)] float a, [Flow(FlowDirection.In)] float nx, [Flow(FlowDirection.In)] float ny, [Flow(FlowDirection.In)] float nz, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rc">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="tc">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="c">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public abstract unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rc">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="tc">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="c">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public abstract void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] ref uint rc, [Count(Count = 2), Flow(FlowDirection.In)] Span<float> tc, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> c, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> n, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rc">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        /// <param name="nx">
        /// To be added.
        /// </param>
        /// <param name="ny">
        /// To be added.
        /// </param>
        /// <param name="nz">
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
        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN")]
        public abstract void ReplacementCodeuiTexCoord2fNormal3fVertex3([Flow(FlowDirection.In)] uint rc, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float nx, [Flow(FlowDirection.In)] float ny, [Flow(FlowDirection.In)] float nz, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rc">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="tc">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN")]
        public abstract unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rc">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="tc">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN")]
        public abstract void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] ref uint rc, [Count(Count = 2), Flow(FlowDirection.In)] Span<float> tc, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> n, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rc">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
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
        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fSUN")]
        public abstract void ReplacementCodeuiTexCoord2fVertex3([Flow(FlowDirection.In)] uint rc, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rc">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="tc">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN")]
        public abstract unsafe void ReplacementCodeuiTexCoord2fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rc">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="tc">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN")]
        public abstract void ReplacementCodeuiTexCoord2fVertex3([Count(Count = 1), Flow(FlowDirection.In)] ref uint rc, [Count(Count = 2), Flow(FlowDirection.In)] Span<float> tc, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rc">
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
        [NativeApi(EntryPoint = "glReplacementCodeuiVertex3fSUN")]
        public abstract void ReplacementCodeuiVertex3([Flow(FlowDirection.In)] uint rc, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rc">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeuiVertex3fvSUN")]
        public abstract unsafe void ReplacementCodeuiVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rc">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeuiVertex3fvSUN")]
        public abstract void ReplacementCodeuiVertex3([Count(Count = 1), Flow(FlowDirection.In)] ref uint rc, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

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
        /// <param name="g">
        /// To be added.
        /// </param>
        /// <param name="b">
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
        [NativeApi(EntryPoint = "glTexCoord2fColor3fVertex3fSUN")]
        public abstract void TexCoord2fColor3fVertex3([Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float g, [Flow(FlowDirection.In)] float b, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="tc">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="c">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord2fColor3fVertex3fvSUN")]
        public abstract unsafe void TexCoord2fColor3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="tc">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="c">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord2fColor3fVertex3fvSUN")]
        public abstract void TexCoord2fColor3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] Span<float> tc, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> c, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

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
        /// <param name="g">
        /// To be added.
        /// </param>
        /// <param name="b">
        /// To be added.
        /// </param>
        /// <param name="a">
        /// To be added.
        /// </param>
        /// <param name="nx">
        /// To be added.
        /// </param>
        /// <param name="ny">
        /// To be added.
        /// </param>
        /// <param name="nz">
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
        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fSUN")]
        public abstract void TexCoord2fColor4fNormal3fVertex3([Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float g, [Flow(FlowDirection.In)] float b, [Flow(FlowDirection.In)] float a, [Flow(FlowDirection.In)] float nx, [Flow(FlowDirection.In)] float ny, [Flow(FlowDirection.In)] float nz, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="tc">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="c">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public abstract unsafe void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="tc">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="c">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public abstract void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] Span<float> tc, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> c, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> n, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

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
        /// <param name="g">
        /// To be added.
        /// </param>
        /// <param name="b">
        /// To be added.
        /// </param>
        /// <param name="a">
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
        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fSUN")]
        public abstract void TexCoord2fColor4ubVertex3([Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] byte r, [Flow(FlowDirection.In)] byte g, [Flow(FlowDirection.In)] byte b, [Flow(FlowDirection.In)] byte a, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="tc">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="c">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN")]
        public abstract unsafe void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] byte* c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="tc">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="c">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN")]
        public abstract void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(FlowDirection.In)] Span<float> tc, [Count(Count = 4), Flow(FlowDirection.In)] Span<byte> c, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        /// <param name="nx">
        /// To be added.
        /// </param>
        /// <param name="ny">
        /// To be added.
        /// </param>
        /// <param name="nz">
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
        [NativeApi(EntryPoint = "glTexCoord2fNormal3fVertex3fSUN")]
        public abstract void TexCoord2fNormal3fVertex3([Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float nx, [Flow(FlowDirection.In)] float ny, [Flow(FlowDirection.In)] float nz, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="tc">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord2fNormal3fVertex3fvSUN")]
        public abstract unsafe void TexCoord2fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="tc">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord2fNormal3fVertex3fvSUN")]
        public abstract void TexCoord2fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] Span<float> tc, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> n, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
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
        [NativeApi(EntryPoint = "glTexCoord2fVertex3fSUN")]
        public abstract void TexCoord2fVertex3([Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="tc">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord2fVertex3fvSUN")]
        public abstract unsafe void TexCoord2fVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="tc">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord2fVertex3fvSUN")]
        public abstract void TexCoord2fVertex3([Count(Count = 2), Flow(FlowDirection.In)] Span<float> tc, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        /// <param name="p">
        /// To be added.
        /// </param>
        /// <param name="q">
        /// To be added.
        /// </param>
        /// <param name="r">
        /// To be added.
        /// </param>
        /// <param name="g">
        /// To be added.
        /// </param>
        /// <param name="b">
        /// To be added.
        /// </param>
        /// <param name="a">
        /// To be added.
        /// </param>
        /// <param name="nx">
        /// To be added.
        /// </param>
        /// <param name="ny">
        /// To be added.
        /// </param>
        /// <param name="nz">
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
        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fSUN")]
        public abstract void TexCoord4fColor4fNormal3fVertex4([Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float p, [Flow(FlowDirection.In)] float q, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float g, [Flow(FlowDirection.In)] float b, [Flow(FlowDirection.In)] float a, [Flow(FlowDirection.In)] float nx, [Flow(FlowDirection.In)] float ny, [Flow(FlowDirection.In)] float nz, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="tc">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        /// <param name="c">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN")]
        public abstract unsafe void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="tc">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        /// <param name="c">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN")]
        public abstract void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(FlowDirection.In)] Span<float> tc, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> c, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> n, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        /// <param name="p">
        /// To be added.
        /// </param>
        /// <param name="q">
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
        [NativeApi(EntryPoint = "glTexCoord4fVertex4fSUN")]
        public abstract void TexCoord4fVertex4([Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float p, [Flow(FlowDirection.In)] float q, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="tc">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord4fVertex4fvSUN")]
        public abstract unsafe void TexCoord4fVertex4([Count(Count = 4), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="tc">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord4fVertex4fvSUN")]
        public abstract void TexCoord4fVertex4([Count(Count = 4), Flow(FlowDirection.In)] Span<float> tc, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="c">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColor4ubVertex2fvSUN")]
        public abstract unsafe void Color4ubVertex2([Flow(FlowDirection.In)] string c, [Count(Count = 2), Flow(FlowDirection.In)] float* v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="c">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColor4ubVertex2fvSUN")]
        public abstract void Color4ubVertex2([Flow(FlowDirection.In)] string c, [Count(Count = 2), Flow(FlowDirection.In)] Span<float> v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="c">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColor4ubVertex3fvSUN")]
        public abstract unsafe void Color4ubVertex3([Flow(FlowDirection.In)] string c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="c">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColor4ubVertex3fvSUN")]
        public abstract void Color4ubVertex3([Flow(FlowDirection.In)] string c, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rc">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="c">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN")]
        public abstract unsafe void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Flow(FlowDirection.In)] string c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rc">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="c">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN")]
        public abstract void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(FlowDirection.In)] ref uint rc, [Flow(FlowDirection.In)] string c, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="tc">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="c">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN")]
        public abstract unsafe void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Flow(FlowDirection.In)] string c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="tc">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="c">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN")]
        public abstract void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(FlowDirection.In)] Span<float> tc, [Flow(FlowDirection.In)] string c, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        public SunVertex(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

