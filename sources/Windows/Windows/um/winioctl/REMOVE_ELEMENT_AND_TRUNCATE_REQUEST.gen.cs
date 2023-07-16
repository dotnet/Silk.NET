// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='REMOVE_ELEMENT_AND_TRUNCATE_REQUEST.xml' path='doc/member[@name="REMOVE_ELEMENT_AND_TRUNCATE_REQUEST"]/*'/>
public partial struct REMOVE_ELEMENT_AND_TRUNCATE_REQUEST
{
    /// <include file='REMOVE_ELEMENT_AND_TRUNCATE_REQUEST.xml' path='doc/member[@name="REMOVE_ELEMENT_AND_TRUNCATE_REQUEST.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='REMOVE_ELEMENT_AND_TRUNCATE_REQUEST.xml' path='doc/member[@name="REMOVE_ELEMENT_AND_TRUNCATE_REQUEST.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='REMOVE_ELEMENT_AND_TRUNCATE_REQUEST.xml' path='doc/member[@name="REMOVE_ELEMENT_AND_TRUNCATE_REQUEST.RequestCapacity"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong RequestCapacity;
    /// <include file='REMOVE_ELEMENT_AND_TRUNCATE_REQUEST.xml' path='doc/member[@name="REMOVE_ELEMENT_AND_TRUNCATE_REQUEST.ElementIdentifier"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ElementIdentifier;
    /// <include file='REMOVE_ELEMENT_AND_TRUNCATE_REQUEST.xml' path='doc/member[@name="REMOVE_ELEMENT_AND_TRUNCATE_REQUEST.Reserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reserved;
}