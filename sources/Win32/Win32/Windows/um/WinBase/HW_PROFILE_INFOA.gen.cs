// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct HW_PROFILE_INFOA
{
    [NativeTypeName("DWORD")]
    public uint dwDockInfo;

    [NativeTypeName("CHAR[39]")]
    public _szHwProfileGuid_e__FixedBuffer szHwProfileGuid;

    [NativeTypeName("CHAR[80]")]
    public _szHwProfileName_e__FixedBuffer szHwProfileName;

    [InlineArray(39)]
    public partial struct _szHwProfileGuid_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(80)]
    public partial struct _szHwProfileName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
