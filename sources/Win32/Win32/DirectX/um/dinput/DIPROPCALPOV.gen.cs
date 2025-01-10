// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DIPROPCALPOV
{
    public DIPROPHEADER diph;

    [NativeTypeName("LONG[5]")]
    public _lMin_e__FixedBuffer lMin;

    [NativeTypeName("LONG[5]")]
    public _lMax_e__FixedBuffer lMax;

    [InlineArray(5)]
    public partial struct _lMin_e__FixedBuffer
    {
        public int e0;
    }

    [InlineArray(5)]
    public partial struct _lMax_e__FixedBuffer
    {
        public int e0;
    }
}
