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

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_vertex_streams")]
    public unsafe partial class AtiVertexStreams : NativeExtension<GL>
    {
        public const string ExtensionName = "ATI_vertex_streams";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClientActiveVertexStreamATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClientActiveVertexStream([Flow(FlowDirection.In)] ATI stream)
            => ImplClientActiveVertexStream(stream);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
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
        [NativeApi(EntryPoint = "glNormalStream3bATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] sbyte nx, [Flow(FlowDirection.In)] sbyte ny, [Flow(FlowDirection.In)] sbyte nz)
            => ImplNormalStream3(stream, nx, ny, nz);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalStream3bvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] sbyte* coords)
            => ImplNormalStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalStream3bvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<sbyte> coords)
            => ImplNormalStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
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
        [NativeApi(EntryPoint = "glNormalStream3sATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] short nx, [Flow(FlowDirection.In)] short ny, [Flow(FlowDirection.In)] short nz)
            => ImplNormalStream3(stream, nx, ny, nz);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalStream3svATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] short* coords)
            => ImplNormalStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalStream3svATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<short> coords)
            => ImplNormalStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
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
        [NativeApi(EntryPoint = "glNormalStream3iATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] int nx, [Flow(FlowDirection.In)] int ny, [Flow(FlowDirection.In)] int nz)
            => ImplNormalStream3(stream, nx, ny, nz);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalStream3ivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] int* coords)
            => ImplNormalStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalStream3ivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<int> coords)
            => ImplNormalStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
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
        [NativeApi(EntryPoint = "glNormalStream3fATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] float nx, [Flow(FlowDirection.In)] float ny, [Flow(FlowDirection.In)] float nz)
            => ImplNormalStream3(stream, nx, ny, nz);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalStream3fvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] float* coords)
            => ImplNormalStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalStream3fvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> coords)
            => ImplNormalStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
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
        [NativeApi(EntryPoint = "glNormalStream3dATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] double nx, [Flow(FlowDirection.In)] double ny, [Flow(FlowDirection.In)] double nz)
            => ImplNormalStream3(stream, nx, ny, nz);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalStream3dvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] double* coords)
            => ImplNormalStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalStream3dvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<double> coords)
            => ImplNormalStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexBlendEnviATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexBlendEnv([Flow(FlowDirection.In)] ATI pname, [Flow(FlowDirection.In)] int param)
            => ImplVertexBlendEnv(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexBlendEnvfATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexBlendEnv([Flow(FlowDirection.In)] ATI pname, [Flow(FlowDirection.In)] float param)
            => ImplVertexBlendEnv(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream1sATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] short x)
            => ImplVertexStream1(stream, x);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream1svATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(FlowDirection.In)] short* coords)
            => ImplVertexStream1(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream1svATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(FlowDirection.In)] ref short coords)
            => ImplVertexStream1(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream1iATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] int x)
            => ImplVertexStream1(stream, x);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream1ivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(FlowDirection.In)] int* coords)
            => ImplVertexStream1(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream1ivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(FlowDirection.In)] ref int coords)
            => ImplVertexStream1(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream1fATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] float x)
            => ImplVertexStream1(stream, x);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream1fvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(FlowDirection.In)] float* coords)
            => ImplVertexStream1(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream1fvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(FlowDirection.In)] ref float coords)
            => ImplVertexStream1(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream1dATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] double x)
            => ImplVertexStream1(stream, x);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream1dvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(FlowDirection.In)] double* coords)
            => ImplVertexStream1(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream1dvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(FlowDirection.In)] ref double coords)
            => ImplVertexStream1(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream2sATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y)
            => ImplVertexStream2(stream, x, y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream2svATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(FlowDirection.In)] short* coords)
            => ImplVertexStream2(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream2svATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(FlowDirection.In)] Span<short> coords)
            => ImplVertexStream2(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream2iATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y)
            => ImplVertexStream2(stream, x, y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream2ivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(FlowDirection.In)] int* coords)
            => ImplVertexStream2(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream2ivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(FlowDirection.In)] Span<int> coords)
            => ImplVertexStream2(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream2fATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y)
            => ImplVertexStream2(stream, x, y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream2fvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(FlowDirection.In)] float* coords)
            => ImplVertexStream2(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream2fvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(FlowDirection.In)] Span<float> coords)
            => ImplVertexStream2(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream2dATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y)
            => ImplVertexStream2(stream, x, y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream2dvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(FlowDirection.In)] double* coords)
            => ImplVertexStream2(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream2dvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(FlowDirection.In)] Span<double> coords)
            => ImplVertexStream2(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
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
        [NativeApi(EntryPoint = "glVertexStream3sATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z)
            => ImplVertexStream3(stream, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream3svATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] short* coords)
            => ImplVertexStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream3svATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<short> coords)
            => ImplVertexStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
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
        [NativeApi(EntryPoint = "glVertexStream3iATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z)
            => ImplVertexStream3(stream, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream3ivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] int* coords)
            => ImplVertexStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream3ivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<int> coords)
            => ImplVertexStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
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
        [NativeApi(EntryPoint = "glVertexStream3fATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z)
            => ImplVertexStream3(stream, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream3fvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] float* coords)
            => ImplVertexStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream3fvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> coords)
            => ImplVertexStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
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
        [NativeApi(EntryPoint = "glVertexStream3dATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z)
            => ImplVertexStream3(stream, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream3dvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] double* coords)
            => ImplVertexStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream3dvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<double> coords)
            => ImplVertexStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
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
        [NativeApi(EntryPoint = "glVertexStream4sATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z, [Flow(FlowDirection.In)] short w)
            => ImplVertexStream4(stream, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream4svATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(FlowDirection.In)] short* coords)
            => ImplVertexStream4(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream4svATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(FlowDirection.In)] Span<short> coords)
            => ImplVertexStream4(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
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
        [NativeApi(EntryPoint = "glVertexStream4iATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w)
            => ImplVertexStream4(stream, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream4ivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(FlowDirection.In)] int* coords)
            => ImplVertexStream4(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream4ivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> coords)
            => ImplVertexStream4(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
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
        [NativeApi(EntryPoint = "glVertexStream4fATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w)
            => ImplVertexStream4(stream, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream4fvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(FlowDirection.In)] float* coords)
            => ImplVertexStream4(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream4fvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> coords)
            => ImplVertexStream4(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
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
        [NativeApi(EntryPoint = "glVertexStream4dATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w)
            => ImplVertexStream4(stream, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream4dvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(FlowDirection.In)] double* coords)
            => ImplVertexStream4(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream4dvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> coords)
            => ImplVertexStream4(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClientActiveVertexStreamATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClientActiveVertexStream([Flow(FlowDirection.In)] VertexStreamATI stream)
            => ImplClientActiveVertexStream(stream);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
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
        [NativeApi(EntryPoint = "glNormalStream3bATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] sbyte nx, [Flow(FlowDirection.In)] sbyte ny, [Flow(FlowDirection.In)] sbyte nz)
            => ImplNormalStream3(stream, nx, ny, nz);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalStream3bvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] sbyte* coords)
            => ImplNormalStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalStream3bvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<sbyte> coords)
            => ImplNormalStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
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
        [NativeApi(EntryPoint = "glNormalStream3sATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] short nx, [Flow(FlowDirection.In)] short ny, [Flow(FlowDirection.In)] short nz)
            => ImplNormalStream3(stream, nx, ny, nz);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalStream3svATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] short* coords)
            => ImplNormalStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalStream3svATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<short> coords)
            => ImplNormalStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
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
        [NativeApi(EntryPoint = "glNormalStream3iATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] int nx, [Flow(FlowDirection.In)] int ny, [Flow(FlowDirection.In)] int nz)
            => ImplNormalStream3(stream, nx, ny, nz);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalStream3ivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] int* coords)
            => ImplNormalStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalStream3ivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<int> coords)
            => ImplNormalStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
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
        [NativeApi(EntryPoint = "glNormalStream3fATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] float nx, [Flow(FlowDirection.In)] float ny, [Flow(FlowDirection.In)] float nz)
            => ImplNormalStream3(stream, nx, ny, nz);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalStream3fvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] float* coords)
            => ImplNormalStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalStream3fvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> coords)
            => ImplNormalStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
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
        [NativeApi(EntryPoint = "glNormalStream3dATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] double nx, [Flow(FlowDirection.In)] double ny, [Flow(FlowDirection.In)] double nz)
            => ImplNormalStream3(stream, nx, ny, nz);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalStream3dvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] double* coords)
            => ImplNormalStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalStream3dvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<double> coords)
            => ImplNormalStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexBlendEnviATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexBlendEnv([Flow(FlowDirection.In)] VertexStreamATI pname, [Flow(FlowDirection.In)] int param)
            => ImplVertexBlendEnv(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexBlendEnvfATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexBlendEnv([Flow(FlowDirection.In)] VertexStreamATI pname, [Flow(FlowDirection.In)] float param)
            => ImplVertexBlendEnv(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream1sATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] short x)
            => ImplVertexStream1(stream, x);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream1svATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(FlowDirection.In)] short* coords)
            => ImplVertexStream1(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream1svATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(FlowDirection.In)] ref short coords)
            => ImplVertexStream1(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream1iATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] int x)
            => ImplVertexStream1(stream, x);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream1ivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(FlowDirection.In)] int* coords)
            => ImplVertexStream1(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream1ivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(FlowDirection.In)] ref int coords)
            => ImplVertexStream1(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream1fATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] float x)
            => ImplVertexStream1(stream, x);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream1fvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(FlowDirection.In)] float* coords)
            => ImplVertexStream1(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream1fvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(FlowDirection.In)] ref float coords)
            => ImplVertexStream1(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream1dATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] double x)
            => ImplVertexStream1(stream, x);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream1dvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(FlowDirection.In)] double* coords)
            => ImplVertexStream1(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream1dvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(FlowDirection.In)] ref double coords)
            => ImplVertexStream1(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream2sATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y)
            => ImplVertexStream2(stream, x, y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream2svATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(FlowDirection.In)] short* coords)
            => ImplVertexStream2(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream2svATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(FlowDirection.In)] Span<short> coords)
            => ImplVertexStream2(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream2iATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y)
            => ImplVertexStream2(stream, x, y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream2ivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(FlowDirection.In)] int* coords)
            => ImplVertexStream2(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream2ivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(FlowDirection.In)] Span<int> coords)
            => ImplVertexStream2(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream2fATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y)
            => ImplVertexStream2(stream, x, y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream2fvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(FlowDirection.In)] float* coords)
            => ImplVertexStream2(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream2fvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(FlowDirection.In)] Span<float> coords)
            => ImplVertexStream2(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream2dATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y)
            => ImplVertexStream2(stream, x, y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream2dvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(FlowDirection.In)] double* coords)
            => ImplVertexStream2(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream2dvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(FlowDirection.In)] Span<double> coords)
            => ImplVertexStream2(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
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
        [NativeApi(EntryPoint = "glVertexStream3sATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z)
            => ImplVertexStream3(stream, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream3svATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] short* coords)
            => ImplVertexStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream3svATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<short> coords)
            => ImplVertexStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
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
        [NativeApi(EntryPoint = "glVertexStream3iATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z)
            => ImplVertexStream3(stream, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream3ivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] int* coords)
            => ImplVertexStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream3ivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<int> coords)
            => ImplVertexStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
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
        [NativeApi(EntryPoint = "glVertexStream3fATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z)
            => ImplVertexStream3(stream, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream3fvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] float* coords)
            => ImplVertexStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream3fvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> coords)
            => ImplVertexStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
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
        [NativeApi(EntryPoint = "glVertexStream3dATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z)
            => ImplVertexStream3(stream, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream3dvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] double* coords)
            => ImplVertexStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream3dvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<double> coords)
            => ImplVertexStream3(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
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
        [NativeApi(EntryPoint = "glVertexStream4sATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z, [Flow(FlowDirection.In)] short w)
            => ImplVertexStream4(stream, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream4svATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(FlowDirection.In)] short* coords)
            => ImplVertexStream4(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream4svATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(FlowDirection.In)] Span<short> coords)
            => ImplVertexStream4(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
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
        [NativeApi(EntryPoint = "glVertexStream4iATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w)
            => ImplVertexStream4(stream, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream4ivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(FlowDirection.In)] int* coords)
            => ImplVertexStream4(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream4ivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> coords)
            => ImplVertexStream4(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
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
        [NativeApi(EntryPoint = "glVertexStream4fATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w)
            => ImplVertexStream4(stream, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream4fvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(FlowDirection.In)] float* coords)
            => ImplVertexStream4(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream4fvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> coords)
            => ImplVertexStream4(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
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
        [NativeApi(EntryPoint = "glVertexStream4dATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w)
            => ImplVertexStream4(stream, x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream4dvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(FlowDirection.In)] double* coords)
            => ImplVertexStream4(stream, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexStream4dvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> coords)
            => ImplVertexStream4(stream, coords);

        public AtiVertexStreams(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

