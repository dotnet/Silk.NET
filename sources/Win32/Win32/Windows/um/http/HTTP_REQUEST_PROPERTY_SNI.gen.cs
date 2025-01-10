// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct HTTP_REQUEST_PROPERTY_SNI
{
    [NativeTypeName("WCHAR[256]")]
    public _Hostname_e__FixedBuffer Hostname;

    [NativeTypeName("ULONG")]
    public uint Flags;

    [InlineArray(256)]
    public partial struct _Hostname_e__FixedBuffer
    {
        public ushort e0;
    }
}
