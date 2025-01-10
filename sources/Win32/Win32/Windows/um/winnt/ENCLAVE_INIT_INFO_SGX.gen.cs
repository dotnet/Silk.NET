// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0")]
public partial struct ENCLAVE_INIT_INFO_SGX
{
    [NativeTypeName("BYTE[1808]")]
    public _SigStruct_e__FixedBuffer SigStruct;

    [NativeTypeName("BYTE[240]")]
    public _Reserved1_e__FixedBuffer Reserved1;

    [NativeTypeName("BYTE[304]")]
    public _EInitToken_e__FixedBuffer EInitToken;

    [NativeTypeName("BYTE[1744]")]
    public _Reserved2_e__FixedBuffer Reserved2;

    [InlineArray(1808)]
    public partial struct _SigStruct_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(240)]
    public partial struct _Reserved1_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(304)]
    public partial struct _EInitToken_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(1744)]
    public partial struct _Reserved2_e__FixedBuffer
    {
        public byte e0;
    }
}
