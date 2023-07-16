// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WTA_OPTIONS.xml' path='doc/member[@name="WTA_OPTIONS"]/*'/>
public partial struct WTA_OPTIONS
{
    /// <include file='WTA_OPTIONS.xml' path='doc/member[@name="WTA_OPTIONS.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='WTA_OPTIONS.xml' path='doc/member[@name="WTA_OPTIONS.dwMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMask;
}