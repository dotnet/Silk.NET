// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class AMMPEG2
{
    [NativeTypeName("#define AMMPEG2_DoPanScan 0x00000001")]
    public const int AMMPEG2_DoPanScan = 0x00000001;
    [NativeTypeName("#define AMMPEG2_DVDLine21Field1 0x00000002")]
    public const int AMMPEG2_DVDLine21Field1 = 0x00000002;
    [NativeTypeName("#define AMMPEG2_DVDLine21Field2 0x00000004")]
    public const int AMMPEG2_DVDLine21Field2 = 0x00000004;
    [NativeTypeName("#define AMMPEG2_SourceIsLetterboxed 0x00000008")]
    public const int AMMPEG2_SourceIsLetterboxed = 0x00000008;
    [NativeTypeName("#define AMMPEG2_FilmCameraMode 0x00000010")]
    public const int AMMPEG2_FilmCameraMode = 0x00000010;
    [NativeTypeName("#define AMMPEG2_LetterboxAnalogOut 0x00000020")]
    public const int AMMPEG2_LetterboxAnalogOut = 0x00000020;
    [NativeTypeName("#define AMMPEG2_DSS_UserData 0x00000040")]
    public const int AMMPEG2_DSS_UserData = 0x00000040;
    [NativeTypeName("#define AMMPEG2_DVB_UserData 0x00000080")]
    public const int AMMPEG2_DVB_UserData = 0x00000080;
    [NativeTypeName("#define AMMPEG2_27MhzTimebase 0x00000100")]
    public const int AMMPEG2_27MhzTimebase = 0x00000100;
    [NativeTypeName("#define AMMPEG2_WidescreenAnalogOut 0x00000200")]
    public const int AMMPEG2_WidescreenAnalogOut = 0x00000200;
}