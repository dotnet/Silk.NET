// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NEGOTIATE_MESSAGES.xml' path='doc/member[@name="NEGOTIATE_MESSAGES"]/*'/>
public enum NEGOTIATE_MESSAGES
{
    /// <include file='NEGOTIATE_MESSAGES.xml' path='doc/member[@name="NEGOTIATE_MESSAGES.NegEnumPackagePrefixes"]/*'/>
    NegEnumPackagePrefixes = 0,
    /// <include file='NEGOTIATE_MESSAGES.xml' path='doc/member[@name="NEGOTIATE_MESSAGES.NegGetCallerName"]/*'/>
    NegGetCallerName = 1,
    /// <include file='NEGOTIATE_MESSAGES.xml' path='doc/member[@name="NEGOTIATE_MESSAGES.NegTransferCredentials"]/*'/>
    NegTransferCredentials = 2,
    /// <include file='NEGOTIATE_MESSAGES.xml' path='doc/member[@name="NEGOTIATE_MESSAGES.NegMsgReserved1"]/*'/>
    NegMsgReserved1 = 3,
    /// <include file='NEGOTIATE_MESSAGES.xml' path='doc/member[@name="NEGOTIATE_MESSAGES.NegCallPackageMax"]/*'/>
    NegCallPackageMax,
}