// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='GLOBALOPT_PROPERTIES.xml' path='doc/member[@name="GLOBALOPT_PROPERTIES"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum GLOBALOPT_PROPERTIES
{
    /// <include file='GLOBALOPT_PROPERTIES.xml' path='doc/member[@name="GLOBALOPT_PROPERTIES.COMGLB_EXCEPTION_HANDLING"]/*'/>
    COMGLB_EXCEPTION_HANDLING = 1,
    /// <include file='GLOBALOPT_PROPERTIES.xml' path='doc/member[@name="GLOBALOPT_PROPERTIES.COMGLB_APPID"]/*'/>
    COMGLB_APPID = 2,
    /// <include file='GLOBALOPT_PROPERTIES.xml' path='doc/member[@name="GLOBALOPT_PROPERTIES.COMGLB_RPC_THREADPOOL_SETTING"]/*'/>
    COMGLB_RPC_THREADPOOL_SETTING = 3,
    /// <include file='GLOBALOPT_PROPERTIES.xml' path='doc/member[@name="GLOBALOPT_PROPERTIES.COMGLB_RO_SETTINGS"]/*'/>
    COMGLB_RO_SETTINGS = 4,
    /// <include file='GLOBALOPT_PROPERTIES.xml' path='doc/member[@name="GLOBALOPT_PROPERTIES.COMGLB_UNMARSHALING_POLICY"]/*'/>
    COMGLB_UNMARSHALING_POLICY = 5,
    /// <include file='GLOBALOPT_PROPERTIES.xml' path='doc/member[@name="GLOBALOPT_PROPERTIES.COMGLB_PROPERTIES_RESERVED1"]/*'/>
    COMGLB_PROPERTIES_RESERVED1 = 6,
    /// <include file='GLOBALOPT_PROPERTIES.xml' path='doc/member[@name="GLOBALOPT_PROPERTIES.COMGLB_PROPERTIES_RESERVED2"]/*'/>
    COMGLB_PROPERTIES_RESERVED2 = 7,
    /// <include file='GLOBALOPT_PROPERTIES.xml' path='doc/member[@name="GLOBALOPT_PROPERTIES.COMGLB_PROPERTIES_RESERVED3"]/*'/>
    COMGLB_PROPERTIES_RESERVED3 = 8,
}