// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='SYNCMGRLOGERRORINFO.xml' path='doc/member[@name="SYNCMGRLOGERRORINFO"]/*'/>
public partial struct SYNCMGRLOGERRORINFO
{
    /// <include file='SYNCMGRLOGERRORINFO.xml' path='doc/member[@name="SYNCMGRLOGERRORINFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='SYNCMGRLOGERRORINFO.xml' path='doc/member[@name="SYNCMGRLOGERRORINFO.mask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint mask;
    /// <include file='SYNCMGRLOGERRORINFO.xml' path='doc/member[@name="SYNCMGRLOGERRORINFO.dwSyncMgrErrorFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSyncMgrErrorFlags;
    /// <include file='SYNCMGRLOGERRORINFO.xml' path='doc/member[@name="SYNCMGRLOGERRORINFO.ErrorID"]/*'/>
    public Guid ErrorID;
    /// <include file='SYNCMGRLOGERRORINFO.xml' path='doc/member[@name="SYNCMGRLOGERRORINFO.ItemID"]/*'/>
    public Guid ItemID;
}