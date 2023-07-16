// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='StorageLayout.xml' path='doc/member[@name="StorageLayout"]/*'/>
public unsafe partial struct StorageLayout
{
    /// <include file='StorageLayout.xml' path='doc/member[@name="StorageLayout.LayoutType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LayoutType;
    /// <include file='StorageLayout.xml' path='doc/member[@name="StorageLayout.pwcsElementName"]/*'/>
    [NativeTypeName("OLECHAR *")]
    public ushort* pwcsElementName;
    /// <include file='StorageLayout.xml' path='doc/member[@name="StorageLayout.cOffset"]/*'/>
    public LARGE_INTEGER cOffset;
    /// <include file='StorageLayout.xml' path='doc/member[@name="StorageLayout.cBytes"]/*'/>
    public LARGE_INTEGER cBytes;
}