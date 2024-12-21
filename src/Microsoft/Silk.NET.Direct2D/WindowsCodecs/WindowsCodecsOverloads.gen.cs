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

namespace Silk.NET.WindowsCodecs
{
    public static class WindowsCodecsOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5244, Column 43 in wincodec.h")]
        public static unsafe int IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationProxy(this WindowsCodecs thisApi, IWICBitmapCodecProgressNotification* This, Span<IWICProgressCallback> pICallback, uint dwProgressFlags)
        {
            // SpanOverloader
            return thisApi.IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationProxy(This, ref pICallback.GetPinnableReference(), dwProgressFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5244, Column 43 in wincodec.h")]
        public static unsafe int IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationProxy(this WindowsCodecs thisApi, Span<IWICBitmapCodecProgressNotification> This, IWICProgressCallback* pICallback, uint dwProgressFlags)
        {
            // SpanOverloader
            return thisApi.IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationProxy(ref This.GetPinnableReference(), pICallback, dwProgressFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5244, Column 43 in wincodec.h")]
        public static unsafe int IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationProxy(this WindowsCodecs thisApi, Span<IWICBitmapCodecProgressNotification> This, Span<IWICProgressCallback> pICallback, uint dwProgressFlags)
        {
            // SpanOverloader
            return thisApi.IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationProxy(ref This.GetPinnableReference(), ref pICallback.GetPinnableReference(), dwProgressFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(This, _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5250, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapCodecProgressNotificationRemoteRegisterProgressNotificationStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6480, Column 43 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoRemoteGetPatternsProxy(this WindowsCodecs thisApi, IWICBitmapDecoderInfo* This, BitmapPattern** ppPatterns, Span<uint> pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoRemoteGetPatternsProxy(This, ppPatterns, ref pcPatterns.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6480, Column 43 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoRemoteGetPatternsProxy(this WindowsCodecs thisApi, IWICBitmapDecoderInfo* This, ref BitmapPattern* ppPatterns, Span<uint> pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoRemoteGetPatternsProxy(This, ref ppPatterns, ref pcPatterns.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6480, Column 43 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoRemoteGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICBitmapDecoderInfo> This, BitmapPattern** ppPatterns, uint* pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoRemoteGetPatternsProxy(ref This.GetPinnableReference(), ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6480, Column 43 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoRemoteGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICBitmapDecoderInfo> This, BitmapPattern** ppPatterns, Span<uint> pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoRemoteGetPatternsProxy(ref This.GetPinnableReference(), ppPatterns, ref pcPatterns.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6480, Column 43 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoRemoteGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICBitmapDecoderInfo> This, ref BitmapPattern* ppPatterns, uint* pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoRemoteGetPatternsProxy(ref This.GetPinnableReference(), ref ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6480, Column 43 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoRemoteGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICBitmapDecoderInfo> This, ref BitmapPattern* ppPatterns, Span<uint> pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoRemoteGetPatternsProxy(ref This.GetPinnableReference(), ref ppPatterns, ref pcPatterns.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapDecoderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapDecoderInfoRemoteGetPatternsStub(This, _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapDecoderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapDecoderInfoRemoteGetPatternsStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapDecoderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapDecoderInfoRemoteGetPatternsStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapDecoderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapDecoderInfoRemoteGetPatternsStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapDecoderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapDecoderInfoRemoteGetPatternsStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapDecoderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapDecoderInfoRemoteGetPatternsStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapDecoderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapDecoderInfoRemoteGetPatternsStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapDecoderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapDecoderInfoRemoteGetPatternsStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapDecoderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapDecoderInfoRemoteGetPatternsStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapDecoderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapDecoderInfoRemoteGetPatternsStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapDecoderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapDecoderInfoRemoteGetPatternsStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapDecoderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapDecoderInfoRemoteGetPatternsStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapDecoderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapDecoderInfoRemoteGetPatternsStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapDecoderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapDecoderInfoRemoteGetPatternsStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 6486, Column 17 in wincodec.h")]
        public static unsafe void IWICBitmapDecoderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICBitmapDecoderInfoRemoteGetPatternsStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7696, Column 16 in wincodec.h")]
        public static unsafe int ConvertBitmapSource(this WindowsCodecs thisApi, Guid* dstFormat, Span<IWICBitmapSource> pISrc, IWICBitmapSource** ppIDst)
        {
            // SpanOverloader
            return thisApi.ConvertBitmapSource(dstFormat, ref pISrc.GetPinnableReference(), ppIDst);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7696, Column 16 in wincodec.h")]
        public static unsafe int ConvertBitmapSource(this WindowsCodecs thisApi, Guid* dstFormat, Span<IWICBitmapSource> pISrc, ref IWICBitmapSource* ppIDst)
        {
            // SpanOverloader
            return thisApi.ConvertBitmapSource(dstFormat, ref pISrc.GetPinnableReference(), ref ppIDst);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7696, Column 16 in wincodec.h")]
        public static unsafe int ConvertBitmapSource(this WindowsCodecs thisApi, Span<Guid> dstFormat, IWICBitmapSource* pISrc, IWICBitmapSource** ppIDst)
        {
            // SpanOverloader
            return thisApi.ConvertBitmapSource(ref dstFormat.GetPinnableReference(), pISrc, ppIDst);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7696, Column 16 in wincodec.h")]
        public static unsafe int ConvertBitmapSource(this WindowsCodecs thisApi, Span<Guid> dstFormat, IWICBitmapSource* pISrc, ref IWICBitmapSource* ppIDst)
        {
            // SpanOverloader
            return thisApi.ConvertBitmapSource(ref dstFormat.GetPinnableReference(), pISrc, ref ppIDst);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7696, Column 16 in wincodec.h")]
        public static unsafe int ConvertBitmapSource(this WindowsCodecs thisApi, Span<Guid> dstFormat, Span<IWICBitmapSource> pISrc, IWICBitmapSource** ppIDst)
        {
            // SpanOverloader
            return thisApi.ConvertBitmapSource(ref dstFormat.GetPinnableReference(), ref pISrc.GetPinnableReference(), ppIDst);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7696, Column 16 in wincodec.h")]
        public static unsafe int ConvertBitmapSource(this WindowsCodecs thisApi, Span<Guid> dstFormat, Span<IWICBitmapSource> pISrc, ref IWICBitmapSource* ppIDst)
        {
            // SpanOverloader
            return thisApi.ConvertBitmapSource(ref dstFormat.GetPinnableReference(), ref pISrc.GetPinnableReference(), ref ppIDst);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7701, Column 16 in wincodec.h")]
        public static unsafe int CreateBitmapFromSection<T0>(this WindowsCodecs thisApi, uint width, uint height, Guid* pixelFormat, Span<T0> hSection, uint stride, uint offset, IWICBitmap** ppIBitmap) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBitmapFromSection(width, height, pixelFormat, ref hSection.GetPinnableReference(), stride, offset, ppIBitmap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7701, Column 16 in wincodec.h")]
        public static unsafe int CreateBitmapFromSection<T0>(this WindowsCodecs thisApi, uint width, uint height, Guid* pixelFormat, Span<T0> hSection, uint stride, uint offset, ref IWICBitmap* ppIBitmap) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBitmapFromSection(width, height, pixelFormat, ref hSection.GetPinnableReference(), stride, offset, ref ppIBitmap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7701, Column 16 in wincodec.h")]
        public static unsafe int CreateBitmapFromSection(this WindowsCodecs thisApi, uint width, uint height, Span<Guid> pixelFormat, void* hSection, uint stride, uint offset, IWICBitmap** ppIBitmap)
        {
            // SpanOverloader
            return thisApi.CreateBitmapFromSection(width, height, ref pixelFormat.GetPinnableReference(), hSection, stride, offset, ppIBitmap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7701, Column 16 in wincodec.h")]
        public static unsafe int CreateBitmapFromSection(this WindowsCodecs thisApi, uint width, uint height, Span<Guid> pixelFormat, void* hSection, uint stride, uint offset, ref IWICBitmap* ppIBitmap)
        {
            // SpanOverloader
            return thisApi.CreateBitmapFromSection(width, height, ref pixelFormat.GetPinnableReference(), hSection, stride, offset, ref ppIBitmap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7701, Column 16 in wincodec.h")]
        public static unsafe int CreateBitmapFromSection<T0>(this WindowsCodecs thisApi, uint width, uint height, Span<Guid> pixelFormat, Span<T0> hSection, uint stride, uint offset, IWICBitmap** ppIBitmap) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBitmapFromSection(width, height, ref pixelFormat.GetPinnableReference(), ref hSection.GetPinnableReference(), stride, offset, ppIBitmap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7701, Column 16 in wincodec.h")]
        public static unsafe int CreateBitmapFromSection<T0>(this WindowsCodecs thisApi, uint width, uint height, Span<Guid> pixelFormat, Span<T0> hSection, uint stride, uint offset, ref IWICBitmap* ppIBitmap) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBitmapFromSection(width, height, ref pixelFormat.GetPinnableReference(), ref hSection.GetPinnableReference(), stride, offset, ref ppIBitmap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7710, Column 16 in wincodec.h")]
        public static unsafe int CreateBitmapFromSectionEx<T0>(this WindowsCodecs thisApi, uint width, uint height, Guid* pixelFormat, Span<T0> hSection, uint stride, uint offset, SectionAccessLevel desiredAccessLevel, IWICBitmap** ppIBitmap) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBitmapFromSectionEx(width, height, pixelFormat, ref hSection.GetPinnableReference(), stride, offset, desiredAccessLevel, ppIBitmap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7710, Column 16 in wincodec.h")]
        public static unsafe int CreateBitmapFromSectionEx<T0>(this WindowsCodecs thisApi, uint width, uint height, Guid* pixelFormat, Span<T0> hSection, uint stride, uint offset, SectionAccessLevel desiredAccessLevel, ref IWICBitmap* ppIBitmap) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBitmapFromSectionEx(width, height, pixelFormat, ref hSection.GetPinnableReference(), stride, offset, desiredAccessLevel, ref ppIBitmap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7710, Column 16 in wincodec.h")]
        public static unsafe int CreateBitmapFromSectionEx(this WindowsCodecs thisApi, uint width, uint height, Span<Guid> pixelFormat, void* hSection, uint stride, uint offset, SectionAccessLevel desiredAccessLevel, IWICBitmap** ppIBitmap)
        {
            // SpanOverloader
            return thisApi.CreateBitmapFromSectionEx(width, height, ref pixelFormat.GetPinnableReference(), hSection, stride, offset, desiredAccessLevel, ppIBitmap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7710, Column 16 in wincodec.h")]
        public static unsafe int CreateBitmapFromSectionEx(this WindowsCodecs thisApi, uint width, uint height, Span<Guid> pixelFormat, void* hSection, uint stride, uint offset, SectionAccessLevel desiredAccessLevel, ref IWICBitmap* ppIBitmap)
        {
            // SpanOverloader
            return thisApi.CreateBitmapFromSectionEx(width, height, ref pixelFormat.GetPinnableReference(), hSection, stride, offset, desiredAccessLevel, ref ppIBitmap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7710, Column 16 in wincodec.h")]
        public static unsafe int CreateBitmapFromSectionEx<T0>(this WindowsCodecs thisApi, uint width, uint height, Span<Guid> pixelFormat, Span<T0> hSection, uint stride, uint offset, SectionAccessLevel desiredAccessLevel, IWICBitmap** ppIBitmap) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBitmapFromSectionEx(width, height, ref pixelFormat.GetPinnableReference(), ref hSection.GetPinnableReference(), stride, offset, desiredAccessLevel, ppIBitmap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7710, Column 16 in wincodec.h")]
        public static unsafe int CreateBitmapFromSectionEx<T0>(this WindowsCodecs thisApi, uint width, uint height, Span<Guid> pixelFormat, Span<T0> hSection, uint stride, uint offset, SectionAccessLevel desiredAccessLevel, ref IWICBitmap* ppIBitmap) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBitmapFromSectionEx(width, height, ref pixelFormat.GetPinnableReference(), ref hSection.GetPinnableReference(), stride, offset, desiredAccessLevel, ref ppIBitmap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7720, Column 16 in wincodec.h")]
        public static unsafe int MapGuidToShortName(this WindowsCodecs thisApi, Guid* guid, uint cchName, char* wzName, Span<uint> pcchActual)
        {
            // SpanOverloader
            return thisApi.MapGuidToShortName(guid, cchName, wzName, ref pcchActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7720, Column 16 in wincodec.h")]
        public static unsafe int MapGuidToShortName(this WindowsCodecs thisApi, Guid* guid, uint cchName, Span<char> wzName, uint* pcchActual)
        {
            // SpanOverloader
            return thisApi.MapGuidToShortName(guid, cchName, ref wzName.GetPinnableReference(), pcchActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7720, Column 16 in wincodec.h")]
        public static unsafe int MapGuidToShortName(this WindowsCodecs thisApi, Guid* guid, uint cchName, Span<char> wzName, Span<uint> pcchActual)
        {
            // SpanOverloader
            return thisApi.MapGuidToShortName(guid, cchName, ref wzName.GetPinnableReference(), ref pcchActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7720, Column 16 in wincodec.h")]
        public static unsafe int MapGuidToShortName(this WindowsCodecs thisApi, Guid* guid, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, Span<uint> pcchActual)
        {
            // SpanOverloader
            return thisApi.MapGuidToShortName(guid, cchName, wzName, ref pcchActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7720, Column 16 in wincodec.h")]
        public static unsafe int MapGuidToShortName(this WindowsCodecs thisApi, Span<Guid> guid, uint cchName, char* wzName, uint* pcchActual)
        {
            // SpanOverloader
            return thisApi.MapGuidToShortName(ref guid.GetPinnableReference(), cchName, wzName, pcchActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7720, Column 16 in wincodec.h")]
        public static unsafe int MapGuidToShortName(this WindowsCodecs thisApi, Span<Guid> guid, uint cchName, char* wzName, Span<uint> pcchActual)
        {
            // SpanOverloader
            return thisApi.MapGuidToShortName(ref guid.GetPinnableReference(), cchName, wzName, ref pcchActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7720, Column 16 in wincodec.h")]
        public static unsafe int MapGuidToShortName(this WindowsCodecs thisApi, Span<Guid> guid, uint cchName, Span<char> wzName, uint* pcchActual)
        {
            // SpanOverloader
            return thisApi.MapGuidToShortName(ref guid.GetPinnableReference(), cchName, ref wzName.GetPinnableReference(), pcchActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7720, Column 16 in wincodec.h")]
        public static unsafe int MapGuidToShortName(this WindowsCodecs thisApi, Span<Guid> guid, uint cchName, Span<char> wzName, Span<uint> pcchActual)
        {
            // SpanOverloader
            return thisApi.MapGuidToShortName(ref guid.GetPinnableReference(), cchName, ref wzName.GetPinnableReference(), ref pcchActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7720, Column 16 in wincodec.h")]
        public static unsafe int MapGuidToShortName(this WindowsCodecs thisApi, Span<Guid> guid, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, uint* pcchActual)
        {
            // SpanOverloader
            return thisApi.MapGuidToShortName(ref guid.GetPinnableReference(), cchName, wzName, pcchActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7720, Column 16 in wincodec.h")]
        public static unsafe int MapGuidToShortName(this WindowsCodecs thisApi, Span<Guid> guid, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, Span<uint> pcchActual)
        {
            // SpanOverloader
            return thisApi.MapGuidToShortName(ref guid.GetPinnableReference(), cchName, wzName, ref pcchActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7726, Column 16 in wincodec.h")]
        public static unsafe int MapShortNameToGuid(this WindowsCodecs thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzName, Span<Guid> pguid)
        {
            // SpanOverloader
            return thisApi.MapShortNameToGuid(wzName, ref pguid.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7726, Column 16 in wincodec.h")]
        public static unsafe int MapShortNameToGuid(this WindowsCodecs thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> wzName, Guid* pguid)
        {
            // SpanOverloader
            return thisApi.MapShortNameToGuid(in wzName.GetPinnableReference(), pguid);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7726, Column 16 in wincodec.h")]
        public static unsafe int MapShortNameToGuid(this WindowsCodecs thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> wzName, Span<Guid> pguid)
        {
            // SpanOverloader
            return thisApi.MapShortNameToGuid(in wzName.GetPinnableReference(), ref pguid.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7726, Column 16 in wincodec.h")]
        public static unsafe int MapShortNameToGuid(this WindowsCodecs thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, Span<Guid> pguid)
        {
            // SpanOverloader
            return thisApi.MapShortNameToGuid(wzName, ref pguid.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Guid* guidMetadataFormat, char* pwzSchema, uint cchName, char* wzName, Span<uint> pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(guidMetadataFormat, pwzSchema, cchName, wzName, ref pcchActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Guid* guidMetadataFormat, char* pwzSchema, uint cchName, Span<char> wzName, uint* pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(guidMetadataFormat, pwzSchema, cchName, ref wzName.GetPinnableReference(), pcchActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Guid* guidMetadataFormat, char* pwzSchema, uint cchName, Span<char> wzName, Span<uint> pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(guidMetadataFormat, pwzSchema, cchName, ref wzName.GetPinnableReference(), ref pcchActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Guid* guidMetadataFormat, char* pwzSchema, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, Span<uint> pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(guidMetadataFormat, pwzSchema, cchName, wzName, ref pcchActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Guid* guidMetadataFormat, Span<char> pwzSchema, uint cchName, char* wzName, uint* pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(guidMetadataFormat, ref pwzSchema.GetPinnableReference(), cchName, wzName, pcchActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Guid* guidMetadataFormat, Span<char> pwzSchema, uint cchName, char* wzName, Span<uint> pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(guidMetadataFormat, ref pwzSchema.GetPinnableReference(), cchName, wzName, ref pcchActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Guid* guidMetadataFormat, Span<char> pwzSchema, uint cchName, Span<char> wzName, uint* pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(guidMetadataFormat, ref pwzSchema.GetPinnableReference(), cchName, ref wzName.GetPinnableReference(), pcchActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Guid* guidMetadataFormat, Span<char> pwzSchema, uint cchName, Span<char> wzName, Span<uint> pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(guidMetadataFormat, ref pwzSchema.GetPinnableReference(), cchName, ref wzName.GetPinnableReference(), ref pcchActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Guid* guidMetadataFormat, Span<char> pwzSchema, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, uint* pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(guidMetadataFormat, ref pwzSchema.GetPinnableReference(), cchName, wzName, pcchActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Guid* guidMetadataFormat, Span<char> pwzSchema, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, Span<uint> pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(guidMetadataFormat, ref pwzSchema.GetPinnableReference(), cchName, wzName, ref pcchActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Guid* guidMetadataFormat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwzSchema, uint cchName, char* wzName, Span<uint> pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(guidMetadataFormat, pwzSchema, cchName, wzName, ref pcchActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Guid* guidMetadataFormat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwzSchema, uint cchName, Span<char> wzName, uint* pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(guidMetadataFormat, pwzSchema, cchName, ref wzName.GetPinnableReference(), pcchActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Guid* guidMetadataFormat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwzSchema, uint cchName, Span<char> wzName, Span<uint> pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(guidMetadataFormat, pwzSchema, cchName, ref wzName.GetPinnableReference(), ref pcchActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Guid* guidMetadataFormat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwzSchema, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, Span<uint> pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(guidMetadataFormat, pwzSchema, cchName, wzName, ref pcchActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Span<Guid> guidMetadataFormat, char* pwzSchema, uint cchName, char* wzName, uint* pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(ref guidMetadataFormat.GetPinnableReference(), pwzSchema, cchName, wzName, pcchActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Span<Guid> guidMetadataFormat, char* pwzSchema, uint cchName, char* wzName, Span<uint> pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(ref guidMetadataFormat.GetPinnableReference(), pwzSchema, cchName, wzName, ref pcchActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Span<Guid> guidMetadataFormat, char* pwzSchema, uint cchName, Span<char> wzName, uint* pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(ref guidMetadataFormat.GetPinnableReference(), pwzSchema, cchName, ref wzName.GetPinnableReference(), pcchActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Span<Guid> guidMetadataFormat, char* pwzSchema, uint cchName, Span<char> wzName, Span<uint> pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(ref guidMetadataFormat.GetPinnableReference(), pwzSchema, cchName, ref wzName.GetPinnableReference(), ref pcchActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Span<Guid> guidMetadataFormat, char* pwzSchema, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, uint* pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(ref guidMetadataFormat.GetPinnableReference(), pwzSchema, cchName, wzName, pcchActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Span<Guid> guidMetadataFormat, char* pwzSchema, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, Span<uint> pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(ref guidMetadataFormat.GetPinnableReference(), pwzSchema, cchName, wzName, ref pcchActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Span<Guid> guidMetadataFormat, Span<char> pwzSchema, uint cchName, char* wzName, uint* pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(ref guidMetadataFormat.GetPinnableReference(), ref pwzSchema.GetPinnableReference(), cchName, wzName, pcchActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Span<Guid> guidMetadataFormat, Span<char> pwzSchema, uint cchName, char* wzName, Span<uint> pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(ref guidMetadataFormat.GetPinnableReference(), ref pwzSchema.GetPinnableReference(), cchName, wzName, ref pcchActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Span<Guid> guidMetadataFormat, Span<char> pwzSchema, uint cchName, Span<char> wzName, uint* pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(ref guidMetadataFormat.GetPinnableReference(), ref pwzSchema.GetPinnableReference(), cchName, ref wzName.GetPinnableReference(), pcchActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Span<Guid> guidMetadataFormat, Span<char> pwzSchema, uint cchName, Span<char> wzName, Span<uint> pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(ref guidMetadataFormat.GetPinnableReference(), ref pwzSchema.GetPinnableReference(), cchName, ref wzName.GetPinnableReference(), ref pcchActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Span<Guid> guidMetadataFormat, Span<char> pwzSchema, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, uint* pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(ref guidMetadataFormat.GetPinnableReference(), ref pwzSchema.GetPinnableReference(), cchName, wzName, pcchActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Span<Guid> guidMetadataFormat, Span<char> pwzSchema, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, Span<uint> pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(ref guidMetadataFormat.GetPinnableReference(), ref pwzSchema.GetPinnableReference(), cchName, wzName, ref pcchActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Span<Guid> guidMetadataFormat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwzSchema, uint cchName, char* wzName, uint* pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(ref guidMetadataFormat.GetPinnableReference(), pwzSchema, cchName, wzName, pcchActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Span<Guid> guidMetadataFormat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwzSchema, uint cchName, char* wzName, Span<uint> pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(ref guidMetadataFormat.GetPinnableReference(), pwzSchema, cchName, wzName, ref pcchActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Span<Guid> guidMetadataFormat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwzSchema, uint cchName, Span<char> wzName, uint* pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(ref guidMetadataFormat.GetPinnableReference(), pwzSchema, cchName, ref wzName.GetPinnableReference(), pcchActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Span<Guid> guidMetadataFormat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwzSchema, uint cchName, Span<char> wzName, Span<uint> pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(ref guidMetadataFormat.GetPinnableReference(), pwzSchema, cchName, ref wzName.GetPinnableReference(), ref pcchActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Span<Guid> guidMetadataFormat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwzSchema, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, uint* pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(ref guidMetadataFormat.GetPinnableReference(), pwzSchema, cchName, wzName, pcchActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 7730, Column 16 in wincodec.h")]
        public static unsafe int MapSchemaToName(this WindowsCodecs thisApi, Span<Guid> guidMetadataFormat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pwzSchema, uint cchName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzName, Span<uint> pcchActual)
        {
            // SpanOverloader
            return thisApi.MapSchemaToName(ref guidMetadataFormat.GetPinnableReference(), pwzSchema, cchName, wzName, ref pcchActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8505, Column 43 in wincodec.h")]
        public static unsafe int IWICDevelopRawRemoteQueryRawCapabilitiesInfoProxy(this WindowsCodecs thisApi, IWICDevelopRaw* This, Span<RawCapabilitiesInfo> pInfo)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawRemoteQueryRawCapabilitiesInfoProxy(This, ref pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8505, Column 43 in wincodec.h")]
        public static unsafe int IWICDevelopRawRemoteQueryRawCapabilitiesInfoProxy(this WindowsCodecs thisApi, Span<IWICDevelopRaw> This, RawCapabilitiesInfo* pInfo)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawRemoteQueryRawCapabilitiesInfoProxy(ref This.GetPinnableReference(), pInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8505, Column 43 in wincodec.h")]
        public static unsafe int IWICDevelopRawRemoteQueryRawCapabilitiesInfoProxy(this WindowsCodecs thisApi, Span<IWICDevelopRaw> This, Span<RawCapabilitiesInfo> pInfo)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawRemoteQueryRawCapabilitiesInfoProxy(ref This.GetPinnableReference(), ref pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(This, _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8510, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteQueryRawCapabilitiesInfoStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8517, Column 43 in wincodec.h")]
        public static unsafe int IWICDevelopRawRemoteSetToneCurveProxy(this WindowsCodecs thisApi, IWICDevelopRaw* This, uint cPoints, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RawToneCurvePoint> aPoints)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawRemoteSetToneCurveProxy(This, cPoints, in aPoints.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8517, Column 43 in wincodec.h")]
        public static unsafe int IWICDevelopRawRemoteSetToneCurveProxy(this WindowsCodecs thisApi, Span<IWICDevelopRaw> This, uint cPoints, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RawToneCurvePoint* aPoints)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawRemoteSetToneCurveProxy(ref This.GetPinnableReference(), cPoints, aPoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8517, Column 43 in wincodec.h")]
        public static unsafe int IWICDevelopRawRemoteSetToneCurveProxy(this WindowsCodecs thisApi, Span<IWICDevelopRaw> This, uint cPoints, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RawToneCurvePoint> aPoints)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawRemoteSetToneCurveProxy(ref This.GetPinnableReference(), cPoints, in aPoints.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteSetToneCurveStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteSetToneCurveStub(This, _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteSetToneCurveStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteSetToneCurveStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteSetToneCurveStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteSetToneCurveStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteSetToneCurveStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteSetToneCurveStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteSetToneCurveStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteSetToneCurveStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteSetToneCurveStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteSetToneCurveStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteSetToneCurveStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteSetToneCurveStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteSetToneCurveStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteSetToneCurveStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteSetToneCurveStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteSetToneCurveStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteSetToneCurveStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteSetToneCurveStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteSetToneCurveStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteSetToneCurveStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteSetToneCurveStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteSetToneCurveStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteSetToneCurveStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteSetToneCurveStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteSetToneCurveStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteSetToneCurveStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8523, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteSetToneCurveStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteSetToneCurveStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8530, Column 43 in wincodec.h")]
        public static unsafe int IWICDevelopRawRemoteGetToneCurveProxy(this WindowsCodecs thisApi, IWICDevelopRaw* This, Span<uint> pcPoints, RawToneCurvePoint** paPoints)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawRemoteGetToneCurveProxy(This, ref pcPoints.GetPinnableReference(), paPoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8530, Column 43 in wincodec.h")]
        public static unsafe int IWICDevelopRawRemoteGetToneCurveProxy(this WindowsCodecs thisApi, IWICDevelopRaw* This, Span<uint> pcPoints, ref RawToneCurvePoint* paPoints)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawRemoteGetToneCurveProxy(This, ref pcPoints.GetPinnableReference(), ref paPoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8530, Column 43 in wincodec.h")]
        public static unsafe int IWICDevelopRawRemoteGetToneCurveProxy(this WindowsCodecs thisApi, Span<IWICDevelopRaw> This, uint* pcPoints, RawToneCurvePoint** paPoints)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawRemoteGetToneCurveProxy(ref This.GetPinnableReference(), pcPoints, paPoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8530, Column 43 in wincodec.h")]
        public static unsafe int IWICDevelopRawRemoteGetToneCurveProxy(this WindowsCodecs thisApi, Span<IWICDevelopRaw> This, uint* pcPoints, ref RawToneCurvePoint* paPoints)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawRemoteGetToneCurveProxy(ref This.GetPinnableReference(), pcPoints, ref paPoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8530, Column 43 in wincodec.h")]
        public static unsafe int IWICDevelopRawRemoteGetToneCurveProxy(this WindowsCodecs thisApi, Span<IWICDevelopRaw> This, Span<uint> pcPoints, RawToneCurvePoint** paPoints)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawRemoteGetToneCurveProxy(ref This.GetPinnableReference(), ref pcPoints.GetPinnableReference(), paPoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8530, Column 43 in wincodec.h")]
        public static unsafe int IWICDevelopRawRemoteGetToneCurveProxy(this WindowsCodecs thisApi, Span<IWICDevelopRaw> This, Span<uint> pcPoints, ref RawToneCurvePoint* paPoints)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawRemoteGetToneCurveProxy(ref This.GetPinnableReference(), ref pcPoints.GetPinnableReference(), ref paPoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteGetToneCurveStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteGetToneCurveStub(This, _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteGetToneCurveStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteGetToneCurveStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteGetToneCurveStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteGetToneCurveStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteGetToneCurveStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteGetToneCurveStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteGetToneCurveStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteGetToneCurveStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteGetToneCurveStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteGetToneCurveStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteGetToneCurveStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteGetToneCurveStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteGetToneCurveStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteGetToneCurveStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteGetToneCurveStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteGetToneCurveStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteGetToneCurveStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteGetToneCurveStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteGetToneCurveStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteGetToneCurveStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteGetToneCurveStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteGetToneCurveStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteGetToneCurveStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteGetToneCurveStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteGetToneCurveStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteGetToneCurveStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8536, Column 17 in wincodec.h")]
        public static unsafe void IWICDevelopRawRemoteGetToneCurveStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICDevelopRawRemoteGetToneCurveStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9275, Column 39 in wincodec.h")]
        public static unsafe uint BSTRUserSize(this WindowsCodecs thisApi, Span<uint> arg0, uint arg1, char** arg2)
        {
            // SpanOverloader
            return thisApi.BSTRUserSize(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9275, Column 39 in wincodec.h")]
        public static unsafe uint BSTRUserSize(this WindowsCodecs thisApi, Span<uint> arg0, uint arg1, ref char* arg2)
        {
            // SpanOverloader
            return thisApi.BSTRUserSize(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        public static unsafe byte* BSTRUserMarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, char** arg2)
        {
            // SpanOverloader
            return thisApi.BSTRUserMarshal(arg0, ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        public static unsafe byte* BSTRUserMarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, ref char* arg2)
        {
            // SpanOverloader
            return thisApi.BSTRUserMarshal(arg0, ref arg1.GetPinnableReference(), ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        public static unsafe byte* BSTRUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, char** arg2)
        {
            // SpanOverloader
            return thisApi.BSTRUserMarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        public static unsafe byte* BSTRUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, ref char* arg2)
        {
            // SpanOverloader
            return thisApi.BSTRUserMarshal(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        public static unsafe byte* BSTRUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, char** arg2)
        {
            // SpanOverloader
            return thisApi.BSTRUserMarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        public static unsafe byte* BSTRUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, ref char* arg2)
        {
            // SpanOverloader
            return thisApi.BSTRUserMarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        public static unsafe byte* BSTRUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, char** arg2)
        {
            // SpanOverloader
            return thisApi.BSTRUserMarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9276, Column 29 in wincodec.h")]
        public static unsafe byte* BSTRUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref char* arg2)
        {
            // SpanOverloader
            return thisApi.BSTRUserMarshal(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        public static unsafe byte* BSTRUserUnmarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, char** arg2)
        {
            // SpanOverloader
            return thisApi.BSTRUserUnmarshal(arg0, ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        public static unsafe byte* BSTRUserUnmarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, ref char* arg2)
        {
            // SpanOverloader
            return thisApi.BSTRUserUnmarshal(arg0, ref arg1.GetPinnableReference(), ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        public static unsafe byte* BSTRUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, char** arg2)
        {
            // SpanOverloader
            return thisApi.BSTRUserUnmarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        public static unsafe byte* BSTRUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, ref char* arg2)
        {
            // SpanOverloader
            return thisApi.BSTRUserUnmarshal(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        public static unsafe byte* BSTRUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, char** arg2)
        {
            // SpanOverloader
            return thisApi.BSTRUserUnmarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        public static unsafe byte* BSTRUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, ref char* arg2)
        {
            // SpanOverloader
            return thisApi.BSTRUserUnmarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        public static unsafe byte* BSTRUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, char** arg2)
        {
            // SpanOverloader
            return thisApi.BSTRUserUnmarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9277, Column 29 in wincodec.h")]
        public static unsafe byte* BSTRUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref char* arg2)
        {
            // SpanOverloader
            return thisApi.BSTRUserUnmarshal(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9278, Column 39 in wincodec.h")]
        public static unsafe void BSTRUserFree(this WindowsCodecs thisApi, Span<uint> arg0, char** arg1)
        {
            // SpanOverloader
            thisApi.BSTRUserFree(ref arg0.GetPinnableReference(), arg1);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9278, Column 39 in wincodec.h")]
        public static unsafe void BSTRUserFree(this WindowsCodecs thisApi, Span<uint> arg0, ref char* arg1)
        {
            // SpanOverloader
            thisApi.BSTRUserFree(ref arg0.GetPinnableReference(), ref arg1);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9280, Column 39 in wincodec.h")]
        public static unsafe uint HBITMAPUserSize(this WindowsCodecs thisApi, Span<uint> arg0, uint arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HBITMAPUserSize(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9280, Column 39 in wincodec.h")]
        public static unsafe uint HBITMAPUserSize(this WindowsCodecs thisApi, Span<uint> arg0, uint arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HBITMAPUserSize(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        public static unsafe byte* HBITMAPUserMarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HBITMAPUserMarshal(arg0, ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        public static unsafe byte* HBITMAPUserMarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HBITMAPUserMarshal(arg0, ref arg1.GetPinnableReference(), ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        public static unsafe byte* HBITMAPUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HBITMAPUserMarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        public static unsafe byte* HBITMAPUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HBITMAPUserMarshal(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        public static unsafe byte* HBITMAPUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HBITMAPUserMarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        public static unsafe byte* HBITMAPUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HBITMAPUserMarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        public static unsafe byte* HBITMAPUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HBITMAPUserMarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9281, Column 29 in wincodec.h")]
        public static unsafe byte* HBITMAPUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HBITMAPUserMarshal(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        public static unsafe byte* HBITMAPUserUnmarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HBITMAPUserUnmarshal(arg0, ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        public static unsafe byte* HBITMAPUserUnmarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HBITMAPUserUnmarshal(arg0, ref arg1.GetPinnableReference(), ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        public static unsafe byte* HBITMAPUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HBITMAPUserUnmarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        public static unsafe byte* HBITMAPUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HBITMAPUserUnmarshal(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        public static unsafe byte* HBITMAPUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HBITMAPUserUnmarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        public static unsafe byte* HBITMAPUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HBITMAPUserUnmarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        public static unsafe byte* HBITMAPUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HBITMAPUserUnmarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9282, Column 29 in wincodec.h")]
        public static unsafe byte* HBITMAPUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HBITMAPUserUnmarshal(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9283, Column 39 in wincodec.h")]
        public static unsafe void HBITMAPUserFree(this WindowsCodecs thisApi, Span<uint> arg0, void** arg1)
        {
            // SpanOverloader
            thisApi.HBITMAPUserFree(ref arg0.GetPinnableReference(), arg1);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9283, Column 39 in wincodec.h")]
        public static unsafe void HBITMAPUserFree(this WindowsCodecs thisApi, Span<uint> arg0, ref void* arg1)
        {
            // SpanOverloader
            thisApi.HBITMAPUserFree(ref arg0.GetPinnableReference(), ref arg1);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9285, Column 39 in wincodec.h")]
        public static unsafe uint HICONUserSize(this WindowsCodecs thisApi, Span<uint> arg0, uint arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HICONUserSize(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9285, Column 39 in wincodec.h")]
        public static unsafe uint HICONUserSize(this WindowsCodecs thisApi, Span<uint> arg0, uint arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HICONUserSize(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        public static unsafe byte* HICONUserMarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HICONUserMarshal(arg0, ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        public static unsafe byte* HICONUserMarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HICONUserMarshal(arg0, ref arg1.GetPinnableReference(), ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        public static unsafe byte* HICONUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HICONUserMarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        public static unsafe byte* HICONUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HICONUserMarshal(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        public static unsafe byte* HICONUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HICONUserMarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        public static unsafe byte* HICONUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HICONUserMarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        public static unsafe byte* HICONUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HICONUserMarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9286, Column 29 in wincodec.h")]
        public static unsafe byte* HICONUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HICONUserMarshal(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        public static unsafe byte* HICONUserUnmarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HICONUserUnmarshal(arg0, ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        public static unsafe byte* HICONUserUnmarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HICONUserUnmarshal(arg0, ref arg1.GetPinnableReference(), ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        public static unsafe byte* HICONUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HICONUserUnmarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        public static unsafe byte* HICONUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HICONUserUnmarshal(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        public static unsafe byte* HICONUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HICONUserUnmarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        public static unsafe byte* HICONUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HICONUserUnmarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        public static unsafe byte* HICONUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HICONUserUnmarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9287, Column 29 in wincodec.h")]
        public static unsafe byte* HICONUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HICONUserUnmarshal(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9288, Column 39 in wincodec.h")]
        public static unsafe void HICONUserFree(this WindowsCodecs thisApi, Span<uint> arg0, void** arg1)
        {
            // SpanOverloader
            thisApi.HICONUserFree(ref arg0.GetPinnableReference(), arg1);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9288, Column 39 in wincodec.h")]
        public static unsafe void HICONUserFree(this WindowsCodecs thisApi, Span<uint> arg0, ref void* arg1)
        {
            // SpanOverloader
            thisApi.HICONUserFree(ref arg0.GetPinnableReference(), ref arg1);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9290, Column 39 in wincodec.h")]
        public static unsafe uint HPALETTEUserSize(this WindowsCodecs thisApi, Span<uint> arg0, uint arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HPALETTEUserSize(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9290, Column 39 in wincodec.h")]
        public static unsafe uint HPALETTEUserSize(this WindowsCodecs thisApi, Span<uint> arg0, uint arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HPALETTEUserSize(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        public static unsafe byte* HPALETTEUserMarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HPALETTEUserMarshal(arg0, ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        public static unsafe byte* HPALETTEUserMarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HPALETTEUserMarshal(arg0, ref arg1.GetPinnableReference(), ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        public static unsafe byte* HPALETTEUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HPALETTEUserMarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        public static unsafe byte* HPALETTEUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HPALETTEUserMarshal(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        public static unsafe byte* HPALETTEUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HPALETTEUserMarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        public static unsafe byte* HPALETTEUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HPALETTEUserMarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        public static unsafe byte* HPALETTEUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HPALETTEUserMarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9291, Column 29 in wincodec.h")]
        public static unsafe byte* HPALETTEUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HPALETTEUserMarshal(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        public static unsafe byte* HPALETTEUserUnmarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HPALETTEUserUnmarshal(arg0, ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        public static unsafe byte* HPALETTEUserUnmarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HPALETTEUserUnmarshal(arg0, ref arg1.GetPinnableReference(), ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        public static unsafe byte* HPALETTEUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HPALETTEUserUnmarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        public static unsafe byte* HPALETTEUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HPALETTEUserUnmarshal(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        public static unsafe byte* HPALETTEUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HPALETTEUserUnmarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        public static unsafe byte* HPALETTEUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HPALETTEUserUnmarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        public static unsafe byte* HPALETTEUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, void** arg2)
        {
            // SpanOverloader
            return thisApi.HPALETTEUserUnmarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9292, Column 29 in wincodec.h")]
        public static unsafe byte* HPALETTEUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref void* arg2)
        {
            // SpanOverloader
            return thisApi.HPALETTEUserUnmarshal(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9293, Column 39 in wincodec.h")]
        public static unsafe void HPALETTEUserFree(this WindowsCodecs thisApi, Span<uint> arg0, void** arg1)
        {
            // SpanOverloader
            thisApi.HPALETTEUserFree(ref arg0.GetPinnableReference(), arg1);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9293, Column 39 in wincodec.h")]
        public static unsafe void HPALETTEUserFree(this WindowsCodecs thisApi, Span<uint> arg0, ref void* arg1)
        {
            // SpanOverloader
            thisApi.HPALETTEUserFree(ref arg0.GetPinnableReference(), ref arg1);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9295, Column 39 in wincodec.h")]
        public static unsafe uint LPSAFEARRAYUserSize(this WindowsCodecs thisApi, Span<uint> arg0, uint arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2)
        {
            // SpanOverloader
            return thisApi.LPSAFEARRAYUserSize(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9295, Column 39 in wincodec.h")]
        public static unsafe uint LPSAFEARRAYUserSize(this WindowsCodecs thisApi, Span<uint> arg0, uint arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2)
        {
            // SpanOverloader
            return thisApi.LPSAFEARRAYUserSize(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        public static unsafe byte* LPSAFEARRAYUserMarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2)
        {
            // SpanOverloader
            return thisApi.LPSAFEARRAYUserMarshal(arg0, ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        public static unsafe byte* LPSAFEARRAYUserMarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2)
        {
            // SpanOverloader
            return thisApi.LPSAFEARRAYUserMarshal(arg0, ref arg1.GetPinnableReference(), ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        public static unsafe byte* LPSAFEARRAYUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2)
        {
            // SpanOverloader
            return thisApi.LPSAFEARRAYUserMarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        public static unsafe byte* LPSAFEARRAYUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2)
        {
            // SpanOverloader
            return thisApi.LPSAFEARRAYUserMarshal(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        public static unsafe byte* LPSAFEARRAYUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2)
        {
            // SpanOverloader
            return thisApi.LPSAFEARRAYUserMarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        public static unsafe byte* LPSAFEARRAYUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2)
        {
            // SpanOverloader
            return thisApi.LPSAFEARRAYUserMarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        public static unsafe byte* LPSAFEARRAYUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2)
        {
            // SpanOverloader
            return thisApi.LPSAFEARRAYUserMarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9296, Column 29 in wincodec.h")]
        public static unsafe byte* LPSAFEARRAYUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2)
        {
            // SpanOverloader
            return thisApi.LPSAFEARRAYUserMarshal(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        public static unsafe byte* LPSAFEARRAYUserUnmarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2)
        {
            // SpanOverloader
            return thisApi.LPSAFEARRAYUserUnmarshal(arg0, ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        public static unsafe byte* LPSAFEARRAYUserUnmarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2)
        {
            // SpanOverloader
            return thisApi.LPSAFEARRAYUserUnmarshal(arg0, ref arg1.GetPinnableReference(), ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        public static unsafe byte* LPSAFEARRAYUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2)
        {
            // SpanOverloader
            return thisApi.LPSAFEARRAYUserUnmarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        public static unsafe byte* LPSAFEARRAYUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2)
        {
            // SpanOverloader
            return thisApi.LPSAFEARRAYUserUnmarshal(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        public static unsafe byte* LPSAFEARRAYUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2)
        {
            // SpanOverloader
            return thisApi.LPSAFEARRAYUserUnmarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        public static unsafe byte* LPSAFEARRAYUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2)
        {
            // SpanOverloader
            return thisApi.LPSAFEARRAYUserUnmarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        public static unsafe byte* LPSAFEARRAYUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, Silk.NET.Core.Win32Extras.SafeArray** arg2)
        {
            // SpanOverloader
            return thisApi.LPSAFEARRAYUserUnmarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9297, Column 29 in wincodec.h")]
        public static unsafe byte* LPSAFEARRAYUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref Silk.NET.Core.Win32Extras.SafeArray* arg2)
        {
            // SpanOverloader
            return thisApi.LPSAFEARRAYUserUnmarshal(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9298, Column 39 in wincodec.h")]
        public static unsafe void LPSAFEARRAYUserFree(this WindowsCodecs thisApi, Span<uint> arg0, Silk.NET.Core.Win32Extras.SafeArray** arg1)
        {
            // SpanOverloader
            thisApi.LPSAFEARRAYUserFree(ref arg0.GetPinnableReference(), arg1);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9298, Column 39 in wincodec.h")]
        public static unsafe void LPSAFEARRAYUserFree(this WindowsCodecs thisApi, Span<uint> arg0, ref Silk.NET.Core.Win32Extras.SafeArray* arg1)
        {
            // SpanOverloader
            thisApi.LPSAFEARRAYUserFree(ref arg0.GetPinnableReference(), ref arg1);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9300, Column 39 in wincodec.h")]
        public static unsafe uint InProcPointerUserSize(this WindowsCodecs thisApi, Span<uint> arg0, uint arg1, byte** arg2)
        {
            // SpanOverloader
            return thisApi.InProcPointerUserSize(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9300, Column 39 in wincodec.h")]
        public static unsafe uint InProcPointerUserSize(this WindowsCodecs thisApi, Span<uint> arg0, uint arg1, ref byte* arg2)
        {
            // SpanOverloader
            return thisApi.InProcPointerUserSize(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        public static unsafe byte* InProcPointerUserMarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, byte** arg2)
        {
            // SpanOverloader
            return thisApi.InProcPointerUserMarshal(arg0, ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        public static unsafe byte* InProcPointerUserMarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, ref byte* arg2)
        {
            // SpanOverloader
            return thisApi.InProcPointerUserMarshal(arg0, ref arg1.GetPinnableReference(), ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        public static unsafe byte* InProcPointerUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, byte** arg2)
        {
            // SpanOverloader
            return thisApi.InProcPointerUserMarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        public static unsafe byte* InProcPointerUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, ref byte* arg2)
        {
            // SpanOverloader
            return thisApi.InProcPointerUserMarshal(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        public static unsafe byte* InProcPointerUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, byte** arg2)
        {
            // SpanOverloader
            return thisApi.InProcPointerUserMarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        public static unsafe byte* InProcPointerUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, ref byte* arg2)
        {
            // SpanOverloader
            return thisApi.InProcPointerUserMarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        public static unsafe byte* InProcPointerUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, byte** arg2)
        {
            // SpanOverloader
            return thisApi.InProcPointerUserMarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9301, Column 29 in wincodec.h")]
        public static unsafe byte* InProcPointerUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref byte* arg2)
        {
            // SpanOverloader
            return thisApi.InProcPointerUserMarshal(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        public static unsafe byte* InProcPointerUserUnmarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, byte** arg2)
        {
            // SpanOverloader
            return thisApi.InProcPointerUserUnmarshal(arg0, ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        public static unsafe byte* InProcPointerUserUnmarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, ref byte* arg2)
        {
            // SpanOverloader
            return thisApi.InProcPointerUserUnmarshal(arg0, ref arg1.GetPinnableReference(), ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        public static unsafe byte* InProcPointerUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, byte** arg2)
        {
            // SpanOverloader
            return thisApi.InProcPointerUserUnmarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        public static unsafe byte* InProcPointerUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, ref byte* arg2)
        {
            // SpanOverloader
            return thisApi.InProcPointerUserUnmarshal(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        public static unsafe byte* InProcPointerUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, byte** arg2)
        {
            // SpanOverloader
            return thisApi.InProcPointerUserUnmarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        public static unsafe byte* InProcPointerUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, ref byte* arg2)
        {
            // SpanOverloader
            return thisApi.InProcPointerUserUnmarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        public static unsafe byte* InProcPointerUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, byte** arg2)
        {
            // SpanOverloader
            return thisApi.InProcPointerUserUnmarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9302, Column 29 in wincodec.h")]
        public static unsafe byte* InProcPointerUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ref byte* arg2)
        {
            // SpanOverloader
            return thisApi.InProcPointerUserUnmarshal(ref arg0.GetPinnableReference(), arg1, ref arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9303, Column 39 in wincodec.h")]
        public static unsafe void InProcPointerUserFree(this WindowsCodecs thisApi, Span<uint> arg0, byte** arg1)
        {
            // SpanOverloader
            thisApi.InProcPointerUserFree(ref arg0.GetPinnableReference(), arg1);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9303, Column 39 in wincodec.h")]
        public static unsafe void InProcPointerUserFree(this WindowsCodecs thisApi, Span<uint> arg0, ref byte* arg1)
        {
            // SpanOverloader
            thisApi.InProcPointerUserFree(ref arg0.GetPinnableReference(), ref arg1);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9305, Column 41 in wincodec.h")]
        public static unsafe int IWICBitmapCodecProgressNotificationRegisterProgressNotificationProxy<T0>(this WindowsCodecs thisApi, IWICBitmapCodecProgressNotification* This, PfnProgressNotification pfnProgressNotification, Span<T0> pvData, uint dwProgressFlags) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.IWICBitmapCodecProgressNotificationRegisterProgressNotificationProxy(This, pfnProgressNotification, ref pvData.GetPinnableReference(), dwProgressFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9305, Column 41 in wincodec.h")]
        public static unsafe int IWICBitmapCodecProgressNotificationRegisterProgressNotificationProxy(this WindowsCodecs thisApi, Span<IWICBitmapCodecProgressNotification> This, PfnProgressNotification pfnProgressNotification, void* pvData, uint dwProgressFlags)
        {
            // SpanOverloader
            return thisApi.IWICBitmapCodecProgressNotificationRegisterProgressNotificationProxy(ref This.GetPinnableReference(), pfnProgressNotification, pvData, dwProgressFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9305, Column 41 in wincodec.h")]
        public static unsafe int IWICBitmapCodecProgressNotificationRegisterProgressNotificationProxy<T0>(this WindowsCodecs thisApi, Span<IWICBitmapCodecProgressNotification> This, PfnProgressNotification pfnProgressNotification, Span<T0> pvData, uint dwProgressFlags) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.IWICBitmapCodecProgressNotificationRegisterProgressNotificationProxy(ref This.GetPinnableReference(), pfnProgressNotification, ref pvData.GetPinnableReference(), dwProgressFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9314, Column 43 in wincodec.h")]
        public static unsafe int IWICBitmapCodecProgressNotificationRegisterProgressNotificationStub(this WindowsCodecs thisApi, IWICBitmapCodecProgressNotification* This, Span<IWICProgressCallback> pICallback, uint dwProgressFlags)
        {
            // SpanOverloader
            return thisApi.IWICBitmapCodecProgressNotificationRegisterProgressNotificationStub(This, ref pICallback.GetPinnableReference(), dwProgressFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9314, Column 43 in wincodec.h")]
        public static unsafe int IWICBitmapCodecProgressNotificationRegisterProgressNotificationStub(this WindowsCodecs thisApi, Span<IWICBitmapCodecProgressNotification> This, IWICProgressCallback* pICallback, uint dwProgressFlags)
        {
            // SpanOverloader
            return thisApi.IWICBitmapCodecProgressNotificationRegisterProgressNotificationStub(ref This.GetPinnableReference(), pICallback, dwProgressFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9314, Column 43 in wincodec.h")]
        public static unsafe int IWICBitmapCodecProgressNotificationRegisterProgressNotificationStub(this WindowsCodecs thisApi, Span<IWICBitmapCodecProgressNotification> This, Span<IWICProgressCallback> pICallback, uint dwProgressFlags)
        {
            // SpanOverloader
            return thisApi.IWICBitmapCodecProgressNotificationRegisterProgressNotificationStub(ref This.GetPinnableReference(), ref pICallback.GetPinnableReference(), dwProgressFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoGetPatternsProxy(this WindowsCodecs thisApi, IWICBitmapDecoderInfo* This, uint cbSizePatterns, BitmapPattern* pPatterns, uint* pcPatterns, Span<uint> pcbPatternsActual)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoGetPatternsProxy(This, cbSizePatterns, pPatterns, pcPatterns, ref pcbPatternsActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoGetPatternsProxy(this WindowsCodecs thisApi, IWICBitmapDecoderInfo* This, uint cbSizePatterns, BitmapPattern* pPatterns, Span<uint> pcPatterns, uint* pcbPatternsActual)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoGetPatternsProxy(This, cbSizePatterns, pPatterns, ref pcPatterns.GetPinnableReference(), pcbPatternsActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoGetPatternsProxy(this WindowsCodecs thisApi, IWICBitmapDecoderInfo* This, uint cbSizePatterns, BitmapPattern* pPatterns, Span<uint> pcPatterns, Span<uint> pcbPatternsActual)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoGetPatternsProxy(This, cbSizePatterns, pPatterns, ref pcPatterns.GetPinnableReference(), ref pcbPatternsActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoGetPatternsProxy(this WindowsCodecs thisApi, IWICBitmapDecoderInfo* This, uint cbSizePatterns, Span<BitmapPattern> pPatterns, uint* pcPatterns, uint* pcbPatternsActual)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoGetPatternsProxy(This, cbSizePatterns, ref pPatterns.GetPinnableReference(), pcPatterns, pcbPatternsActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoGetPatternsProxy(this WindowsCodecs thisApi, IWICBitmapDecoderInfo* This, uint cbSizePatterns, Span<BitmapPattern> pPatterns, uint* pcPatterns, Span<uint> pcbPatternsActual)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoGetPatternsProxy(This, cbSizePatterns, ref pPatterns.GetPinnableReference(), pcPatterns, ref pcbPatternsActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoGetPatternsProxy(this WindowsCodecs thisApi, IWICBitmapDecoderInfo* This, uint cbSizePatterns, Span<BitmapPattern> pPatterns, Span<uint> pcPatterns, uint* pcbPatternsActual)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoGetPatternsProxy(This, cbSizePatterns, ref pPatterns.GetPinnableReference(), ref pcPatterns.GetPinnableReference(), pcbPatternsActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoGetPatternsProxy(this WindowsCodecs thisApi, IWICBitmapDecoderInfo* This, uint cbSizePatterns, Span<BitmapPattern> pPatterns, Span<uint> pcPatterns, Span<uint> pcbPatternsActual)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoGetPatternsProxy(This, cbSizePatterns, ref pPatterns.GetPinnableReference(), ref pcPatterns.GetPinnableReference(), ref pcbPatternsActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICBitmapDecoderInfo> This, uint cbSizePatterns, BitmapPattern* pPatterns, uint* pcPatterns, uint* pcbPatternsActual)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoGetPatternsProxy(ref This.GetPinnableReference(), cbSizePatterns, pPatterns, pcPatterns, pcbPatternsActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICBitmapDecoderInfo> This, uint cbSizePatterns, BitmapPattern* pPatterns, uint* pcPatterns, Span<uint> pcbPatternsActual)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoGetPatternsProxy(ref This.GetPinnableReference(), cbSizePatterns, pPatterns, pcPatterns, ref pcbPatternsActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICBitmapDecoderInfo> This, uint cbSizePatterns, BitmapPattern* pPatterns, Span<uint> pcPatterns, uint* pcbPatternsActual)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoGetPatternsProxy(ref This.GetPinnableReference(), cbSizePatterns, pPatterns, ref pcPatterns.GetPinnableReference(), pcbPatternsActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICBitmapDecoderInfo> This, uint cbSizePatterns, BitmapPattern* pPatterns, Span<uint> pcPatterns, Span<uint> pcbPatternsActual)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoGetPatternsProxy(ref This.GetPinnableReference(), cbSizePatterns, pPatterns, ref pcPatterns.GetPinnableReference(), ref pcbPatternsActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICBitmapDecoderInfo> This, uint cbSizePatterns, Span<BitmapPattern> pPatterns, uint* pcPatterns, uint* pcbPatternsActual)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoGetPatternsProxy(ref This.GetPinnableReference(), cbSizePatterns, ref pPatterns.GetPinnableReference(), pcPatterns, pcbPatternsActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICBitmapDecoderInfo> This, uint cbSizePatterns, Span<BitmapPattern> pPatterns, uint* pcPatterns, Span<uint> pcbPatternsActual)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoGetPatternsProxy(ref This.GetPinnableReference(), cbSizePatterns, ref pPatterns.GetPinnableReference(), pcPatterns, ref pcbPatternsActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICBitmapDecoderInfo> This, uint cbSizePatterns, Span<BitmapPattern> pPatterns, Span<uint> pcPatterns, uint* pcbPatternsActual)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoGetPatternsProxy(ref This.GetPinnableReference(), cbSizePatterns, ref pPatterns.GetPinnableReference(), ref pcPatterns.GetPinnableReference(), pcbPatternsActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9319, Column 41 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICBitmapDecoderInfo> This, uint cbSizePatterns, Span<BitmapPattern> pPatterns, Span<uint> pcPatterns, Span<uint> pcbPatternsActual)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoGetPatternsProxy(ref This.GetPinnableReference(), cbSizePatterns, ref pPatterns.GetPinnableReference(), ref pcPatterns.GetPinnableReference(), ref pcbPatternsActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9330, Column 43 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoGetPatternsStub(this WindowsCodecs thisApi, IWICBitmapDecoderInfo* This, BitmapPattern** ppPatterns, Span<uint> pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoGetPatternsStub(This, ppPatterns, ref pcPatterns.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9330, Column 43 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoGetPatternsStub(this WindowsCodecs thisApi, IWICBitmapDecoderInfo* This, ref BitmapPattern* ppPatterns, Span<uint> pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoGetPatternsStub(This, ref ppPatterns, ref pcPatterns.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9330, Column 43 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoGetPatternsStub(this WindowsCodecs thisApi, Span<IWICBitmapDecoderInfo> This, BitmapPattern** ppPatterns, uint* pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoGetPatternsStub(ref This.GetPinnableReference(), ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9330, Column 43 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoGetPatternsStub(this WindowsCodecs thisApi, Span<IWICBitmapDecoderInfo> This, BitmapPattern** ppPatterns, Span<uint> pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoGetPatternsStub(ref This.GetPinnableReference(), ppPatterns, ref pcPatterns.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9330, Column 43 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoGetPatternsStub(this WindowsCodecs thisApi, Span<IWICBitmapDecoderInfo> This, ref BitmapPattern* ppPatterns, uint* pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoGetPatternsStub(ref This.GetPinnableReference(), ref ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9330, Column 43 in wincodec.h")]
        public static unsafe int IWICBitmapDecoderInfoGetPatternsStub(this WindowsCodecs thisApi, Span<IWICBitmapDecoderInfo> This, ref BitmapPattern* ppPatterns, Span<uint> pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICBitmapDecoderInfoGetPatternsStub(ref This.GetPinnableReference(), ref ppPatterns, ref pcPatterns.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9335, Column 41 in wincodec.h")]
        public static unsafe int IWICDevelopRawQueryRawCapabilitiesInfoProxy(this WindowsCodecs thisApi, IWICDevelopRaw* This, Span<RawCapabilitiesInfo> pInfo)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawQueryRawCapabilitiesInfoProxy(This, ref pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9335, Column 41 in wincodec.h")]
        public static unsafe int IWICDevelopRawQueryRawCapabilitiesInfoProxy(this WindowsCodecs thisApi, Span<IWICDevelopRaw> This, RawCapabilitiesInfo* pInfo)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawQueryRawCapabilitiesInfoProxy(ref This.GetPinnableReference(), pInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9335, Column 41 in wincodec.h")]
        public static unsafe int IWICDevelopRawQueryRawCapabilitiesInfoProxy(this WindowsCodecs thisApi, Span<IWICDevelopRaw> This, Span<RawCapabilitiesInfo> pInfo)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawQueryRawCapabilitiesInfoProxy(ref This.GetPinnableReference(), ref pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9340, Column 43 in wincodec.h")]
        public static unsafe int IWICDevelopRawQueryRawCapabilitiesInfoStub(this WindowsCodecs thisApi, IWICDevelopRaw* This, Span<RawCapabilitiesInfo> pInfo)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawQueryRawCapabilitiesInfoStub(This, ref pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9340, Column 43 in wincodec.h")]
        public static unsafe int IWICDevelopRawQueryRawCapabilitiesInfoStub(this WindowsCodecs thisApi, Span<IWICDevelopRaw> This, RawCapabilitiesInfo* pInfo)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawQueryRawCapabilitiesInfoStub(ref This.GetPinnableReference(), pInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9340, Column 43 in wincodec.h")]
        public static unsafe int IWICDevelopRawQueryRawCapabilitiesInfoStub(this WindowsCodecs thisApi, Span<IWICDevelopRaw> This, Span<RawCapabilitiesInfo> pInfo)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawQueryRawCapabilitiesInfoStub(ref This.GetPinnableReference(), ref pInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9344, Column 41 in wincodec.h")]
        public static unsafe int IWICDevelopRawSetToneCurveProxy(this WindowsCodecs thisApi, IWICDevelopRaw* This, uint cbToneCurveSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RawToneCurve> pToneCurve)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawSetToneCurveProxy(This, cbToneCurveSize, in pToneCurve.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9344, Column 41 in wincodec.h")]
        public static unsafe int IWICDevelopRawSetToneCurveProxy(this WindowsCodecs thisApi, Span<IWICDevelopRaw> This, uint cbToneCurveSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RawToneCurve* pToneCurve)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawSetToneCurveProxy(ref This.GetPinnableReference(), cbToneCurveSize, pToneCurve);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9344, Column 41 in wincodec.h")]
        public static unsafe int IWICDevelopRawSetToneCurveProxy(this WindowsCodecs thisApi, Span<IWICDevelopRaw> This, uint cbToneCurveSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RawToneCurve> pToneCurve)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawSetToneCurveProxy(ref This.GetPinnableReference(), cbToneCurveSize, in pToneCurve.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9351, Column 43 in wincodec.h")]
        public static unsafe int IWICDevelopRawSetToneCurveStub(this WindowsCodecs thisApi, IWICDevelopRaw* This, uint cPoints, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RawToneCurvePoint> aPoints)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawSetToneCurveStub(This, cPoints, in aPoints.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9351, Column 43 in wincodec.h")]
        public static unsafe int IWICDevelopRawSetToneCurveStub(this WindowsCodecs thisApi, Span<IWICDevelopRaw> This, uint cPoints, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RawToneCurvePoint* aPoints)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawSetToneCurveStub(ref This.GetPinnableReference(), cPoints, aPoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9351, Column 43 in wincodec.h")]
        public static unsafe int IWICDevelopRawSetToneCurveStub(this WindowsCodecs thisApi, Span<IWICDevelopRaw> This, uint cPoints, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RawToneCurvePoint> aPoints)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawSetToneCurveStub(ref This.GetPinnableReference(), cPoints, in aPoints.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9356, Column 41 in wincodec.h")]
        public static unsafe int IWICDevelopRawGetToneCurveProxy(this WindowsCodecs thisApi, IWICDevelopRaw* This, uint cbToneCurveBufferSize, RawToneCurve* pToneCurve, Span<uint> pcbActualToneCurveBufferSize)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawGetToneCurveProxy(This, cbToneCurveBufferSize, pToneCurve, ref pcbActualToneCurveBufferSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9356, Column 41 in wincodec.h")]
        public static unsafe int IWICDevelopRawGetToneCurveProxy(this WindowsCodecs thisApi, IWICDevelopRaw* This, uint cbToneCurveBufferSize, Span<RawToneCurve> pToneCurve, uint* pcbActualToneCurveBufferSize)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawGetToneCurveProxy(This, cbToneCurveBufferSize, ref pToneCurve.GetPinnableReference(), pcbActualToneCurveBufferSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9356, Column 41 in wincodec.h")]
        public static unsafe int IWICDevelopRawGetToneCurveProxy(this WindowsCodecs thisApi, IWICDevelopRaw* This, uint cbToneCurveBufferSize, Span<RawToneCurve> pToneCurve, Span<uint> pcbActualToneCurveBufferSize)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawGetToneCurveProxy(This, cbToneCurveBufferSize, ref pToneCurve.GetPinnableReference(), ref pcbActualToneCurveBufferSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9356, Column 41 in wincodec.h")]
        public static unsafe int IWICDevelopRawGetToneCurveProxy(this WindowsCodecs thisApi, Span<IWICDevelopRaw> This, uint cbToneCurveBufferSize, RawToneCurve* pToneCurve, uint* pcbActualToneCurveBufferSize)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawGetToneCurveProxy(ref This.GetPinnableReference(), cbToneCurveBufferSize, pToneCurve, pcbActualToneCurveBufferSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9356, Column 41 in wincodec.h")]
        public static unsafe int IWICDevelopRawGetToneCurveProxy(this WindowsCodecs thisApi, Span<IWICDevelopRaw> This, uint cbToneCurveBufferSize, RawToneCurve* pToneCurve, Span<uint> pcbActualToneCurveBufferSize)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawGetToneCurveProxy(ref This.GetPinnableReference(), cbToneCurveBufferSize, pToneCurve, ref pcbActualToneCurveBufferSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9356, Column 41 in wincodec.h")]
        public static unsafe int IWICDevelopRawGetToneCurveProxy(this WindowsCodecs thisApi, Span<IWICDevelopRaw> This, uint cbToneCurveBufferSize, Span<RawToneCurve> pToneCurve, uint* pcbActualToneCurveBufferSize)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawGetToneCurveProxy(ref This.GetPinnableReference(), cbToneCurveBufferSize, ref pToneCurve.GetPinnableReference(), pcbActualToneCurveBufferSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9356, Column 41 in wincodec.h")]
        public static unsafe int IWICDevelopRawGetToneCurveProxy(this WindowsCodecs thisApi, Span<IWICDevelopRaw> This, uint cbToneCurveBufferSize, Span<RawToneCurve> pToneCurve, Span<uint> pcbActualToneCurveBufferSize)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawGetToneCurveProxy(ref This.GetPinnableReference(), cbToneCurveBufferSize, ref pToneCurve.GetPinnableReference(), ref pcbActualToneCurveBufferSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9365, Column 43 in wincodec.h")]
        public static unsafe int IWICDevelopRawGetToneCurveStub(this WindowsCodecs thisApi, IWICDevelopRaw* This, Span<uint> pcPoints, RawToneCurvePoint** paPoints)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawGetToneCurveStub(This, ref pcPoints.GetPinnableReference(), paPoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9365, Column 43 in wincodec.h")]
        public static unsafe int IWICDevelopRawGetToneCurveStub(this WindowsCodecs thisApi, IWICDevelopRaw* This, Span<uint> pcPoints, ref RawToneCurvePoint* paPoints)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawGetToneCurveStub(This, ref pcPoints.GetPinnableReference(), ref paPoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9365, Column 43 in wincodec.h")]
        public static unsafe int IWICDevelopRawGetToneCurveStub(this WindowsCodecs thisApi, Span<IWICDevelopRaw> This, uint* pcPoints, RawToneCurvePoint** paPoints)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawGetToneCurveStub(ref This.GetPinnableReference(), pcPoints, paPoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9365, Column 43 in wincodec.h")]
        public static unsafe int IWICDevelopRawGetToneCurveStub(this WindowsCodecs thisApi, Span<IWICDevelopRaw> This, uint* pcPoints, ref RawToneCurvePoint* paPoints)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawGetToneCurveStub(ref This.GetPinnableReference(), pcPoints, ref paPoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9365, Column 43 in wincodec.h")]
        public static unsafe int IWICDevelopRawGetToneCurveStub(this WindowsCodecs thisApi, Span<IWICDevelopRaw> This, Span<uint> pcPoints, RawToneCurvePoint** paPoints)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawGetToneCurveStub(ref This.GetPinnableReference(), ref pcPoints.GetPinnableReference(), paPoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 9365, Column 43 in wincodec.h")]
        public static unsafe int IWICDevelopRawGetToneCurveStub(this WindowsCodecs thisApi, Span<IWICDevelopRaw> This, Span<uint> pcPoints, ref RawToneCurvePoint* paPoints)
        {
            // SpanOverloader
            return thisApi.IWICDevelopRawGetToneCurveStub(ref This.GetPinnableReference(), ref pcPoints.GetPinnableReference(), ref paPoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoRemoteGetPatternsProxy(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Guid* guidContainerFormat, MetadataPattern** ppPatterns, Span<uint> pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoRemoteGetPatternsProxy(This, guidContainerFormat, ppPatterns, ref pcPatterns.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoRemoteGetPatternsProxy(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Guid* guidContainerFormat, ref MetadataPattern* ppPatterns, Span<uint> pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoRemoteGetPatternsProxy(This, guidContainerFormat, ref ppPatterns, ref pcPatterns.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoRemoteGetPatternsProxy(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Span<Guid> guidContainerFormat, MetadataPattern** ppPatterns, uint* pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoRemoteGetPatternsProxy(This, ref guidContainerFormat.GetPinnableReference(), ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoRemoteGetPatternsProxy(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Span<Guid> guidContainerFormat, MetadataPattern** ppPatterns, Span<uint> pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoRemoteGetPatternsProxy(This, ref guidContainerFormat.GetPinnableReference(), ppPatterns, ref pcPatterns.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoRemoteGetPatternsProxy(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Span<Guid> guidContainerFormat, ref MetadataPattern* ppPatterns, uint* pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoRemoteGetPatternsProxy(This, ref guidContainerFormat.GetPinnableReference(), ref ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoRemoteGetPatternsProxy(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Span<Guid> guidContainerFormat, ref MetadataPattern* ppPatterns, Span<uint> pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoRemoteGetPatternsProxy(This, ref guidContainerFormat.GetPinnableReference(), ref ppPatterns, ref pcPatterns.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoRemoteGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Guid* guidContainerFormat, MetadataPattern** ppPatterns, uint* pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoRemoteGetPatternsProxy(ref This.GetPinnableReference(), guidContainerFormat, ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoRemoteGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Guid* guidContainerFormat, MetadataPattern** ppPatterns, Span<uint> pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoRemoteGetPatternsProxy(ref This.GetPinnableReference(), guidContainerFormat, ppPatterns, ref pcPatterns.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoRemoteGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Guid* guidContainerFormat, ref MetadataPattern* ppPatterns, uint* pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoRemoteGetPatternsProxy(ref This.GetPinnableReference(), guidContainerFormat, ref ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoRemoteGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Guid* guidContainerFormat, ref MetadataPattern* ppPatterns, Span<uint> pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoRemoteGetPatternsProxy(ref This.GetPinnableReference(), guidContainerFormat, ref ppPatterns, ref pcPatterns.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoRemoteGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Span<Guid> guidContainerFormat, MetadataPattern** ppPatterns, uint* pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoRemoteGetPatternsProxy(ref This.GetPinnableReference(), ref guidContainerFormat.GetPinnableReference(), ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoRemoteGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Span<Guid> guidContainerFormat, MetadataPattern** ppPatterns, Span<uint> pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoRemoteGetPatternsProxy(ref This.GetPinnableReference(), ref guidContainerFormat.GetPinnableReference(), ppPatterns, ref pcPatterns.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoRemoteGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Span<Guid> guidContainerFormat, ref MetadataPattern* ppPatterns, uint* pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoRemoteGetPatternsProxy(ref This.GetPinnableReference(), ref guidContainerFormat.GetPinnableReference(), ref ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1683, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoRemoteGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Span<Guid> guidContainerFormat, ref MetadataPattern* ppPatterns, Span<uint> pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoRemoteGetPatternsProxy(ref This.GetPinnableReference(), ref guidContainerFormat.GetPinnableReference(), ref ppPatterns, ref pcPatterns.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataReaderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataReaderInfoRemoteGetPatternsStub(This, _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataReaderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataReaderInfoRemoteGetPatternsStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataReaderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataReaderInfoRemoteGetPatternsStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataReaderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataReaderInfoRemoteGetPatternsStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataReaderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataReaderInfoRemoteGetPatternsStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataReaderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataReaderInfoRemoteGetPatternsStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataReaderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataReaderInfoRemoteGetPatternsStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataReaderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataReaderInfoRemoteGetPatternsStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataReaderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataReaderInfoRemoteGetPatternsStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataReaderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataReaderInfoRemoteGetPatternsStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataReaderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataReaderInfoRemoteGetPatternsStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataReaderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataReaderInfoRemoteGetPatternsStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataReaderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataReaderInfoRemoteGetPatternsStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataReaderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataReaderInfoRemoteGetPatternsStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataReaderInfoRemoteGetPatternsStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataReaderInfoRemoteGetPatternsStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1954, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoRemoteGetHeaderProxy(this WindowsCodecs thisApi, IWICMetadataWriterInfo* This, Guid* guidContainerFormat, Span<MetadataHeader> pHeader)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoRemoteGetHeaderProxy(This, guidContainerFormat, ref pHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1954, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoRemoteGetHeaderProxy(this WindowsCodecs thisApi, IWICMetadataWriterInfo* This, Span<Guid> guidContainerFormat, MetadataHeader* pHeader)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoRemoteGetHeaderProxy(This, ref guidContainerFormat.GetPinnableReference(), pHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1954, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoRemoteGetHeaderProxy(this WindowsCodecs thisApi, IWICMetadataWriterInfo* This, Span<Guid> guidContainerFormat, Span<MetadataHeader> pHeader)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoRemoteGetHeaderProxy(This, ref guidContainerFormat.GetPinnableReference(), ref pHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1954, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoRemoteGetHeaderProxy(this WindowsCodecs thisApi, Span<IWICMetadataWriterInfo> This, Guid* guidContainerFormat, MetadataHeader* pHeader)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoRemoteGetHeaderProxy(ref This.GetPinnableReference(), guidContainerFormat, pHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1954, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoRemoteGetHeaderProxy(this WindowsCodecs thisApi, Span<IWICMetadataWriterInfo> This, Guid* guidContainerFormat, Span<MetadataHeader> pHeader)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoRemoteGetHeaderProxy(ref This.GetPinnableReference(), guidContainerFormat, ref pHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1954, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoRemoteGetHeaderProxy(this WindowsCodecs thisApi, Span<IWICMetadataWriterInfo> This, Span<Guid> guidContainerFormat, MetadataHeader* pHeader)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoRemoteGetHeaderProxy(ref This.GetPinnableReference(), ref guidContainerFormat.GetPinnableReference(), pHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1954, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoRemoteGetHeaderProxy(this WindowsCodecs thisApi, Span<IWICMetadataWriterInfo> This, Span<Guid> guidContainerFormat, Span<MetadataHeader> pHeader)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoRemoteGetHeaderProxy(ref This.GetPinnableReference(), ref guidContainerFormat.GetPinnableReference(), ref pHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataWriterInfoRemoteGetHeaderStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataWriterInfoRemoteGetHeaderStub(This, _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataWriterInfoRemoteGetHeaderStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataWriterInfoRemoteGetHeaderStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataWriterInfoRemoteGetHeaderStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataWriterInfoRemoteGetHeaderStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataWriterInfoRemoteGetHeaderStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataWriterInfoRemoteGetHeaderStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataWriterInfoRemoteGetHeaderStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataWriterInfoRemoteGetHeaderStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataWriterInfoRemoteGetHeaderStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataWriterInfoRemoteGetHeaderStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataWriterInfoRemoteGetHeaderStub(this WindowsCodecs thisApi, Silk.NET.Core.Win32Extras.IRpcStubBuffer* This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataWriterInfoRemoteGetHeaderStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataWriterInfoRemoteGetHeaderStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataWriterInfoRemoteGetHeaderStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataWriterInfoRemoteGetHeaderStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataWriterInfoRemoteGetHeaderStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataWriterInfoRemoteGetHeaderStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataWriterInfoRemoteGetHeaderStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataWriterInfoRemoteGetHeaderStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Silk.NET.Core.Win32Extras.IRpcChannelBuffer* _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataWriterInfoRemoteGetHeaderStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataWriterInfoRemoteGetHeaderStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataWriterInfoRemoteGetHeaderStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataWriterInfoRemoteGetHeaderStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Silk.NET.Core.Win32Extras.RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataWriterInfoRemoteGetHeaderStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataWriterInfoRemoteGetHeaderStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataWriterInfoRemoteGetHeaderStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1960, Column 17 in wincodecsdk.h")]
        public static unsafe void IWICMetadataWriterInfoRemoteGetHeaderStub(this WindowsCodecs thisApi, Span<Silk.NET.Core.Win32Extras.IRpcStubBuffer> This, Span<Silk.NET.Core.Win32Extras.IRpcChannelBuffer> _pRpcChannelBuffer, Span<Silk.NET.Core.Win32Extras.RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IWICMetadataWriterInfoRemoteGetHeaderStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        public static unsafe int MatchMetadataContent(this WindowsCodecs thisApi, Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, Silk.NET.Core.Win32Extras.IStream* pIStream, Span<Guid> pguidMetadataFormat)
        {
            // SpanOverloader
            return thisApi.MatchMetadataContent(guidContainerFormat, pguidVendor, pIStream, ref pguidMetadataFormat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        public static unsafe int MatchMetadataContent(this WindowsCodecs thisApi, Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, Span<Silk.NET.Core.Win32Extras.IStream> pIStream, Guid* pguidMetadataFormat)
        {
            // SpanOverloader
            return thisApi.MatchMetadataContent(guidContainerFormat, pguidVendor, ref pIStream.GetPinnableReference(), pguidMetadataFormat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        public static unsafe int MatchMetadataContent(this WindowsCodecs thisApi, Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, Span<Silk.NET.Core.Win32Extras.IStream> pIStream, Span<Guid> pguidMetadataFormat)
        {
            // SpanOverloader
            return thisApi.MatchMetadataContent(guidContainerFormat, pguidVendor, ref pIStream.GetPinnableReference(), ref pguidMetadataFormat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        public static unsafe int MatchMetadataContent(this WindowsCodecs thisApi, Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, Silk.NET.Core.Win32Extras.IStream* pIStream, Guid* pguidMetadataFormat)
        {
            // SpanOverloader
            return thisApi.MatchMetadataContent(guidContainerFormat, in pguidVendor.GetPinnableReference(), pIStream, pguidMetadataFormat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        public static unsafe int MatchMetadataContent(this WindowsCodecs thisApi, Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, Silk.NET.Core.Win32Extras.IStream* pIStream, Span<Guid> pguidMetadataFormat)
        {
            // SpanOverloader
            return thisApi.MatchMetadataContent(guidContainerFormat, in pguidVendor.GetPinnableReference(), pIStream, ref pguidMetadataFormat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        public static unsafe int MatchMetadataContent(this WindowsCodecs thisApi, Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, Span<Silk.NET.Core.Win32Extras.IStream> pIStream, Guid* pguidMetadataFormat)
        {
            // SpanOverloader
            return thisApi.MatchMetadataContent(guidContainerFormat, in pguidVendor.GetPinnableReference(), ref pIStream.GetPinnableReference(), pguidMetadataFormat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        public static unsafe int MatchMetadataContent(this WindowsCodecs thisApi, Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, Span<Silk.NET.Core.Win32Extras.IStream> pIStream, Span<Guid> pguidMetadataFormat)
        {
            // SpanOverloader
            return thisApi.MatchMetadataContent(guidContainerFormat, in pguidVendor.GetPinnableReference(), ref pIStream.GetPinnableReference(), ref pguidMetadataFormat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        public static unsafe int MatchMetadataContent(this WindowsCodecs thisApi, Span<Guid> guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, Silk.NET.Core.Win32Extras.IStream* pIStream, Guid* pguidMetadataFormat)
        {
            // SpanOverloader
            return thisApi.MatchMetadataContent(ref guidContainerFormat.GetPinnableReference(), pguidVendor, pIStream, pguidMetadataFormat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        public static unsafe int MatchMetadataContent(this WindowsCodecs thisApi, Span<Guid> guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, Silk.NET.Core.Win32Extras.IStream* pIStream, Span<Guid> pguidMetadataFormat)
        {
            // SpanOverloader
            return thisApi.MatchMetadataContent(ref guidContainerFormat.GetPinnableReference(), pguidVendor, pIStream, ref pguidMetadataFormat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        public static unsafe int MatchMetadataContent(this WindowsCodecs thisApi, Span<Guid> guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, Span<Silk.NET.Core.Win32Extras.IStream> pIStream, Guid* pguidMetadataFormat)
        {
            // SpanOverloader
            return thisApi.MatchMetadataContent(ref guidContainerFormat.GetPinnableReference(), pguidVendor, ref pIStream.GetPinnableReference(), pguidMetadataFormat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        public static unsafe int MatchMetadataContent(this WindowsCodecs thisApi, Span<Guid> guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, Span<Silk.NET.Core.Win32Extras.IStream> pIStream, Span<Guid> pguidMetadataFormat)
        {
            // SpanOverloader
            return thisApi.MatchMetadataContent(ref guidContainerFormat.GetPinnableReference(), pguidVendor, ref pIStream.GetPinnableReference(), ref pguidMetadataFormat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        public static unsafe int MatchMetadataContent(this WindowsCodecs thisApi, Span<Guid> guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, Silk.NET.Core.Win32Extras.IStream* pIStream, Guid* pguidMetadataFormat)
        {
            // SpanOverloader
            return thisApi.MatchMetadataContent(ref guidContainerFormat.GetPinnableReference(), in pguidVendor.GetPinnableReference(), pIStream, pguidMetadataFormat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        public static unsafe int MatchMetadataContent(this WindowsCodecs thisApi, Span<Guid> guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, Silk.NET.Core.Win32Extras.IStream* pIStream, Span<Guid> pguidMetadataFormat)
        {
            // SpanOverloader
            return thisApi.MatchMetadataContent(ref guidContainerFormat.GetPinnableReference(), in pguidVendor.GetPinnableReference(), pIStream, ref pguidMetadataFormat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        public static unsafe int MatchMetadataContent(this WindowsCodecs thisApi, Span<Guid> guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, Span<Silk.NET.Core.Win32Extras.IStream> pIStream, Guid* pguidMetadataFormat)
        {
            // SpanOverloader
            return thisApi.MatchMetadataContent(ref guidContainerFormat.GetPinnableReference(), in pguidVendor.GetPinnableReference(), ref pIStream.GetPinnableReference(), pguidMetadataFormat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2403, Column 16 in wincodecsdk.h")]
        public static unsafe int MatchMetadataContent(this WindowsCodecs thisApi, Span<Guid> guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pguidVendor, Span<Silk.NET.Core.Win32Extras.IStream> pIStream, Span<Guid> pguidMetadataFormat)
        {
            // SpanOverloader
            return thisApi.MatchMetadataContent(ref guidContainerFormat.GetPinnableReference(), in pguidVendor.GetPinnableReference(), ref pIStream.GetPinnableReference(), ref pguidMetadataFormat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2409, Column 16 in wincodecsdk.h")]
        public static unsafe int SerializeMetadataContent(this WindowsCodecs thisApi, Guid* guidContainerFormat, IWICMetadataWriter* pIWriter, uint dwPersistOptions, Span<Silk.NET.Core.Win32Extras.IStream> pIStream)
        {
            // SpanOverloader
            return thisApi.SerializeMetadataContent(guidContainerFormat, pIWriter, dwPersistOptions, ref pIStream.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2409, Column 16 in wincodecsdk.h")]
        public static unsafe int SerializeMetadataContent(this WindowsCodecs thisApi, Guid* guidContainerFormat, Span<IWICMetadataWriter> pIWriter, uint dwPersistOptions, Silk.NET.Core.Win32Extras.IStream* pIStream)
        {
            // SpanOverloader
            return thisApi.SerializeMetadataContent(guidContainerFormat, ref pIWriter.GetPinnableReference(), dwPersistOptions, pIStream);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2409, Column 16 in wincodecsdk.h")]
        public static unsafe int SerializeMetadataContent(this WindowsCodecs thisApi, Guid* guidContainerFormat, Span<IWICMetadataWriter> pIWriter, uint dwPersistOptions, Span<Silk.NET.Core.Win32Extras.IStream> pIStream)
        {
            // SpanOverloader
            return thisApi.SerializeMetadataContent(guidContainerFormat, ref pIWriter.GetPinnableReference(), dwPersistOptions, ref pIStream.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2409, Column 16 in wincodecsdk.h")]
        public static unsafe int SerializeMetadataContent(this WindowsCodecs thisApi, Span<Guid> guidContainerFormat, IWICMetadataWriter* pIWriter, uint dwPersistOptions, Silk.NET.Core.Win32Extras.IStream* pIStream)
        {
            // SpanOverloader
            return thisApi.SerializeMetadataContent(ref guidContainerFormat.GetPinnableReference(), pIWriter, dwPersistOptions, pIStream);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2409, Column 16 in wincodecsdk.h")]
        public static unsafe int SerializeMetadataContent(this WindowsCodecs thisApi, Span<Guid> guidContainerFormat, IWICMetadataWriter* pIWriter, uint dwPersistOptions, Span<Silk.NET.Core.Win32Extras.IStream> pIStream)
        {
            // SpanOverloader
            return thisApi.SerializeMetadataContent(ref guidContainerFormat.GetPinnableReference(), pIWriter, dwPersistOptions, ref pIStream.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2409, Column 16 in wincodecsdk.h")]
        public static unsafe int SerializeMetadataContent(this WindowsCodecs thisApi, Span<Guid> guidContainerFormat, Span<IWICMetadataWriter> pIWriter, uint dwPersistOptions, Silk.NET.Core.Win32Extras.IStream* pIStream)
        {
            // SpanOverloader
            return thisApi.SerializeMetadataContent(ref guidContainerFormat.GetPinnableReference(), ref pIWriter.GetPinnableReference(), dwPersistOptions, pIStream);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2409, Column 16 in wincodecsdk.h")]
        public static unsafe int SerializeMetadataContent(this WindowsCodecs thisApi, Span<Guid> guidContainerFormat, Span<IWICMetadataWriter> pIWriter, uint dwPersistOptions, Span<Silk.NET.Core.Win32Extras.IStream> pIStream)
        {
            // SpanOverloader
            return thisApi.SerializeMetadataContent(ref guidContainerFormat.GetPinnableReference(), ref pIWriter.GetPinnableReference(), dwPersistOptions, ref pIStream.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2415, Column 16 in wincodecsdk.h")]
        public static unsafe int GetMetadataContentSize(this WindowsCodecs thisApi, Guid* guidContainerFormat, IWICMetadataWriter* pIWriter, Span<ulong> pcbSize)
        {
            // SpanOverloader
            return thisApi.GetMetadataContentSize(guidContainerFormat, pIWriter, ref pcbSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2415, Column 16 in wincodecsdk.h")]
        public static unsafe int GetMetadataContentSize(this WindowsCodecs thisApi, Guid* guidContainerFormat, Span<IWICMetadataWriter> pIWriter, ulong* pcbSize)
        {
            // SpanOverloader
            return thisApi.GetMetadataContentSize(guidContainerFormat, ref pIWriter.GetPinnableReference(), pcbSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2415, Column 16 in wincodecsdk.h")]
        public static unsafe int GetMetadataContentSize(this WindowsCodecs thisApi, Guid* guidContainerFormat, Span<IWICMetadataWriter> pIWriter, Span<ulong> pcbSize)
        {
            // SpanOverloader
            return thisApi.GetMetadataContentSize(guidContainerFormat, ref pIWriter.GetPinnableReference(), ref pcbSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2415, Column 16 in wincodecsdk.h")]
        public static unsafe int GetMetadataContentSize(this WindowsCodecs thisApi, Span<Guid> guidContainerFormat, IWICMetadataWriter* pIWriter, ulong* pcbSize)
        {
            // SpanOverloader
            return thisApi.GetMetadataContentSize(ref guidContainerFormat.GetPinnableReference(), pIWriter, pcbSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2415, Column 16 in wincodecsdk.h")]
        public static unsafe int GetMetadataContentSize(this WindowsCodecs thisApi, Span<Guid> guidContainerFormat, IWICMetadataWriter* pIWriter, Span<ulong> pcbSize)
        {
            // SpanOverloader
            return thisApi.GetMetadataContentSize(ref guidContainerFormat.GetPinnableReference(), pIWriter, ref pcbSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2415, Column 16 in wincodecsdk.h")]
        public static unsafe int GetMetadataContentSize(this WindowsCodecs thisApi, Span<Guid> guidContainerFormat, Span<IWICMetadataWriter> pIWriter, ulong* pcbSize)
        {
            // SpanOverloader
            return thisApi.GetMetadataContentSize(ref guidContainerFormat.GetPinnableReference(), ref pIWriter.GetPinnableReference(), pcbSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2415, Column 16 in wincodecsdk.h")]
        public static unsafe int GetMetadataContentSize(this WindowsCodecs thisApi, Span<Guid> guidContainerFormat, Span<IWICMetadataWriter> pIWriter, Span<ulong> pcbSize)
        {
            // SpanOverloader
            return thisApi.GetMetadataContentSize(ref guidContainerFormat.GetPinnableReference(), ref pIWriter.GetPinnableReference(), ref pcbSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2432, Column 39 in wincodecsdk.h")]
        public static unsafe uint CLIPFORMATUserSize(this WindowsCodecs thisApi, uint* arg0, uint arg1, Span<ushort> arg2)
        {
            // SpanOverloader
            return thisApi.CLIPFORMATUserSize(arg0, arg1, ref arg2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2432, Column 39 in wincodecsdk.h")]
        public static unsafe uint CLIPFORMATUserSize(this WindowsCodecs thisApi, Span<uint> arg0, uint arg1, ushort* arg2)
        {
            // SpanOverloader
            return thisApi.CLIPFORMATUserSize(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2432, Column 39 in wincodecsdk.h")]
        public static unsafe uint CLIPFORMATUserSize(this WindowsCodecs thisApi, Span<uint> arg0, uint arg1, Span<ushort> arg2)
        {
            // SpanOverloader
            return thisApi.CLIPFORMATUserSize(ref arg0.GetPinnableReference(), arg1, ref arg2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        public static unsafe byte* CLIPFORMATUserMarshal(this WindowsCodecs thisApi, uint* arg0, byte* arg1, Span<ushort> arg2)
        {
            // SpanOverloader
            return thisApi.CLIPFORMATUserMarshal(arg0, arg1, ref arg2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        public static unsafe byte* CLIPFORMATUserMarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, ushort* arg2)
        {
            // SpanOverloader
            return thisApi.CLIPFORMATUserMarshal(arg0, ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        public static unsafe byte* CLIPFORMATUserMarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, Span<ushort> arg2)
        {
            // SpanOverloader
            return thisApi.CLIPFORMATUserMarshal(arg0, ref arg1.GetPinnableReference(), ref arg2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        public static unsafe byte* CLIPFORMATUserMarshal(this WindowsCodecs thisApi, uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, Span<ushort> arg2)
        {
            // SpanOverloader
            return thisApi.CLIPFORMATUserMarshal(arg0, arg1, ref arg2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        public static unsafe byte* CLIPFORMATUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, ushort* arg2)
        {
            // SpanOverloader
            return thisApi.CLIPFORMATUserMarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        public static unsafe byte* CLIPFORMATUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, Span<ushort> arg2)
        {
            // SpanOverloader
            return thisApi.CLIPFORMATUserMarshal(ref arg0.GetPinnableReference(), arg1, ref arg2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        public static unsafe byte* CLIPFORMATUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, ushort* arg2)
        {
            // SpanOverloader
            return thisApi.CLIPFORMATUserMarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        public static unsafe byte* CLIPFORMATUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, Span<ushort> arg2)
        {
            // SpanOverloader
            return thisApi.CLIPFORMATUserMarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), ref arg2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        public static unsafe byte* CLIPFORMATUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ushort* arg2)
        {
            // SpanOverloader
            return thisApi.CLIPFORMATUserMarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2433, Column 29 in wincodecsdk.h")]
        public static unsafe byte* CLIPFORMATUserMarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, Span<ushort> arg2)
        {
            // SpanOverloader
            return thisApi.CLIPFORMATUserMarshal(ref arg0.GetPinnableReference(), arg1, ref arg2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        public static unsafe byte* CLIPFORMATUserUnmarshal(this WindowsCodecs thisApi, uint* arg0, byte* arg1, Span<ushort> arg2)
        {
            // SpanOverloader
            return thisApi.CLIPFORMATUserUnmarshal(arg0, arg1, ref arg2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        public static unsafe byte* CLIPFORMATUserUnmarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, ushort* arg2)
        {
            // SpanOverloader
            return thisApi.CLIPFORMATUserUnmarshal(arg0, ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        public static unsafe byte* CLIPFORMATUserUnmarshal(this WindowsCodecs thisApi, uint* arg0, Span<byte> arg1, Span<ushort> arg2)
        {
            // SpanOverloader
            return thisApi.CLIPFORMATUserUnmarshal(arg0, ref arg1.GetPinnableReference(), ref arg2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        public static unsafe byte* CLIPFORMATUserUnmarshal(this WindowsCodecs thisApi, uint* arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, Span<ushort> arg2)
        {
            // SpanOverloader
            return thisApi.CLIPFORMATUserUnmarshal(arg0, arg1, ref arg2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        public static unsafe byte* CLIPFORMATUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, ushort* arg2)
        {
            // SpanOverloader
            return thisApi.CLIPFORMATUserUnmarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        public static unsafe byte* CLIPFORMATUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, byte* arg1, Span<ushort> arg2)
        {
            // SpanOverloader
            return thisApi.CLIPFORMATUserUnmarshal(ref arg0.GetPinnableReference(), arg1, ref arg2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        public static unsafe byte* CLIPFORMATUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, ushort* arg2)
        {
            // SpanOverloader
            return thisApi.CLIPFORMATUserUnmarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        public static unsafe byte* CLIPFORMATUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, Span<byte> arg1, Span<ushort> arg2)
        {
            // SpanOverloader
            return thisApi.CLIPFORMATUserUnmarshal(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference(), ref arg2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        public static unsafe byte* CLIPFORMATUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, ushort* arg2)
        {
            // SpanOverloader
            return thisApi.CLIPFORMATUserUnmarshal(ref arg0.GetPinnableReference(), arg1, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 29 in wincodecsdk.h")]
        public static unsafe byte* CLIPFORMATUserUnmarshal(this WindowsCodecs thisApi, Span<uint> arg0, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, Span<ushort> arg2)
        {
            // SpanOverloader
            return thisApi.CLIPFORMATUserUnmarshal(ref arg0.GetPinnableReference(), arg1, ref arg2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2435, Column 39 in wincodecsdk.h")]
        public static unsafe void CLIPFORMATUserFree(this WindowsCodecs thisApi, uint* arg0, Span<ushort> arg1)
        {
            // SpanOverloader
            thisApi.CLIPFORMATUserFree(arg0, ref arg1.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2435, Column 39 in wincodecsdk.h")]
        public static unsafe void CLIPFORMATUserFree(this WindowsCodecs thisApi, Span<uint> arg0, ushort* arg1)
        {
            // SpanOverloader
            thisApi.CLIPFORMATUserFree(ref arg0.GetPinnableReference(), arg1);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2435, Column 39 in wincodecsdk.h")]
        public static unsafe void CLIPFORMATUserFree(this WindowsCodecs thisApi, Span<uint> arg0, Span<ushort> arg1)
        {
            // SpanOverloader
            thisApi.CLIPFORMATUserFree(ref arg0.GetPinnableReference(), ref arg1.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, Span<uint> pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(This, guidContainerFormat, cbSize, pPattern, pcCount, ref pcbActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, Span<uint> pcCount, uint* pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(This, guidContainerFormat, cbSize, pPattern, ref pcCount.GetPinnableReference(), pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, Span<uint> pcCount, Span<uint> pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(This, guidContainerFormat, cbSize, pPattern, ref pcCount.GetPinnableReference(), ref pcbActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Guid* guidContainerFormat, uint cbSize, Span<MetadataPattern> pPattern, uint* pcCount, uint* pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(This, guidContainerFormat, cbSize, ref pPattern.GetPinnableReference(), pcCount, pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Guid* guidContainerFormat, uint cbSize, Span<MetadataPattern> pPattern, uint* pcCount, Span<uint> pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(This, guidContainerFormat, cbSize, ref pPattern.GetPinnableReference(), pcCount, ref pcbActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Guid* guidContainerFormat, uint cbSize, Span<MetadataPattern> pPattern, Span<uint> pcCount, uint* pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(This, guidContainerFormat, cbSize, ref pPattern.GetPinnableReference(), ref pcCount.GetPinnableReference(), pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Guid* guidContainerFormat, uint cbSize, Span<MetadataPattern> pPattern, Span<uint> pcCount, Span<uint> pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(This, guidContainerFormat, cbSize, ref pPattern.GetPinnableReference(), ref pcCount.GetPinnableReference(), ref pcbActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Span<Guid> guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, uint* pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(This, ref guidContainerFormat.GetPinnableReference(), cbSize, pPattern, pcCount, pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Span<Guid> guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, Span<uint> pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(This, ref guidContainerFormat.GetPinnableReference(), cbSize, pPattern, pcCount, ref pcbActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Span<Guid> guidContainerFormat, uint cbSize, MetadataPattern* pPattern, Span<uint> pcCount, uint* pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(This, ref guidContainerFormat.GetPinnableReference(), cbSize, pPattern, ref pcCount.GetPinnableReference(), pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Span<Guid> guidContainerFormat, uint cbSize, MetadataPattern* pPattern, Span<uint> pcCount, Span<uint> pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(This, ref guidContainerFormat.GetPinnableReference(), cbSize, pPattern, ref pcCount.GetPinnableReference(), ref pcbActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Span<Guid> guidContainerFormat, uint cbSize, Span<MetadataPattern> pPattern, uint* pcCount, uint* pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(This, ref guidContainerFormat.GetPinnableReference(), cbSize, ref pPattern.GetPinnableReference(), pcCount, pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Span<Guid> guidContainerFormat, uint cbSize, Span<MetadataPattern> pPattern, uint* pcCount, Span<uint> pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(This, ref guidContainerFormat.GetPinnableReference(), cbSize, ref pPattern.GetPinnableReference(), pcCount, ref pcbActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Span<Guid> guidContainerFormat, uint cbSize, Span<MetadataPattern> pPattern, Span<uint> pcCount, uint* pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(This, ref guidContainerFormat.GetPinnableReference(), cbSize, ref pPattern.GetPinnableReference(), ref pcCount.GetPinnableReference(), pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Span<Guid> guidContainerFormat, uint cbSize, Span<MetadataPattern> pPattern, Span<uint> pcCount, Span<uint> pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(This, ref guidContainerFormat.GetPinnableReference(), cbSize, ref pPattern.GetPinnableReference(), ref pcCount.GetPinnableReference(), ref pcbActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, uint* pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(ref This.GetPinnableReference(), guidContainerFormat, cbSize, pPattern, pcCount, pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, Span<uint> pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(ref This.GetPinnableReference(), guidContainerFormat, cbSize, pPattern, pcCount, ref pcbActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, Span<uint> pcCount, uint* pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(ref This.GetPinnableReference(), guidContainerFormat, cbSize, pPattern, ref pcCount.GetPinnableReference(), pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, Span<uint> pcCount, Span<uint> pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(ref This.GetPinnableReference(), guidContainerFormat, cbSize, pPattern, ref pcCount.GetPinnableReference(), ref pcbActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Guid* guidContainerFormat, uint cbSize, Span<MetadataPattern> pPattern, uint* pcCount, uint* pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(ref This.GetPinnableReference(), guidContainerFormat, cbSize, ref pPattern.GetPinnableReference(), pcCount, pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Guid* guidContainerFormat, uint cbSize, Span<MetadataPattern> pPattern, uint* pcCount, Span<uint> pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(ref This.GetPinnableReference(), guidContainerFormat, cbSize, ref pPattern.GetPinnableReference(), pcCount, ref pcbActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Guid* guidContainerFormat, uint cbSize, Span<MetadataPattern> pPattern, Span<uint> pcCount, uint* pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(ref This.GetPinnableReference(), guidContainerFormat, cbSize, ref pPattern.GetPinnableReference(), ref pcCount.GetPinnableReference(), pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Guid* guidContainerFormat, uint cbSize, Span<MetadataPattern> pPattern, Span<uint> pcCount, Span<uint> pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(ref This.GetPinnableReference(), guidContainerFormat, cbSize, ref pPattern.GetPinnableReference(), ref pcCount.GetPinnableReference(), ref pcbActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Span<Guid> guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, uint* pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(ref This.GetPinnableReference(), ref guidContainerFormat.GetPinnableReference(), cbSize, pPattern, pcCount, pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Span<Guid> guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, Span<uint> pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(ref This.GetPinnableReference(), ref guidContainerFormat.GetPinnableReference(), cbSize, pPattern, pcCount, ref pcbActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Span<Guid> guidContainerFormat, uint cbSize, MetadataPattern* pPattern, Span<uint> pcCount, uint* pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(ref This.GetPinnableReference(), ref guidContainerFormat.GetPinnableReference(), cbSize, pPattern, ref pcCount.GetPinnableReference(), pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Span<Guid> guidContainerFormat, uint cbSize, MetadataPattern* pPattern, Span<uint> pcCount, Span<uint> pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(ref This.GetPinnableReference(), ref guidContainerFormat.GetPinnableReference(), cbSize, pPattern, ref pcCount.GetPinnableReference(), ref pcbActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Span<Guid> guidContainerFormat, uint cbSize, Span<MetadataPattern> pPattern, uint* pcCount, uint* pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(ref This.GetPinnableReference(), ref guidContainerFormat.GetPinnableReference(), cbSize, ref pPattern.GetPinnableReference(), pcCount, pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Span<Guid> guidContainerFormat, uint cbSize, Span<MetadataPattern> pPattern, uint* pcCount, Span<uint> pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(ref This.GetPinnableReference(), ref guidContainerFormat.GetPinnableReference(), cbSize, ref pPattern.GetPinnableReference(), pcCount, ref pcbActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Span<Guid> guidContainerFormat, uint cbSize, Span<MetadataPattern> pPattern, Span<uint> pcCount, uint* pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(ref This.GetPinnableReference(), ref guidContainerFormat.GetPinnableReference(), cbSize, ref pPattern.GetPinnableReference(), ref pcCount.GetPinnableReference(), pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2442, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsProxy(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Span<Guid> guidContainerFormat, uint cbSize, Span<MetadataPattern> pPattern, Span<uint> pcCount, Span<uint> pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsProxy(ref This.GetPinnableReference(), ref guidContainerFormat.GetPinnableReference(), cbSize, ref pPattern.GetPinnableReference(), ref pcCount.GetPinnableReference(), ref pcbActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsStub(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Guid* guidContainerFormat, MetadataPattern** ppPatterns, Span<uint> pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsStub(This, guidContainerFormat, ppPatterns, ref pcPatterns.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsStub(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Guid* guidContainerFormat, ref MetadataPattern* ppPatterns, Span<uint> pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsStub(This, guidContainerFormat, ref ppPatterns, ref pcPatterns.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsStub(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Span<Guid> guidContainerFormat, MetadataPattern** ppPatterns, uint* pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsStub(This, ref guidContainerFormat.GetPinnableReference(), ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsStub(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Span<Guid> guidContainerFormat, MetadataPattern** ppPatterns, Span<uint> pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsStub(This, ref guidContainerFormat.GetPinnableReference(), ppPatterns, ref pcPatterns.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsStub(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Span<Guid> guidContainerFormat, ref MetadataPattern* ppPatterns, uint* pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsStub(This, ref guidContainerFormat.GetPinnableReference(), ref ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsStub(this WindowsCodecs thisApi, IWICMetadataReaderInfo* This, Span<Guid> guidContainerFormat, ref MetadataPattern* ppPatterns, Span<uint> pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsStub(This, ref guidContainerFormat.GetPinnableReference(), ref ppPatterns, ref pcPatterns.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsStub(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Guid* guidContainerFormat, MetadataPattern** ppPatterns, uint* pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsStub(ref This.GetPinnableReference(), guidContainerFormat, ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsStub(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Guid* guidContainerFormat, MetadataPattern** ppPatterns, Span<uint> pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsStub(ref This.GetPinnableReference(), guidContainerFormat, ppPatterns, ref pcPatterns.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsStub(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Guid* guidContainerFormat, ref MetadataPattern* ppPatterns, uint* pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsStub(ref This.GetPinnableReference(), guidContainerFormat, ref ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsStub(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Guid* guidContainerFormat, ref MetadataPattern* ppPatterns, Span<uint> pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsStub(ref This.GetPinnableReference(), guidContainerFormat, ref ppPatterns, ref pcPatterns.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsStub(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Span<Guid> guidContainerFormat, MetadataPattern** ppPatterns, uint* pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsStub(ref This.GetPinnableReference(), ref guidContainerFormat.GetPinnableReference(), ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsStub(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Span<Guid> guidContainerFormat, MetadataPattern** ppPatterns, Span<uint> pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsStub(ref This.GetPinnableReference(), ref guidContainerFormat.GetPinnableReference(), ppPatterns, ref pcPatterns.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsStub(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Span<Guid> guidContainerFormat, ref MetadataPattern* ppPatterns, uint* pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsStub(ref This.GetPinnableReference(), ref guidContainerFormat.GetPinnableReference(), ref ppPatterns, pcPatterns);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2454, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataReaderInfoGetPatternsStub(this WindowsCodecs thisApi, Span<IWICMetadataReaderInfo> This, Span<Guid> guidContainerFormat, ref MetadataPattern* ppPatterns, Span<uint> pcPatterns)
        {
            // SpanOverloader
            return thisApi.IWICMetadataReaderInfoGetPatternsStub(ref This.GetPinnableReference(), ref guidContainerFormat.GetPinnableReference(), ref ppPatterns, ref pcPatterns.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoGetHeaderProxy(this WindowsCodecs thisApi, IWICMetadataWriterInfo* This, Guid* guidContainerFormat, uint cbSize, MetadataHeader* pHeader, Span<uint> pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoGetHeaderProxy(This, guidContainerFormat, cbSize, pHeader, ref pcbActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoGetHeaderProxy(this WindowsCodecs thisApi, IWICMetadataWriterInfo* This, Guid* guidContainerFormat, uint cbSize, Span<MetadataHeader> pHeader, uint* pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoGetHeaderProxy(This, guidContainerFormat, cbSize, ref pHeader.GetPinnableReference(), pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoGetHeaderProxy(this WindowsCodecs thisApi, IWICMetadataWriterInfo* This, Guid* guidContainerFormat, uint cbSize, Span<MetadataHeader> pHeader, Span<uint> pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoGetHeaderProxy(This, guidContainerFormat, cbSize, ref pHeader.GetPinnableReference(), ref pcbActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoGetHeaderProxy(this WindowsCodecs thisApi, IWICMetadataWriterInfo* This, Span<Guid> guidContainerFormat, uint cbSize, MetadataHeader* pHeader, uint* pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoGetHeaderProxy(This, ref guidContainerFormat.GetPinnableReference(), cbSize, pHeader, pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoGetHeaderProxy(this WindowsCodecs thisApi, IWICMetadataWriterInfo* This, Span<Guid> guidContainerFormat, uint cbSize, MetadataHeader* pHeader, Span<uint> pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoGetHeaderProxy(This, ref guidContainerFormat.GetPinnableReference(), cbSize, pHeader, ref pcbActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoGetHeaderProxy(this WindowsCodecs thisApi, IWICMetadataWriterInfo* This, Span<Guid> guidContainerFormat, uint cbSize, Span<MetadataHeader> pHeader, uint* pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoGetHeaderProxy(This, ref guidContainerFormat.GetPinnableReference(), cbSize, ref pHeader.GetPinnableReference(), pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoGetHeaderProxy(this WindowsCodecs thisApi, IWICMetadataWriterInfo* This, Span<Guid> guidContainerFormat, uint cbSize, Span<MetadataHeader> pHeader, Span<uint> pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoGetHeaderProxy(This, ref guidContainerFormat.GetPinnableReference(), cbSize, ref pHeader.GetPinnableReference(), ref pcbActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoGetHeaderProxy(this WindowsCodecs thisApi, Span<IWICMetadataWriterInfo> This, Guid* guidContainerFormat, uint cbSize, MetadataHeader* pHeader, uint* pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoGetHeaderProxy(ref This.GetPinnableReference(), guidContainerFormat, cbSize, pHeader, pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoGetHeaderProxy(this WindowsCodecs thisApi, Span<IWICMetadataWriterInfo> This, Guid* guidContainerFormat, uint cbSize, MetadataHeader* pHeader, Span<uint> pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoGetHeaderProxy(ref This.GetPinnableReference(), guidContainerFormat, cbSize, pHeader, ref pcbActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoGetHeaderProxy(this WindowsCodecs thisApi, Span<IWICMetadataWriterInfo> This, Guid* guidContainerFormat, uint cbSize, Span<MetadataHeader> pHeader, uint* pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoGetHeaderProxy(ref This.GetPinnableReference(), guidContainerFormat, cbSize, ref pHeader.GetPinnableReference(), pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoGetHeaderProxy(this WindowsCodecs thisApi, Span<IWICMetadataWriterInfo> This, Guid* guidContainerFormat, uint cbSize, Span<MetadataHeader> pHeader, Span<uint> pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoGetHeaderProxy(ref This.GetPinnableReference(), guidContainerFormat, cbSize, ref pHeader.GetPinnableReference(), ref pcbActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoGetHeaderProxy(this WindowsCodecs thisApi, Span<IWICMetadataWriterInfo> This, Span<Guid> guidContainerFormat, uint cbSize, MetadataHeader* pHeader, uint* pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoGetHeaderProxy(ref This.GetPinnableReference(), ref guidContainerFormat.GetPinnableReference(), cbSize, pHeader, pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoGetHeaderProxy(this WindowsCodecs thisApi, Span<IWICMetadataWriterInfo> This, Span<Guid> guidContainerFormat, uint cbSize, MetadataHeader* pHeader, Span<uint> pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoGetHeaderProxy(ref This.GetPinnableReference(), ref guidContainerFormat.GetPinnableReference(), cbSize, pHeader, ref pcbActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoGetHeaderProxy(this WindowsCodecs thisApi, Span<IWICMetadataWriterInfo> This, Span<Guid> guidContainerFormat, uint cbSize, Span<MetadataHeader> pHeader, uint* pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoGetHeaderProxy(ref This.GetPinnableReference(), ref guidContainerFormat.GetPinnableReference(), cbSize, ref pHeader.GetPinnableReference(), pcbActual);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2460, Column 41 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoGetHeaderProxy(this WindowsCodecs thisApi, Span<IWICMetadataWriterInfo> This, Span<Guid> guidContainerFormat, uint cbSize, Span<MetadataHeader> pHeader, Span<uint> pcbActual)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoGetHeaderProxy(ref This.GetPinnableReference(), ref guidContainerFormat.GetPinnableReference(), cbSize, ref pHeader.GetPinnableReference(), ref pcbActual.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoGetHeaderStub(this WindowsCodecs thisApi, IWICMetadataWriterInfo* This, Guid* guidContainerFormat, Span<MetadataHeader> pHeader)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoGetHeaderStub(This, guidContainerFormat, ref pHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoGetHeaderStub(this WindowsCodecs thisApi, IWICMetadataWriterInfo* This, Span<Guid> guidContainerFormat, MetadataHeader* pHeader)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoGetHeaderStub(This, ref guidContainerFormat.GetPinnableReference(), pHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoGetHeaderStub(this WindowsCodecs thisApi, IWICMetadataWriterInfo* This, Span<Guid> guidContainerFormat, Span<MetadataHeader> pHeader)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoGetHeaderStub(This, ref guidContainerFormat.GetPinnableReference(), ref pHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoGetHeaderStub(this WindowsCodecs thisApi, Span<IWICMetadataWriterInfo> This, Guid* guidContainerFormat, MetadataHeader* pHeader)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoGetHeaderStub(ref This.GetPinnableReference(), guidContainerFormat, pHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoGetHeaderStub(this WindowsCodecs thisApi, Span<IWICMetadataWriterInfo> This, Guid* guidContainerFormat, Span<MetadataHeader> pHeader)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoGetHeaderStub(ref This.GetPinnableReference(), guidContainerFormat, ref pHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoGetHeaderStub(this WindowsCodecs thisApi, Span<IWICMetadataWriterInfo> This, Span<Guid> guidContainerFormat, MetadataHeader* pHeader)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoGetHeaderStub(ref This.GetPinnableReference(), ref guidContainerFormat.GetPinnableReference(), pHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 43 in wincodecsdk.h")]
        public static unsafe int IWICMetadataWriterInfoGetHeaderStub(this WindowsCodecs thisApi, Span<IWICMetadataWriterInfo> This, Span<Guid> guidContainerFormat, Span<MetadataHeader> pHeader)
        {
            // SpanOverloader
            return thisApi.IWICMetadataWriterInfoGetHeaderStub(ref This.GetPinnableReference(), ref guidContainerFormat.GetPinnableReference(), ref pHeader.GetPinnableReference());
        }

    }
}

