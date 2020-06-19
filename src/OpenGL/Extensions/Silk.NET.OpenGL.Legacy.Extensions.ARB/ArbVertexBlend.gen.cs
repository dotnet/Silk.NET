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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_vertex_blend")]
    public abstract unsafe partial class ArbVertexBlend : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_vertex_blend";
        [NativeApi(EntryPoint = "glVertexBlendARB")]
        public abstract void VertexBlend([Flow(FlowDirection.In)] int count);

        [NativeApi(EntryPoint = "glWeightbvARB")]
        public abstract unsafe void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] sbyte* weights);

        [NativeApi(EntryPoint = "glWeightbvARB")]
        public abstract void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<sbyte> weights);

        [NativeApi(EntryPoint = "glWeightsvARB")]
        public abstract unsafe void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] short* weights);

        [NativeApi(EntryPoint = "glWeightsvARB")]
        public abstract void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<short> weights);

        [NativeApi(EntryPoint = "glWeightivARB")]
        public abstract unsafe void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] int* weights);

        [NativeApi(EntryPoint = "glWeightivARB")]
        public abstract void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<int> weights);

        [NativeApi(EntryPoint = "glWeightfvARB")]
        public abstract unsafe void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] float* weights);

        [NativeApi(EntryPoint = "glWeightfvARB")]
        public abstract void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<float> weights);

        [NativeApi(EntryPoint = "glWeightdvARB")]
        public abstract unsafe void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] double* weights);

        [NativeApi(EntryPoint = "glWeightdvARB")]
        public abstract void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<double> weights);

        [NativeApi(EntryPoint = "glWeightubvARB")]
        public abstract unsafe void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] byte* weights);

        [NativeApi(EntryPoint = "glWeightubvARB")]
        public abstract void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<byte> weights);

        [NativeApi(EntryPoint = "glWeightusvARB")]
        public abstract unsafe void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ushort* weights);

        [NativeApi(EntryPoint = "glWeightusvARB")]
        public abstract void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<ushort> weights);

        [NativeApi(EntryPoint = "glWeightuivARB")]
        public abstract unsafe void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] uint* weights);

        [NativeApi(EntryPoint = "glWeightuivARB")]
        public abstract void Weight([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<uint> weights);

        [NativeApi(EntryPoint = "glWeightPointerARB")]
        public abstract unsafe void WeightPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glWeightPointerARB")]
        public abstract void WeightPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glWeightubvARB")]
        public abstract void Weight([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] string weights);

        [NativeApi(EntryPoint = "glWeightPointerARB")]
        public abstract unsafe void WeightPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] WeightPointerTypeARB type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glWeightPointerARB")]
        public abstract void WeightPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] WeightPointerTypeARB type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        public ArbVertexBlend(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

