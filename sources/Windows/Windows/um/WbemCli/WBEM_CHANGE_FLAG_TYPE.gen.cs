// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WBEM_CHANGE_FLAG_TYPE.xml' path='doc/member[@name="WBEM_CHANGE_FLAG_TYPE"]/*'/>
public enum WBEM_CHANGE_FLAG_TYPE
{
    /// <include file='WBEM_CHANGE_FLAG_TYPE.xml' path='doc/member[@name="WBEM_CHANGE_FLAG_TYPE.WBEM_FLAG_CREATE_OR_UPDATE"]/*'/>
    WBEM_FLAG_CREATE_OR_UPDATE = 0,
    /// <include file='WBEM_CHANGE_FLAG_TYPE.xml' path='doc/member[@name="WBEM_CHANGE_FLAG_TYPE.WBEM_FLAG_UPDATE_ONLY"]/*'/>
    WBEM_FLAG_UPDATE_ONLY = 0x1,
    /// <include file='WBEM_CHANGE_FLAG_TYPE.xml' path='doc/member[@name="WBEM_CHANGE_FLAG_TYPE.WBEM_FLAG_CREATE_ONLY"]/*'/>
    WBEM_FLAG_CREATE_ONLY = 0x2,
    /// <include file='WBEM_CHANGE_FLAG_TYPE.xml' path='doc/member[@name="WBEM_CHANGE_FLAG_TYPE.WBEM_FLAG_UPDATE_COMPATIBLE"]/*'/>
    WBEM_FLAG_UPDATE_COMPATIBLE = 0,
    /// <include file='WBEM_CHANGE_FLAG_TYPE.xml' path='doc/member[@name="WBEM_CHANGE_FLAG_TYPE.WBEM_FLAG_UPDATE_SAFE_MODE"]/*'/>
    WBEM_FLAG_UPDATE_SAFE_MODE = 0x20,
    /// <include file='WBEM_CHANGE_FLAG_TYPE.xml' path='doc/member[@name="WBEM_CHANGE_FLAG_TYPE.WBEM_FLAG_UPDATE_FORCE_MODE"]/*'/>
    WBEM_FLAG_UPDATE_FORCE_MODE = 0x40,
    /// <include file='WBEM_CHANGE_FLAG_TYPE.xml' path='doc/member[@name="WBEM_CHANGE_FLAG_TYPE.WBEM_MASK_UPDATE_MODE"]/*'/>
    WBEM_MASK_UPDATE_MODE = 0x60,
    /// <include file='WBEM_CHANGE_FLAG_TYPE.xml' path='doc/member[@name="WBEM_CHANGE_FLAG_TYPE.WBEM_FLAG_ADVISORY"]/*'/>
    WBEM_FLAG_ADVISORY = 0x10000,
}