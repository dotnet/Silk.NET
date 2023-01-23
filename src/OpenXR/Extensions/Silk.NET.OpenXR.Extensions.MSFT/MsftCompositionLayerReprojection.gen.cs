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
using Silk.NET.OpenXR;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.MSFT
{
    [Extension("XR_MSFT_composition_layer_reprojection")]
    public unsafe partial class MsftCompositionLayerReprojection : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_MSFT_composition_layer_reprojection";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateReprojectionModesMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateReprojectionModesMsft([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint modeCapacityInput, [Count(Count = 0)] uint* modeCountOutput, [Count(Parameter = "modeCapacityInput")] ReprojectionModeMSFT* modes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateReprojectionModesMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateReprojectionModesMsft([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint modeCapacityInput, [Count(Count = 0)] uint* modeCountOutput, [Count(Parameter = "modeCapacityInput")] ref ReprojectionModeMSFT modes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateReprojectionModesMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateReprojectionModesMsft([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint modeCapacityInput, [Count(Count = 0)] ref uint modeCountOutput, [Count(Parameter = "modeCapacityInput")] ReprojectionModeMSFT* modes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateReprojectionModesMSFT", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateReprojectionModesMsft([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint modeCapacityInput, [Count(Count = 0)] ref uint modeCountOutput, [Count(Parameter = "modeCapacityInput")] ref ReprojectionModeMSFT modes);

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateReprojectionModesMsft([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint* modeCountOutput, [Count(Parameter = "modeCapacityInput")] Span<ReprojectionModeMSFT> modes)
        {
            // ImplicitCountSpanOverloader
            return EnumerateReprojectionModesMsft(instance, systemId, viewConfigurationType, (uint) modes.Length, modeCountOutput, ref modes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateReprojectionModesMsft([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] ref uint modeCountOutput, [Count(Parameter = "modeCapacityInput")] Span<ReprojectionModeMSFT> modes)
        {
            // ImplicitCountSpanOverloader
            return EnumerateReprojectionModesMsft(instance, systemId, viewConfigurationType, (uint) modes.Length, ref modeCountOutput, ref modes.GetPinnableReference());
        }

        public MsftCompositionLayerReprojection(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

