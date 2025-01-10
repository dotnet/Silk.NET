// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DICONDITION
{
    [NativeTypeName("LONG")]
    public int lOffset;

    [NativeTypeName("LONG")]
    public int lPositiveCoefficient;

    [NativeTypeName("LONG")]
    public int lNegativeCoefficient;

    [NativeTypeName("DWORD")]
    public uint dwPositiveSaturation;

    [NativeTypeName("DWORD")]
    public uint dwNegativeSaturation;

    [NativeTypeName("LONG")]
    public int lDeadBand;
}
