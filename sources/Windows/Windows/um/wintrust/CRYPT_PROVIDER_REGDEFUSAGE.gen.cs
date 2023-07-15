// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='CRYPT_PROVIDER_REGDEFUSAGE.xml' path='doc/member[@name="CRYPT_PROVIDER_REGDEFUSAGE"]/*'/>
public unsafe partial struct CRYPT_PROVIDER_REGDEFUSAGE
{
    /// <include file='CRYPT_PROVIDER_REGDEFUSAGE.xml' path='doc/member[@name="CRYPT_PROVIDER_REGDEFUSAGE.cbStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbStruct;
    /// <include file='CRYPT_PROVIDER_REGDEFUSAGE.xml' path='doc/member[@name="CRYPT_PROVIDER_REGDEFUSAGE.pgActionID"]/*'/>
    public Guid* pgActionID;
    /// <include file='CRYPT_PROVIDER_REGDEFUSAGE.xml' path='doc/member[@name="CRYPT_PROVIDER_REGDEFUSAGE.pwszDllName"]/*'/>
    [NativeTypeName("WCHAR *")]
    public ushort* pwszDllName;
    /// <include file='CRYPT_PROVIDER_REGDEFUSAGE.xml' path='doc/member[@name="CRYPT_PROVIDER_REGDEFUSAGE.pwszLoadCallbackDataFunctionName"]/*'/>
    [NativeTypeName("char *")]
    public sbyte* pwszLoadCallbackDataFunctionName;
    /// <include file='CRYPT_PROVIDER_REGDEFUSAGE.xml' path='doc/member[@name="CRYPT_PROVIDER_REGDEFUSAGE.pwszFreeCallbackDataFunctionName"]/*'/>
    [NativeTypeName("char *")]
    public sbyte* pwszFreeCallbackDataFunctionName;
}