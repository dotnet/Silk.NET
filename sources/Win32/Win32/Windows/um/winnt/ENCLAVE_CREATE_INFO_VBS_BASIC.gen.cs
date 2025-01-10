// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct ENCLAVE_CREATE_INFO_VBS_BASIC
{
    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("BYTE[32]")]
    public _OwnerID_e__FixedBuffer OwnerID;

    [InlineArray(32)]
    public partial struct _OwnerID_e__FixedBuffer
    {
        public byte e0;
    }
}
