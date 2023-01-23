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
    [Extension("XR_MSFT_controller_model")]
    public unsafe partial class MsftControllerModel : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_MSFT_controller_model";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetControllerModelKeyMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetControllerModelKeyMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ulong topLevelUserPath, [Count(Count = 0)] ControllerModelKeyStateMSFT* controllerModelKeyState);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetControllerModelKeyMSFT", Convention = CallingConvention.Winapi)]
        public partial Result GetControllerModelKeyMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ulong topLevelUserPath, [Count(Count = 0)] ref ControllerModelKeyStateMSFT controllerModelKeyState);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetControllerModelPropertiesMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetControllerModelPropertiesMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] ControllerModelPropertiesMSFT* properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetControllerModelPropertiesMSFT", Convention = CallingConvention.Winapi)]
        public partial Result GetControllerModelPropertiesMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] ref ControllerModelPropertiesMSFT properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetControllerModelStateMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetControllerModelStateMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] ControllerModelStateMSFT* state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetControllerModelStateMSFT", Convention = CallingConvention.Winapi)]
        public partial Result GetControllerModelStateMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] ref ControllerModelStateMSFT state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLoadControllerModelMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LoadControllerModelMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLoadControllerModelMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LoadControllerModelMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLoadControllerModelMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LoadControllerModelMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLoadControllerModelMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LoadControllerModelMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLoadControllerModelMSFT", Convention = CallingConvention.Winapi)]
        public partial Result LoadControllerModelMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLoadControllerModelMSFT", Convention = CallingConvention.Winapi)]
        public partial Result LoadControllerModelMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        public unsafe Result LoadControllerModelMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return LoadControllerModelMsft(session, modelKey, (uint) buffer.Length, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result LoadControllerModelMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return LoadControllerModelMsft(session, modelKey, (uint) buffer.Length, ref bufferCountOutput, ref buffer.GetPinnableReference());
        }

        public MsftControllerModel(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

