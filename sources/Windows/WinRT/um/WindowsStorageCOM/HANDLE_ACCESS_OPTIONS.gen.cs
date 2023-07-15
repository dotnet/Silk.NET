// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.WinRT;
/// <include file='HANDLE_ACCESS_OPTIONS.xml' path='doc/member[@name="HANDLE_ACCESS_OPTIONS"]/*'/>
[Flags]
[SupportedOSPlatform("windows10.0")]
public enum HANDLE_ACCESS_OPTIONS
{
    /// <include file='HANDLE_ACCESS_OPTIONS.xml' path='doc/member[@name="HANDLE_ACCESS_OPTIONS.HAO_NONE"]/*'/>
    HAO_NONE = 0,
    /// <include file='HANDLE_ACCESS_OPTIONS.xml' path='doc/member[@name="HANDLE_ACCESS_OPTIONS.HAO_READ_ATTRIBUTES"]/*'/>
    HAO_READ_ATTRIBUTES = 0x80,
    /// <include file='HANDLE_ACCESS_OPTIONS.xml' path='doc/member[@name="HANDLE_ACCESS_OPTIONS.HAO_READ"]/*'/>
    HAO_READ = 0x120089,
    /// <include file='HANDLE_ACCESS_OPTIONS.xml' path='doc/member[@name="HANDLE_ACCESS_OPTIONS.HAO_WRITE"]/*'/>
    HAO_WRITE = 0x120116,
    /// <include file='HANDLE_ACCESS_OPTIONS.xml' path='doc/member[@name="HANDLE_ACCESS_OPTIONS.HAO_DELETE"]/*'/>
    HAO_DELETE = 0x10000,
}