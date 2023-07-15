// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='FSCTL_QUERY_STORAGE_CLASSES_OUTPUT.xml' path='doc/member[@name="FSCTL_QUERY_STORAGE_CLASSES_OUTPUT"]/*'/>
public partial struct FSCTL_QUERY_STORAGE_CLASSES_OUTPUT
{
    /// <include file='FSCTL_QUERY_STORAGE_CLASSES_OUTPUT.xml' path='doc/member[@name="FSCTL_QUERY_STORAGE_CLASSES_OUTPUT.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='FSCTL_QUERY_STORAGE_CLASSES_OUTPUT.xml' path='doc/member[@name="FSCTL_QUERY_STORAGE_CLASSES_OUTPUT.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='FSCTL_QUERY_STORAGE_CLASSES_OUTPUT.xml' path='doc/member[@name="FSCTL_QUERY_STORAGE_CLASSES_OUTPUT.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='FSCTL_QUERY_STORAGE_CLASSES_OUTPUT.xml' path='doc/member[@name="FSCTL_QUERY_STORAGE_CLASSES_OUTPUT.TotalNumberOfTiers"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TotalNumberOfTiers;
    /// <include file='FSCTL_QUERY_STORAGE_CLASSES_OUTPUT.xml' path='doc/member[@name="FSCTL_QUERY_STORAGE_CLASSES_OUTPUT.NumberOfTiersReturned"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfTiersReturned;
    /// <include file='FSCTL_QUERY_STORAGE_CLASSES_OUTPUT.xml' path='doc/member[@name="FSCTL_QUERY_STORAGE_CLASSES_OUTPUT.Tiers"]/*'/>
    [NativeTypeName("FILE_STORAGE_TIER[1]")]
    public _Tiers_e__FixedBuffer Tiers;
    /// <include file='_Tiers_e__FixedBuffer.xml' path='doc/member[@name="_Tiers_e__FixedBuffer"]/*'/>
    public partial struct _Tiers_e__FixedBuffer
    {
        public FILE_STORAGE_TIER e0;
        [UnscopedRef]
        public ref FILE_STORAGE_TIER this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<FILE_STORAGE_TIER> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}