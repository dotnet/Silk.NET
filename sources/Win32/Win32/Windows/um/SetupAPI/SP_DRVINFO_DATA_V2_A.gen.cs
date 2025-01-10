// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SP_DRVINFO_DATA_V2_A
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("DWORD")]
    public uint DriverType;

    [NativeTypeName("ULONG_PTR")]
    public nuint Reserved;

    [NativeTypeName("CHAR[256]")]
    public _Description_e__FixedBuffer Description;

    [NativeTypeName("CHAR[256]")]
    public _MfgName_e__FixedBuffer MfgName;

    [NativeTypeName("CHAR[256]")]
    public _ProviderName_e__FixedBuffer ProviderName;
    public FILETIME DriverDate;

    [NativeTypeName("DWORDLONG")]
    public ulong DriverVersion;

    [InlineArray(256)]
    public partial struct _Description_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(256)]
    public partial struct _MfgName_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(256)]
    public partial struct _ProviderName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
