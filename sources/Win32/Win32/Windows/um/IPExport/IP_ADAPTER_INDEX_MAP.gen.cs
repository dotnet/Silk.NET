// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IP_ADAPTER_INDEX_MAP
{
    [NativeTypeName("ULONG")]
    public uint Index;

    [NativeTypeName("WCHAR[128]")]
    public _Name_e__FixedBuffer Name;

    [InlineArray(128)]
    public partial struct _Name_e__FixedBuffer
    {
        public ushort e0;
    }
}
