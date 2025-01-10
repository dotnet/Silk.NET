// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SPC_SERIALIZED_OBJECT
{
    [NativeTypeName("SPC_UUID")]
    public _ClassId_e__FixedBuffer ClassId;
    public CRYPT_DATA_BLOB SerializedData;

    [InlineArray(16)]
    public partial struct _ClassId_e__FixedBuffer
    {
        public byte e0;
    }
}
