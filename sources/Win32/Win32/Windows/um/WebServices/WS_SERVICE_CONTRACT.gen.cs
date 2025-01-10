// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct WS_SERVICE_CONTRACT
{
    [NativeTypeName("const WS_CONTRACT_DESCRIPTION *")]
    public WS_CONTRACT_DESCRIPTION* contractDescription;

    [NativeTypeName("WS_SERVICE_MESSAGE_RECEIVE_CALLBACK")]
    public delegate* unmanaged<
        void*,
        WS_ASYNC_CONTEXT*,
        void*,
        HRESULT> defaultMessageHandlerCallback;

    [NativeTypeName("const void *")]
    public void* methodTable;
}
