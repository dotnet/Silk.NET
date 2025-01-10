// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DESKBANDINFO
{
    [NativeTypeName("DWORD")]
    public uint dwMask;
    public POINTL ptMinSize;
    public POINTL ptMaxSize;
    public POINTL ptIntegral;
    public POINTL ptActual;

    [NativeTypeName("WCHAR[256]")]
    public _wszTitle_e__FixedBuffer wszTitle;

    [NativeTypeName("DWORD")]
    public uint dwModeFlags;
    public COLORREF crBkgnd;

    [InlineArray(256)]
    public partial struct _wszTitle_e__FixedBuffer
    {
        public ushort e0;
    }
}
