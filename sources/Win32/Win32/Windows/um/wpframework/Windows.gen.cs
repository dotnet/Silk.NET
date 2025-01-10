// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport(
        "webengine4",
        EntryPoint = "?LoadManagedRuntime@@YAJPEB_WPEAPEAUIUnknown@@@Z",
        ExactSpelling = true
    )]
    public static extern HRESULT LoadManagedRuntime(
        [NativeTypeName("PCWSTR")] ushort* pwszRuntimeVersion,
        IUnknown* ppManagedRuntimeHost
    );

    [NativeTypeName("#define MANAGED_RUNTIME_LOADER_FUNCTION \"LoadManagedRuntime\"")]
    public static ReadOnlySpan<byte> MANAGED_RUNTIME_LOADER_FUNCTION => "LoadManagedRuntime"u8;

    [NativeTypeName("#define MANAGED_RUNTIME_LOADER_EX_FUNCTION \"LoadManagedRuntimeEx\"")]
    public static ReadOnlySpan<byte> MANAGED_RUNTIME_LOADER_EX_FUNCTION => "LoadManagedRuntimeEx"u8;
}
