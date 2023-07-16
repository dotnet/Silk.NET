// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SYNCMGR_CONFLICT_ID_INFO.xml' path='doc/member[@name="SYNCMGR_CONFLICT_ID_INFO"]/*'/>
public unsafe partial struct SYNCMGR_CONFLICT_ID_INFO
{
    /// <include file='SYNCMGR_CONFLICT_ID_INFO.xml' path='doc/member[@name="SYNCMGR_CONFLICT_ID_INFO.pblobID"]/*'/>
    public BYTE_BLOB* pblobID;
    /// <include file='SYNCMGR_CONFLICT_ID_INFO.xml' path='doc/member[@name="SYNCMGR_CONFLICT_ID_INFO.pblobExtra"]/*'/>
    public BYTE_BLOB* pblobExtra;
}