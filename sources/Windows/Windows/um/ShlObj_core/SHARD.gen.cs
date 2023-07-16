// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SHARD.xml' path='doc/member[@name="SHARD"]/*'/>
public enum SHARD
{
    /// <include file='SHARD.xml' path='doc/member[@name="SHARD.SHARD_PIDL"]/*'/>
    SHARD_PIDL = 0x00000001,
    /// <include file='SHARD.xml' path='doc/member[@name="SHARD.SHARD_PATHA"]/*'/>
    SHARD_PATHA = 0x00000002,
    /// <include file='SHARD.xml' path='doc/member[@name="SHARD.SHARD_PATHW"]/*'/>
    SHARD_PATHW = 0x00000003,
    /// <include file='SHARD.xml' path='doc/member[@name="SHARD.SHARD_APPIDINFO"]/*'/>
    SHARD_APPIDINFO = 0x00000004,
    /// <include file='SHARD.xml' path='doc/member[@name="SHARD.SHARD_APPIDINFOIDLIST"]/*'/>
    SHARD_APPIDINFOIDLIST = 0x00000005,
    /// <include file='SHARD.xml' path='doc/member[@name="SHARD.SHARD_LINK"]/*'/>
    SHARD_LINK = 0x00000006,
    /// <include file='SHARD.xml' path='doc/member[@name="SHARD.SHARD_APPIDINFOLINK"]/*'/>
    SHARD_APPIDINFOLINK = 0x00000007,
    /// <include file='SHARD.xml' path='doc/member[@name="SHARD.SHARD_SHELLITEM"]/*'/>
    SHARD_SHELLITEM = 0x00000008,
}