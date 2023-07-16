// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SOURCEFILEW.xml' path='doc/member[@name="SOURCEFILEW"]/*'/>
public unsafe partial struct SOURCEFILEW
{
    /// <include file='SOURCEFILEW.xml' path='doc/member[@name="SOURCEFILEW.ModBase"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong ModBase;
    /// <include file='SOURCEFILEW.xml' path='doc/member[@name="SOURCEFILEW.FileName"]/*'/>
    [NativeTypeName("PWSTR")]
    public ushort* FileName;
}