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
    [Extension("ARB_vertex_blend")]
    public unsafe partial class ArbVertexBlend : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_vertex_blend";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexBlendARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexBlend([Flow(FlowDirection.In)] int count)
            => ImplVertexBlend(count);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glWeightbvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] sbyte* weights)
            => ImplWeight(size, weights);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glWeightbvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<sbyte> weights)
            => ImplWeight(size, weights);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glWeightsvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] short* weights)
            => ImplWeight(size, weights);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glWeightsvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<short> weights)
            => ImplWeight(size, weights);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glWeightivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] int* weights)
            => ImplWeight(size, weights);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glWeightivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<int> weights)
            => ImplWeight(size, weights);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glWeightfvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] float* weights)
            => ImplWeight(size, weights);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glWeightfvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<float> weights)
            => ImplWeight(size, weights);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glWeightdvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] double* weights)
            => ImplWeight(size, weights);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glWeightdvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<double> weights)
            => ImplWeight(size, weights);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glWeightubvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] byte* weights)
            => ImplWeight(size, weights);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glWeightubvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<byte> weights)
            => ImplWeight(size, weights);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glWeightusvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ushort* weights)
            => ImplWeight(size, weights);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glWeightusvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<ushort> weights)
            => ImplWeight(size, weights);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glWeightuivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] uint* weights)
            => ImplWeight(size, weights);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glWeightuivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<uint> weights)
            => ImplWeight(size, weights);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type and stride.
        /// </param>
        [NativeApi(EntryPoint = "glWeightPointerARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void WeightPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer)
            => ImplWeightPointer(size, type, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type and stride.
        /// </param>
        [NativeApi(EntryPoint = "glWeightPointerARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WeightPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplWeightPointer<T0>(size, type, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glWeightubvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Weight([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] string weights)
            => ImplWeight(size, weights);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type and stride.
        /// </param>
        [NativeApi(EntryPoint = "glWeightPointerARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void WeightPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] WeightPointerTypeARB type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer)
            => ImplWeightPointer(size, type, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type and stride.
        /// </param>
        [NativeApi(EntryPoint = "glWeightPointerARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WeightPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] WeightPointerTypeARB type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplWeightPointer<T0>(size, type, stride, pointer);

        public ArbVertexBlend(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

