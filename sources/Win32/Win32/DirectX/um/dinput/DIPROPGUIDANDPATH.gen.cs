// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DIPROPGUIDANDPATH
{
    public DIPROPHEADER diph;
    public Guid guidClass;

    [NativeTypeName("WCHAR[260]")]
    public _wszPath_e__FixedBuffer wszPath;

    [InlineArray(260)]
    public partial struct _wszPath_e__FixedBuffer
    {
        public ushort e0;
    }
}
