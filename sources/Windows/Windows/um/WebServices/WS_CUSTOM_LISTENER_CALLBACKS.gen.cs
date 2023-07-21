// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='WS_CUSTOM_LISTENER_CALLBACKS.xml' path='doc/member[@name="WS_CUSTOM_LISTENER_CALLBACKS"]/*' />
public unsafe partial struct WS_CUSTOM_LISTENER_CALLBACKS
{
    /// <include file='WS_CUSTOM_LISTENER_CALLBACKS.xml' path='doc/member[@name="WS_CUSTOM_LISTENER_CALLBACKS.createListenerCallback"]/*' />
    [NativeTypeName("WS_CREATE_LISTENER_CALLBACK")]
    public delegate* unmanaged<WS_CHANNEL_TYPE, void*, uint, void**, IntPtr, HRESULT> createListenerCallback;

    /// <include file='WS_CUSTOM_LISTENER_CALLBACKS.xml' path='doc/member[@name="WS_CUSTOM_LISTENER_CALLBACKS.freeListenerCallback"]/*' />
    [NativeTypeName("WS_FREE_LISTENER_CALLBACK")]
    public delegate* unmanaged<void*, void> freeListenerCallback;

    /// <include file='WS_CUSTOM_LISTENER_CALLBACKS.xml' path='doc/member[@name="WS_CUSTOM_LISTENER_CALLBACKS.resetListenerCallback"]/*' />
    [NativeTypeName("WS_RESET_LISTENER_CALLBACK")]
    public delegate* unmanaged<void*, IntPtr, HRESULT> resetListenerCallback;

    /// <include file='WS_CUSTOM_LISTENER_CALLBACKS.xml' path='doc/member[@name="WS_CUSTOM_LISTENER_CALLBACKS.openListenerCallback"]/*' />
    [NativeTypeName("WS_OPEN_LISTENER_CALLBACK")]
    public delegate* unmanaged<void*, WS_STRING*, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> openListenerCallback;

    /// <include file='WS_CUSTOM_LISTENER_CALLBACKS.xml' path='doc/member[@name="WS_CUSTOM_LISTENER_CALLBACKS.closeListenerCallback"]/*' />
    [NativeTypeName("WS_CLOSE_LISTENER_CALLBACK")]
    public delegate* unmanaged<void*, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> closeListenerCallback;

    /// <include file='WS_CUSTOM_LISTENER_CALLBACKS.xml' path='doc/member[@name="WS_CUSTOM_LISTENER_CALLBACKS.abortListenerCallback"]/*' />
    [NativeTypeName("WS_ABORT_LISTENER_CALLBACK")]
    public delegate* unmanaged<void*, IntPtr, HRESULT> abortListenerCallback;

    /// <include file='WS_CUSTOM_LISTENER_CALLBACKS.xml' path='doc/member[@name="WS_CUSTOM_LISTENER_CALLBACKS.getListenerPropertyCallback"]/*' />
    [NativeTypeName("WS_GET_LISTENER_PROPERTY_CALLBACK")]
    public delegate* unmanaged<void*, WS_LISTENER_PROPERTY_ID, void*, uint, IntPtr, HRESULT> getListenerPropertyCallback;

    /// <include file='WS_CUSTOM_LISTENER_CALLBACKS.xml' path='doc/member[@name="WS_CUSTOM_LISTENER_CALLBACKS.setListenerPropertyCallback"]/*' />
    [NativeTypeName("WS_SET_LISTENER_PROPERTY_CALLBACK")]
    public delegate* unmanaged<void*, WS_LISTENER_PROPERTY_ID, void*, uint, IntPtr, HRESULT> setListenerPropertyCallback;

    /// <include file='WS_CUSTOM_LISTENER_CALLBACKS.xml' path='doc/member[@name="WS_CUSTOM_LISTENER_CALLBACKS.createChannelForListenerCallback"]/*' />
    [NativeTypeName("WS_CREATE_CHANNEL_FOR_LISTENER_CALLBACK")]
    public delegate* unmanaged<void*, void*, uint, void**, IntPtr, HRESULT> createChannelForListenerCallback;

    /// <include file='WS_CUSTOM_LISTENER_CALLBACKS.xml' path='doc/member[@name="WS_CUSTOM_LISTENER_CALLBACKS.acceptChannelCallback"]/*' />
    [NativeTypeName("WS_ACCEPT_CHANNEL_CALLBACK")]
    public delegate* unmanaged<void*, void*, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> acceptChannelCallback;
}
