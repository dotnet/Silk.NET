// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WBEM_COMPILER_OPTIONS.xml' path='doc/member[@name="WBEM_COMPILER_OPTIONS"]/*'/>
public enum WBEM_COMPILER_OPTIONS
{
    /// <include file='WBEM_COMPILER_OPTIONS.xml' path='doc/member[@name="WBEM_COMPILER_OPTIONS.WBEM_FLAG_CHECK_ONLY"]/*'/>
    WBEM_FLAG_CHECK_ONLY = 0x1,
    /// <include file='WBEM_COMPILER_OPTIONS.xml' path='doc/member[@name="WBEM_COMPILER_OPTIONS.WBEM_FLAG_AUTORECOVER"]/*'/>
    WBEM_FLAG_AUTORECOVER = 0x2,
    /// <include file='WBEM_COMPILER_OPTIONS.xml' path='doc/member[@name="WBEM_COMPILER_OPTIONS.WBEM_FLAG_WMI_CHECK"]/*'/>
    WBEM_FLAG_WMI_CHECK = 0x4,
    /// <include file='WBEM_COMPILER_OPTIONS.xml' path='doc/member[@name="WBEM_COMPILER_OPTIONS.WBEM_FLAG_CONSOLE_PRINT"]/*'/>
    WBEM_FLAG_CONSOLE_PRINT = 0x8,
    /// <include file='WBEM_COMPILER_OPTIONS.xml' path='doc/member[@name="WBEM_COMPILER_OPTIONS.WBEM_FLAG_DONT_ADD_TO_LIST"]/*'/>
    WBEM_FLAG_DONT_ADD_TO_LIST = 0x10,
    /// <include file='WBEM_COMPILER_OPTIONS.xml' path='doc/member[@name="WBEM_COMPILER_OPTIONS.WBEM_FLAG_SPLIT_FILES"]/*'/>
    WBEM_FLAG_SPLIT_FILES = 0x20,
    /// <include file='WBEM_COMPILER_OPTIONS.xml' path='doc/member[@name="WBEM_COMPILER_OPTIONS.WBEM_FLAG_STORE_FILE"]/*'/>
    WBEM_FLAG_STORE_FILE = 0x100,
}