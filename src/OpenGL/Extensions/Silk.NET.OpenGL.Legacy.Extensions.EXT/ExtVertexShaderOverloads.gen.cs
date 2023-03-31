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

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    public static class ExtVertexShaderOverloads
    {
        public static unsafe void GetInvariantBoolean(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<bool> data)
        {
            // SpanOverloader
            thisApi.GetInvariantBoolean(id, value, out data.GetPinnableReference());
        }

        public static unsafe void GetInvariantBoolean(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<bool> data)
        {
            // SpanOverloader
            thisApi.GetInvariantBoolean(id, value, out data.GetPinnableReference());
        }

        public static unsafe void GetInvariantFloat(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> data)
        {
            // SpanOverloader
            thisApi.GetInvariantFloat(id, value, out data.GetPinnableReference());
        }

        public static unsafe void GetInvariantFloat(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> data)
        {
            // SpanOverloader
            thisApi.GetInvariantFloat(id, value, out data.GetPinnableReference());
        }

        public static unsafe void GetInvariantInteger(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> data)
        {
            // SpanOverloader
            thisApi.GetInvariantInteger(id, value, out data.GetPinnableReference());
        }

        public static unsafe void GetInvariantInteger(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> data)
        {
            // SpanOverloader
            thisApi.GetInvariantInteger(id, value, out data.GetPinnableReference());
        }

        public static unsafe void GetLocalConstantBoolean(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<bool> data)
        {
            // SpanOverloader
            thisApi.GetLocalConstantBoolean(id, value, out data.GetPinnableReference());
        }

        public static unsafe void GetLocalConstantBoolean(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<bool> data)
        {
            // SpanOverloader
            thisApi.GetLocalConstantBoolean(id, value, out data.GetPinnableReference());
        }

        public static unsafe void GetLocalConstantFloat(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> data)
        {
            // SpanOverloader
            thisApi.GetLocalConstantFloat(id, value, out data.GetPinnableReference());
        }

        public static unsafe void GetLocalConstantFloat(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> data)
        {
            // SpanOverloader
            thisApi.GetLocalConstantFloat(id, value, out data.GetPinnableReference());
        }

        public static unsafe void GetLocalConstantInteger(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> data)
        {
            // SpanOverloader
            thisApi.GetLocalConstantInteger(id, value, out data.GetPinnableReference());
        }

        public static unsafe void GetLocalConstantInteger(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> data)
        {
            // SpanOverloader
            thisApi.GetLocalConstantInteger(id, value, out data.GetPinnableReference());
        }

        public static unsafe void GetVariantBoolean(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<bool> data)
        {
            // SpanOverloader
            thisApi.GetVariantBoolean(id, value, out data.GetPinnableReference());
        }

        public static unsafe void GetVariantBoolean(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<bool> data)
        {
            // SpanOverloader
            thisApi.GetVariantBoolean(id, value, out data.GetPinnableReference());
        }

        public static unsafe void GetVariantFloat(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> data)
        {
            // SpanOverloader
            thisApi.GetVariantFloat(id, value, out data.GetPinnableReference());
        }

        public static unsafe void GetVariantFloat(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> data)
        {
            // SpanOverloader
            thisApi.GetVariantFloat(id, value, out data.GetPinnableReference());
        }

        public static unsafe void GetVariantInteger(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> data)
        {
            // SpanOverloader
            thisApi.GetVariantInteger(id, value, out data.GetPinnableReference());
        }

        public static unsafe void GetVariantInteger(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetVariantValueEXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> data)
        {
            // SpanOverloader
            thisApi.GetVariantInteger(id, value, out data.GetPinnableReference());
        }

        public static unsafe void SetInvariant<T0>(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "id, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> addr) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SetInvariant(id, type, in addr.GetPinnableReference());
        }

        public static unsafe void SetInvariant<T0>(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScalarType type, [Count(Computed = "id, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> addr) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SetInvariant(id, type, in addr.GetPinnableReference());
        }

        public static unsafe void SetLocalConstant<T0>(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "id, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> addr) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SetLocalConstant(id, type, in addr.GetPinnableReference());
        }

        public static unsafe void SetLocalConstant<T0>(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScalarType type, [Count(Computed = "id, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> addr) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SetLocalConstant(id, type, in addr.GetPinnableReference());
        }

        public static unsafe void Variant(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<sbyte> addr)
        {
            // SpanOverloader
            thisApi.Variant(id, in addr.GetPinnableReference());
        }

        public static unsafe void Variant(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> addr)
        {
            // SpanOverloader
            thisApi.Variant(id, in addr.GetPinnableReference());
        }

        public static unsafe void Variant(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> addr)
        {
            // SpanOverloader
            thisApi.Variant(id, in addr.GetPinnableReference());
        }

        public static unsafe void Variant(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> addr)
        {
            // SpanOverloader
            thisApi.Variant(id, in addr.GetPinnableReference());
        }

        public static unsafe void Variant(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> addr)
        {
            // SpanOverloader
            thisApi.Variant(id, in addr.GetPinnableReference());
        }

        public static unsafe void Variant(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> addr)
        {
            // SpanOverloader
            thisApi.Variant(id, in addr.GetPinnableReference());
        }

        public static unsafe void Variant(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> addr)
        {
            // SpanOverloader
            thisApi.Variant(id, in addr.GetPinnableReference());
        }

        public static unsafe void Variant(this ExtVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> addr)
        {
            // SpanOverloader
            thisApi.Variant(id, in addr.GetPinnableReference());
        }

    }
}

