// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tbs.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct TPM_WNF_PROVISIONING
{
    [NativeTypeName("UINT32")]
    public uint status;

    [NativeTypeName("BYTE[28]")]
    public _message_e__FixedBuffer message;

    [InlineArray(28)]
    public partial struct _message_e__FixedBuffer
    {
        public byte e0;
    }
}
