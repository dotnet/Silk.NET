// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct OFSTRUCT
{
    public byte cBytes;
    public byte fFixedDisk;

    [NativeTypeName("WORD")]
    public ushort nErrCode;

    [NativeTypeName("WORD")]
    public ushort Reserved1;

    [NativeTypeName("WORD")]
    public ushort Reserved2;

    [NativeTypeName("CHAR[128]")]
    public _szPathName_e__FixedBuffer szPathName;

    [InlineArray(128)]
    public partial struct _szPathName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
