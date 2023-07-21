// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_ASYNC_CONTEXT.xml' path='doc/member[@name="WS_ASYNC_CONTEXT"]/*' />
public unsafe partial struct WS_ASYNC_CONTEXT
{
    /// <include file='WS_ASYNC_CONTEXT.xml' path='doc/member[@name="WS_ASYNC_CONTEXT.callback"]/*' />
    [NativeTypeName("WS_ASYNC_CALLBACK")]
    public delegate* unmanaged<HRESULT, WS_CALLBACK_MODEL, void*, void> callback;

    /// <include file='WS_ASYNC_CONTEXT.xml' path='doc/member[@name="WS_ASYNC_CONTEXT.callbackState"]/*' />
    public void* callbackState;
}
