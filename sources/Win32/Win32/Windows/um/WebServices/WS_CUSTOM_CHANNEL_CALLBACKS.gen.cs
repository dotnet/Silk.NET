// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct WS_CUSTOM_CHANNEL_CALLBACKS
{
    [NativeTypeName("WS_CREATE_CHANNEL_CALLBACK")]
    public delegate* unmanaged<
        WS_CHANNEL_TYPE,
        void*,
        uint,
        void**,
        void*,
        HRESULT> createChannelCallback;

    [NativeTypeName("WS_FREE_CHANNEL_CALLBACK")]
    public delegate* unmanaged<void*, void> freeChannelCallback;

    [NativeTypeName("WS_RESET_CHANNEL_CALLBACK")]
    public delegate* unmanaged<void*, void*, HRESULT> resetChannelCallback;

    [NativeTypeName("WS_OPEN_CHANNEL_CALLBACK")]
    public delegate* unmanaged<
        void*,
        WS_ENDPOINT_ADDRESS*,
        WS_ASYNC_CONTEXT*,
        void*,
        HRESULT> openChannelCallback;

    [NativeTypeName("WS_CLOSE_CHANNEL_CALLBACK")]
    public delegate* unmanaged<void*, WS_ASYNC_CONTEXT*, void*, HRESULT> closeChannelCallback;

    [NativeTypeName("WS_ABORT_CHANNEL_CALLBACK")]
    public delegate* unmanaged<void*, void*, HRESULT> abortChannelCallback;

    [NativeTypeName("WS_GET_CHANNEL_PROPERTY_CALLBACK")]
    public delegate* unmanaged<
        void*,
        WS_CHANNEL_PROPERTY_ID,
        void*,
        uint,
        void*,
        HRESULT> getChannelPropertyCallback;

    [NativeTypeName("WS_SET_CHANNEL_PROPERTY_CALLBACK")]
    public delegate* unmanaged<
        void*,
        WS_CHANNEL_PROPERTY_ID,
        void*,
        uint,
        void*,
        HRESULT> setChannelPropertyCallback;

    [NativeTypeName("WS_WRITE_MESSAGE_START_CALLBACK")]
    public delegate* unmanaged<
        void*,
        void*,
        WS_ASYNC_CONTEXT*,
        void*,
        HRESULT> writeMessageStartCallback;

    [NativeTypeName("WS_WRITE_MESSAGE_END_CALLBACK")]
    public delegate* unmanaged<
        void*,
        void*,
        WS_ASYNC_CONTEXT*,
        void*,
        HRESULT> writeMessageEndCallback;

    [NativeTypeName("WS_READ_MESSAGE_START_CALLBACK")]
    public delegate* unmanaged<
        void*,
        void*,
        WS_ASYNC_CONTEXT*,
        void*,
        HRESULT> readMessageStartCallback;

    [NativeTypeName("WS_READ_MESSAGE_END_CALLBACK")]
    public delegate* unmanaged<
        void*,
        void*,
        WS_ASYNC_CONTEXT*,
        void*,
        HRESULT> readMessageEndCallback;

    [NativeTypeName("WS_ABANDON_MESSAGE_CALLBACK")]
    public delegate* unmanaged<void*, void*, void*, HRESULT> abandonMessageCallback;

    [NativeTypeName("WS_SHUTDOWN_SESSION_CHANNEL_CALLBACK")]
    public delegate* unmanaged<
        void*,
        WS_ASYNC_CONTEXT*,
        void*,
        HRESULT> shutdownSessionChannelCallback;
}
