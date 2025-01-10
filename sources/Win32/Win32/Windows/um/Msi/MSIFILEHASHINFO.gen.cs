// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Msi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MSIFILEHASHINFO
{
    [NativeTypeName("ULONG")]
    public uint dwFileHashInfoSize;

    [NativeTypeName("ULONG[4]")]
    public _dwData_e__FixedBuffer dwData;

    [InlineArray(4)]
    public partial struct _dwData_e__FixedBuffer
    {
        public uint e0;
    }
}
