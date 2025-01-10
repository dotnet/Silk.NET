// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0")]
public partial struct SSL_F12_EXTRA_CERT_CHAIN_POLICY_STATUS
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("DWORD")]
    public uint dwErrorLevel;

    [NativeTypeName("DWORD")]
    public uint dwErrorCategory;

    [NativeTypeName("DWORD")]
    public uint dwReserved;

    [NativeTypeName("WCHAR[256]")]
    public _wszErrorText_e__FixedBuffer wszErrorText;

    [InlineArray(256)]
    public partial struct _wszErrorText_e__FixedBuffer
    {
        public ushort e0;
    }
}
