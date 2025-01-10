// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.pickers.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[51]")]
    public const string InterfaceName_Windows_Storage_Pickers_Provider_IFileOpenPickerUI =
        "Windows.Storage.Pickers.Provider.IFileOpenPickerUI";

    [NativeTypeName("const WCHAR[55]")]
    public const string InterfaceName_Windows_Storage_Pickers_Provider_IFileRemovedEventArgs =
        "Windows.Storage.Pickers.Provider.IFileRemovedEventArgs";

    [NativeTypeName("const WCHAR[51]")]
    public const string InterfaceName_Windows_Storage_Pickers_Provider_IFileSavePickerUI =
        "Windows.Storage.Pickers.Provider.IFileSavePickerUI";

    [NativeTypeName("const WCHAR[56]")]
    public const string InterfaceName_Windows_Storage_Pickers_Provider_IPickerClosingDeferral =
        "Windows.Storage.Pickers.Provider.IPickerClosingDeferral";

    [NativeTypeName("const WCHAR[57]")]
    public const string InterfaceName_Windows_Storage_Pickers_Provider_IPickerClosingEventArgs =
        "Windows.Storage.Pickers.Provider.IPickerClosingEventArgs";

    [NativeTypeName("const WCHAR[57]")]
    public const string InterfaceName_Windows_Storage_Pickers_Provider_IPickerClosingOperation =
        "Windows.Storage.Pickers.Provider.IPickerClosingOperation";

    [NativeTypeName("const WCHAR[52]")]
    public const string InterfaceName_Windows_Storage_Pickers_Provider_ITargetFileRequest =
        "Windows.Storage.Pickers.Provider.ITargetFileRequest";

    [NativeTypeName("const WCHAR[60]")]
    public const string InterfaceName_Windows_Storage_Pickers_Provider_ITargetFileRequestDeferral =
        "Windows.Storage.Pickers.Provider.ITargetFileRequestDeferral";

    [NativeTypeName("const WCHAR[63]")]
    public const string InterfaceName_Windows_Storage_Pickers_Provider_ITargetFileRequestedEventArgs =
        "Windows.Storage.Pickers.Provider.ITargetFileRequestedEventArgs";

    [NativeTypeName("const WCHAR[50]")]
    public const string RuntimeClass_Windows_Storage_Pickers_Provider_FileOpenPickerUI =
        "Windows.Storage.Pickers.Provider.FileOpenPickerUI";

    [NativeTypeName("const WCHAR[54]")]
    [Obsolete(
        "Since Windows 10, only apps can remove files, not end users so the FileRemoved event will not be raised."
    )]
    public const string RuntimeClass_Windows_Storage_Pickers_Provider_FileRemovedEventArgs =
        "Windows.Storage.Pickers.Provider.FileRemovedEventArgs";

    [NativeTypeName("const WCHAR[50]")]
    public const string RuntimeClass_Windows_Storage_Pickers_Provider_FileSavePickerUI =
        "Windows.Storage.Pickers.Provider.FileSavePickerUI";

    [NativeTypeName("const WCHAR[55]")]
    public const string RuntimeClass_Windows_Storage_Pickers_Provider_PickerClosingDeferral =
        "Windows.Storage.Pickers.Provider.PickerClosingDeferral";

    [NativeTypeName("const WCHAR[56]")]
    public const string RuntimeClass_Windows_Storage_Pickers_Provider_PickerClosingEventArgs =
        "Windows.Storage.Pickers.Provider.PickerClosingEventArgs";

    [NativeTypeName("const WCHAR[56]")]
    public const string RuntimeClass_Windows_Storage_Pickers_Provider_PickerClosingOperation =
        "Windows.Storage.Pickers.Provider.PickerClosingOperation";

    [NativeTypeName("const WCHAR[51]")]
    public const string RuntimeClass_Windows_Storage_Pickers_Provider_TargetFileRequest =
        "Windows.Storage.Pickers.Provider.TargetFileRequest";

    [NativeTypeName("const WCHAR[59]")]
    public const string RuntimeClass_Windows_Storage_Pickers_Provider_TargetFileRequestDeferral =
        "Windows.Storage.Pickers.Provider.TargetFileRequestDeferral";

    [NativeTypeName("const WCHAR[62]")]
    public const string RuntimeClass_Windows_Storage_Pickers_Provider_TargetFileRequestedEventArgs =
        "Windows.Storage.Pickers.Provider.TargetFileRequestedEventArgs";
}
