// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CONFIRM_CONFLICT_RESULT_INFO.xml' path='doc/member[@name="CONFIRM_CONFLICT_RESULT_INFO"]/*'/>
public unsafe partial struct CONFIRM_CONFLICT_RESULT_INFO
{
    /// <include file='CONFIRM_CONFLICT_RESULT_INFO.xml' path='doc/member[@name="CONFIRM_CONFLICT_RESULT_INFO.pszNewName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszNewName;
    /// <include file='CONFIRM_CONFLICT_RESULT_INFO.xml' path='doc/member[@name="CONFIRM_CONFLICT_RESULT_INFO.iItemIndex"]/*'/>
    public uint iItemIndex;
}