// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FILE_ATTRIBUTE_TAG_INFO.xml' path='doc/member[@name="FILE_ATTRIBUTE_TAG_INFO"]/*'/>
public partial struct FILE_ATTRIBUTE_TAG_INFO
{
    /// <include file='FILE_ATTRIBUTE_TAG_INFO.xml' path='doc/member[@name="FILE_ATTRIBUTE_TAG_INFO.FileAttributes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint FileAttributes;
    /// <include file='FILE_ATTRIBUTE_TAG_INFO.xml' path='doc/member[@name="FILE_ATTRIBUTE_TAG_INFO.ReparseTag"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ReparseTag;
}