// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[43]")]
    public const string InterfaceName_Windows_Media_Streaming_IActiveBasicDevice =
        "Windows.Media.Streaming.IActiveBasicDevice";

    [NativeTypeName("const WCHAR[50]")]
    public const string InterfaceName_Windows_Media_Streaming_IActiveBasicDeviceStatics =
        "Windows.Media.Streaming.IActiveBasicDeviceStatics";

    [NativeTypeName("const WCHAR[37]")]
    public const string InterfaceName_Windows_Media_Streaming_IBasicDevice =
        "Windows.Media.Streaming.IBasicDevice";

    [NativeTypeName("const WCHAR[42]")]
    public const string InterfaceName_Windows_Media_Streaming_IDeviceController =
        "Windows.Media.Streaming.IDeviceController";

    [NativeTypeName("const WCHAR[36]")]
    public const string InterfaceName_Windows_Media_Streaming_IDeviceIcon =
        "Windows.Media.Streaming.IDeviceIcon";

    [NativeTypeName("const WCHAR[36]")]
    public const string InterfaceName_Windows_Media_Streaming_IDevicePair =
        "Windows.Media.Streaming.IDevicePair";

    [NativeTypeName("const WCHAR[39]")]
    public const string InterfaceName_Windows_Media_Streaming_IMediaRenderer =
        "Windows.Media.Streaming.IMediaRenderer";

    [NativeTypeName("const WCHAR[56]")]
    public const string InterfaceName_Windows_Media_Streaming_IMediaRendererActionInformation =
        "Windows.Media.Streaming.IMediaRendererActionInformation";

    [NativeTypeName("const WCHAR[46]")]
    public const string InterfaceName_Windows_Media_Streaming_IMediaRendererFactory =
        "Windows.Media.Streaming.IMediaRendererFactory";

    [NativeTypeName("const WCHAR[47]")]
    public const string InterfaceName_Windows_Media_Streaming_IStreamSelectorStatics =
        "Windows.Media.Streaming.IStreamSelectorStatics";

    [NativeTypeName("const WCHAR[45]")]
    public const string InterfaceName_Windows_Media_Streaming_ITransportParameters =
        "Windows.Media.Streaming.ITransportParameters";

    [NativeTypeName("const WCHAR[42]")]
    public const string RuntimeClass_Windows_Media_Streaming_ActiveBasicDevice =
        "Windows.Media.Streaming.ActiveBasicDevice";

    [NativeTypeName("const WCHAR[36]")]
    public const string RuntimeClass_Windows_Media_Streaming_BasicDevice =
        "Windows.Media.Streaming.BasicDevice";

    [NativeTypeName("const WCHAR[53]")]
    public const string RuntimeClass_Windows_Media_Streaming_CreateMediaRendererOperation =
        "Windows.Media.Streaming.CreateMediaRendererOperation";

    [NativeTypeName("const WCHAR[41]")]
    public const string RuntimeClass_Windows_Media_Streaming_DeviceController =
        "Windows.Media.Streaming.DeviceController";

    [NativeTypeName("const WCHAR[35]")]
    public const string RuntimeClass_Windows_Media_Streaming_DevicePair =
        "Windows.Media.Streaming.DevicePair";

    [NativeTypeName("const WCHAR[38]")]
    public const string RuntimeClass_Windows_Media_Streaming_MediaRenderer =
        "Windows.Media.Streaming.MediaRenderer";

    [NativeTypeName("const WCHAR[39]")]
    public const string RuntimeClass_Windows_Media_Streaming_StreamSelector =
        "Windows.Media.Streaming.StreamSelector";

    [NativeTypeName("#define WINDOWS_GAMING_INPUT_GAMINGINPUTPREVIEWCONTRACT_VERSION 0x20000")]
    public const int WINDOWS_GAMING_INPUT_GAMINGINPUTPREVIEWCONTRACT_VERSION = 0x20000;

    [NativeTypeName("#define WINDOWS_MEDIA_STREAMING_STREAMINGCONTRACT_VERSION 0x10000")]
    public const int WINDOWS_MEDIA_STREAMING_STREAMINGCONTRACT_VERSION = 0x10000;
}
