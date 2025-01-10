// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIXERCONTROLDETAILS_LISTTEXTW
{
    [NativeTypeName("DWORD")]
    public uint dwParam1;

    [NativeTypeName("DWORD")]
    public uint dwParam2;

    [NativeTypeName("WCHAR[64]")]
    public _szName_e__FixedBuffer szName;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(64)]
    public partial struct _szName_e__FixedBuffer
    {
        public ushort e0;
    }
}
