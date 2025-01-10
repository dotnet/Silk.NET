// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/immdev.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SOFTKBDDATA
{
    public uint uCount;

    [NativeTypeName("WORD[1][256]")]
    public _wCode_e__FixedBuffer wCode;

    [InlineArray(1 * 256)]
    public partial struct _wCode_e__FixedBuffer
    {
        public ushort e0_0;
    }
}
