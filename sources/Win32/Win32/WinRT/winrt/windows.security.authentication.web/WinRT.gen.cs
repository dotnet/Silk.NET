// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.authentication.web.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[68]")]
    public const string InterfaceName_Windows_Security_Authentication_Web_IWebAuthenticationBrokerStatics =
        "Windows.Security.Authentication.Web.IWebAuthenticationBrokerStatics";

    [NativeTypeName("const WCHAR[69]")]
    public const string InterfaceName_Windows_Security_Authentication_Web_IWebAuthenticationBrokerStatics2 =
        "Windows.Security.Authentication.Web.IWebAuthenticationBrokerStatics2";

    [NativeTypeName("const WCHAR[61]")]
    public const string InterfaceName_Windows_Security_Authentication_Web_IWebAuthenticationResult =
        "Windows.Security.Authentication.Web.IWebAuthenticationResult";

    [NativeTypeName("const WCHAR[60]")]
    public const string RuntimeClass_Windows_Security_Authentication_Web_WebAuthenticationBroker =
        "Windows.Security.Authentication.Web.WebAuthenticationBroker";

    [NativeTypeName("const WCHAR[60]")]
    public const string RuntimeClass_Windows_Security_Authentication_Web_WebAuthenticationResult =
        "Windows.Security.Authentication.Web.WebAuthenticationResult";
}
