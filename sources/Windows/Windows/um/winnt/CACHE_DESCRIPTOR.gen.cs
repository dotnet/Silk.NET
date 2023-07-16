// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CACHE_DESCRIPTOR.xml' path='doc/member[@name="CACHE_DESCRIPTOR"]/*'/>
public partial struct CACHE_DESCRIPTOR
{
    /// <include file='CACHE_DESCRIPTOR.xml' path='doc/member[@name="CACHE_DESCRIPTOR.Level"]/*'/>
    public byte Level;
    /// <include file='CACHE_DESCRIPTOR.xml' path='doc/member[@name="CACHE_DESCRIPTOR.Associativity"]/*'/>
    public byte Associativity;
    /// <include file='CACHE_DESCRIPTOR.xml' path='doc/member[@name="CACHE_DESCRIPTOR.LineSize"]/*'/>
    [NativeTypeName("WORD")]
    public ushort LineSize;
    /// <include file='CACHE_DESCRIPTOR.xml' path='doc/member[@name="CACHE_DESCRIPTOR.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='CACHE_DESCRIPTOR.xml' path='doc/member[@name="CACHE_DESCRIPTOR.Type"]/*'/>
    public PROCESSOR_CACHE_TYPE Type;
}