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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_multitexture")]
    public abstract unsafe partial class ArbMultitexture : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glActiveTextureARB")]
        public abstract void ActiveTexture([Flow(FlowDirection.In)] ARB texture);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClientActiveTextureARB")]
        public abstract void ClientActiveTexture([Flow(FlowDirection.In)] ARB texture);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1dARB")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] double s);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1dvARB")]
        public abstract unsafe void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] double* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1dvARB")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] ref double v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1fARB")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] float s);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1fvARB")]
        public abstract unsafe void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] float* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1fvARB")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] ref float v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1iARB")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int s);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1ivARB")]
        public abstract unsafe void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1ivARB")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] ref int v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1sARB")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] short s);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1svARB")]
        public abstract unsafe void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] short* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1svARB")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] ref short v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2dARB")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2dvARB")]
        public abstract unsafe void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] double* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2dvARB")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] Span<double> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2fARB")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2fvARB")]
        public abstract unsafe void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] float* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2fvARB")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] Span<float> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2iARB")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2ivARB")]
        public abstract unsafe void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2ivARB")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] Span<int> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2sARB")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2svARB")]
        public abstract unsafe void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] short* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2svARB")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] Span<short> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3dARB")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t, [Flow(FlowDirection.In)] double r);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3dvARB")]
        public abstract unsafe void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] double* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3dvARB")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] Span<double> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3fARB")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float r);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3fvARB")]
        public abstract unsafe void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3fvARB")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3iARB")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3ivARB")]
        public abstract unsafe void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3ivARB")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] Span<int> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3sARB")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t, [Flow(FlowDirection.In)] short r);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3svARB")]
        public abstract unsafe void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] short* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3svARB")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] Span<short> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4dARB")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t, [Flow(FlowDirection.In)] double r, [Flow(FlowDirection.In)] double q);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4dvARB")]
        public abstract unsafe void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4dvARB")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4fARB")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float q);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4fvARB")]
        public abstract unsafe void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4fvARB")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4iARB")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int q);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4ivARB")]
        public abstract unsafe void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4ivARB")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4sARB")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t, [Flow(FlowDirection.In)] short r, [Flow(FlowDirection.In)] short q);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4svARB")]
        public abstract unsafe void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] short* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4svARB")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] Span<short> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glActiveTextureARB")]
        public abstract void ActiveTexture([Flow(FlowDirection.In)] TextureUnit texture);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClientActiveTextureARB")]
        public abstract void ClientActiveTexture([Flow(FlowDirection.In)] TextureUnit texture);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1dARB")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] double s);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1dvARB")]
        public abstract unsafe void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] double* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1dvARB")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] ref double v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1fARB")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] float s);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1fvARB")]
        public abstract unsafe void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] float* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1fvARB")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] ref float v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1iARB")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] int s);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1ivARB")]
        public abstract unsafe void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1ivARB")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] ref int v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1sARB")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] short s);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1svARB")]
        public abstract unsafe void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] short* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord1svARB")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] ref short v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2dARB")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2dvARB")]
        public abstract unsafe void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] double* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2dvARB")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] Span<double> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2fARB")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2fvARB")]
        public abstract unsafe void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] float* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2fvARB")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] Span<float> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2iARB")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2ivARB")]
        public abstract unsafe void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2ivARB")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] Span<int> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2sARB")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2svARB")]
        public abstract unsafe void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] short* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord2svARB")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] Span<short> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3dARB")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t, [Flow(FlowDirection.In)] double r);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3dvARB")]
        public abstract unsafe void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] double* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3dvARB")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] Span<double> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3fARB")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float r);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3fvARB")]
        public abstract unsafe void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3fvARB")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3iARB")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3ivARB")]
        public abstract unsafe void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3ivARB")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] Span<int> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3sARB")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t, [Flow(FlowDirection.In)] short r);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3svARB")]
        public abstract unsafe void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] short* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord3svARB")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] Span<short> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4dARB")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t, [Flow(FlowDirection.In)] double r, [Flow(FlowDirection.In)] double q);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4dvARB")]
        public abstract unsafe void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4dvARB")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4fARB")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float q);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4fvARB")]
        public abstract unsafe void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4fvARB")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4iARB")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int q);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4ivARB")]
        public abstract unsafe void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4ivARB")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4sARB")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t, [Flow(FlowDirection.In)] short r, [Flow(FlowDirection.In)] short q);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4svARB")]
        public abstract unsafe void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] short* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoord4svARB")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] Span<short> v);

        public ArbMultitexture(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

