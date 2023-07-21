// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='WS_SERVICE_CONTRACT.xml' path='doc/member[@name="WS_SERVICE_CONTRACT"]/*' />
public unsafe partial struct WS_SERVICE_CONTRACT
{
    /// <include file='WS_SERVICE_CONTRACT.xml' path='doc/member[@name="WS_SERVICE_CONTRACT.contractDescription"]/*' />
    [NativeTypeName("const WS_CONTRACT_DESCRIPTION *")]
    public WS_CONTRACT_DESCRIPTION* contractDescription;

    /// <include file='WS_SERVICE_CONTRACT.xml' path='doc/member[@name="WS_SERVICE_CONTRACT.defaultMessageHandlerCallback"]/*' />
    [NativeTypeName("WS_SERVICE_MESSAGE_RECEIVE_CALLBACK")]
    public delegate* unmanaged<IntPtr, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> defaultMessageHandlerCallback;

    /// <include file='WS_SERVICE_CONTRACT.xml' path='doc/member[@name="WS_SERVICE_CONTRACT.methodTable"]/*' />
    [NativeTypeName("const void *")]
    public void* methodTable;
}
