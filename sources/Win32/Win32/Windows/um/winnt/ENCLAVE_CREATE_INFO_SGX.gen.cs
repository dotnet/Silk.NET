// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0")]
public partial struct ENCLAVE_CREATE_INFO_SGX
{
    [NativeTypeName("BYTE[4096]")]
    public _Secs_e__FixedBuffer Secs;

    [InlineArray(4096)]
    public partial struct _Secs_e__FixedBuffer
    {
        public byte e0;
    }
}
