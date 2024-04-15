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
    [Extension("ARB_vertex_blend")]
    public unsafe partial class ArbVertexBlend : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_vertex_blend";
        [NativeApi(EntryPoint = "glVertexBlendARB", Convention = CallingConvention.Winapi)]
        public partial void VertexBlend([Flow(Silk.NET.Core.Native.FlowDirection.In)] int count);

        [NativeApi(EntryPoint = "glWeightbvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Weight([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte* weights);

        [NativeApi(EntryPoint = "glWeightbvARB", Convention = CallingConvention.Winapi)]
        public partial void Weight([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in sbyte weights);

        [NativeApi(EntryPoint = "glWeightsvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Weight([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] short* weights);

        [NativeApi(EntryPoint = "glWeightsvARB", Convention = CallingConvention.Winapi)]
        public partial void Weight([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in short weights);

        [NativeApi(EntryPoint = "glWeightivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Weight([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* weights);

        [NativeApi(EntryPoint = "glWeightivARB", Convention = CallingConvention.Winapi)]
        public partial void Weight([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int weights);

        [NativeApi(EntryPoint = "glWeightfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Weight([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* weights);

        [NativeApi(EntryPoint = "glWeightfvARB", Convention = CallingConvention.Winapi)]
        public partial void Weight([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float weights);

        [NativeApi(EntryPoint = "glWeightdvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Weight([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* weights);

        [NativeApi(EntryPoint = "glWeightdvARB", Convention = CallingConvention.Winapi)]
        public partial void Weight([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double weights);

        [NativeApi(EntryPoint = "glWeightubvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Weight([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* weights);

        [NativeApi(EntryPoint = "glWeightubvARB", Convention = CallingConvention.Winapi)]
        public partial void Weight([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte weights);

        [NativeApi(EntryPoint = "glWeightubvARB", Convention = CallingConvention.Winapi)]
        public partial void Weight([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string weights);

        [NativeApi(EntryPoint = "glWeightusvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Weight([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* weights);

        [NativeApi(EntryPoint = "glWeightusvARB", Convention = CallingConvention.Winapi)]
        public partial void Weight([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort weights);

        [NativeApi(EntryPoint = "glWeightuivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Weight([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* weights);

        [NativeApi(EntryPoint = "glWeightuivARB", Convention = CallingConvention.Winapi)]
        public partial void Weight([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint weights);

        [NativeApi(EntryPoint = "glWeightPointerARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void WeightPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glWeightPointerARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void WeightPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WeightPointerTypeARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        public unsafe void Weight([Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<sbyte> weights)
        {
            // ImplicitCountSpanOverloader
            Weight((int) weights.Length, in weights.GetPinnableReference());
        }

        public unsafe void Weight([Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> weights)
        {
            // ImplicitCountSpanOverloader
            Weight((int) weights.Length, in weights.GetPinnableReference());
        }

        public unsafe void Weight([Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> weights)
        {
            // ImplicitCountSpanOverloader
            Weight((int) weights.Length, in weights.GetPinnableReference());
        }

        public unsafe void Weight([Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> weights)
        {
            // ImplicitCountSpanOverloader
            Weight((int) weights.Length, in weights.GetPinnableReference());
        }

        public unsafe void Weight([Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> weights)
        {
            // ImplicitCountSpanOverloader
            Weight((int) weights.Length, in weights.GetPinnableReference());
        }

        public unsafe void Weight([Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> weights)
        {
            // ImplicitCountSpanOverloader
            Weight((int) weights.Length, in weights.GetPinnableReference());
        }

        public unsafe void Weight([Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> weights)
        {
            // ImplicitCountSpanOverloader
            Weight((int) weights.Length, in weights.GetPinnableReference());
        }

        public unsafe void Weight([Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> weights)
        {
            // ImplicitCountSpanOverloader
            Weight((int) weights.Length, in weights.GetPinnableReference());
        }

        public ArbVertexBlend(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

