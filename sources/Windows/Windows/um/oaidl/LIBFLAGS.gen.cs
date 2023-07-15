// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='LIBFLAGS.xml' path='doc/member[@name="LIBFLAGS"]/*'/>
public enum LIBFLAGS
{
    /// <include file='LIBFLAGS.xml' path='doc/member[@name="LIBFLAGS.LIBFLAG_FRESTRICTED"]/*'/>
    LIBFLAG_FRESTRICTED = 0x1,
    /// <include file='LIBFLAGS.xml' path='doc/member[@name="LIBFLAGS.LIBFLAG_FCONTROL"]/*'/>
    LIBFLAG_FCONTROL = 0x2,
    /// <include file='LIBFLAGS.xml' path='doc/member[@name="LIBFLAGS.LIBFLAG_FHIDDEN"]/*'/>
    LIBFLAG_FHIDDEN = 0x4,
    /// <include file='LIBFLAGS.xml' path='doc/member[@name="LIBFLAGS.LIBFLAG_FHASDISKIMAGE"]/*'/>
    LIBFLAG_FHASDISKIMAGE = 0x8,
}