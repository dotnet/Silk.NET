// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='KNOWN_FOLDER_FLAG.xml' path='doc/member[@name="KNOWN_FOLDER_FLAG"]/*'/>
public enum KNOWN_FOLDER_FLAG
{
    /// <include file='KNOWN_FOLDER_FLAG.xml' path='doc/member[@name="KNOWN_FOLDER_FLAG.KF_FLAG_DEFAULT"]/*'/>
    KF_FLAG_DEFAULT = 0x00000000,
    /// <include file='KNOWN_FOLDER_FLAG.xml' path='doc/member[@name="KNOWN_FOLDER_FLAG.KF_FLAG_FORCE_APP_DATA_REDIRECTION"]/*'/>
    KF_FLAG_FORCE_APP_DATA_REDIRECTION = 0x00080000,
    /// <include file='KNOWN_FOLDER_FLAG.xml' path='doc/member[@name="KNOWN_FOLDER_FLAG.KF_FLAG_RETURN_FILTER_REDIRECTION_TARGET"]/*'/>
    KF_FLAG_RETURN_FILTER_REDIRECTION_TARGET = 0x00040000,
    /// <include file='KNOWN_FOLDER_FLAG.xml' path='doc/member[@name="KNOWN_FOLDER_FLAG.KF_FLAG_FORCE_PACKAGE_REDIRECTION"]/*'/>
    KF_FLAG_FORCE_PACKAGE_REDIRECTION = 0x00020000,
    /// <include file='KNOWN_FOLDER_FLAG.xml' path='doc/member[@name="KNOWN_FOLDER_FLAG.KF_FLAG_NO_PACKAGE_REDIRECTION"]/*'/>
    KF_FLAG_NO_PACKAGE_REDIRECTION = 0x00010000,
    /// <include file='KNOWN_FOLDER_FLAG.xml' path='doc/member[@name="KNOWN_FOLDER_FLAG.KF_FLAG_FORCE_APPCONTAINER_REDIRECTION"]/*'/>
    KF_FLAG_FORCE_APPCONTAINER_REDIRECTION = 0x00020000,
    /// <include file='KNOWN_FOLDER_FLAG.xml' path='doc/member[@name="KNOWN_FOLDER_FLAG.KF_FLAG_NO_APPCONTAINER_REDIRECTION"]/*'/>
    KF_FLAG_NO_APPCONTAINER_REDIRECTION = 0x00010000,
    /// <include file='KNOWN_FOLDER_FLAG.xml' path='doc/member[@name="KNOWN_FOLDER_FLAG.KF_FLAG_CREATE"]/*'/>
    KF_FLAG_CREATE = 0x00008000,
    /// <include file='KNOWN_FOLDER_FLAG.xml' path='doc/member[@name="KNOWN_FOLDER_FLAG.KF_FLAG_DONT_VERIFY"]/*'/>
    KF_FLAG_DONT_VERIFY = 0x00004000,
    /// <include file='KNOWN_FOLDER_FLAG.xml' path='doc/member[@name="KNOWN_FOLDER_FLAG.KF_FLAG_DONT_UNEXPAND"]/*'/>
    KF_FLAG_DONT_UNEXPAND = 0x00002000,
    /// <include file='KNOWN_FOLDER_FLAG.xml' path='doc/member[@name="KNOWN_FOLDER_FLAG.KF_FLAG_NO_ALIAS"]/*'/>
    KF_FLAG_NO_ALIAS = 0x00001000,
    /// <include file='KNOWN_FOLDER_FLAG.xml' path='doc/member[@name="KNOWN_FOLDER_FLAG.KF_FLAG_INIT"]/*'/>
    KF_FLAG_INIT = 0x00000800,
    /// <include file='KNOWN_FOLDER_FLAG.xml' path='doc/member[@name="KNOWN_FOLDER_FLAG.KF_FLAG_DEFAULT_PATH"]/*'/>
    KF_FLAG_DEFAULT_PATH = 0x00000400,
    /// <include file='KNOWN_FOLDER_FLAG.xml' path='doc/member[@name="KNOWN_FOLDER_FLAG.KF_FLAG_NOT_PARENT_RELATIVE"]/*'/>
    KF_FLAG_NOT_PARENT_RELATIVE = 0x00000200,
    /// <include file='KNOWN_FOLDER_FLAG.xml' path='doc/member[@name="KNOWN_FOLDER_FLAG.KF_FLAG_SIMPLE_IDLIST"]/*'/>
    KF_FLAG_SIMPLE_IDLIST = 0x00000100,
    /// <include file='KNOWN_FOLDER_FLAG.xml' path='doc/member[@name="KNOWN_FOLDER_FLAG.KF_FLAG_ALIAS_ONLY"]/*'/>
    KF_FLAG_ALIAS_ONLY = unchecked((int)(0x80000000)),
}