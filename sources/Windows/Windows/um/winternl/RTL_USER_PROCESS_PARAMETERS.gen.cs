// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;

namespace Silk.NET.Windows;
/// <include file='RTL_USER_PROCESS_PARAMETERS.xml' path='doc/member[@name="RTL_USER_PROCESS_PARAMETERS"]/*'/>
public unsafe partial struct RTL_USER_PROCESS_PARAMETERS
{
    /// <include file='RTL_USER_PROCESS_PARAMETERS.xml' path='doc/member[@name="RTL_USER_PROCESS_PARAMETERS.Reserved1"]/*'/>
    [NativeTypeName("BYTE[16]")]
    public fixed byte Reserved1[16];
    /// <include file='RTL_USER_PROCESS_PARAMETERS.xml' path='doc/member[@name="RTL_USER_PROCESS_PARAMETERS.Reserved2"]/*'/>
    [NativeTypeName("PVOID[10]")]
    public _Reserved2_e__FixedBuffer Reserved2;
    /// <include file='RTL_USER_PROCESS_PARAMETERS.xml' path='doc/member[@name="RTL_USER_PROCESS_PARAMETERS.ImagePathName"]/*'/>
    public UNICODE_STRING ImagePathName;
    /// <include file='RTL_USER_PROCESS_PARAMETERS.xml' path='doc/member[@name="RTL_USER_PROCESS_PARAMETERS.CommandLine"]/*'/>
    public UNICODE_STRING CommandLine;
    /// <include file='_Reserved2_e__FixedBuffer.xml' path='doc/member[@name="_Reserved2_e__FixedBuffer"]/*'/>
    public unsafe partial struct _Reserved2_e__FixedBuffer
    {
        public void* e0;
        public void* e1;
        public void* e2;
        public void* e3;
        public void* e4;
        public void* e5;
        public void* e6;
        public void* e7;
        public void* e8;
        public void* e9;
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