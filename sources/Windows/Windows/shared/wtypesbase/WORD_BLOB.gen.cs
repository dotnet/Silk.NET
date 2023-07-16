// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WORD_BLOB.xml' path='doc/member[@name="WORD_BLOB"]/*'/>
public unsafe partial struct WORD_BLOB
{
    /// <include file='WORD_BLOB.xml' path='doc/member[@name="WORD_BLOB.clSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint clSize;
    /// <include file='WORD_BLOB.xml' path='doc/member[@name="WORD_BLOB.asData"]/*'/>
    [NativeTypeName("unsigned short[1]")]
    public fixed ushort asData[1];
}