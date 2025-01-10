// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct PERSIST_FOLDER_TARGET_INFO
{
    [NativeTypeName("LPITEMIDLIST")]
    public ITEMIDLIST* pidlTargetFolder;

    [NativeTypeName("WCHAR[260]")]
    public _szTargetParsingName_e__FixedBuffer szTargetParsingName;

    [NativeTypeName("WCHAR[260]")]
    public _szNetworkProvider_e__FixedBuffer szNetworkProvider;

    [NativeTypeName("DWORD")]
    public uint dwAttributes;
    public int csidl;

    [InlineArray(260)]
    public partial struct _szTargetParsingName_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(260)]
    public partial struct _szNetworkProvider_e__FixedBuffer
    {
        public ushort e0;
    }
}
