// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DWORD_BLOB.xml' path='doc/member[@name="DWORD_BLOB"]/*'/>
public unsafe partial struct DWORD_BLOB
{
    /// <include file='DWORD_BLOB.xml' path='doc/member[@name="DWORD_BLOB.clSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint clSize;
    /// <include file='DWORD_BLOB.xml' path='doc/member[@name="DWORD_BLOB.alData"]/*'/>
    [NativeTypeName("ULONG[1]")]
    public fixed uint alData[1];
}