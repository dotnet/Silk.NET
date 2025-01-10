// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SHCOLUMNINIT
{
    [NativeTypeName("ULONG")]
    public uint dwFlags;

    [NativeTypeName("ULONG")]
    public uint dwReserved;

    [NativeTypeName("WCHAR[260]")]
    public _wszFolder_e__FixedBuffer wszFolder;

    [InlineArray(260)]
    public partial struct _wszFolder_e__FixedBuffer
    {
        public ushort e0;
    }
}
