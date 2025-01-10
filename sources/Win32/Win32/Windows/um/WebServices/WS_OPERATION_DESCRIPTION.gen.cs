// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct WS_OPERATION_DESCRIPTION
{
    [NativeTypeName("ULONG")]
    public uint versionInfo;
    public WS_MESSAGE_DESCRIPTION* inputMessageDescription;
    public WS_MESSAGE_DESCRIPTION* outputMessageDescription;

    [NativeTypeName("ULONG")]
    public uint inputMessageOptions;

    [NativeTypeName("ULONG")]
    public uint outputMessageOptions;
    public ushort parameterCount;
    public WS_PARAMETER_DESCRIPTION* parameterDescription;

    [NativeTypeName("WS_SERVICE_STUB_CALLBACK")]
    public delegate* unmanaged<void*, void*, void*, WS_ASYNC_CONTEXT*, void*, HRESULT> stubCallback;
    public WS_OPERATION_STYLE style;
}
