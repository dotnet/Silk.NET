// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace Silk.NET.Windows;

/// <include file='SYSTEM_BASIC_INFORMATION.xml' path='doc/member[@name="SYSTEM_BASIC_INFORMATION"]/*' />
public unsafe partial struct SYSTEM_BASIC_INFORMATION
{
    /// <include file='SYSTEM_BASIC_INFORMATION.xml' path='doc/member[@name="SYSTEM_BASIC_INFORMATION.Reserved1"]/*' />
    [NativeTypeName("BYTE[24]")]
    public fixed byte Reserved1[24];

    /// <include file='SYSTEM_BASIC_INFORMATION.xml' path='doc/member[@name="SYSTEM_BASIC_INFORMATION.Reserved2"]/*' />
    [NativeTypeName("PVOID[4]")]
    public _Reserved2_e__FixedBuffer Reserved2;

    /// <include file='SYSTEM_BASIC_INFORMATION.xml' path='doc/member[@name="SYSTEM_BASIC_INFORMATION.NumberOfProcessors"]/*' />
    [NativeTypeName("CCHAR")]
    public sbyte NumberOfProcessors;

    /// <include file='_Reserved2_e__FixedBuffer.xml' path='doc/member[@name="_Reserved2_e__FixedBuffer"]/*' />
    public unsafe partial struct _Reserved2_e__FixedBuffer
    {
        public void* e0;
        public void* e1;
        public void* e2;
        public void* e3;

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
}
