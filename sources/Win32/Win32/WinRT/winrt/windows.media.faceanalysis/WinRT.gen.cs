// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.faceanalysis.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[41]")]
    public const string InterfaceName_Windows_Media_FaceAnalysis_IDetectedFace =
        "Windows.Media.FaceAnalysis.IDetectedFace";

    [NativeTypeName("const WCHAR[41]")]
    public const string InterfaceName_Windows_Media_FaceAnalysis_IFaceDetector =
        "Windows.Media.FaceAnalysis.IFaceDetector";

    [NativeTypeName("const WCHAR[48]")]
    public const string InterfaceName_Windows_Media_FaceAnalysis_IFaceDetectorStatics =
        "Windows.Media.FaceAnalysis.IFaceDetectorStatics";

    [NativeTypeName("const WCHAR[40]")]
    public const string InterfaceName_Windows_Media_FaceAnalysis_IFaceTracker =
        "Windows.Media.FaceAnalysis.IFaceTracker";

    [NativeTypeName("const WCHAR[47]")]
    public const string InterfaceName_Windows_Media_FaceAnalysis_IFaceTrackerStatics =
        "Windows.Media.FaceAnalysis.IFaceTrackerStatics";

    [NativeTypeName("const WCHAR[40]")]
    public const string RuntimeClass_Windows_Media_FaceAnalysis_DetectedFace =
        "Windows.Media.FaceAnalysis.DetectedFace";

    [NativeTypeName("const WCHAR[40]")]
    public const string RuntimeClass_Windows_Media_FaceAnalysis_FaceDetector =
        "Windows.Media.FaceAnalysis.FaceDetector";

    [NativeTypeName("const WCHAR[39]")]
    public const string RuntimeClass_Windows_Media_FaceAnalysis_FaceTracker =
        "Windows.Media.FaceAnalysis.FaceTracker";
}
