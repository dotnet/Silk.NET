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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_fragment_shading_rate")]
    public unsafe partial class ExtFragmentShadingRate : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_fragment_shading_rate";
        [NativeApi(EntryPoint = "glFramebufferShadingRateEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferShadingRate([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int baseLayer, [Flow(FlowDirection.In)] uint numLayers, [Flow(FlowDirection.In)] uint texelWidth, [Flow(FlowDirection.In)] uint texelHeight);

        [NativeApi(EntryPoint = "glFramebufferShadingRateEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferShadingRate([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int baseLayer, [Flow(FlowDirection.In)] uint numLayers, [Flow(FlowDirection.In)] uint texelWidth, [Flow(FlowDirection.In)] uint texelHeight);

        [NativeApi(EntryPoint = "glFramebufferShadingRateEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferShadingRate([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int baseLayer, [Flow(FlowDirection.In)] uint numLayers, [Flow(FlowDirection.In)] uint texelWidth, [Flow(FlowDirection.In)] uint texelHeight);

        [NativeApi(EntryPoint = "glFramebufferShadingRateEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferShadingRate([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int baseLayer, [Flow(FlowDirection.In)] uint numLayers, [Flow(FlowDirection.In)] uint texelWidth, [Flow(FlowDirection.In)] uint texelHeight);

        [NativeApi(EntryPoint = "glGetFragmentShadingRatesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFragmentShadingRates([Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] EXT* shadingRates);

        [NativeApi(EntryPoint = "glGetFragmentShadingRatesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFragmentShadingRates([Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] out EXT shadingRates);

        [NativeApi(EntryPoint = "glGetFragmentShadingRatesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFragmentShadingRates([Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] out uint count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] EXT* shadingRates);

        [NativeApi(EntryPoint = "glGetFragmentShadingRatesEXT", Convention = CallingConvention.Winapi)]
        public partial void GetFragmentShadingRates([Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] out uint count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] out EXT shadingRates);

        [NativeApi(EntryPoint = "glGetFragmentShadingRatesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFragmentShadingRates([Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] ShadingRate* shadingRates);

        [NativeApi(EntryPoint = "glGetFragmentShadingRatesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFragmentShadingRates([Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] out ShadingRate shadingRates);

        [NativeApi(EntryPoint = "glGetFragmentShadingRatesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFragmentShadingRates([Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] out uint count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] ShadingRate* shadingRates);

        [NativeApi(EntryPoint = "glGetFragmentShadingRatesEXT", Convention = CallingConvention.Winapi)]
        public partial void GetFragmentShadingRates([Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] out uint count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] out ShadingRate shadingRates);

        [NativeApi(EntryPoint = "glShadingRateEXT", Convention = CallingConvention.Winapi)]
        public partial void ShadingRate([Flow(FlowDirection.In)] EXT rate);

        [NativeApi(EntryPoint = "glShadingRateEXT", Convention = CallingConvention.Winapi)]
        public partial void ShadingRate([Flow(FlowDirection.In)] ShadingRate rate);

        [NativeApi(EntryPoint = "glShadingRateCombinerOpsEXT", Convention = CallingConvention.Winapi)]
        public partial void ShadingRateCombinerOp([Flow(FlowDirection.In)] EXT combinerOp0, [Flow(FlowDirection.In)] EXT combinerOp1);

        [NativeApi(EntryPoint = "glShadingRateCombinerOpsEXT", Convention = CallingConvention.Winapi)]
        public partial void ShadingRateCombinerOp([Flow(FlowDirection.In)] EXT combinerOp0, [Flow(FlowDirection.In)] ShadingRateCombinerOp combinerOp1);

        [NativeApi(EntryPoint = "glShadingRateCombinerOpsEXT", Convention = CallingConvention.Winapi)]
        public partial void ShadingRateCombinerOp([Flow(FlowDirection.In)] ShadingRateCombinerOp combinerOp0, [Flow(FlowDirection.In)] EXT combinerOp1);

        [NativeApi(EntryPoint = "glShadingRateCombinerOpsEXT", Convention = CallingConvention.Winapi)]
        public partial void ShadingRateCombinerOp([Flow(FlowDirection.In)] ShadingRateCombinerOp combinerOp0, [Flow(FlowDirection.In)] ShadingRateCombinerOp combinerOp1);

        public unsafe void GetFragmentShadingRates([Flow(FlowDirection.In)] uint samples, [Count(Count = 1), Flow(FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] Span<EXT> shadingRates)
        {
            // ImplicitCountSpanOverloader
            GetFragmentShadingRates(samples, (uint) shadingRates.Length, count, out shadingRates.GetPinnableReference());
        }

        public unsafe void GetFragmentShadingRates([Flow(FlowDirection.In)] uint samples, [Count(Count = 1), Flow(FlowDirection.Out)] out uint count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] Span<EXT> shadingRates)
        {
            // ImplicitCountSpanOverloader
            GetFragmentShadingRates(samples, (uint) shadingRates.Length, out count, out shadingRates.GetPinnableReference());
        }

        public unsafe void GetFragmentShadingRates([Flow(FlowDirection.In)] uint samples, [Count(Count = 1), Flow(FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] Span<ShadingRate> shadingRates)
        {
            // ImplicitCountSpanOverloader
            GetFragmentShadingRates(samples, (uint) shadingRates.Length, count, out shadingRates.GetPinnableReference());
        }

        public unsafe void GetFragmentShadingRates([Flow(FlowDirection.In)] uint samples, [Count(Count = 1), Flow(FlowDirection.Out)] out uint count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] Span<ShadingRate> shadingRates)
        {
            // ImplicitCountSpanOverloader
            GetFragmentShadingRates(samples, (uint) shadingRates.Length, out count, out shadingRates.GetPinnableReference());
        }

        public unsafe EXT GetFragmentShadingRates([Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] uint* count)
        {
            // NonKhrReturnTypeOverloader
            GetFragmentShadingRates(samples, maxCount, count, out EXT silkRet);
            return silkRet;
        }

        public unsafe EXT GetFragmentShadingRates([Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] out uint count)
        {
            // NonKhrReturnTypeOverloader
            GetFragmentShadingRates(samples, maxCount, out count, out EXT silkRet);
            return silkRet;
        }

        public ExtFragmentShadingRate(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

