// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
public static partial class DIEDBSFL
{
    [NativeTypeName("#define DIEDBSFL_ATTACHEDONLY 0x00000000")]
    public const int DIEDBSFL_ATTACHEDONLY = 0x00000000;
    [NativeTypeName("#define DIEDBSFL_THISUSER 0x00000010")]
    public const int DIEDBSFL_THISUSER = 0x00000010;
    [NativeTypeName("#define DIEDBSFL_FORCEFEEDBACK DIEDFL_FORCEFEEDBACK")]
    public const int DIEDBSFL_FORCEFEEDBACK = 0x00000100;
    [NativeTypeName("#define DIEDBSFL_AVAILABLEDEVICES 0x00001000")]
    public const int DIEDBSFL_AVAILABLEDEVICES = 0x00001000;
    [NativeTypeName("#define DIEDBSFL_MULTIMICEKEYBOARDS 0x00002000")]
    public const int DIEDBSFL_MULTIMICEKEYBOARDS = 0x00002000;
    [NativeTypeName("#define DIEDBSFL_NONGAMINGDEVICES 0x00004000")]
    public const int DIEDBSFL_NONGAMINGDEVICES = 0x00004000;
    [NativeTypeName("#define DIEDBSFL_VALID 0x00007110")]
    public const int DIEDBSFL_VALID = 0x00007110;
}