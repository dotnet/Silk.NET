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

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_vertex_streams")]
    public unsafe partial class AtiVertexStreams : NativeExtension<GL>
    {
        public const string ExtensionName = "ATI_vertex_streams";
        [NativeApi(EntryPoint = "glClientActiveVertexStreamATI", Convention = CallingConvention.Winapi)]
        public partial void ClientActiveVertexStream([Flow(FlowDirection.In)] ATI stream);

        [NativeApi(EntryPoint = "glClientActiveVertexStreamATI", Convention = CallingConvention.Winapi)]
        public partial void ClientActiveVertexStream([Flow(FlowDirection.In)] VertexStreamATI stream);

        [NativeApi(EntryPoint = "glNormalStream3bATI", Convention = CallingConvention.Winapi)]
        public partial void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] sbyte nx, [Flow(FlowDirection.In)] sbyte ny, [Flow(FlowDirection.In)] sbyte nz);

        [NativeApi(EntryPoint = "glNormalStream3bATI", Convention = CallingConvention.Winapi)]
        public partial void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] sbyte nx, [Flow(FlowDirection.In)] sbyte ny, [Flow(FlowDirection.In)] sbyte nz);

        [NativeApi(EntryPoint = "glNormalStream3bvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glNormalStream3bvATI", Convention = CallingConvention.Winapi)]
        public partial void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] in sbyte coords);

        [NativeApi(EntryPoint = "glNormalStream3bvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] sbyte* coords);

        [NativeApi(EntryPoint = "glNormalStream3bvATI", Convention = CallingConvention.Winapi)]
        public partial void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] in sbyte coords);

        [NativeApi(EntryPoint = "glNormalStream3sATI", Convention = CallingConvention.Winapi)]
        public partial void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] short nx, [Flow(FlowDirection.In)] short ny, [Flow(FlowDirection.In)] short nz);

        [NativeApi(EntryPoint = "glNormalStream3sATI", Convention = CallingConvention.Winapi)]
        public partial void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] short nx, [Flow(FlowDirection.In)] short ny, [Flow(FlowDirection.In)] short nz);

        [NativeApi(EntryPoint = "glNormalStream3svATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] short* coords);

        [NativeApi(EntryPoint = "glNormalStream3svATI", Convention = CallingConvention.Winapi)]
        public partial void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] in short coords);

        [NativeApi(EntryPoint = "glNormalStream3svATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] short* coords);

        [NativeApi(EntryPoint = "glNormalStream3svATI", Convention = CallingConvention.Winapi)]
        public partial void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] in short coords);

        [NativeApi(EntryPoint = "glNormalStream3iATI", Convention = CallingConvention.Winapi)]
        public partial void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] int nx, [Flow(FlowDirection.In)] int ny, [Flow(FlowDirection.In)] int nz);

        [NativeApi(EntryPoint = "glNormalStream3iATI", Convention = CallingConvention.Winapi)]
        public partial void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] int nx, [Flow(FlowDirection.In)] int ny, [Flow(FlowDirection.In)] int nz);

        [NativeApi(EntryPoint = "glNormalStream3ivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glNormalStream3ivATI", Convention = CallingConvention.Winapi)]
        public partial void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glNormalStream3ivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glNormalStream3ivATI", Convention = CallingConvention.Winapi)]
        public partial void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glNormalStream3fATI", Convention = CallingConvention.Winapi)]
        public partial void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] float nx, [Flow(FlowDirection.In)] float ny, [Flow(FlowDirection.In)] float nz);

        [NativeApi(EntryPoint = "glNormalStream3fATI", Convention = CallingConvention.Winapi)]
        public partial void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] float nx, [Flow(FlowDirection.In)] float ny, [Flow(FlowDirection.In)] float nz);

        [NativeApi(EntryPoint = "glNormalStream3fvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] float* coords);

        [NativeApi(EntryPoint = "glNormalStream3fvATI", Convention = CallingConvention.Winapi)]
        public partial void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] in float coords);

        [NativeApi(EntryPoint = "glNormalStream3fvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] float* coords);

        [NativeApi(EntryPoint = "glNormalStream3fvATI", Convention = CallingConvention.Winapi)]
        public partial void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] in float coords);

        [NativeApi(EntryPoint = "glNormalStream3dATI", Convention = CallingConvention.Winapi)]
        public partial void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] double nx, [Flow(FlowDirection.In)] double ny, [Flow(FlowDirection.In)] double nz);

        [NativeApi(EntryPoint = "glNormalStream3dATI", Convention = CallingConvention.Winapi)]
        public partial void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] double nx, [Flow(FlowDirection.In)] double ny, [Flow(FlowDirection.In)] double nz);

        [NativeApi(EntryPoint = "glNormalStream3dvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] double* coords);

        [NativeApi(EntryPoint = "glNormalStream3dvATI", Convention = CallingConvention.Winapi)]
        public partial void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] in double coords);

        [NativeApi(EntryPoint = "glNormalStream3dvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] double* coords);

        [NativeApi(EntryPoint = "glNormalStream3dvATI", Convention = CallingConvention.Winapi)]
        public partial void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] in double coords);

        [NativeApi(EntryPoint = "glVertexBlendEnviATI", Convention = CallingConvention.Winapi)]
        public partial void VertexBlendEnv([Flow(FlowDirection.In)] ATI pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glVertexBlendEnviATI", Convention = CallingConvention.Winapi)]
        public partial void VertexBlendEnv([Flow(FlowDirection.In)] VertexStreamATI pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glVertexBlendEnvfATI", Convention = CallingConvention.Winapi)]
        public partial void VertexBlendEnv([Flow(FlowDirection.In)] ATI pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glVertexBlendEnvfATI", Convention = CallingConvention.Winapi)]
        public partial void VertexBlendEnv([Flow(FlowDirection.In)] VertexStreamATI pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glVertexStream1sATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] short x);

        [NativeApi(EntryPoint = "glVertexStream1sATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] short x);

        [NativeApi(EntryPoint = "glVertexStream1svATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(FlowDirection.In)] short* coords);

        [NativeApi(EntryPoint = "glVertexStream1svATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(FlowDirection.In)] in short coords);

        [NativeApi(EntryPoint = "glVertexStream1svATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(FlowDirection.In)] short* coords);

        [NativeApi(EntryPoint = "glVertexStream1svATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(FlowDirection.In)] in short coords);

        [NativeApi(EntryPoint = "glVertexStream1iATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] int x);

        [NativeApi(EntryPoint = "glVertexStream1iATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] int x);

        [NativeApi(EntryPoint = "glVertexStream1ivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glVertexStream1ivATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glVertexStream1ivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glVertexStream1ivATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glVertexStream1fATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] float x);

        [NativeApi(EntryPoint = "glVertexStream1fATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] float x);

        [NativeApi(EntryPoint = "glVertexStream1fvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(FlowDirection.In)] float* coords);

        [NativeApi(EntryPoint = "glVertexStream1fvATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(FlowDirection.In)] in float coords);

        [NativeApi(EntryPoint = "glVertexStream1fvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(FlowDirection.In)] float* coords);

        [NativeApi(EntryPoint = "glVertexStream1fvATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(FlowDirection.In)] in float coords);

        [NativeApi(EntryPoint = "glVertexStream1dATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] double x);

        [NativeApi(EntryPoint = "glVertexStream1dATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] double x);

        [NativeApi(EntryPoint = "glVertexStream1dvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(FlowDirection.In)] double* coords);

        [NativeApi(EntryPoint = "glVertexStream1dvATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(FlowDirection.In)] in double coords);

        [NativeApi(EntryPoint = "glVertexStream1dvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(FlowDirection.In)] double* coords);

        [NativeApi(EntryPoint = "glVertexStream1dvATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(FlowDirection.In)] in double coords);

        [NativeApi(EntryPoint = "glVertexStream2sATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y);

        [NativeApi(EntryPoint = "glVertexStream2sATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y);

        [NativeApi(EntryPoint = "glVertexStream2svATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(FlowDirection.In)] short* coords);

        [NativeApi(EntryPoint = "glVertexStream2svATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(FlowDirection.In)] in short coords);

        [NativeApi(EntryPoint = "glVertexStream2svATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(FlowDirection.In)] short* coords);

        [NativeApi(EntryPoint = "glVertexStream2svATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(FlowDirection.In)] in short coords);

        [NativeApi(EntryPoint = "glVertexStream2iATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y);

        [NativeApi(EntryPoint = "glVertexStream2iATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y);

        [NativeApi(EntryPoint = "glVertexStream2ivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glVertexStream2ivATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glVertexStream2ivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glVertexStream2ivATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glVertexStream2fATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y);

        [NativeApi(EntryPoint = "glVertexStream2fATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y);

        [NativeApi(EntryPoint = "glVertexStream2fvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(FlowDirection.In)] float* coords);

        [NativeApi(EntryPoint = "glVertexStream2fvATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(FlowDirection.In)] in float coords);

        [NativeApi(EntryPoint = "glVertexStream2fvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(FlowDirection.In)] float* coords);

        [NativeApi(EntryPoint = "glVertexStream2fvATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(FlowDirection.In)] in float coords);

        [NativeApi(EntryPoint = "glVertexStream2dATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        [NativeApi(EntryPoint = "glVertexStream2dATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        [NativeApi(EntryPoint = "glVertexStream2dvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(FlowDirection.In)] double* coords);

        [NativeApi(EntryPoint = "glVertexStream2dvATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(FlowDirection.In)] in double coords);

        [NativeApi(EntryPoint = "glVertexStream2dvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(FlowDirection.In)] double* coords);

        [NativeApi(EntryPoint = "glVertexStream2dvATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(FlowDirection.In)] in double coords);

        [NativeApi(EntryPoint = "glVertexStream3sATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z);

        [NativeApi(EntryPoint = "glVertexStream3sATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z);

        [NativeApi(EntryPoint = "glVertexStream3svATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] short* coords);

        [NativeApi(EntryPoint = "glVertexStream3svATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] in short coords);

        [NativeApi(EntryPoint = "glVertexStream3svATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] short* coords);

        [NativeApi(EntryPoint = "glVertexStream3svATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] in short coords);

        [NativeApi(EntryPoint = "glVertexStream3iATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        [NativeApi(EntryPoint = "glVertexStream3iATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        [NativeApi(EntryPoint = "glVertexStream3ivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glVertexStream3ivATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glVertexStream3ivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glVertexStream3ivATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glVertexStream3fATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glVertexStream3fATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glVertexStream3fvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] float* coords);

        [NativeApi(EntryPoint = "glVertexStream3fvATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] in float coords);

        [NativeApi(EntryPoint = "glVertexStream3fvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] float* coords);

        [NativeApi(EntryPoint = "glVertexStream3fvATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] in float coords);

        [NativeApi(EntryPoint = "glVertexStream3dATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glVertexStream3dATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glVertexStream3dvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] double* coords);

        [NativeApi(EntryPoint = "glVertexStream3dvATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] in double coords);

        [NativeApi(EntryPoint = "glVertexStream3dvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] double* coords);

        [NativeApi(EntryPoint = "glVertexStream3dvATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] in double coords);

        [NativeApi(EntryPoint = "glVertexStream4sATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z, [Flow(FlowDirection.In)] short w);

        [NativeApi(EntryPoint = "glVertexStream4sATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z, [Flow(FlowDirection.In)] short w);

        [NativeApi(EntryPoint = "glVertexStream4svATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(FlowDirection.In)] short* coords);

        [NativeApi(EntryPoint = "glVertexStream4svATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(FlowDirection.In)] in short coords);

        [NativeApi(EntryPoint = "glVertexStream4svATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(FlowDirection.In)] short* coords);

        [NativeApi(EntryPoint = "glVertexStream4svATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(FlowDirection.In)] in short coords);

        [NativeApi(EntryPoint = "glVertexStream4iATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glVertexStream4iATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glVertexStream4ivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glVertexStream4ivATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glVertexStream4ivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glVertexStream4ivATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glVertexStream4fATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glVertexStream4fATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glVertexStream4fvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(FlowDirection.In)] float* coords);

        [NativeApi(EntryPoint = "glVertexStream4fvATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(FlowDirection.In)] in float coords);

        [NativeApi(EntryPoint = "glVertexStream4fvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(FlowDirection.In)] float* coords);

        [NativeApi(EntryPoint = "glVertexStream4fvATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(FlowDirection.In)] in float coords);

        [NativeApi(EntryPoint = "glVertexStream4dATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glVertexStream4dATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glVertexStream4dvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(FlowDirection.In)] double* coords);

        [NativeApi(EntryPoint = "glVertexStream4dvATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(FlowDirection.In)] in double coords);

        [NativeApi(EntryPoint = "glVertexStream4dvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(FlowDirection.In)] double* coords);

        [NativeApi(EntryPoint = "glVertexStream4dvATI", Convention = CallingConvention.Winapi)]
        public partial void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(FlowDirection.In)] in double coords);

        public AtiVertexStreams(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

