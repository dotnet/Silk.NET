// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS"]/*' />
public enum SHELL_LINK_DATA_FLAGS
{
    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_DEFAULT"]/*' />
    SLDF_DEFAULT = 0x00000000,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_HAS_ID_LIST"]/*' />
    SLDF_HAS_ID_LIST = 0x00000001,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_HAS_LINK_INFO"]/*' />
    SLDF_HAS_LINK_INFO = 0x00000002,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_HAS_NAME"]/*' />
    SLDF_HAS_NAME = 0x00000004,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_HAS_RELPATH"]/*' />
    SLDF_HAS_RELPATH = 0x00000008,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_HAS_WORKINGDIR"]/*' />
    SLDF_HAS_WORKINGDIR = 0x00000010,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_HAS_ARGS"]/*' />
    SLDF_HAS_ARGS = 0x00000020,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_HAS_ICONLOCATION"]/*' />
    SLDF_HAS_ICONLOCATION = 0x00000040,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_UNICODE"]/*' />
    SLDF_UNICODE = 0x00000080,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_FORCE_NO_LINKINFO"]/*' />
    SLDF_FORCE_NO_LINKINFO = 0x00000100,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_HAS_EXP_SZ"]/*' />
    SLDF_HAS_EXP_SZ = 0x00000200,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_RUN_IN_SEPARATE"]/*' />
    SLDF_RUN_IN_SEPARATE = 0x00000400,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_HAS_DARWINID"]/*' />
    SLDF_HAS_DARWINID = 0x00001000,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_RUNAS_USER"]/*' />
    SLDF_RUNAS_USER = 0x00002000,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_HAS_EXP_ICON_SZ"]/*' />
    SLDF_HAS_EXP_ICON_SZ = 0x00004000,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_NO_PIDL_ALIAS"]/*' />
    SLDF_NO_PIDL_ALIAS = 0x00008000,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_FORCE_UNCNAME"]/*' />
    SLDF_FORCE_UNCNAME = 0x00010000,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_RUN_WITH_SHIMLAYER"]/*' />
    SLDF_RUN_WITH_SHIMLAYER = 0x00020000,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_FORCE_NO_LINKTRACK"]/*' />
    SLDF_FORCE_NO_LINKTRACK = 0x00040000,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_ENABLE_TARGET_METADATA"]/*' />
    SLDF_ENABLE_TARGET_METADATA = 0x00080000,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_DISABLE_LINK_PATH_TRACKING"]/*' />
    SLDF_DISABLE_LINK_PATH_TRACKING = 0x00100000,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_DISABLE_KNOWNFOLDER_RELATIVE_TRACKING"]/*' />
    SLDF_DISABLE_KNOWNFOLDER_RELATIVE_TRACKING = 0x00200000,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_NO_KF_ALIAS"]/*' />
    SLDF_NO_KF_ALIAS = 0x00400000,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_ALLOW_LINK_TO_LINK"]/*' />
    SLDF_ALLOW_LINK_TO_LINK = 0x00800000,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_UNALIAS_ON_SAVE"]/*' />
    SLDF_UNALIAS_ON_SAVE = 0x01000000,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_PREFER_ENVIRONMENT_PATH"]/*' />
    SLDF_PREFER_ENVIRONMENT_PATH = 0x02000000,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_KEEP_LOCAL_IDLIST_FOR_UNC_TARGET"]/*' />
    SLDF_KEEP_LOCAL_IDLIST_FOR_UNC_TARGET = 0x04000000,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_PERSIST_VOLUME_ID_RELATIVE"]/*' />
    SLDF_PERSIST_VOLUME_ID_RELATIVE = 0x08000000,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_VALID"]/*' />
    SLDF_VALID = 0x0FFFF7FF,

    /// <include file='SHELL_LINK_DATA_FLAGS.xml' path='doc/member[@name="SHELL_LINK_DATA_FLAGS.SLDF_RESERVED"]/*' />
    SLDF_RESERVED = unchecked((int)(0x80000000)),
}
