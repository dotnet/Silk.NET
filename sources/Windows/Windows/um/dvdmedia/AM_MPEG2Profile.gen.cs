// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='AM_MPEG2Profile.xml' path='doc/member[@name="AM_MPEG2Profile"]/*'/>
public enum AM_MPEG2Profile
{
    /// <include file='AM_MPEG2Profile.xml' path='doc/member[@name="AM_MPEG2Profile.AM_MPEG2Profile_Simple"]/*'/>
    AM_MPEG2Profile_Simple = 1,
    /// <include file='AM_MPEG2Profile.xml' path='doc/member[@name="AM_MPEG2Profile.AM_MPEG2Profile_Main"]/*'/>
    AM_MPEG2Profile_Main = 2,
    /// <include file='AM_MPEG2Profile.xml' path='doc/member[@name="AM_MPEG2Profile.AM_MPEG2Profile_SNRScalable"]/*'/>
    AM_MPEG2Profile_SNRScalable = 3,
    /// <include file='AM_MPEG2Profile.xml' path='doc/member[@name="AM_MPEG2Profile.AM_MPEG2Profile_SpatiallyScalable"]/*'/>
    AM_MPEG2Profile_SpatiallyScalable = 4,
    /// <include file='AM_MPEG2Profile.xml' path='doc/member[@name="AM_MPEG2Profile.AM_MPEG2Profile_High"]/*'/>
    AM_MPEG2Profile_High = 5,
}