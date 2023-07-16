// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.WinRT;
/// <include file='HANDLE_CREATION_OPTIONS.xml' path='doc/member[@name="HANDLE_CREATION_OPTIONS"]/*'/>
[SupportedOSPlatform("windows10.0")]
public enum HANDLE_CREATION_OPTIONS
{
    /// <include file='HANDLE_CREATION_OPTIONS.xml' path='doc/member[@name="HANDLE_CREATION_OPTIONS.HCO_CREATE_NEW"]/*'/>
    HCO_CREATE_NEW = 0x1,
    /// <include file='HANDLE_CREATION_OPTIONS.xml' path='doc/member[@name="HANDLE_CREATION_OPTIONS.HCO_CREATE_ALWAYS"]/*'/>
    HCO_CREATE_ALWAYS = 0x2,
    /// <include file='HANDLE_CREATION_OPTIONS.xml' path='doc/member[@name="HANDLE_CREATION_OPTIONS.HCO_OPEN_EXISTING"]/*'/>
    HCO_OPEN_EXISTING = 0x3,
    /// <include file='HANDLE_CREATION_OPTIONS.xml' path='doc/member[@name="HANDLE_CREATION_OPTIONS.HCO_OPEN_ALWAYS"]/*'/>
    HCO_OPEN_ALWAYS = 0x4,
    /// <include file='HANDLE_CREATION_OPTIONS.xml' path='doc/member[@name="HANDLE_CREATION_OPTIONS.HCO_TRUNCATE_EXISTING"]/*'/>
    HCO_TRUNCATE_EXISTING = 0x5,
}