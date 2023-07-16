// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MF_FILE_OPENMODE.xml' path='doc/member[@name="MF_FILE_OPENMODE"]/*'/>
public enum MF_FILE_OPENMODE
{
    /// <include file='MF_FILE_OPENMODE.xml' path='doc/member[@name="MF_FILE_OPENMODE.MF_OPENMODE_FAIL_IF_NOT_EXIST"]/*'/>
    MF_OPENMODE_FAIL_IF_NOT_EXIST = 0,
    /// <include file='MF_FILE_OPENMODE.xml' path='doc/member[@name="MF_FILE_OPENMODE.MF_OPENMODE_FAIL_IF_EXIST"]/*'/>
    MF_OPENMODE_FAIL_IF_EXIST = 1,
    /// <include file='MF_FILE_OPENMODE.xml' path='doc/member[@name="MF_FILE_OPENMODE.MF_OPENMODE_RESET_IF_EXIST"]/*'/>
    MF_OPENMODE_RESET_IF_EXIST = 2,
    /// <include file='MF_FILE_OPENMODE.xml' path='doc/member[@name="MF_FILE_OPENMODE.MF_OPENMODE_APPEND_IF_EXIST"]/*'/>
    MF_OPENMODE_APPEND_IF_EXIST = 3,
    /// <include file='MF_FILE_OPENMODE.xml' path='doc/member[@name="MF_FILE_OPENMODE.MF_OPENMODE_DELETE_IF_EXIST"]/*'/>
    MF_OPENMODE_DELETE_IF_EXIST = 4,
}