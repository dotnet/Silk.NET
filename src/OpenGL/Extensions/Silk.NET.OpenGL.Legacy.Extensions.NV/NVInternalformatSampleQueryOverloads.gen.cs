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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    public static class NVInternalformatSampleQueryOverloads
    {
        public static unsafe void GetInternalformatSample(this NVInternalformatSampleQuery thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetInternalformatSample(target, internalformat, samples, pname, count, out @params.GetPinnableReference());
        }

        public static unsafe void GetInternalformatSample(this NVInternalformatSampleQuery thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetInternalformatSample(target, internalformat, samples, pname, count, out @params.GetPinnableReference());
        }

        public static unsafe void GetInternalformatSample(this NVInternalformatSampleQuery thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetInternalformatSample(target, internalformat, samples, pname, count, out @params.GetPinnableReference());
        }

        public static unsafe void GetInternalformatSample(this NVInternalformatSampleQuery thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetInternalformatSample(target, internalformat, samples, pname, count, out @params.GetPinnableReference());
        }

        public static unsafe void GetInternalformatSample(this NVInternalformatSampleQuery thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] NV internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetInternalformatSample(target, internalformat, samples, pname, count, out @params.GetPinnableReference());
        }

        public static unsafe void GetInternalformatSample(this NVInternalformatSampleQuery thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] NV internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetInternalformatSample(target, internalformat, samples, pname, count, out @params.GetPinnableReference());
        }

        public static unsafe void GetInternalformatSample(this NVInternalformatSampleQuery thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetInternalformatSample(target, internalformat, samples, pname, count, out @params.GetPinnableReference());
        }

        public static unsafe void GetInternalformatSample(this NVInternalformatSampleQuery thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetInternalformatSample(target, internalformat, samples, pname, count, out @params.GetPinnableReference());
        }

    }
}

