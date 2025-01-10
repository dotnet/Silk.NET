// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct PROV_ENUMALGS
{
    [NativeTypeName("ALG_ID")]
    public uint aiAlgid;

    [NativeTypeName("DWORD")]
    public uint dwBitLen;

    [NativeTypeName("DWORD")]
    public uint dwNameLen;

    [NativeTypeName("CHAR[20]")]
    public _szName_e__FixedBuffer szName;

    [InlineArray(20)]
    public partial struct _szName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
