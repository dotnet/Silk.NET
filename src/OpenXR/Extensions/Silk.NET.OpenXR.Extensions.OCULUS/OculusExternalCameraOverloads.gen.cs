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

namespace Silk.NET.OpenXR.Extensions.OCULUS
{
    public static class OculusExternalCameraOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateExternalCamerasOculus(this OculusExternalCamera thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] uint cameraCapacityInput, [Count(Count = 0)] uint* cameraCountOutput, [Count(Parameter = "cameraCapacityInput")] Span<ExternalCameraOCULUS> cameras)
        {
            // SpanOverloader
            return thisApi.EnumerateExternalCamerasOculus(session, cameraCapacityInput, cameraCountOutput, ref cameras.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateExternalCamerasOculus(this OculusExternalCamera thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] uint cameraCapacityInput, [Count(Count = 0)] Span<uint> cameraCountOutput, [Count(Parameter = "cameraCapacityInput")] ExternalCameraOCULUS* cameras)
        {
            // SpanOverloader
            return thisApi.EnumerateExternalCamerasOculus(session, cameraCapacityInput, ref cameraCountOutput.GetPinnableReference(), cameras);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateExternalCamerasOculus(this OculusExternalCamera thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] uint cameraCapacityInput, [Count(Count = 0)] Span<uint> cameraCountOutput, [Count(Parameter = "cameraCapacityInput")] Span<ExternalCameraOCULUS> cameras)
        {
            // SpanOverloader
            return thisApi.EnumerateExternalCamerasOculus(session, cameraCapacityInput, ref cameraCountOutput.GetPinnableReference(), ref cameras.GetPinnableReference());
        }

    }
}

