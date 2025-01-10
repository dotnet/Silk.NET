// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DXGI_DISPLAY_COLOR_SPACE
{
    [NativeTypeName("FLOAT[8][2]")]
    public _PrimaryCoordinates_e__FixedBuffer PrimaryCoordinates;

    [NativeTypeName("FLOAT[16][2]")]
    public _WhitePoints_e__FixedBuffer WhitePoints;

    [InlineArray(8 * 2)]
    public partial struct _PrimaryCoordinates_e__FixedBuffer
    {
        public float e0_0;
    }

    [InlineArray(16 * 2)]
    public partial struct _WhitePoints_e__FixedBuffer
    {
        public float e0_0;
    }
}
