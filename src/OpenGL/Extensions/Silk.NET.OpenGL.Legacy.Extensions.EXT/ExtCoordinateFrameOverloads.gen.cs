// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    public static class ExtCoordinateFrameOverloads
    {
        public static unsafe void Binormal3(this ExtCoordinateFrame thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<sbyte> v)
        {
            // SpanOverloader
            thisApi.Binormal3(in v.GetPinnableReference());
        }

        public static unsafe void Binormal3(this ExtCoordinateFrame thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.Binormal3(in v.GetPinnableReference());
        }

        public static unsafe void Binormal3(this ExtCoordinateFrame thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.Binormal3(in v.GetPinnableReference());
        }

        public static unsafe void Binormal3(this ExtCoordinateFrame thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.Binormal3(in v.GetPinnableReference());
        }

        public static unsafe void Binormal3(this ExtCoordinateFrame thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.Binormal3(in v.GetPinnableReference());
        }

        public static unsafe void BinormalPointer<T0>(this ExtCoordinateFrame thisApi, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.BinormalPointer(type, stride, in pointer.GetPinnableReference());
        }

        public static unsafe void BinormalPointer<T0>(this ExtCoordinateFrame thisApi, [Flow(FlowDirection.In)] BinormalPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.BinormalPointer(type, stride, in pointer.GetPinnableReference());
        }

        public static unsafe void Tangent3(this ExtCoordinateFrame thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<sbyte> v)
        {
            // SpanOverloader
            thisApi.Tangent3(in v.GetPinnableReference());
        }

        public static unsafe void Tangent3(this ExtCoordinateFrame thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.Tangent3(in v.GetPinnableReference());
        }

        public static unsafe void Tangent3(this ExtCoordinateFrame thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.Tangent3(in v.GetPinnableReference());
        }

        public static unsafe void Tangent3(this ExtCoordinateFrame thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.Tangent3(in v.GetPinnableReference());
        }

        public static unsafe void Tangent3(this ExtCoordinateFrame thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.Tangent3(in v.GetPinnableReference());
        }

        public static unsafe void TangentPointer<T0>(this ExtCoordinateFrame thisApi, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TangentPointer(type, stride, in pointer.GetPinnableReference());
        }

        public static unsafe void TangentPointer<T0>(this ExtCoordinateFrame thisApi, [Flow(FlowDirection.In)] TangentPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TangentPointer(type, stride, in pointer.GetPinnableReference());
        }

    }
}

