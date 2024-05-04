// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_multitexture")]
    public unsafe partial class ArbMultitexture : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_multitexture";
        [NativeApi(EntryPoint = "glActiveTextureARB", Convention = CallingConvention.Winapi)]
        public partial void ActiveTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture);

        [NativeApi(EntryPoint = "glActiveTextureARB", Convention = CallingConvention.Winapi)]
        public partial void ActiveTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture);

        [NativeApi(EntryPoint = "glClientActiveTextureARB", Convention = CallingConvention.Winapi)]
        public partial void ClientActiveTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB texture);

        [NativeApi(EntryPoint = "glClientActiveTextureARB", Convention = CallingConvention.Winapi)]
        public partial void ClientActiveTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture);

        [NativeApi(EntryPoint = "glMultiTexCoord1dARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double s);

        [NativeApi(EntryPoint = "glMultiTexCoord1dARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double s);

        [NativeApi(EntryPoint = "glMultiTexCoord1dvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glMultiTexCoord1dvARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double v);

        [NativeApi(EntryPoint = "glMultiTexCoord1dvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glMultiTexCoord1dvARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double v);

        [NativeApi(EntryPoint = "glMultiTexCoord1fARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float s);

        [NativeApi(EntryPoint = "glMultiTexCoord1fARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float s);

        [NativeApi(EntryPoint = "glMultiTexCoord1fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glMultiTexCoord1fvARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glMultiTexCoord1fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glMultiTexCoord1fvARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glMultiTexCoord1iARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int s);

        [NativeApi(EntryPoint = "glMultiTexCoord1iARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int s);

        [NativeApi(EntryPoint = "glMultiTexCoord1ivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glMultiTexCoord1ivARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v);

        [NativeApi(EntryPoint = "glMultiTexCoord1ivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glMultiTexCoord1ivARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v);

        [NativeApi(EntryPoint = "glMultiTexCoord1sARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short s);

        [NativeApi(EntryPoint = "glMultiTexCoord1sARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short s);

        [NativeApi(EntryPoint = "glMultiTexCoord1svARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glMultiTexCoord1svARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in short v);

        [NativeApi(EntryPoint = "glMultiTexCoord1svARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glMultiTexCoord1svARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in short v);

        [NativeApi(EntryPoint = "glMultiTexCoord2dARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double t);

        [NativeApi(EntryPoint = "glMultiTexCoord2dARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double t);

        [NativeApi(EntryPoint = "glMultiTexCoord2dvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glMultiTexCoord2dvARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double v);

        [NativeApi(EntryPoint = "glMultiTexCoord2dvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glMultiTexCoord2dvARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double v);

        [NativeApi(EntryPoint = "glMultiTexCoord2fARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float t);

        [NativeApi(EntryPoint = "glMultiTexCoord2fARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float t);

        [NativeApi(EntryPoint = "glMultiTexCoord2fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glMultiTexCoord2fvARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glMultiTexCoord2fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glMultiTexCoord2fvARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glMultiTexCoord2iARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int t);

        [NativeApi(EntryPoint = "glMultiTexCoord2iARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int t);

        [NativeApi(EntryPoint = "glMultiTexCoord2ivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glMultiTexCoord2ivARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v);

        [NativeApi(EntryPoint = "glMultiTexCoord2ivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glMultiTexCoord2ivARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v);

        [NativeApi(EntryPoint = "glMultiTexCoord2sARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short t);

        [NativeApi(EntryPoint = "glMultiTexCoord2sARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short t);

        [NativeApi(EntryPoint = "glMultiTexCoord2svARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glMultiTexCoord2svARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in short v);

        [NativeApi(EntryPoint = "glMultiTexCoord2svARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glMultiTexCoord2svARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in short v);

        [NativeApi(EntryPoint = "glMultiTexCoord3dARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double r);

        [NativeApi(EntryPoint = "glMultiTexCoord3dARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double r);

        [NativeApi(EntryPoint = "glMultiTexCoord3dvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glMultiTexCoord3dvARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double v);

        [NativeApi(EntryPoint = "glMultiTexCoord3dvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glMultiTexCoord3dvARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double v);

        [NativeApi(EntryPoint = "glMultiTexCoord3fARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float r);

        [NativeApi(EntryPoint = "glMultiTexCoord3fARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float r);

        [NativeApi(EntryPoint = "glMultiTexCoord3fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glMultiTexCoord3fvARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glMultiTexCoord3fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glMultiTexCoord3fvARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glMultiTexCoord3iARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int r);

        [NativeApi(EntryPoint = "glMultiTexCoord3iARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int r);

        [NativeApi(EntryPoint = "glMultiTexCoord3ivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glMultiTexCoord3ivARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v);

        [NativeApi(EntryPoint = "glMultiTexCoord3ivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glMultiTexCoord3ivARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v);

        [NativeApi(EntryPoint = "glMultiTexCoord3sARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short r);

        [NativeApi(EntryPoint = "glMultiTexCoord3sARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short r);

        [NativeApi(EntryPoint = "glMultiTexCoord3svARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glMultiTexCoord3svARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in short v);

        [NativeApi(EntryPoint = "glMultiTexCoord3svARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glMultiTexCoord3svARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in short v);

        [NativeApi(EntryPoint = "glMultiTexCoord4dARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double q);

        [NativeApi(EntryPoint = "glMultiTexCoord4dARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double q);

        [NativeApi(EntryPoint = "glMultiTexCoord4dvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glMultiTexCoord4dvARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double v);

        [NativeApi(EntryPoint = "glMultiTexCoord4dvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glMultiTexCoord4dvARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double v);

        [NativeApi(EntryPoint = "glMultiTexCoord4fARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float q);

        [NativeApi(EntryPoint = "glMultiTexCoord4fARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float q);

        [NativeApi(EntryPoint = "glMultiTexCoord4fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glMultiTexCoord4fvARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glMultiTexCoord4fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glMultiTexCoord4fvARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glMultiTexCoord4iARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int q);

        [NativeApi(EntryPoint = "glMultiTexCoord4iARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int q);

        [NativeApi(EntryPoint = "glMultiTexCoord4ivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glMultiTexCoord4ivARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v);

        [NativeApi(EntryPoint = "glMultiTexCoord4ivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glMultiTexCoord4ivARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v);

        [NativeApi(EntryPoint = "glMultiTexCoord4sARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short q);

        [NativeApi(EntryPoint = "glMultiTexCoord4sARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short q);

        [NativeApi(EntryPoint = "glMultiTexCoord4svARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glMultiTexCoord4svARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in short v);

        [NativeApi(EntryPoint = "glMultiTexCoord4svARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glMultiTexCoord4svARB", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in short v);

        public ArbMultitexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

