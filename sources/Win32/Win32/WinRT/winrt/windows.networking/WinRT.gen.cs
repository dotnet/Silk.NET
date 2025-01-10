// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[33]")]
    public const string InterfaceName_Windows_Networking_IEndpointPair =
        "Windows.Networking.IEndpointPair";

    [NativeTypeName("const WCHAR[40]")]
    public const string InterfaceName_Windows_Networking_IEndpointPairFactory =
        "Windows.Networking.IEndpointPairFactory";

    [NativeTypeName("const WCHAR[29]")]
    public const string InterfaceName_Windows_Networking_IHostName = "Windows.Networking.IHostName";

    [NativeTypeName("const WCHAR[36]")]
    public const string InterfaceName_Windows_Networking_IHostNameFactory =
        "Windows.Networking.IHostNameFactory";

    [NativeTypeName("const WCHAR[36]")]
    public const string InterfaceName_Windows_Networking_IHostNameStatics =
        "Windows.Networking.IHostNameStatics";

    [NativeTypeName("const WCHAR[32]")]
    public const string RuntimeClass_Windows_Networking_EndpointPair =
        "Windows.Networking.EndpointPair";

    [NativeTypeName("const WCHAR[28]")]
    public const string RuntimeClass_Windows_Networking_HostName = "Windows.Networking.HostName";
}
