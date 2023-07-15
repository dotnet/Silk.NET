// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MF_TRANSCODE_ADJUST_PROFILE_FLAGS.xml' path='doc/member[@name="MF_TRANSCODE_ADJUST_PROFILE_FLAGS"]/*'/>
public enum MF_TRANSCODE_ADJUST_PROFILE_FLAGS
{
    /// <include file='MF_TRANSCODE_ADJUST_PROFILE_FLAGS.xml' path='doc/member[@name="MF_TRANSCODE_ADJUST_PROFILE_FLAGS.MF_TRANSCODE_ADJUST_PROFILE_DEFAULT"]/*'/>
    MF_TRANSCODE_ADJUST_PROFILE_DEFAULT = 0,
    /// <include file='MF_TRANSCODE_ADJUST_PROFILE_FLAGS.xml' path='doc/member[@name="MF_TRANSCODE_ADJUST_PROFILE_FLAGS.MF_TRANSCODE_ADJUST_PROFILE_USE_SOURCE_ATTRIBUTES"]/*'/>
    MF_TRANSCODE_ADJUST_PROFILE_USE_SOURCE_ATTRIBUTES = 1,
}