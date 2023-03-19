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

namespace Silk.NET.XInput
{
    public static class XInputOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 258, Column 14 in Xinput.h")]
        public static unsafe uint GetState(this XInput thisApi, uint dwUserIndex, Span<State> pState)
        {
            // SpanOverloader
            return thisApi.GetState(dwUserIndex, ref pState.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 264, Column 14 in Xinput.h")]
        public static unsafe uint SetState(this XInput thisApi, uint dwUserIndex, Span<Vibration> pVibration)
        {
            // SpanOverloader
            return thisApi.SetState(dwUserIndex, ref pVibration.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 270, Column 14 in Xinput.h")]
        public static unsafe uint GetCapabilities(this XInput thisApi, uint dwUserIndex, uint dwFlags, Span<Capabilities> pCapabilities)
        {
            // SpanOverloader
            return thisApi.GetCapabilities(dwUserIndex, dwFlags, ref pCapabilities.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, char* pRenderDeviceId, uint* pRenderCount, char* pCaptureDeviceId, Span<uint> pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, pRenderDeviceId, pRenderCount, pCaptureDeviceId, ref pCaptureCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, char* pRenderDeviceId, uint* pRenderCount, Span<char> pCaptureDeviceId, uint* pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, pRenderDeviceId, pRenderCount, ref pCaptureDeviceId.GetPinnableReference(), pCaptureCount);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, char* pRenderDeviceId, uint* pRenderCount, Span<char> pCaptureDeviceId, Span<uint> pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, pRenderDeviceId, pRenderCount, ref pCaptureDeviceId.GetPinnableReference(), ref pCaptureCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, char* pRenderDeviceId, uint* pRenderCount, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pCaptureDeviceId, Span<uint> pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, pRenderDeviceId, pRenderCount, pCaptureDeviceId, ref pCaptureCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, char* pRenderDeviceId, Span<uint> pRenderCount, char* pCaptureDeviceId, uint* pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, pRenderDeviceId, ref pRenderCount.GetPinnableReference(), pCaptureDeviceId, pCaptureCount);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, char* pRenderDeviceId, Span<uint> pRenderCount, char* pCaptureDeviceId, Span<uint> pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, pRenderDeviceId, ref pRenderCount.GetPinnableReference(), pCaptureDeviceId, ref pCaptureCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, char* pRenderDeviceId, Span<uint> pRenderCount, Span<char> pCaptureDeviceId, uint* pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, pRenderDeviceId, ref pRenderCount.GetPinnableReference(), ref pCaptureDeviceId.GetPinnableReference(), pCaptureCount);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, char* pRenderDeviceId, Span<uint> pRenderCount, Span<char> pCaptureDeviceId, Span<uint> pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, pRenderDeviceId, ref pRenderCount.GetPinnableReference(), ref pCaptureDeviceId.GetPinnableReference(), ref pCaptureCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, char* pRenderDeviceId, Span<uint> pRenderCount, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pCaptureDeviceId, uint* pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, pRenderDeviceId, ref pRenderCount.GetPinnableReference(), pCaptureDeviceId, pCaptureCount);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, char* pRenderDeviceId, Span<uint> pRenderCount, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pCaptureDeviceId, Span<uint> pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, pRenderDeviceId, ref pRenderCount.GetPinnableReference(), pCaptureDeviceId, ref pCaptureCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, Span<char> pRenderDeviceId, uint* pRenderCount, char* pCaptureDeviceId, uint* pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, ref pRenderDeviceId.GetPinnableReference(), pRenderCount, pCaptureDeviceId, pCaptureCount);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, Span<char> pRenderDeviceId, uint* pRenderCount, char* pCaptureDeviceId, Span<uint> pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, ref pRenderDeviceId.GetPinnableReference(), pRenderCount, pCaptureDeviceId, ref pCaptureCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, Span<char> pRenderDeviceId, uint* pRenderCount, Span<char> pCaptureDeviceId, uint* pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, ref pRenderDeviceId.GetPinnableReference(), pRenderCount, ref pCaptureDeviceId.GetPinnableReference(), pCaptureCount);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, Span<char> pRenderDeviceId, uint* pRenderCount, Span<char> pCaptureDeviceId, Span<uint> pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, ref pRenderDeviceId.GetPinnableReference(), pRenderCount, ref pCaptureDeviceId.GetPinnableReference(), ref pCaptureCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, Span<char> pRenderDeviceId, uint* pRenderCount, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pCaptureDeviceId, uint* pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, ref pRenderDeviceId.GetPinnableReference(), pRenderCount, pCaptureDeviceId, pCaptureCount);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, Span<char> pRenderDeviceId, uint* pRenderCount, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pCaptureDeviceId, Span<uint> pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, ref pRenderDeviceId.GetPinnableReference(), pRenderCount, pCaptureDeviceId, ref pCaptureCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, Span<char> pRenderDeviceId, Span<uint> pRenderCount, char* pCaptureDeviceId, uint* pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, ref pRenderDeviceId.GetPinnableReference(), ref pRenderCount.GetPinnableReference(), pCaptureDeviceId, pCaptureCount);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, Span<char> pRenderDeviceId, Span<uint> pRenderCount, char* pCaptureDeviceId, Span<uint> pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, ref pRenderDeviceId.GetPinnableReference(), ref pRenderCount.GetPinnableReference(), pCaptureDeviceId, ref pCaptureCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, Span<char> pRenderDeviceId, Span<uint> pRenderCount, Span<char> pCaptureDeviceId, uint* pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, ref pRenderDeviceId.GetPinnableReference(), ref pRenderCount.GetPinnableReference(), ref pCaptureDeviceId.GetPinnableReference(), pCaptureCount);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, Span<char> pRenderDeviceId, Span<uint> pRenderCount, Span<char> pCaptureDeviceId, Span<uint> pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, ref pRenderDeviceId.GetPinnableReference(), ref pRenderCount.GetPinnableReference(), ref pCaptureDeviceId.GetPinnableReference(), ref pCaptureCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, Span<char> pRenderDeviceId, Span<uint> pRenderCount, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pCaptureDeviceId, uint* pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, ref pRenderDeviceId.GetPinnableReference(), ref pRenderCount.GetPinnableReference(), pCaptureDeviceId, pCaptureCount);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, Span<char> pRenderDeviceId, Span<uint> pRenderCount, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pCaptureDeviceId, Span<uint> pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, ref pRenderDeviceId.GetPinnableReference(), ref pRenderCount.GetPinnableReference(), pCaptureDeviceId, ref pCaptureCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pRenderDeviceId, uint* pRenderCount, char* pCaptureDeviceId, Span<uint> pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, pRenderDeviceId, pRenderCount, pCaptureDeviceId, ref pCaptureCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pRenderDeviceId, uint* pRenderCount, Span<char> pCaptureDeviceId, uint* pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, pRenderDeviceId, pRenderCount, ref pCaptureDeviceId.GetPinnableReference(), pCaptureCount);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pRenderDeviceId, uint* pRenderCount, Span<char> pCaptureDeviceId, Span<uint> pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, pRenderDeviceId, pRenderCount, ref pCaptureDeviceId.GetPinnableReference(), ref pCaptureCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pRenderDeviceId, uint* pRenderCount, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pCaptureDeviceId, Span<uint> pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, pRenderDeviceId, pRenderCount, pCaptureDeviceId, ref pCaptureCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pRenderDeviceId, Span<uint> pRenderCount, char* pCaptureDeviceId, uint* pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, pRenderDeviceId, ref pRenderCount.GetPinnableReference(), pCaptureDeviceId, pCaptureCount);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pRenderDeviceId, Span<uint> pRenderCount, char* pCaptureDeviceId, Span<uint> pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, pRenderDeviceId, ref pRenderCount.GetPinnableReference(), pCaptureDeviceId, ref pCaptureCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pRenderDeviceId, Span<uint> pRenderCount, Span<char> pCaptureDeviceId, uint* pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, pRenderDeviceId, ref pRenderCount.GetPinnableReference(), ref pCaptureDeviceId.GetPinnableReference(), pCaptureCount);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pRenderDeviceId, Span<uint> pRenderCount, Span<char> pCaptureDeviceId, Span<uint> pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, pRenderDeviceId, ref pRenderCount.GetPinnableReference(), ref pCaptureDeviceId.GetPinnableReference(), ref pCaptureCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pRenderDeviceId, Span<uint> pRenderCount, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pCaptureDeviceId, uint* pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, pRenderDeviceId, ref pRenderCount.GetPinnableReference(), pCaptureDeviceId, pCaptureCount);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        public static unsafe uint GetAudioDeviceIds(this XInput thisApi, uint dwUserIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pRenderDeviceId, Span<uint> pRenderCount, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pCaptureDeviceId, Span<uint> pCaptureCount)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceIds(dwUserIndex, pRenderDeviceId, ref pRenderCount.GetPinnableReference(), pCaptureDeviceId, ref pCaptureCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 297, Column 14 in Xinput.h")]
        public static unsafe uint GetBatteryInformation(this XInput thisApi, uint dwUserIndex, byte devType, Span<BatteryInformation> pBatteryInformation)
        {
            // SpanOverloader
            return thisApi.GetBatteryInformation(dwUserIndex, devType, ref pBatteryInformation.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 304, Column 14 in Xinput.h")]
        public static unsafe uint GetKeystroke(this XInput thisApi, uint dwUserIndex, uint dwReserved, Span<Keystroke> pKeystroke)
        {
            // SpanOverloader
            return thisApi.GetKeystroke(dwUserIndex, dwReserved, ref pKeystroke.GetPinnableReference());
        }

    }
}

