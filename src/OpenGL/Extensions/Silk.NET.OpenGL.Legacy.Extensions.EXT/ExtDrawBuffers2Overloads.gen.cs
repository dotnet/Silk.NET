// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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
    public static class ExtDrawBuffers2Overloads
    {
        public static unsafe void GetBooleanIndexed(this ExtDrawBuffers2 thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<bool> data)
        {
            // SpanOverloader
            thisApi.GetBooleanIndexed(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetBooleanIndexed(this ExtDrawBuffers2 thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<Boolean> data)
        {
            // SpanOverloader
            thisApi.GetBooleanIndexed(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetBooleanIndexed(this ExtDrawBuffers2 thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<bool> data)
        {
            // SpanOverloader
            thisApi.GetBooleanIndexed(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetBooleanIndexed(this ExtDrawBuffers2 thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<Boolean> data)
        {
            // SpanOverloader
            thisApi.GetBooleanIndexed(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetIntegerIndexed(this ExtDrawBuffers2 thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<int> data)
        {
            // SpanOverloader
            thisApi.GetIntegerIndexed(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetIntegerIndexed(this ExtDrawBuffers2 thisApi, [Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<int> data)
        {
            // SpanOverloader
            thisApi.GetIntegerIndexed(target, index, out data.GetPinnableReference());
        }

    }
}

