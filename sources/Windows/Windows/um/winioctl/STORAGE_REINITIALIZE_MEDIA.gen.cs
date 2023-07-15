// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_REINITIALIZE_MEDIA.xml' path='doc/member[@name="STORAGE_REINITIALIZE_MEDIA"]/*'/>
public partial struct STORAGE_REINITIALIZE_MEDIA
{
    /// <include file='STORAGE_REINITIALIZE_MEDIA.xml' path='doc/member[@name="STORAGE_REINITIALIZE_MEDIA.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_REINITIALIZE_MEDIA.xml' path='doc/member[@name="STORAGE_REINITIALIZE_MEDIA.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_REINITIALIZE_MEDIA.xml' path='doc/member[@name="STORAGE_REINITIALIZE_MEDIA.TimeoutInSeconds"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TimeoutInSeconds;
    /// <include file='STORAGE_REINITIALIZE_MEDIA.xml' path='doc/member[@name="STORAGE_REINITIALIZE_MEDIA.SanitizeOption"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L5502_C5")]
    public _SanitizeOption_e__Struct SanitizeOption;
    /// <include file='_SanitizeOption_e__Struct.xml' path='doc/member[@name="_SanitizeOption_e__Struct"]/*'/>
    public partial struct _SanitizeOption_e__Struct
    {
        public uint _bitfield;
        /// <include file='_SanitizeOption_e__Struct.xml' path='doc/member[@name="_SanitizeOption_e__Struct.SanitizeMethod"]/*'/>
        [NativeTypeName("DWORD : 4")]
        public uint SanitizeMethod
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield & 0xFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0xFu) | (value & 0xFu);
            }
        }

        /// <include file='_SanitizeOption_e__Struct.xml' path='doc/member[@name="_SanitizeOption_e__Struct.DisallowUnrestrictedSanitizeExit"]/*'/>
        [NativeTypeName("DWORD : 1")]
        public uint DisallowUnrestrictedSanitizeExit
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 4) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4);
            }
        }

        /// <include file='_SanitizeOption_e__Struct.xml' path='doc/member[@name="_SanitizeOption_e__Struct.Reserved"]/*'/>
        [NativeTypeName("DWORD : 27")]
        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 5) & 0x7FFFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x7FFFFFFu << 5)) | ((value & 0x7FFFFFFu) << 5);
            }
        }
    }
}