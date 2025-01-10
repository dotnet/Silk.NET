// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct WS_CHANNEL_DECODER
{
    public void* createContext;

    [NativeTypeName("WS_CREATE_DECODER_CALLBACK")]
    public delegate* unmanaged<
        void*,
        delegate* unmanaged<void*, void*, uint, uint*, WS_ASYNC_CONTEXT*, void*, HRESULT>,
        void*,
        void**,
        void*,
        HRESULT> createDecoderCallback;

    [NativeTypeName("WS_DECODER_GET_CONTENT_TYPE_CALLBACK")]
    public delegate* unmanaged<
        void*,
        WS_STRING*,
        WS_STRING*,
        WS_STRING*,
        void*,
        HRESULT> decoderGetContentTypeCallback;

    [NativeTypeName("WS_DECODER_START_CALLBACK")]
    public delegate* unmanaged<void*, WS_ASYNC_CONTEXT*, void*, HRESULT> decoderStartCallback;

    [NativeTypeName("WS_DECODER_DECODE_CALLBACK")]
    public delegate* unmanaged<
        void*,
        void*,
        uint,
        uint*,
        WS_ASYNC_CONTEXT*,
        void*,
        HRESULT> decoderDecodeCallback;

    [NativeTypeName("WS_DECODER_END_CALLBACK")]
    public delegate* unmanaged<void*, WS_ASYNC_CONTEXT*, void*, HRESULT> decoderEndCallback;

    [NativeTypeName("WS_FREE_DECODER_CALLBACK")]
    public delegate* unmanaged<void*, void> freeDecoderCallback;
}
