// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct IP_ADAPTER_DNS_SUFFIX
{
    [NativeTypeName("struct _IP_ADAPTER_DNS_SUFFIX *")]
    public IP_ADAPTER_DNS_SUFFIX* Next;

    [NativeTypeName("WCHAR[256]")]
    public _String_e__FixedBuffer String;

    [InlineArray(256)]
    public partial struct _String_e__FixedBuffer
    {
        public ushort e0;
    }
}
