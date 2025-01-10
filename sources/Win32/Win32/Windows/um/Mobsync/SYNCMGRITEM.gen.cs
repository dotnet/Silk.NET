// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SYNCMGRITEM
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("DWORD")]
    public uint dwFlags;
    public Guid ItemID;

    [NativeTypeName("DWORD")]
    public uint dwItemState;
    public HICON hIcon;

    [NativeTypeName("WCHAR[128]")]
    public _wszItemName_e__FixedBuffer wszItemName;
    public FILETIME ftLastUpdate;

    [InlineArray(128)]
    public partial struct _wszItemName_e__FixedBuffer
    {
        public ushort e0;
    }
}
