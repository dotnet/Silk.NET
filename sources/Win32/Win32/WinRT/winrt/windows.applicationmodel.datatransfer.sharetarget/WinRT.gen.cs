// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.datatransfer.sharetarget.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[61]")]
    public const string InterfaceName_Windows_ApplicationModel_DataTransfer_ShareTarget_IQuickLink =
        "Windows.ApplicationModel.DataTransfer.ShareTarget.IQuickLink";

    [NativeTypeName("const WCHAR[66]")]
    public const string InterfaceName_Windows_ApplicationModel_DataTransfer_ShareTarget_IShareOperation =
        "Windows.ApplicationModel.DataTransfer.ShareTarget.IShareOperation";

    [NativeTypeName("const WCHAR[67]")]
    public const string InterfaceName_Windows_ApplicationModel_DataTransfer_ShareTarget_IShareOperation2 =
        "Windows.ApplicationModel.DataTransfer.ShareTarget.IShareOperation2";

    [NativeTypeName("const WCHAR[67]")]
    public const string InterfaceName_Windows_ApplicationModel_DataTransfer_ShareTarget_IShareOperation3 =
        "Windows.ApplicationModel.DataTransfer.ShareTarget.IShareOperation3";

    [NativeTypeName("const WCHAR[60]")]
    public const string RuntimeClass_Windows_ApplicationModel_DataTransfer_ShareTarget_QuickLink =
        "Windows.ApplicationModel.DataTransfer.ShareTarget.QuickLink";

    [NativeTypeName("const WCHAR[65]")]
    public const string RuntimeClass_Windows_ApplicationModel_DataTransfer_ShareTarget_ShareOperation =
        "Windows.ApplicationModel.DataTransfer.ShareTarget.ShareOperation";
}
