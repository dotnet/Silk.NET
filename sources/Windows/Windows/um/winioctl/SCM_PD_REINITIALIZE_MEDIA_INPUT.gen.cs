// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;
/// <include file='SCM_PD_REINITIALIZE_MEDIA_INPUT.xml' path='doc/member[@name="SCM_PD_REINITIALIZE_MEDIA_INPUT"]/*'/>
public partial struct SCM_PD_REINITIALIZE_MEDIA_INPUT
{
    /// <include file='SCM_PD_REINITIALIZE_MEDIA_INPUT.xml' path='doc/member[@name="SCM_PD_REINITIALIZE_MEDIA_INPUT.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='SCM_PD_REINITIALIZE_MEDIA_INPUT.xml' path='doc/member[@name="SCM_PD_REINITIALIZE_MEDIA_INPUT.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='SCM_PD_REINITIALIZE_MEDIA_INPUT.xml' path='doc/member[@name="SCM_PD_REINITIALIZE_MEDIA_INPUT.Options"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L8344_C5")]
    public _Options_e__Struct Options;
    /// <include file='_Options_e__Struct.xml' path='doc/member[@name="_Options_e__Struct"]/*'/>
    public partial struct _Options_e__Struct
    {
        public uint _bitfield;
        /// <include file='_Options_e__Struct.xml' path='doc/member[@name="_Options_e__Struct.Overwrite"]/*'/>
        [NativeTypeName("DWORD : 1")]
        public uint Overwrite
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
            }
        }
    }
}