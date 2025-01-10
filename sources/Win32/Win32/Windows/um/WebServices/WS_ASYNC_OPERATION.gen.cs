// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct WS_ASYNC_OPERATION
{
    [NativeTypeName("WS_ASYNC_FUNCTION")]
    public delegate* unmanaged<
        HRESULT,
        WS_CALLBACK_MODEL,
        void*,
        WS_ASYNC_OPERATION*,
        WS_ASYNC_CONTEXT*,
        void*,
        HRESULT> function;
}
