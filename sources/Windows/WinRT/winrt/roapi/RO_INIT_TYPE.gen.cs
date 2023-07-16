// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/roapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.WinRT;
/// <include file='RO_INIT_TYPE.xml' path='doc/member[@name="RO_INIT_TYPE"]/*'/>
public enum RO_INIT_TYPE
{
    /// <include file='RO_INIT_TYPE.xml' path='doc/member[@name="RO_INIT_TYPE.RO_INIT_SINGLETHREADED"]/*'/>
    RO_INIT_SINGLETHREADED = 0,
    /// <include file='RO_INIT_TYPE.xml' path='doc/member[@name="RO_INIT_TYPE.RO_INIT_MULTITHREADED"]/*'/>
    RO_INIT_MULTITHREADED = 1,
}