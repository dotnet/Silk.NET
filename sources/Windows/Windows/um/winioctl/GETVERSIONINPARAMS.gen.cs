// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='GETVERSIONINPARAMS.xml' path='doc/member[@name="GETVERSIONINPARAMS"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct GETVERSIONINPARAMS
{
    /// <include file='GETVERSIONINPARAMS.xml' path='doc/member[@name="GETVERSIONINPARAMS.bVersion"]/*'/>
    public byte bVersion;
    /// <include file='GETVERSIONINPARAMS.xml' path='doc/member[@name="GETVERSIONINPARAMS.bRevision"]/*'/>
    public byte bRevision;
    /// <include file='GETVERSIONINPARAMS.xml' path='doc/member[@name="GETVERSIONINPARAMS.bReserved"]/*'/>
    public byte bReserved;
    /// <include file='GETVERSIONINPARAMS.xml' path='doc/member[@name="GETVERSIONINPARAMS.bIDEDeviceMap"]/*'/>
    public byte bIDEDeviceMap;
    /// <include file='GETVERSIONINPARAMS.xml' path='doc/member[@name="GETVERSIONINPARAMS.fCapabilities"]/*'/>
    [NativeTypeName("DWORD")]
    public uint fCapabilities;
    /// <include file='GETVERSIONINPARAMS.xml' path='doc/member[@name="GETVERSIONINPARAMS.dwReserved"]/*'/>
    [NativeTypeName("DWORD[4]")]
    public fixed uint dwReserved[4];
}