// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FILE_ID_128.xml' path='doc/member[@name="FILE_ID_128"]/*'/>
public unsafe partial struct FILE_ID_128
{
    /// <include file='FILE_ID_128.xml' path='doc/member[@name="FILE_ID_128.Identifier"]/*'/>
    [NativeTypeName("BYTE[16]")]
    public fixed byte Identifier[16];
}