// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TRUSTED_CONTROLLERS_INFO.xml' path='doc/member[@name="TRUSTED_CONTROLLERS_INFO"]/*'/>
public unsafe partial struct TRUSTED_CONTROLLERS_INFO
{
    /// <include file='TRUSTED_CONTROLLERS_INFO.xml' path='doc/member[@name="TRUSTED_CONTROLLERS_INFO.Entries"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Entries;
    /// <include file='TRUSTED_CONTROLLERS_INFO.xml' path='doc/member[@name="TRUSTED_CONTROLLERS_INFO.Names"]/*'/>
    [NativeTypeName("PLSA_UNICODE_STRING")]
    public LSA_UNICODE_STRING* Names;
}