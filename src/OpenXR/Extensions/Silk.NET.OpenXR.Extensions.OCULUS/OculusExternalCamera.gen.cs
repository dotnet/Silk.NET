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

namespace Silk.NET.OpenXR.Extensions.OCULUS
{
    [Extension("XR_OCULUS_external_camera")]
    public unsafe partial class OculusExternalCamera : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_OCULUS_external_camera";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateExternalCamerasOCULUS", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateExternalCamerasOculus([Count(Count = 0)] Session session, [Count(Count = 0)] uint cameraCapacityInput, [Count(Count = 0)] uint* cameraCountOutput, [Count(Parameter = "cameraCapacityInput")] ExternalCameraOCULUS* cameras);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateExternalCamerasOCULUS", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateExternalCamerasOculus([Count(Count = 0)] Session session, [Count(Count = 0)] uint cameraCapacityInput, [Count(Count = 0)] uint* cameraCountOutput, [Count(Parameter = "cameraCapacityInput")] ref ExternalCameraOCULUS cameras);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateExternalCamerasOCULUS", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateExternalCamerasOculus([Count(Count = 0)] Session session, [Count(Count = 0)] uint cameraCapacityInput, [Count(Count = 0)] ref uint cameraCountOutput, [Count(Parameter = "cameraCapacityInput")] ExternalCameraOCULUS* cameras);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateExternalCamerasOCULUS", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateExternalCamerasOculus([Count(Count = 0)] Session session, [Count(Count = 0)] uint cameraCapacityInput, [Count(Count = 0)] ref uint cameraCountOutput, [Count(Parameter = "cameraCapacityInput")] ref ExternalCameraOCULUS cameras);

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateExternalCamerasOculus([Count(Count = 0)] Session session, [Count(Count = 0)] uint* cameraCountOutput, [Count(Parameter = "cameraCapacityInput")] Span<ExternalCameraOCULUS> cameras)
        {
            // ImplicitCountSpanOverloader
            return EnumerateExternalCamerasOculus(session, (uint) cameras.Length, cameraCountOutput, ref cameras.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateExternalCamerasOculus([Count(Count = 0)] Session session, [Count(Count = 0)] ref uint cameraCountOutput, [Count(Parameter = "cameraCapacityInput")] Span<ExternalCameraOCULUS> cameras)
        {
            // ImplicitCountSpanOverloader
            return EnumerateExternalCamerasOculus(session, (uint) cameras.Length, ref cameraCountOutput, ref cameras.GetPinnableReference());
        }

        public OculusExternalCamera(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

