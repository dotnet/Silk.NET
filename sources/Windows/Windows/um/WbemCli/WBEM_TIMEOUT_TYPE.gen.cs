// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WBEM_TIMEOUT_TYPE.xml' path='doc/member[@name="WBEM_TIMEOUT_TYPE"]/*'/>
public enum WBEM_TIMEOUT_TYPE
{
    /// <include file='WBEM_TIMEOUT_TYPE.xml' path='doc/member[@name="WBEM_TIMEOUT_TYPE.WBEM_NO_WAIT"]/*'/>
    WBEM_NO_WAIT = 0,
    /// <include file='WBEM_TIMEOUT_TYPE.xml' path='doc/member[@name="WBEM_TIMEOUT_TYPE.WBEM_INFINITE"]/*'/>
    WBEM_INFINITE = unchecked((int)(0xffffffff)),
}