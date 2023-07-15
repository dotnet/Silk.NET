// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;
/// <include file='COPYFILE2_EXTENDED_PARAMETERS_V2.xml' path='doc/member[@name="COPYFILE2_EXTENDED_PARAMETERS_V2"]/*'/>
public unsafe partial struct COPYFILE2_EXTENDED_PARAMETERS_V2
{
    /// <include file='COPYFILE2_EXTENDED_PARAMETERS_V2.xml' path='doc/member[@name="COPYFILE2_EXTENDED_PARAMETERS_V2.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='COPYFILE2_EXTENDED_PARAMETERS_V2.xml' path='doc/member[@name="COPYFILE2_EXTENDED_PARAMETERS_V2.dwCopyFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCopyFlags;
    /// <include file='COPYFILE2_EXTENDED_PARAMETERS_V2.xml' path='doc/member[@name="COPYFILE2_EXTENDED_PARAMETERS_V2.pfCancel"]/*'/>
    public BOOL* pfCancel;
    /// <include file='COPYFILE2_EXTENDED_PARAMETERS_V2.xml' path='doc/member[@name="COPYFILE2_EXTENDED_PARAMETERS_V2.pProgressRoutine"]/*'/>
    [NativeTypeName("PCOPYFILE2_PROGRESS_ROUTINE")]
    public delegate* unmanaged<COPYFILE2_MESSAGE*, void*, COPYFILE2_MESSAGE_ACTION> pProgressRoutine;
    /// <include file='COPYFILE2_EXTENDED_PARAMETERS_V2.xml' path='doc/member[@name="COPYFILE2_EXTENDED_PARAMETERS_V2.pvCallbackContext"]/*'/>
    [NativeTypeName("PVOID")]
    public void* pvCallbackContext;
    /// <include file='COPYFILE2_EXTENDED_PARAMETERS_V2.xml' path='doc/member[@name="COPYFILE2_EXTENDED_PARAMETERS_V2.dwCopyFlagsV2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCopyFlagsV2;
    /// <include file='COPYFILE2_EXTENDED_PARAMETERS_V2.xml' path='doc/member[@name="COPYFILE2_EXTENDED_PARAMETERS_V2.ioDesiredSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ioDesiredSize;
    /// <include file='COPYFILE2_EXTENDED_PARAMETERS_V2.xml' path='doc/member[@name="COPYFILE2_EXTENDED_PARAMETERS_V2.ioDesiredRate"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ioDesiredRate;
    /// <include file='COPYFILE2_EXTENDED_PARAMETERS_V2.xml' path='doc/member[@name="COPYFILE2_EXTENDED_PARAMETERS_V2.reserved"]/*'/>
    [NativeTypeName("PVOID[8]")]
    public _reserved_e__FixedBuffer reserved;
    /// <include file='_reserved_e__FixedBuffer.xml' path='doc/member[@name="_reserved_e__FixedBuffer"]/*'/>
    public unsafe partial struct _reserved_e__FixedBuffer
    {
        public void* e0;
        public void* e1;
        public void* e2;
        public void* e3;
        public void* e4;
        public void* e5;
        public void* e6;
        public void* e7;
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