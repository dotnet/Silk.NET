// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WBEM_CONNECT_OPTIONS.xml' path='doc/member[@name="WBEM_CONNECT_OPTIONS"]/*'/>
public enum WBEM_CONNECT_OPTIONS
{
    /// <include file='WBEM_CONNECT_OPTIONS.xml' path='doc/member[@name="WBEM_CONNECT_OPTIONS.WBEM_FLAG_CONNECT_REPOSITORY_ONLY"]/*'/>
    WBEM_FLAG_CONNECT_REPOSITORY_ONLY = 0x40,
    /// <include file='WBEM_CONNECT_OPTIONS.xml' path='doc/member[@name="WBEM_CONNECT_OPTIONS.WBEM_FLAG_CONNECT_USE_MAX_WAIT"]/*'/>
    WBEM_FLAG_CONNECT_USE_MAX_WAIT = 0x80,
    /// <include file='WBEM_CONNECT_OPTIONS.xml' path='doc/member[@name="WBEM_CONNECT_OPTIONS.WBEM_FLAG_CONNECT_PROVIDERS"]/*'/>
    WBEM_FLAG_CONNECT_PROVIDERS = 0x100,
}