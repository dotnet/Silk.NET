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

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_vertex_streams")]
    public abstract unsafe partial class AtiVertexStreams : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClientActiveVertexStreamATI")]
        public abstract void ClientActiveVertexStream([Flow(FlowDirection.In)] ATI stream);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3bATI")]
        public abstract void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] sbyte nx, [Flow(FlowDirection.In)] sbyte ny, [Flow(FlowDirection.In)] sbyte nz);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3bvATI")]
        public abstract unsafe void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] sbyte* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3bvATI")]
        public abstract void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<sbyte> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3sATI")]
        public abstract void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] short nx, [Flow(FlowDirection.In)] short ny, [Flow(FlowDirection.In)] short nz);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3svATI")]
        public abstract unsafe void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] short* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3svATI")]
        public abstract void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<short> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3iATI")]
        public abstract void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] int nx, [Flow(FlowDirection.In)] int ny, [Flow(FlowDirection.In)] int nz);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3ivATI")]
        public abstract unsafe void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] int* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3ivATI")]
        public abstract void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<int> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3fATI")]
        public abstract void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] float nx, [Flow(FlowDirection.In)] float ny, [Flow(FlowDirection.In)] float nz);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3fvATI")]
        public abstract unsafe void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] float* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3fvATI")]
        public abstract void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3dATI")]
        public abstract void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] double nx, [Flow(FlowDirection.In)] double ny, [Flow(FlowDirection.In)] double nz);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3dvATI")]
        public abstract unsafe void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] double* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3dvATI")]
        public abstract void NormalStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<double> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexBlendEnviATI")]
        public abstract void VertexBlendEnv([Flow(FlowDirection.In)] ATI pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexBlendEnvfATI")]
        public abstract void VertexBlendEnv([Flow(FlowDirection.In)] ATI pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream1sATI")]
        public abstract void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] short x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream1svATI")]
        public abstract unsafe void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(FlowDirection.In)] short* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream1svATI")]
        public abstract void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(FlowDirection.In)] ref short coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream1iATI")]
        public abstract void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] int x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream1ivATI")]
        public abstract unsafe void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(FlowDirection.In)] int* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream1ivATI")]
        public abstract void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(FlowDirection.In)] ref int coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream1fATI")]
        public abstract void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] float x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream1fvATI")]
        public abstract unsafe void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(FlowDirection.In)] float* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream1fvATI")]
        public abstract void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(FlowDirection.In)] ref float coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream1dATI")]
        public abstract void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] double x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream1dvATI")]
        public abstract unsafe void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(FlowDirection.In)] double* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream1dvATI")]
        public abstract void VertexStream1([Flow(FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(FlowDirection.In)] ref double coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream2sATI")]
        public abstract void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream2svATI")]
        public abstract unsafe void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(FlowDirection.In)] short* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream2svATI")]
        public abstract void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(FlowDirection.In)] Span<short> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream2iATI")]
        public abstract void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream2ivATI")]
        public abstract unsafe void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(FlowDirection.In)] int* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream2ivATI")]
        public abstract void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(FlowDirection.In)] Span<int> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream2fATI")]
        public abstract void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream2fvATI")]
        public abstract unsafe void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(FlowDirection.In)] float* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream2fvATI")]
        public abstract void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(FlowDirection.In)] Span<float> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream2dATI")]
        public abstract void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream2dvATI")]
        public abstract unsafe void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(FlowDirection.In)] double* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream2dvATI")]
        public abstract void VertexStream2([Flow(FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(FlowDirection.In)] Span<double> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream3sATI")]
        public abstract void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream3svATI")]
        public abstract unsafe void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] short* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream3svATI")]
        public abstract void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<short> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream3iATI")]
        public abstract void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream3ivATI")]
        public abstract unsafe void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] int* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream3ivATI")]
        public abstract void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<int> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream3fATI")]
        public abstract void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream3fvATI")]
        public abstract unsafe void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] float* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream3fvATI")]
        public abstract void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream3dATI")]
        public abstract void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream3dvATI")]
        public abstract unsafe void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] double* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream3dvATI")]
        public abstract void VertexStream3([Flow(FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<double> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream4sATI")]
        public abstract void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z, [Flow(FlowDirection.In)] short w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream4svATI")]
        public abstract unsafe void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(FlowDirection.In)] short* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream4svATI")]
        public abstract void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(FlowDirection.In)] Span<short> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream4iATI")]
        public abstract void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream4ivATI")]
        public abstract unsafe void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(FlowDirection.In)] int* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream4ivATI")]
        public abstract void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream4fATI")]
        public abstract void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream4fvATI")]
        public abstract unsafe void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(FlowDirection.In)] float* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream4fvATI")]
        public abstract void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream4dATI")]
        public abstract void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream4dvATI")]
        public abstract unsafe void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(FlowDirection.In)] double* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream4dvATI")]
        public abstract void VertexStream4([Flow(FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClientActiveVertexStreamATI")]
        public abstract void ClientActiveVertexStream([Flow(FlowDirection.In)] VertexStreamATI stream);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3bATI")]
        public abstract void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] sbyte nx, [Flow(FlowDirection.In)] sbyte ny, [Flow(FlowDirection.In)] sbyte nz);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3bvATI")]
        public abstract unsafe void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] sbyte* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3bvATI")]
        public abstract void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<sbyte> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3sATI")]
        public abstract void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] short nx, [Flow(FlowDirection.In)] short ny, [Flow(FlowDirection.In)] short nz);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3svATI")]
        public abstract unsafe void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] short* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3svATI")]
        public abstract void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<short> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3iATI")]
        public abstract void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] int nx, [Flow(FlowDirection.In)] int ny, [Flow(FlowDirection.In)] int nz);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3ivATI")]
        public abstract unsafe void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] int* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3ivATI")]
        public abstract void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<int> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3fATI")]
        public abstract void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] float nx, [Flow(FlowDirection.In)] float ny, [Flow(FlowDirection.In)] float nz);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3fvATI")]
        public abstract unsafe void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] float* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3fvATI")]
        public abstract void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3dATI")]
        public abstract void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] double nx, [Flow(FlowDirection.In)] double ny, [Flow(FlowDirection.In)] double nz);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3dvATI")]
        public abstract unsafe void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] double* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalStream3dvATI")]
        public abstract void NormalStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<double> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexBlendEnviATI")]
        public abstract void VertexBlendEnv([Flow(FlowDirection.In)] VertexStreamATI pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexBlendEnvfATI")]
        public abstract void VertexBlendEnv([Flow(FlowDirection.In)] VertexStreamATI pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream1sATI")]
        public abstract void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] short x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream1svATI")]
        public abstract unsafe void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(FlowDirection.In)] short* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream1svATI")]
        public abstract void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(FlowDirection.In)] ref short coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream1iATI")]
        public abstract void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] int x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream1ivATI")]
        public abstract unsafe void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(FlowDirection.In)] int* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream1ivATI")]
        public abstract void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(FlowDirection.In)] ref int coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream1fATI")]
        public abstract void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] float x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream1fvATI")]
        public abstract unsafe void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(FlowDirection.In)] float* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream1fvATI")]
        public abstract void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(FlowDirection.In)] ref float coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream1dATI")]
        public abstract void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] double x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream1dvATI")]
        public abstract unsafe void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(FlowDirection.In)] double* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream1dvATI")]
        public abstract void VertexStream1([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(FlowDirection.In)] ref double coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream2sATI")]
        public abstract void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream2svATI")]
        public abstract unsafe void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(FlowDirection.In)] short* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream2svATI")]
        public abstract void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(FlowDirection.In)] Span<short> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream2iATI")]
        public abstract void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream2ivATI")]
        public abstract unsafe void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(FlowDirection.In)] int* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream2ivATI")]
        public abstract void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(FlowDirection.In)] Span<int> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream2fATI")]
        public abstract void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream2fvATI")]
        public abstract unsafe void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(FlowDirection.In)] float* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream2fvATI")]
        public abstract void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(FlowDirection.In)] Span<float> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream2dATI")]
        public abstract void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream2dvATI")]
        public abstract unsafe void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(FlowDirection.In)] double* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream2dvATI")]
        public abstract void VertexStream2([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(FlowDirection.In)] Span<double> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream3sATI")]
        public abstract void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream3svATI")]
        public abstract unsafe void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] short* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream3svATI")]
        public abstract void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<short> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream3iATI")]
        public abstract void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream3ivATI")]
        public abstract unsafe void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] int* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream3ivATI")]
        public abstract void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<int> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream3fATI")]
        public abstract void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream3fvATI")]
        public abstract unsafe void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] float* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream3fvATI")]
        public abstract void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream3dATI")]
        public abstract void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream3dvATI")]
        public abstract unsafe void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] double* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream3dvATI")]
        public abstract void VertexStream3([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(FlowDirection.In)] Span<double> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream4sATI")]
        public abstract void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z, [Flow(FlowDirection.In)] short w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream4svATI")]
        public abstract unsafe void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(FlowDirection.In)] short* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream4svATI")]
        public abstract void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(FlowDirection.In)] Span<short> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream4iATI")]
        public abstract void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream4ivATI")]
        public abstract unsafe void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(FlowDirection.In)] int* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream4ivATI")]
        public abstract void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream4fATI")]
        public abstract void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream4fvATI")]
        public abstract unsafe void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(FlowDirection.In)] float* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream4fvATI")]
        public abstract void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream4dATI")]
        public abstract void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream4dvATI")]
        public abstract unsafe void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(FlowDirection.In)] double* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexStream4dvATI")]
        public abstract void VertexStream4([Flow(FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> coords);

        public AtiVertexStreams(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

