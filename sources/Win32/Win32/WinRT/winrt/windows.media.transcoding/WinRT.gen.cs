// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.transcoding.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[43]")]
    public const string InterfaceName_Windows_Media_Transcoding_IMediaTranscoder =
        "Windows.Media.Transcoding.IMediaTranscoder";

    [NativeTypeName("const WCHAR[44]")]
    public const string InterfaceName_Windows_Media_Transcoding_IMediaTranscoder2 =
        "Windows.Media.Transcoding.IMediaTranscoder2";

    [NativeTypeName("const WCHAR[50]")]
    public const string InterfaceName_Windows_Media_Transcoding_IPrepareTranscodeResult =
        "Windows.Media.Transcoding.IPrepareTranscodeResult";

    [NativeTypeName("const WCHAR[42]")]
    public const string RuntimeClass_Windows_Media_Transcoding_MediaTranscoder =
        "Windows.Media.Transcoding.MediaTranscoder";

    [NativeTypeName("const WCHAR[49]")]
    public const string RuntimeClass_Windows_Media_Transcoding_PrepareTranscodeResult =
        "Windows.Media.Transcoding.PrepareTranscodeResult";
}
