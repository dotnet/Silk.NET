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

namespace Silk.NET.OpenXR.Extensions.MSFT
{
    public static class MsftCompositionLayerReprojectionOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateReprojectionModesMsft(this MsftCompositionLayerReprojection thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint modeCapacityInput, [Count(Count = 0)] uint* modeCountOutput, [Count(Parameter = "modeCapacityInput")] Span<ReprojectionModeMSFT> modes)
        {
            // SpanOverloader
            return thisApi.EnumerateReprojectionModesMsft(instance, systemId, viewConfigurationType, modeCapacityInput, modeCountOutput, ref modes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateReprojectionModesMsft(this MsftCompositionLayerReprojection thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint modeCapacityInput, [Count(Count = 0)] Span<uint> modeCountOutput, [Count(Parameter = "modeCapacityInput")] ReprojectionModeMSFT* modes)
        {
            // SpanOverloader
            return thisApi.EnumerateReprojectionModesMsft(instance, systemId, viewConfigurationType, modeCapacityInput, ref modeCountOutput.GetPinnableReference(), modes);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateReprojectionModesMsft(this MsftCompositionLayerReprojection thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint modeCapacityInput, [Count(Count = 0)] Span<uint> modeCountOutput, [Count(Parameter = "modeCapacityInput")] Span<ReprojectionModeMSFT> modes)
        {
            // SpanOverloader
            return thisApi.EnumerateReprojectionModesMsft(instance, systemId, viewConfigurationType, modeCapacityInput, ref modeCountOutput.GetPinnableReference(), ref modes.GetPinnableReference());
        }

    }
}

