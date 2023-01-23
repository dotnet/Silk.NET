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
    public static class MsftControllerModelOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetControllerModelKeyMsft(this MsftControllerModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] ulong topLevelUserPath, [Count(Count = 0)] Span<ControllerModelKeyStateMSFT> controllerModelKeyState)
        {
            // SpanOverloader
            return thisApi.GetControllerModelKeyMsft(session, topLevelUserPath, ref controllerModelKeyState.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetControllerModelPropertiesMsft(this MsftControllerModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] Span<ControllerModelPropertiesMSFT> properties)
        {
            // SpanOverloader
            return thisApi.GetControllerModelPropertiesMsft(session, modelKey, ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetControllerModelStateMsft(this MsftControllerModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] Span<ControllerModelStateMSFT> state)
        {
            // SpanOverloader
            return thisApi.GetControllerModelStateMsft(session, modelKey, ref state.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LoadControllerModelMsft(this MsftControllerModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.LoadControllerModelMsft(session, modelKey, bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LoadControllerModelMsft(this MsftControllerModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer)
        {
            // SpanOverloader
            return thisApi.LoadControllerModelMsft(session, modelKey, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LoadControllerModelMsft(this MsftControllerModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.LoadControllerModelMsft(session, modelKey, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LoadControllerModelMsft(this MsftControllerModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer)
        {
            // SpanOverloader
            return thisApi.LoadControllerModelMsft(session, modelKey, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

    }
}

