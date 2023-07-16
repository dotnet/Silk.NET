// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/evntprov.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='EVENT_DESCRIPTOR.xml' path='doc/member[@name="EVENT_DESCRIPTOR"]/*'/>
public partial struct EVENT_DESCRIPTOR
{
    /// <include file='EVENT_DESCRIPTOR.xml' path='doc/member[@name="EVENT_DESCRIPTOR.Id"]/*'/>
    public ushort Id;
    /// <include file='EVENT_DESCRIPTOR.xml' path='doc/member[@name="EVENT_DESCRIPTOR.Version"]/*'/>
    [NativeTypeName("UCHAR")]
    public byte Version;
    /// <include file='EVENT_DESCRIPTOR.xml' path='doc/member[@name="EVENT_DESCRIPTOR.Channel"]/*'/>
    [NativeTypeName("UCHAR")]
    public byte Channel;
    /// <include file='EVENT_DESCRIPTOR.xml' path='doc/member[@name="EVENT_DESCRIPTOR.Level"]/*'/>
    [NativeTypeName("UCHAR")]
    public byte Level;
    /// <include file='EVENT_DESCRIPTOR.xml' path='doc/member[@name="EVENT_DESCRIPTOR.Opcode"]/*'/>
    [NativeTypeName("UCHAR")]
    public byte Opcode;
    /// <include file='EVENT_DESCRIPTOR.xml' path='doc/member[@name="EVENT_DESCRIPTOR.Task"]/*'/>
    public ushort Task;
    /// <include file='EVENT_DESCRIPTOR.xml' path='doc/member[@name="EVENT_DESCRIPTOR.Keyword"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong Keyword;
}