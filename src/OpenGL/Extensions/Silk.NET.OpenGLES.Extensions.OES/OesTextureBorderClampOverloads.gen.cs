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

namespace Silk.NET.OpenGLES.Extensions.OES
{
    public static class OesTextureBorderClampOverloads
    {
        public static unsafe void GetSamplerParameterI(this OesTextureBorderClamp thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetSamplerParameterI(sampler, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetSamplerParameterI(this OesTextureBorderClamp thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetSamplerParameterI(sampler, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetSamplerParameterI(this OesTextureBorderClamp thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetSamplerParameterI(sampler, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetSamplerParameterI(this OesTextureBorderClamp thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetSamplerParameterI(sampler, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameterI(this OesTextureBorderClamp thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameterI(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameterI(this OesTextureBorderClamp thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameterI(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameterI(this OesTextureBorderClamp thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameterI(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameterI(this OesTextureBorderClamp thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameterI(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameterI(this OesTextureBorderClamp thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameterI(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameterI(this OesTextureBorderClamp thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameterI(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameterI(this OesTextureBorderClamp thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameterI(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameterI(this OesTextureBorderClamp thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameterI(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void SamplerParameterI(this OesTextureBorderClamp thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> param)
        {
            // SpanOverloader
            thisApi.SamplerParameterI(sampler, pname, in param.GetPinnableReference());
        }

        public static unsafe void SamplerParameterI(this OesTextureBorderClamp thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> param)
        {
            // SpanOverloader
            thisApi.SamplerParameterI(sampler, pname, in param.GetPinnableReference());
        }

        public static unsafe void SamplerParameterI(this OesTextureBorderClamp thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> param)
        {
            // SpanOverloader
            thisApi.SamplerParameterI(sampler, pname, in param.GetPinnableReference());
        }

        public static unsafe void SamplerParameterI(this OesTextureBorderClamp thisApi, [Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> param)
        {
            // SpanOverloader
            thisApi.SamplerParameterI(sampler, pname, in param.GetPinnableReference());
        }

        public static unsafe void TexParameterI(this OesTextureBorderClamp thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TexParameterI(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexParameterI(this OesTextureBorderClamp thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TexParameterI(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexParameterI(this OesTextureBorderClamp thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TexParameterI(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexParameterI(this OesTextureBorderClamp thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TexParameterI(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexParameterI(this OesTextureBorderClamp thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.TexParameterI(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexParameterI(this OesTextureBorderClamp thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.TexParameterI(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexParameterI(this OesTextureBorderClamp thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.TexParameterI(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexParameterI(this OesTextureBorderClamp thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.TexParameterI(target, pname, in @params.GetPinnableReference());
        }

    }
}

