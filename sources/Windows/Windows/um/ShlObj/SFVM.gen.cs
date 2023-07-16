// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class SFVM
{
    [NativeTypeName("#define SFVM_REARRANGE 0x00000001")]
    public const int SFVM_REARRANGE = 0x00000001;
    [NativeTypeName("#define SFVM_ADDOBJECT 0x00000003")]
    public const int SFVM_ADDOBJECT = 0x00000003;
    [NativeTypeName("#define SFVM_REMOVEOBJECT 0x00000006")]
    public const int SFVM_REMOVEOBJECT = 0x00000006;
    [NativeTypeName("#define SFVM_UPDATEOBJECT 0x00000007")]
    public const int SFVM_UPDATEOBJECT = 0x00000007;
    [NativeTypeName("#define SFVM_GETSELECTEDOBJECTS 0x00000009")]
    public const int SFVM_GETSELECTEDOBJECTS = 0x00000009;
    [NativeTypeName("#define SFVM_SETITEMPOS 0x0000000e")]
    public const int SFVM_SETITEMPOS = 0x0000000e;
    [NativeTypeName("#define SFVM_SETCLIPBOARD 0x00000010")]
    public const int SFVM_SETCLIPBOARD = 0x00000010;
    [NativeTypeName("#define SFVM_SETPOINTS 0x00000017")]
    public const int SFVM_SETPOINTS = 0x00000017;
}