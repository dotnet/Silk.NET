// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct FONTSIGNATURE
{
    [NativeTypeName("DWORD[4]")]
    public _fsUsb_e__FixedBuffer fsUsb;

    [NativeTypeName("DWORD[2]")]
    public _fsCsb_e__FixedBuffer fsCsb;

    [InlineArray(4)]
    public partial struct _fsUsb_e__FixedBuffer
    {
        public uint e0;
    }

    [InlineArray(2)]
    public partial struct _fsCsb_e__FixedBuffer
    {
        public uint e0;
    }
}
