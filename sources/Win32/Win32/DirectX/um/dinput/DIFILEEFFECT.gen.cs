// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct DIFILEEFFECT
{
    [NativeTypeName("DWORD")]
    public uint dwSize;
    public Guid GuidEffect;

    [NativeTypeName("LPCDIEFFECT")]
    public DIEFFECT_DX6* lpDiEffect;

    [NativeTypeName("CHAR[260]")]
    public _szFriendlyName_e__FixedBuffer szFriendlyName;

    [InlineArray(260)]
    public partial struct _szFriendlyName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
