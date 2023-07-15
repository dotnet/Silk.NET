// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MF_FILE_FLAGS.xml' path='doc/member[@name="MF_FILE_FLAGS"]/*'/>
public enum MF_FILE_FLAGS
{
    /// <include file='MF_FILE_FLAGS.xml' path='doc/member[@name="MF_FILE_FLAGS.MF_FILEFLAGS_NONE"]/*'/>
    MF_FILEFLAGS_NONE = 0,
    /// <include file='MF_FILE_FLAGS.xml' path='doc/member[@name="MF_FILE_FLAGS.MF_FILEFLAGS_NOBUFFERING"]/*'/>
    MF_FILEFLAGS_NOBUFFERING = 0x1,
    /// <include file='MF_FILE_FLAGS.xml' path='doc/member[@name="MF_FILE_FLAGS.MF_FILEFLAGS_ALLOW_WRITE_SHARING"]/*'/>
    MF_FILEFLAGS_ALLOW_WRITE_SHARING = 0x2,
}