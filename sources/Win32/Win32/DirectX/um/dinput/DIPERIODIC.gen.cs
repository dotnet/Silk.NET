// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DIPERIODIC
{
    [NativeTypeName("DWORD")]
    public uint dwMagnitude;

    [NativeTypeName("LONG")]
    public int lOffset;

    [NativeTypeName("DWORD")]
    public uint dwPhase;

    [NativeTypeName("DWORD")]
    public uint dwPeriod;
}
