// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DIPROPSTRING
{
    public DIPROPHEADER diph;

    [NativeTypeName("WCHAR[260]")]
    public _wsz_e__FixedBuffer wsz;

    [InlineArray(260)]
    public partial struct _wsz_e__FixedBuffer
    {
        public ushort e0;
    }
}
