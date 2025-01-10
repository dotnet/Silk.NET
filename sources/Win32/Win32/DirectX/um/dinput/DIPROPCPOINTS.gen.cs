// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DIPROPCPOINTS
{
    public DIPROPHEADER diph;

    [NativeTypeName("DWORD")]
    public uint dwCPointsNum;

    [NativeTypeName("CPOINT[8]")]
    public _cp_e__FixedBuffer cp;

    [InlineArray(8)]
    public partial struct _cp_e__FixedBuffer
    {
        public CPOINT e0;
    }
}
