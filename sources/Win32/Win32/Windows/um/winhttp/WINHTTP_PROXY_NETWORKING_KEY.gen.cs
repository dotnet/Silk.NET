// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct WINHTTP_PROXY_NETWORKING_KEY
{
    [NativeTypeName("unsigned char[128]")]
    public _pbBuffer_e__FixedBuffer pbBuffer;

    [InlineArray(128)]
    public partial struct _pbBuffer_e__FixedBuffer
    {
        public byte e0;
    }
}
