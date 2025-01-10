// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DIENVELOPE
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwAttackLevel;

    [NativeTypeName("DWORD")]
    public uint dwAttackTime;

    [NativeTypeName("DWORD")]
    public uint dwFadeLevel;

    [NativeTypeName("DWORD")]
    public uint dwFadeTime;
}
