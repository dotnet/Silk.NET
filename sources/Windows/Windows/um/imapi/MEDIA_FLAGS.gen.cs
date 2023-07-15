// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MEDIA_FLAGS.xml' path='doc/member[@name="MEDIA_FLAGS"]/*'/>
public enum MEDIA_FLAGS
{
    /// <include file='MEDIA_FLAGS.xml' path='doc/member[@name="MEDIA_FLAGS.MEDIA_BLANK"]/*'/>
    MEDIA_BLANK = 0x1,
    /// <include file='MEDIA_FLAGS.xml' path='doc/member[@name="MEDIA_FLAGS.MEDIA_RW"]/*'/>
    MEDIA_RW = 0x2,
    /// <include file='MEDIA_FLAGS.xml' path='doc/member[@name="MEDIA_FLAGS.MEDIA_WRITABLE"]/*'/>
    MEDIA_WRITABLE = 0x4,
    /// <include file='MEDIA_FLAGS.xml' path='doc/member[@name="MEDIA_FLAGS.MEDIA_FORMAT_UNUSABLE_BY_IMAPI"]/*'/>
    MEDIA_FORMAT_UNUSABLE_BY_IMAPI = 0x8,
}