// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class STARTF
{
    [NativeTypeName("#define STARTF_USESHOWWINDOW 0x00000001")]
    public const int STARTF_USESHOWWINDOW = 0x00000001;
    [NativeTypeName("#define STARTF_USESIZE 0x00000002")]
    public const int STARTF_USESIZE = 0x00000002;
    [NativeTypeName("#define STARTF_USEPOSITION 0x00000004")]
    public const int STARTF_USEPOSITION = 0x00000004;
    [NativeTypeName("#define STARTF_USECOUNTCHARS 0x00000008")]
    public const int STARTF_USECOUNTCHARS = 0x00000008;
    [NativeTypeName("#define STARTF_USEFILLATTRIBUTE 0x00000010")]
    public const int STARTF_USEFILLATTRIBUTE = 0x00000010;
    [NativeTypeName("#define STARTF_RUNFULLSCREEN 0x00000020")]
    public const int STARTF_RUNFULLSCREEN = 0x00000020;
    [NativeTypeName("#define STARTF_FORCEONFEEDBACK 0x00000040")]
    public const int STARTF_FORCEONFEEDBACK = 0x00000040;
    [NativeTypeName("#define STARTF_FORCEOFFFEEDBACK 0x00000080")]
    public const int STARTF_FORCEOFFFEEDBACK = 0x00000080;
    [NativeTypeName("#define STARTF_USESTDHANDLES 0x00000100")]
    public const int STARTF_USESTDHANDLES = 0x00000100;
    [NativeTypeName("#define STARTF_USEHOTKEY 0x00000200")]
    public const int STARTF_USEHOTKEY = 0x00000200;
    [NativeTypeName("#define STARTF_TITLEISLINKNAME 0x00000800")]
    public const int STARTF_TITLEISLINKNAME = 0x00000800;
    [NativeTypeName("#define STARTF_TITLEISAPPID 0x00001000")]
    public const int STARTF_TITLEISAPPID = 0x00001000;
    [NativeTypeName("#define STARTF_PREVENTPINNING 0x00002000")]
    public const int STARTF_PREVENTPINNING = 0x00002000;
    [NativeTypeName("#define STARTF_UNTRUSTEDSOURCE 0x00008000")]
    public const int STARTF_UNTRUSTEDSOURCE = 0x00008000;
    [NativeTypeName("#define STARTF_HOLOGRAPHIC 0x00040000")]
    public const int STARTF_HOLOGRAPHIC = 0x00040000;
}