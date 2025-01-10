// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.credentials.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[48]")]
    public const string InterfaceName_Windows_Security_Credentials_ICredentialFactory =
        "Windows.Security.Credentials.ICredentialFactory";

    [NativeTypeName("const WCHAR[44]")]
    public const string InterfaceName_Windows_Security_Credentials_IKeyCredential =
        "Windows.Security.Credentials.IKeyCredential";

    [NativeTypeName("const WCHAR[61]")]
    public const string InterfaceName_Windows_Security_Credentials_IKeyCredentialAttestationResult =
        "Windows.Security.Credentials.IKeyCredentialAttestationResult";

    [NativeTypeName("const WCHAR[58]")]
    public const string InterfaceName_Windows_Security_Credentials_IKeyCredentialManagerStatics =
        "Windows.Security.Credentials.IKeyCredentialManagerStatics";

    [NativeTypeName("const WCHAR[59]")]
    public const string InterfaceName_Windows_Security_Credentials_IKeyCredentialOperationResult =
        "Windows.Security.Credentials.IKeyCredentialOperationResult";

    [NativeTypeName("const WCHAR[59]")]
    public const string InterfaceName_Windows_Security_Credentials_IKeyCredentialRetrievalResult =
        "Windows.Security.Credentials.IKeyCredentialRetrievalResult";

    [NativeTypeName("const WCHAR[49]")]
    public const string InterfaceName_Windows_Security_Credentials_IPasswordCredential =
        "Windows.Security.Credentials.IPasswordCredential";

    [NativeTypeName("const WCHAR[44]")]
    public const string InterfaceName_Windows_Security_Credentials_IPasswordVault =
        "Windows.Security.Credentials.IPasswordVault";

    [NativeTypeName("const WCHAR[41]")]
    public const string InterfaceName_Windows_Security_Credentials_IWebAccount =
        "Windows.Security.Credentials.IWebAccount";

    [NativeTypeName("const WCHAR[42]")]
    public const string InterfaceName_Windows_Security_Credentials_IWebAccount2 =
        "Windows.Security.Credentials.IWebAccount2";

    [NativeTypeName("const WCHAR[48]")]
    public const string InterfaceName_Windows_Security_Credentials_IWebAccountFactory =
        "Windows.Security.Credentials.IWebAccountFactory";

    [NativeTypeName("const WCHAR[49]")]
    public const string InterfaceName_Windows_Security_Credentials_IWebAccountProvider =
        "Windows.Security.Credentials.IWebAccountProvider";

    [NativeTypeName("const WCHAR[50]")]
    public const string InterfaceName_Windows_Security_Credentials_IWebAccountProvider2 =
        "Windows.Security.Credentials.IWebAccountProvider2";

    [NativeTypeName("const WCHAR[50]")]
    public const string InterfaceName_Windows_Security_Credentials_IWebAccountProvider3 =
        "Windows.Security.Credentials.IWebAccountProvider3";

    [NativeTypeName("const WCHAR[50]")]
    public const string InterfaceName_Windows_Security_Credentials_IWebAccountProvider4 =
        "Windows.Security.Credentials.IWebAccountProvider4";

    [NativeTypeName("const WCHAR[56]")]
    public const string InterfaceName_Windows_Security_Credentials_IWebAccountProviderFactory =
        "Windows.Security.Credentials.IWebAccountProviderFactory";

    [NativeTypeName("const WCHAR[43]")]
    public const string RuntimeClass_Windows_Security_Credentials_KeyCredential =
        "Windows.Security.Credentials.KeyCredential";

    [NativeTypeName("const WCHAR[60]")]
    public const string RuntimeClass_Windows_Security_Credentials_KeyCredentialAttestationResult =
        "Windows.Security.Credentials.KeyCredentialAttestationResult";

    [NativeTypeName("const WCHAR[50]")]
    public const string RuntimeClass_Windows_Security_Credentials_KeyCredentialManager =
        "Windows.Security.Credentials.KeyCredentialManager";

    [NativeTypeName("const WCHAR[58]")]
    public const string RuntimeClass_Windows_Security_Credentials_KeyCredentialOperationResult =
        "Windows.Security.Credentials.KeyCredentialOperationResult";

    [NativeTypeName("const WCHAR[58]")]
    public const string RuntimeClass_Windows_Security_Credentials_KeyCredentialRetrievalResult =
        "Windows.Security.Credentials.KeyCredentialRetrievalResult";

    [NativeTypeName("const WCHAR[48]")]
    public const string RuntimeClass_Windows_Security_Credentials_PasswordCredential =
        "Windows.Security.Credentials.PasswordCredential";

    [NativeTypeName("const WCHAR[61]")]
    public const string RuntimeClass_Windows_Security_Credentials_PasswordCredentialPropertyStore =
        "Windows.Security.Credentials.PasswordCredentialPropertyStore";

    [NativeTypeName("const WCHAR[43]")]
    public const string RuntimeClass_Windows_Security_Credentials_PasswordVault =
        "Windows.Security.Credentials.PasswordVault";

    [NativeTypeName("const WCHAR[40]")]
    public const string RuntimeClass_Windows_Security_Credentials_WebAccount =
        "Windows.Security.Credentials.WebAccount";

    [NativeTypeName("const WCHAR[48]")]
    public const string RuntimeClass_Windows_Security_Credentials_WebAccountProvider =
        "Windows.Security.Credentials.WebAccountProvider";
}
