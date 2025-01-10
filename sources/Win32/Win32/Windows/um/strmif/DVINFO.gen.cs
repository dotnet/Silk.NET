// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DVINFO
{
    [NativeTypeName("DWORD")]
    public uint dwDVAAuxSrc;

    [NativeTypeName("DWORD")]
    public uint dwDVAAuxCtl;

    [NativeTypeName("DWORD")]
    public uint dwDVAAuxSrc1;

    [NativeTypeName("DWORD")]
    public uint dwDVAAuxCtl1;

    [NativeTypeName("DWORD")]
    public uint dwDVVAuxSrc;

    [NativeTypeName("DWORD")]
    public uint dwDVVAuxCtl;

    [NativeTypeName("DWORD[2]")]
    public _dwDVReserved_e__FixedBuffer dwDVReserved;

    [InlineArray(2)]
    public partial struct _dwDVReserved_e__FixedBuffer
    {
        public uint e0;
    }
}
