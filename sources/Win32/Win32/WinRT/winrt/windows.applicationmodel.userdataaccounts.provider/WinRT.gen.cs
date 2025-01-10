// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.userdataaccounts.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[86]")]
    public const string InterfaceName_Windows_ApplicationModel_UserDataAccounts_Provider_IUserDataAccountPartnerAccountInfo =
        "Windows.ApplicationModel.UserDataAccounts.Provider.IUserDataAccountPartnerAccountInfo";

    [NativeTypeName("const WCHAR[95]")]
    public const string InterfaceName_Windows_ApplicationModel_UserDataAccounts_Provider_IUserDataAccountProviderAddAccountOperation =
        "Windows.ApplicationModel.UserDataAccounts.Provider.IUserDataAccountProviderAddAccountOperation";

    [NativeTypeName("const WCHAR[85]")]
    public const string InterfaceName_Windows_ApplicationModel_UserDataAccounts_Provider_IUserDataAccountProviderOperation =
        "Windows.ApplicationModel.UserDataAccounts.Provider.IUserDataAccountProviderOperation";

    [NativeTypeName("const WCHAR[98]")]
    public const string InterfaceName_Windows_ApplicationModel_UserDataAccounts_Provider_IUserDataAccountProviderResolveErrorsOperation =
        "Windows.ApplicationModel.UserDataAccounts.Provider.IUserDataAccountProviderResolveErrorsOperation";

    [NativeTypeName("const WCHAR[93]")]
    public const string InterfaceName_Windows_ApplicationModel_UserDataAccounts_Provider_IUserDataAccountProviderSettingsOperation =
        "Windows.ApplicationModel.UserDataAccounts.Provider.IUserDataAccountProviderSettingsOperation";

    [NativeTypeName("const WCHAR[85]")]
    public const string RuntimeClass_Windows_ApplicationModel_UserDataAccounts_Provider_UserDataAccountPartnerAccountInfo =
        "Windows.ApplicationModel.UserDataAccounts.Provider.UserDataAccountPartnerAccountInfo";

    [NativeTypeName("const WCHAR[94]")]
    public const string RuntimeClass_Windows_ApplicationModel_UserDataAccounts_Provider_UserDataAccountProviderAddAccountOperation =
        "Windows.ApplicationModel.UserDataAccounts.Provider.UserDataAccountProviderAddAccountOperation";

    [NativeTypeName("const WCHAR[97]")]
    public const string RuntimeClass_Windows_ApplicationModel_UserDataAccounts_Provider_UserDataAccountProviderResolveErrorsOperation =
        "Windows.ApplicationModel.UserDataAccounts.Provider.UserDataAccountProviderResolveErrorsOperation";

    [NativeTypeName("const WCHAR[92]")]
    public const string RuntimeClass_Windows_ApplicationModel_UserDataAccounts_Provider_UserDataAccountProviderSettingsOperation =
        "Windows.ApplicationModel.UserDataAccounts.Provider.UserDataAccountProviderSettingsOperation";
}
