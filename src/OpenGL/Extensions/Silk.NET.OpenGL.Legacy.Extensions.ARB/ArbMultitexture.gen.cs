// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_multitexture")]
    public unsafe partial class ArbMultitexture : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_multitexture";
        [NativeApi(EntryPoint = "glActiveTextureARB")]
        public partial void ActiveTexture([Flow(FlowDirection.In)] ARB texture);

        [NativeApi(EntryPoint = "glActiveTextureARB")]
        public partial void ActiveTexture([Flow(FlowDirection.In)] TextureUnit texture);

        [NativeApi(EntryPoint = "glClientActiveTextureARB")]
        public partial void ClientActiveTexture([Flow(FlowDirection.In)] ARB texture);

        [NativeApi(EntryPoint = "glClientActiveTextureARB")]
        public partial void ClientActiveTexture([Flow(FlowDirection.In)] TextureUnit texture);

        [NativeApi(EntryPoint = "glMultiTexCoord1dARB")]
        public partial void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] double s);

        [NativeApi(EntryPoint = "glMultiTexCoord1dARB")]
        public partial void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] double s);

        [NativeApi(EntryPoint = "glMultiTexCoord1dvARB")]
        public unsafe partial void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glMultiTexCoord1dvARB")]
        public partial void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glMultiTexCoord1dvARB")]
        public unsafe partial void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glMultiTexCoord1dvARB")]
        public partial void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glMultiTexCoord1fARB")]
        public partial void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] float s);

        [NativeApi(EntryPoint = "glMultiTexCoord1fARB")]
        public partial void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] float s);

        [NativeApi(EntryPoint = "glMultiTexCoord1fvARB")]
        public unsafe partial void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glMultiTexCoord1fvARB")]
        public partial void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glMultiTexCoord1fvARB")]
        public unsafe partial void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glMultiTexCoord1fvARB")]
        public partial void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glMultiTexCoord1iARB")]
        public partial void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int s);

        [NativeApi(EntryPoint = "glMultiTexCoord1iARB")]
        public partial void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] int s);

        [NativeApi(EntryPoint = "glMultiTexCoord1ivARB")]
        public unsafe partial void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glMultiTexCoord1ivARB")]
        public partial void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glMultiTexCoord1ivARB")]
        public unsafe partial void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glMultiTexCoord1ivARB")]
        public partial void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glMultiTexCoord1sARB")]
        public partial void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] short s);

        [NativeApi(EntryPoint = "glMultiTexCoord1sARB")]
        public partial void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] short s);

        [NativeApi(EntryPoint = "glMultiTexCoord1svARB")]
        public unsafe partial void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glMultiTexCoord1svARB")]
        public partial void MultiTexCoord1([Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glMultiTexCoord1svARB")]
        public unsafe partial void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glMultiTexCoord1svARB")]
        public partial void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glMultiTexCoord2dARB")]
        public partial void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t);

        [NativeApi(EntryPoint = "glMultiTexCoord2dARB")]
        public partial void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t);

        [NativeApi(EntryPoint = "glMultiTexCoord2dvARB")]
        public unsafe partial void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glMultiTexCoord2dvARB")]
        public partial void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glMultiTexCoord2dvARB")]
        public unsafe partial void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glMultiTexCoord2dvARB")]
        public partial void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glMultiTexCoord2fARB")]
        public partial void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t);

        [NativeApi(EntryPoint = "glMultiTexCoord2fARB")]
        public partial void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t);

        [NativeApi(EntryPoint = "glMultiTexCoord2fvARB")]
        public unsafe partial void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glMultiTexCoord2fvARB")]
        public partial void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glMultiTexCoord2fvARB")]
        public unsafe partial void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glMultiTexCoord2fvARB")]
        public partial void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glMultiTexCoord2iARB")]
        public partial void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t);

        [NativeApi(EntryPoint = "glMultiTexCoord2iARB")]
        public partial void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t);

        [NativeApi(EntryPoint = "glMultiTexCoord2ivARB")]
        public unsafe partial void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glMultiTexCoord2ivARB")]
        public partial void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glMultiTexCoord2ivARB")]
        public unsafe partial void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glMultiTexCoord2ivARB")]
        public partial void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glMultiTexCoord2sARB")]
        public partial void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t);

        [NativeApi(EntryPoint = "glMultiTexCoord2sARB")]
        public partial void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t);

        [NativeApi(EntryPoint = "glMultiTexCoord2svARB")]
        public unsafe partial void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glMultiTexCoord2svARB")]
        public partial void MultiTexCoord2([Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glMultiTexCoord2svARB")]
        public unsafe partial void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glMultiTexCoord2svARB")]
        public partial void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glMultiTexCoord3dARB")]
        public partial void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t, [Flow(FlowDirection.In)] double r);

        [NativeApi(EntryPoint = "glMultiTexCoord3dARB")]
        public partial void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t, [Flow(FlowDirection.In)] double r);

        [NativeApi(EntryPoint = "glMultiTexCoord3dvARB")]
        public unsafe partial void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glMultiTexCoord3dvARB")]
        public partial void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glMultiTexCoord3dvARB")]
        public unsafe partial void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glMultiTexCoord3dvARB")]
        public partial void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glMultiTexCoord3fARB")]
        public partial void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float r);

        [NativeApi(EntryPoint = "glMultiTexCoord3fARB")]
        public partial void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float r);

        [NativeApi(EntryPoint = "glMultiTexCoord3fvARB")]
        public unsafe partial void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glMultiTexCoord3fvARB")]
        public partial void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glMultiTexCoord3fvARB")]
        public unsafe partial void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glMultiTexCoord3fvARB")]
        public partial void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glMultiTexCoord3iARB")]
        public partial void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r);

        [NativeApi(EntryPoint = "glMultiTexCoord3iARB")]
        public partial void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r);

        [NativeApi(EntryPoint = "glMultiTexCoord3ivARB")]
        public unsafe partial void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glMultiTexCoord3ivARB")]
        public partial void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glMultiTexCoord3ivARB")]
        public unsafe partial void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glMultiTexCoord3ivARB")]
        public partial void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glMultiTexCoord3sARB")]
        public partial void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t, [Flow(FlowDirection.In)] short r);

        [NativeApi(EntryPoint = "glMultiTexCoord3sARB")]
        public partial void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t, [Flow(FlowDirection.In)] short r);

        [NativeApi(EntryPoint = "glMultiTexCoord3svARB")]
        public unsafe partial void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glMultiTexCoord3svARB")]
        public partial void MultiTexCoord3([Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glMultiTexCoord3svARB")]
        public unsafe partial void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glMultiTexCoord3svARB")]
        public partial void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glMultiTexCoord4dARB")]
        public partial void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t, [Flow(FlowDirection.In)] double r, [Flow(FlowDirection.In)] double q);

        [NativeApi(EntryPoint = "glMultiTexCoord4dARB")]
        public partial void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t, [Flow(FlowDirection.In)] double r, [Flow(FlowDirection.In)] double q);

        [NativeApi(EntryPoint = "glMultiTexCoord4dvARB")]
        public unsafe partial void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glMultiTexCoord4dvARB")]
        public partial void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glMultiTexCoord4dvARB")]
        public unsafe partial void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glMultiTexCoord4dvARB")]
        public partial void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glMultiTexCoord4fARB")]
        public partial void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float q);

        [NativeApi(EntryPoint = "glMultiTexCoord4fARB")]
        public partial void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float q);

        [NativeApi(EntryPoint = "glMultiTexCoord4fvARB")]
        public unsafe partial void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glMultiTexCoord4fvARB")]
        public partial void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glMultiTexCoord4fvARB")]
        public unsafe partial void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glMultiTexCoord4fvARB")]
        public partial void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glMultiTexCoord4iARB")]
        public partial void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int q);

        [NativeApi(EntryPoint = "glMultiTexCoord4iARB")]
        public partial void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int q);

        [NativeApi(EntryPoint = "glMultiTexCoord4ivARB")]
        public unsafe partial void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glMultiTexCoord4ivARB")]
        public partial void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glMultiTexCoord4ivARB")]
        public unsafe partial void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glMultiTexCoord4ivARB")]
        public partial void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glMultiTexCoord4sARB")]
        public partial void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t, [Flow(FlowDirection.In)] short r, [Flow(FlowDirection.In)] short q);

        [NativeApi(EntryPoint = "glMultiTexCoord4sARB")]
        public partial void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t, [Flow(FlowDirection.In)] short r, [Flow(FlowDirection.In)] short q);

        [NativeApi(EntryPoint = "glMultiTexCoord4svARB")]
        public unsafe partial void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glMultiTexCoord4svARB")]
        public partial void MultiTexCoord4([Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glMultiTexCoord4svARB")]
        public unsafe partial void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glMultiTexCoord4svARB")]
        public partial void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] in short v);

        public ArbMultitexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

