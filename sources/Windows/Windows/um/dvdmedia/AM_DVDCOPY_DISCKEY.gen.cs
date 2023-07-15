// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='AM_DVDCOPY_DISCKEY.xml' path='doc/member[@name="AM_DVDCOPY_DISCKEY"]/*'/>
public unsafe partial struct AM_DVDCOPY_DISCKEY
{
    /// <include file='AM_DVDCOPY_DISCKEY.xml' path='doc/member[@name="AM_DVDCOPY_DISCKEY.DiscKey"]/*'/>
    [NativeTypeName("BYTE[2048]")]
    public fixed byte DiscKey[2048];
}