// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WBEM_STATUS_TYPE.xml' path='doc/member[@name="WBEM_STATUS_TYPE"]/*' />
public enum WBEM_STATUS_TYPE
{
    /// <include file='WBEM_STATUS_TYPE.xml' path='doc/member[@name="WBEM_STATUS_TYPE.WBEM_STATUS_COMPLETE"]/*' />
    WBEM_STATUS_COMPLETE = 0,

    /// <include file='WBEM_STATUS_TYPE.xml' path='doc/member[@name="WBEM_STATUS_TYPE.WBEM_STATUS_REQUIREMENTS"]/*' />
    WBEM_STATUS_REQUIREMENTS = 1,

    /// <include file='WBEM_STATUS_TYPE.xml' path='doc/member[@name="WBEM_STATUS_TYPE.WBEM_STATUS_PROGRESS"]/*' />
    WBEM_STATUS_PROGRESS = 2,

    /// <include file='WBEM_STATUS_TYPE.xml' path='doc/member[@name="WBEM_STATUS_TYPE.WBEM_STATUS_LOGGING_INFORMATION"]/*' />
    WBEM_STATUS_LOGGING_INFORMATION = 0x100,

    /// <include file='WBEM_STATUS_TYPE.xml' path='doc/member[@name="WBEM_STATUS_TYPE.WBEM_STATUS_LOGGING_INFORMATION_PROVIDER"]/*' />
    WBEM_STATUS_LOGGING_INFORMATION_PROVIDER = 0x200,

    /// <include file='WBEM_STATUS_TYPE.xml' path='doc/member[@name="WBEM_STATUS_TYPE.WBEM_STATUS_LOGGING_INFORMATION_HOST"]/*' />
    WBEM_STATUS_LOGGING_INFORMATION_HOST = 0x400,

    /// <include file='WBEM_STATUS_TYPE.xml' path='doc/member[@name="WBEM_STATUS_TYPE.WBEM_STATUS_LOGGING_INFORMATION_REPOSITORY"]/*' />
    WBEM_STATUS_LOGGING_INFORMATION_REPOSITORY = 0x800,

    /// <include file='WBEM_STATUS_TYPE.xml' path='doc/member[@name="WBEM_STATUS_TYPE.WBEM_STATUS_LOGGING_INFORMATION_ESS"]/*' />
    WBEM_STATUS_LOGGING_INFORMATION_ESS = 0x1000,
}
