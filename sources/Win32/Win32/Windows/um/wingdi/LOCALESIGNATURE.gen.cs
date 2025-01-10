// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct LOCALESIGNATURE
{
    [NativeTypeName("DWORD[4]")]
    public _lsUsb_e__FixedBuffer lsUsb;

    [NativeTypeName("DWORD[2]")]
    public _lsCsbDefault_e__FixedBuffer lsCsbDefault;

    [NativeTypeName("DWORD[2]")]
    public _lsCsbSupported_e__FixedBuffer lsCsbSupported;

    [InlineArray(4)]
    public partial struct _lsUsb_e__FixedBuffer
    {
        public uint e0;
    }

    [InlineArray(2)]
    public partial struct _lsCsbDefault_e__FixedBuffer
    {
        public uint e0;
    }

    [InlineArray(2)]
    public partial struct _lsCsbSupported_e__FixedBuffer
    {
        public uint e0;
    }
}
