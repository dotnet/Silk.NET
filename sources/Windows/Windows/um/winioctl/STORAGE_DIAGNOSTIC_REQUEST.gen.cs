// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_DIAGNOSTIC_REQUEST.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_REQUEST"]/*'/>
public partial struct STORAGE_DIAGNOSTIC_REQUEST
{
    /// <include file='STORAGE_DIAGNOSTIC_REQUEST.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_REQUEST.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_DIAGNOSTIC_REQUEST.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_REQUEST.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_DIAGNOSTIC_REQUEST.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_REQUEST.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='STORAGE_DIAGNOSTIC_REQUEST.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_REQUEST.TargetType"]/*'/>
    public STORAGE_DIAGNOSTIC_TARGET_TYPE TargetType;
    /// <include file='STORAGE_DIAGNOSTIC_REQUEST.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_REQUEST.Level"]/*'/>
    public STORAGE_DIAGNOSTIC_LEVEL Level;
}