// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.web.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[33]")]
    public const string InterfaceName_Windows_Web_IUriToStreamResolver =
        "Windows.Web.IUriToStreamResolver";

    [NativeTypeName("const WCHAR[29]")]
    public const string InterfaceName_Windows_Web_IWebErrorStatics = "Windows.Web.IWebErrorStatics";

    [NativeTypeName("const WCHAR[21]")]
    public const string RuntimeClass_Windows_Web_WebError = "Windows.Web.WebError";
}
