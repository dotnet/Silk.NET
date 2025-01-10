// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MSChapp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SAMPR_ENCRYPTED_USER_PASSWORD
{
    [NativeTypeName("UCHAR[516]")]
    public _Buffer_e__FixedBuffer Buffer;

    [InlineArray(516)]
    public partial struct _Buffer_e__FixedBuffer
    {
        public byte e0;
    }
}
