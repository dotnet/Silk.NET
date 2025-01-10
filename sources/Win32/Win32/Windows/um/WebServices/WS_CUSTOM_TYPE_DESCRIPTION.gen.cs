// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct WS_CUSTOM_TYPE_DESCRIPTION
{
    [NativeTypeName("ULONG")]
    public uint size;

    [NativeTypeName("ULONG")]
    public uint alignment;

    [NativeTypeName("WS_READ_TYPE_CALLBACK")]
    public delegate* unmanaged<
        void*,
        WS_TYPE_MAPPING,
        void*,
        void*,
        void*,
        uint,
        void*,
        HRESULT> readCallback;

    [NativeTypeName("WS_WRITE_TYPE_CALLBACK")]
    public delegate* unmanaged<
        void*,
        WS_TYPE_MAPPING,
        void*,
        void*,
        uint,
        void*,
        HRESULT> writeCallback;
    public void* descriptionData;

    [NativeTypeName("WS_IS_DEFAULT_VALUE_CALLBACK")]
    public delegate* unmanaged<
        void*,
        void*,
        void*,
        uint,
        BOOL*,
        void*,
        HRESULT> isDefaultValueCallback;
}
