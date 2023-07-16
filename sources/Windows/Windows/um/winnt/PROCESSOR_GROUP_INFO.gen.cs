// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PROCESSOR_GROUP_INFO.xml' path='doc/member[@name="PROCESSOR_GROUP_INFO"]/*'/>
public unsafe partial struct PROCESSOR_GROUP_INFO
{
    /// <include file='PROCESSOR_GROUP_INFO.xml' path='doc/member[@name="PROCESSOR_GROUP_INFO.MaximumProcessorCount"]/*'/>
    public byte MaximumProcessorCount;
    /// <include file='PROCESSOR_GROUP_INFO.xml' path='doc/member[@name="PROCESSOR_GROUP_INFO.ActiveProcessorCount"]/*'/>
    public byte ActiveProcessorCount;
    /// <include file='PROCESSOR_GROUP_INFO.xml' path='doc/member[@name="PROCESSOR_GROUP_INFO.Reserved"]/*'/>
    [NativeTypeName("BYTE[38]")]
    public fixed byte Reserved[38];
    /// <include file='PROCESSOR_GROUP_INFO.xml' path='doc/member[@name="PROCESSOR_GROUP_INFO.ActiveProcessorMask"]/*'/>
    [NativeTypeName("KAFFINITY")]
    public nuint ActiveProcessorMask;
}