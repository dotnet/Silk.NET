// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;

namespace Silk.NET.Windows;
/// <include file='SYSTEM_POLICY_INFORMATION.xml' path='doc/member[@name="SYSTEM_POLICY_INFORMATION"]/*'/>
public unsafe partial struct SYSTEM_POLICY_INFORMATION
{
    /// <include file='SYSTEM_POLICY_INFORMATION.xml' path='doc/member[@name="SYSTEM_POLICY_INFORMATION.Reserved1"]/*'/>
    [NativeTypeName("PVOID[2]")]
    public _Reserved1_e__FixedBuffer Reserved1;
    /// <include file='SYSTEM_POLICY_INFORMATION.xml' path='doc/member[@name="SYSTEM_POLICY_INFORMATION.Reserved2"]/*'/>
    [NativeTypeName("ULONG[3]")]
    public fixed uint Reserved2[3];
    /// <include file='_Reserved1_e__FixedBuffer.xml' path='doc/member[@name="_Reserved1_e__FixedBuffer"]/*'/>
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
}