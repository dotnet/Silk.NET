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

namespace Silk.NET.OpenXR.Extensions.MSFT
{
    public static class MsftControllerModelOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result GetControllerModelKeyMsft(this MsftControllerModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] ulong topLevelUserPath, [Count(Count = 0)] Span<ControllerModelKeyStateMSFT> controllerModelKeyState)
        {
            // SpanOverloader
            return thisApi.GetControllerModelKeyMsft(session, topLevelUserPath, ref controllerModelKeyState.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetControllerModelPropertiesMsft(this MsftControllerModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] Span<ControllerModelPropertiesMSFT> properties)
        {
            // SpanOverloader
            return thisApi.GetControllerModelPropertiesMsft(session, modelKey, ref properties.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetControllerModelStateMsft(this MsftControllerModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] Span<ControllerModelStateMSFT> state)
        {
            // SpanOverloader
            return thisApi.GetControllerModelStateMsft(session, modelKey, ref state.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result LoadControllerModelMsft(this MsftControllerModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Computed = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.LoadControllerModelMsft(session, modelKey, bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result LoadControllerModelMsft(this MsftControllerModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Computed = "bufferCapacityInput")] byte* buffer)
        {
            // SpanOverloader
            return thisApi.LoadControllerModelMsft(session, modelKey, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result LoadControllerModelMsft(this MsftControllerModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Computed = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.LoadControllerModelMsft(session, modelKey, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result LoadControllerModelMsft(this MsftControllerModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] ulong modelKey, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, string buffer)
        {
            // SpanOverloader
            return thisApi.LoadControllerModelMsft(session, modelKey, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

    }
}

