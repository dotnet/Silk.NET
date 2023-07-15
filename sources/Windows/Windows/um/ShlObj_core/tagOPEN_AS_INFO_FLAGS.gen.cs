// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='tagOPEN_AS_INFO_FLAGS.xml' path='doc/member[@name="tagOPEN_AS_INFO_FLAGS"]/*'/>
public enum tagOPEN_AS_INFO_FLAGS
{
    /// <include file='tagOPEN_AS_INFO_FLAGS.xml' path='doc/member[@name="tagOPEN_AS_INFO_FLAGS.OAIF_ALLOW_REGISTRATION"]/*'/>
    OAIF_ALLOW_REGISTRATION = 0x00000001,
    /// <include file='tagOPEN_AS_INFO_FLAGS.xml' path='doc/member[@name="tagOPEN_AS_INFO_FLAGS.OAIF_REGISTER_EXT"]/*'/>
    OAIF_REGISTER_EXT = 0x00000002,
    /// <include file='tagOPEN_AS_INFO_FLAGS.xml' path='doc/member[@name="tagOPEN_AS_INFO_FLAGS.OAIF_EXEC"]/*'/>
    OAIF_EXEC = 0x00000004,
    /// <include file='tagOPEN_AS_INFO_FLAGS.xml' path='doc/member[@name="tagOPEN_AS_INFO_FLAGS.OAIF_FORCE_REGISTRATION"]/*'/>
    OAIF_FORCE_REGISTRATION = 0x00000008,
    /// <include file='tagOPEN_AS_INFO_FLAGS.xml' path='doc/member[@name="tagOPEN_AS_INFO_FLAGS.OAIF_HIDE_REGISTRATION"]/*'/>
    OAIF_HIDE_REGISTRATION = 0x00000020,
    /// <include file='tagOPEN_AS_INFO_FLAGS.xml' path='doc/member[@name="tagOPEN_AS_INFO_FLAGS.OAIF_URL_PROTOCOL"]/*'/>
    OAIF_URL_PROTOCOL = 0x00000040,
    /// <include file='tagOPEN_AS_INFO_FLAGS.xml' path='doc/member[@name="tagOPEN_AS_INFO_FLAGS.OAIF_FILE_IS_URI"]/*'/>
    OAIF_FILE_IS_URI = 0x00000080,
}