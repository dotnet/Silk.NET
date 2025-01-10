// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DIEDFL
{
    [NativeTypeName("#define DIEDFL_ALLDEVICES 0x00000000")]
    public const int DIEDFL_ALLDEVICES = 0x00000000;

    [NativeTypeName("#define DIEDFL_ATTACHEDONLY 0x00000001")]
    public const int DIEDFL_ATTACHEDONLY = 0x00000001;

    [NativeTypeName("#define DIEDFL_FORCEFEEDBACK 0x00000100")]
    public const int DIEDFL_FORCEFEEDBACK = 0x00000100;

    [NativeTypeName("#define DIEDFL_INCLUDEALIASES 0x00010000")]
    public const int DIEDFL_INCLUDEALIASES = 0x00010000;

    [NativeTypeName("#define DIEDFL_INCLUDEPHANTOMS 0x00020000")]
    public const int DIEDFL_INCLUDEPHANTOMS = 0x00020000;

    [NativeTypeName("#define DIEDFL_INCLUDEHIDDEN 0x00040000")]
    public const int DIEDFL_INCLUDEHIDDEN = 0x00040000;
}
