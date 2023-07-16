// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='WAVEFORMATEXTENSIBLE.xml' path='doc/member[@name="WAVEFORMATEXTENSIBLE"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WAVEFORMATEXTENSIBLE
{
    /// <include file='WAVEFORMATEXTENSIBLE.xml' path='doc/member[@name="WAVEFORMATEXTENSIBLE.Format"]/*'/>
    public WAVEFORMATEX Format;
    /// <include file='WAVEFORMATEXTENSIBLE.xml' path='doc/member[@name="WAVEFORMATEXTENSIBLE.Samples"]/*'/>
    [NativeTypeName("__AnonymousRecord_mmreg_L2525_C5")]
    public _Samples_e__Union Samples;
    /// <include file='WAVEFORMATEXTENSIBLE.xml' path='doc/member[@name="WAVEFORMATEXTENSIBLE.dwChannelMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwChannelMask;
    /// <include file='WAVEFORMATEXTENSIBLE.xml' path='doc/member[@name="WAVEFORMATEXTENSIBLE.SubFormat"]/*'/>
    public Guid SubFormat;
    /// <include file='_Samples_e__Union.xml' path='doc/member[@name="_Samples_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public partial struct _Samples_e__Union
    {
        /// <include file='_Samples_e__Union.xml' path='doc/member[@name="_Samples_e__Union.wValidBitsPerSample"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("WORD")]
        public ushort wValidBitsPerSample;
        /// <include file='_Samples_e__Union.xml' path='doc/member[@name="_Samples_e__Union.wSamplesPerBlock"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("WORD")]
        public ushort wSamplesPerBlock;
        /// <include file='_Samples_e__Union.xml' path='doc/member[@name="_Samples_e__Union.wReserved"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("WORD")]
        public ushort wReserved;
    }
}