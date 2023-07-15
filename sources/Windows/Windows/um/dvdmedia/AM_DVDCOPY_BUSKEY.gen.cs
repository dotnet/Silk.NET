// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='AM_DVDCOPY_BUSKEY.xml' path='doc/member[@name="AM_DVDCOPY_BUSKEY"]/*'/>
public unsafe partial struct AM_DVDCOPY_BUSKEY
{
    /// <include file='AM_DVDCOPY_BUSKEY.xml' path='doc/member[@name="AM_DVDCOPY_BUSKEY.BusKey"]/*'/>
    [NativeTypeName("BYTE[5]")]
    public fixed byte BusKey[5];
    /// <include file='AM_DVDCOPY_BUSKEY.xml' path='doc/member[@name="AM_DVDCOPY_BUSKEY.Reserved"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte Reserved[1];
}