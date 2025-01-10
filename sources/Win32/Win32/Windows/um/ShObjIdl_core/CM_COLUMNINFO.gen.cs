// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct CM_COLUMNINFO
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("DWORD")]
    public uint dwMask;

    [NativeTypeName("DWORD")]
    public uint dwState;
    public uint uWidth;
    public uint uDefaultWidth;
    public uint uIdealWidth;

    [NativeTypeName("WCHAR[80]")]
    public _wszName_e__FixedBuffer wszName;

    [InlineArray(80)]
    public partial struct _wszName_e__FixedBuffer
    {
        public ushort e0;
    }
}
