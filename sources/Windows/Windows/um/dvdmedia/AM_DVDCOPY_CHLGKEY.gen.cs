// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='AM_DVDCOPY_CHLGKEY.xml' path='doc/member[@name="AM_DVDCOPY_CHLGKEY"]/*'/>
public unsafe partial struct AM_DVDCOPY_CHLGKEY
{
    /// <include file='AM_DVDCOPY_CHLGKEY.xml' path='doc/member[@name="AM_DVDCOPY_CHLGKEY.ChlgKey"]/*'/>
    [NativeTypeName("BYTE[10]")]
    public fixed byte ChlgKey[10];
    /// <include file='AM_DVDCOPY_CHLGKEY.xml' path='doc/member[@name="AM_DVDCOPY_CHLGKEY.Reserved"]/*'/>
    [NativeTypeName("BYTE[2]")]
    public fixed byte Reserved[2];
}