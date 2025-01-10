// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.contacts.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[60]")]
    public const string InterfaceName_Windows_ApplicationModel_Contacts_Provider_IContactPickerUI =
        "Windows.ApplicationModel.Contacts.Provider.IContactPickerUI";

    [NativeTypeName("const WCHAR[61]")]
    public const string InterfaceName_Windows_ApplicationModel_Contacts_Provider_IContactPickerUI2 =
        "Windows.ApplicationModel.Contacts.Provider.IContactPickerUI2";

    [NativeTypeName("const WCHAR[68]")]
    public const string InterfaceName_Windows_ApplicationModel_Contacts_Provider_IContactRemovedEventArgs =
        "Windows.ApplicationModel.Contacts.Provider.IContactRemovedEventArgs";

    [NativeTypeName("const WCHAR[59]")]
    public const string RuntimeClass_Windows_ApplicationModel_Contacts_Provider_ContactPickerUI =
        "Windows.ApplicationModel.Contacts.Provider.ContactPickerUI";

    [NativeTypeName("const WCHAR[67]")]
    public const string RuntimeClass_Windows_ApplicationModel_Contacts_Provider_ContactRemovedEventArgs =
        "Windows.ApplicationModel.Contacts.Provider.ContactRemovedEventArgs";
}
