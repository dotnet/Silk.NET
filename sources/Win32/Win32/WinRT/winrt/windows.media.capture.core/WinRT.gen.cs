// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.capture.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[59]")]
    public const string InterfaceName_Windows_Media_Capture_Core_IVariablePhotoCapturedEventArgs =
        "Windows.Media.Capture.Core.IVariablePhotoCapturedEventArgs";

    [NativeTypeName("const WCHAR[57]")]
    public const string InterfaceName_Windows_Media_Capture_Core_IVariablePhotoSequenceCapture =
        "Windows.Media.Capture.Core.IVariablePhotoSequenceCapture";

    [NativeTypeName("const WCHAR[58]")]
    public const string InterfaceName_Windows_Media_Capture_Core_IVariablePhotoSequenceCapture2 =
        "Windows.Media.Capture.Core.IVariablePhotoSequenceCapture2";

    [NativeTypeName("const WCHAR[58]")]
    public const string RuntimeClass_Windows_Media_Capture_Core_VariablePhotoCapturedEventArgs =
        "Windows.Media.Capture.Core.VariablePhotoCapturedEventArgs";

    [NativeTypeName("const WCHAR[56]")]
    public const string RuntimeClass_Windows_Media_Capture_Core_VariablePhotoSequenceCapture =
        "Windows.Media.Capture.Core.VariablePhotoSequenceCapture";
}
