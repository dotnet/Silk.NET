// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SOURCEFILE.xml' path='doc/member[@name="SOURCEFILE"]/*'/>
public unsafe partial struct SOURCEFILE
{
    /// <include file='SOURCEFILE.xml' path='doc/member[@name="SOURCEFILE.ModBase"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong ModBase;
    /// <include file='SOURCEFILE.xml' path='doc/member[@name="SOURCEFILE.FileName"]/*'/>
    [NativeTypeName("PCHAR")]
    public sbyte* FileName;
}