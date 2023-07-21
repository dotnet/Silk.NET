// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='WS_CHANNEL_DECODER.xml' path='doc/member[@name="WS_CHANNEL_DECODER"]/*' />
public unsafe partial struct WS_CHANNEL_DECODER
{
    /// <include file='WS_CHANNEL_DECODER.xml' path='doc/member[@name="WS_CHANNEL_DECODER.createContext"]/*' />
    public void* createContext;

    /// <include file='WS_CHANNEL_DECODER.xml' path='doc/member[@name="WS_CHANNEL_DECODER.createDecoderCallback"]/*' />
    [NativeTypeName("WS_CREATE_DECODER_CALLBACK")]
    public delegate* unmanaged<void*, delegate* unmanaged<void*, void*, uint, uint*, WS_ASYNC_CONTEXT*, IntPtr, HRESULT>, void*, void**, IntPtr, HRESULT> createDecoderCallback;

    /// <include file='WS_CHANNEL_DECODER.xml' path='doc/member[@name="WS_CHANNEL_DECODER.decoderGetContentTypeCallback"]/*' />
    [NativeTypeName("WS_DECODER_GET_CONTENT_TYPE_CALLBACK")]
    public delegate* unmanaged<void*, WS_STRING*, WS_STRING*, WS_STRING*, IntPtr, HRESULT> decoderGetContentTypeCallback;

    /// <include file='WS_CHANNEL_DECODER.xml' path='doc/member[@name="WS_CHANNEL_DECODER.decoderStartCallback"]/*' />
    [NativeTypeName("WS_DECODER_START_CALLBACK")]
    public delegate* unmanaged<void*, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> decoderStartCallback;

    /// <include file='WS_CHANNEL_DECODER.xml' path='doc/member[@name="WS_CHANNEL_DECODER.decoderDecodeCallback"]/*' />
    [NativeTypeName("WS_DECODER_DECODE_CALLBACK")]
    public delegate* unmanaged<void*, void*, uint, uint*, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> decoderDecodeCallback;

    /// <include file='WS_CHANNEL_DECODER.xml' path='doc/member[@name="WS_CHANNEL_DECODER.decoderEndCallback"]/*' />
    [NativeTypeName("WS_DECODER_END_CALLBACK")]
    public delegate* unmanaged<void*, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> decoderEndCallback;

    /// <include file='WS_CHANNEL_DECODER.xml' path='doc/member[@name="WS_CHANNEL_DECODER.freeDecoderCallback"]/*' />
    [NativeTypeName("WS_FREE_DECODER_CALLBACK")]
    public delegate* unmanaged<void*, void> freeDecoderCallback;
}
