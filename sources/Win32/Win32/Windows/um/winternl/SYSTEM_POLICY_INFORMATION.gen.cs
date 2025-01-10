// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SYSTEM_POLICY_INFORMATION
{
    [NativeTypeName("PVOID[2]")]
    public _Reserved1_e__FixedBuffer Reserved1;

    [NativeTypeName("ULONG[3]")]
    public _Reserved2_e__FixedBuffer Reserved2;

    public unsafe partial struct _Reserved1_e__FixedBuffer
    {
        public void* e0;
        public void* e1;
        public ref void* this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (void** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }

    [InlineArray(3)]
    public partial struct _Reserved2_e__FixedBuffer
    {
        public uint e0;
    }
}
