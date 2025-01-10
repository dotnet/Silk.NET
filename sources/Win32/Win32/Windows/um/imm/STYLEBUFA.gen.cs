// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct STYLEBUFA
{
    [NativeTypeName("DWORD")]
    public uint dwStyle;

    [NativeTypeName("CHAR[32]")]
    public _szDescription_e__FixedBuffer szDescription;

    [InlineArray(32)]
    public partial struct _szDescription_e__FixedBuffer
    {
        public sbyte e0;
    }
}
