// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/evntprov.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EVENT_FILTER_HEADER.xml' path='doc/member[@name="EVENT_FILTER_HEADER"]/*'/>
public unsafe partial struct EVENT_FILTER_HEADER
{
    /// <include file='EVENT_FILTER_HEADER.xml' path='doc/member[@name="EVENT_FILTER_HEADER.Id"]/*'/>
    public ushort Id;
    /// <include file='EVENT_FILTER_HEADER.xml' path='doc/member[@name="EVENT_FILTER_HEADER.Version"]/*'/>
    [NativeTypeName("UCHAR")]
    public byte Version;
    /// <include file='EVENT_FILTER_HEADER.xml' path='doc/member[@name="EVENT_FILTER_HEADER.Reserved"]/*'/>
    [NativeTypeName("UCHAR[5]")]
    public fixed byte Reserved[5];
    /// <include file='EVENT_FILTER_HEADER.xml' path='doc/member[@name="EVENT_FILTER_HEADER.InstanceId"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong InstanceId;
    /// <include file='EVENT_FILTER_HEADER.xml' path='doc/member[@name="EVENT_FILTER_HEADER.Size"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Size;
    /// <include file='EVENT_FILTER_HEADER.xml' path='doc/member[@name="EVENT_FILTER_HEADER.NextOffset"]/*'/>
    [NativeTypeName("ULONG")]
    public uint NextOffset;
}