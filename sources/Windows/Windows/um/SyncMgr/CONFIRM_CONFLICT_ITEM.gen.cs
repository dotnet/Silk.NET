// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CONFIRM_CONFLICT_ITEM.xml' path='doc/member[@name="CONFIRM_CONFLICT_ITEM"]/*'/>
public unsafe partial struct CONFIRM_CONFLICT_ITEM
{
    /// <include file='CONFIRM_CONFLICT_ITEM.xml' path='doc/member[@name="CONFIRM_CONFLICT_ITEM.pShellItem"]/*'/>
    public IShellItem2* pShellItem;
    /// <include file='CONFIRM_CONFLICT_ITEM.xml' path='doc/member[@name="CONFIRM_CONFLICT_ITEM.pszOriginalName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszOriginalName;
    /// <include file='CONFIRM_CONFLICT_ITEM.xml' path='doc/member[@name="CONFIRM_CONFLICT_ITEM.pszAlternateName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszAlternateName;
    /// <include file='CONFIRM_CONFLICT_ITEM.xml' path='doc/member[@name="CONFIRM_CONFLICT_ITEM.pszLocationShort"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszLocationShort;
    /// <include file='CONFIRM_CONFLICT_ITEM.xml' path='doc/member[@name="CONFIRM_CONFLICT_ITEM.pszLocationFull"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszLocationFull;
    /// <include file='CONFIRM_CONFLICT_ITEM.xml' path='doc/member[@name="CONFIRM_CONFLICT_ITEM.nType"]/*'/>
    public SYNCMGR_CONFLICT_ITEM_TYPE nType;
}