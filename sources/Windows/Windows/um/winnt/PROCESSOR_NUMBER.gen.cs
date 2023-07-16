// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PROCESSOR_NUMBER.xml' path='doc/member[@name="PROCESSOR_NUMBER"]/*'/>
public partial struct PROCESSOR_NUMBER
{
    /// <include file='PROCESSOR_NUMBER.xml' path='doc/member[@name="PROCESSOR_NUMBER.Group"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Group;
    /// <include file='PROCESSOR_NUMBER.xml' path='doc/member[@name="PROCESSOR_NUMBER.Number"]/*'/>
    public byte Number;
    /// <include file='PROCESSOR_NUMBER.xml' path='doc/member[@name="PROCESSOR_NUMBER.Reserved"]/*'/>
    public byte Reserved;
}