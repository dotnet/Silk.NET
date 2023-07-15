// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='FD_FLAGS.xml' path='doc/member[@name="FD_FLAGS"]/*'/>
public enum FD_FLAGS
{
    /// <include file='FD_FLAGS.xml' path='doc/member[@name="FD_FLAGS.FD_CLSID"]/*'/>
    FD_CLSID = 0x00000001,
    /// <include file='FD_FLAGS.xml' path='doc/member[@name="FD_FLAGS.FD_SIZEPOINT"]/*'/>
    FD_SIZEPOINT = 0x00000002,
    /// <include file='FD_FLAGS.xml' path='doc/member[@name="FD_FLAGS.FD_ATTRIBUTES"]/*'/>
    FD_ATTRIBUTES = 0x00000004,
    /// <include file='FD_FLAGS.xml' path='doc/member[@name="FD_FLAGS.FD_CREATETIME"]/*'/>
    FD_CREATETIME = 0x00000008,
    /// <include file='FD_FLAGS.xml' path='doc/member[@name="FD_FLAGS.FD_ACCESSTIME"]/*'/>
    FD_ACCESSTIME = 0x00000010,
    /// <include file='FD_FLAGS.xml' path='doc/member[@name="FD_FLAGS.FD_WRITESTIME"]/*'/>
    FD_WRITESTIME = 0x00000020,
    /// <include file='FD_FLAGS.xml' path='doc/member[@name="FD_FLAGS.FD_FILESIZE"]/*'/>
    FD_FILESIZE = 0x00000040,
    /// <include file='FD_FLAGS.xml' path='doc/member[@name="FD_FLAGS.FD_PROGRESSUI"]/*'/>
    FD_PROGRESSUI = 0x00004000,
    /// <include file='FD_FLAGS.xml' path='doc/member[@name="FD_FLAGS.FD_LINKUI"]/*'/>
    FD_LINKUI = 0x00008000,
    /// <include file='FD_FLAGS.xml' path='doc/member[@name="FD_FLAGS.FD_UNICODE"]/*'/>
    FD_UNICODE = unchecked((int)(0x80000000)),
}