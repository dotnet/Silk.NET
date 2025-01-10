// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SYNCMGRHANDLERINFO
{
    [NativeTypeName("DWORD")]
    public uint cbSize;
    public HICON hIcon;

    [NativeTypeName("DWORD")]
    public uint SyncMgrHandlerFlags;

    [NativeTypeName("WCHAR[32]")]
    public _wszHandlerName_e__FixedBuffer wszHandlerName;

    [InlineArray(32)]
    public partial struct _wszHandlerName_e__FixedBuffer
    {
        public ushort e0;
    }
}
