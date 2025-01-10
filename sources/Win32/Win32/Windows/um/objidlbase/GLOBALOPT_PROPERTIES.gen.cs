// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public enum GLOBALOPT_PROPERTIES
{
    COMGLB_EXCEPTION_HANDLING = 1,
    COMGLB_APPID = 2,
    COMGLB_RPC_THREADPOOL_SETTING = 3,
    COMGLB_RO_SETTINGS = 4,
    COMGLB_UNMARSHALING_POLICY = 5,
    COMGLB_PROPERTIES_RESERVED1 = 6,
    COMGLB_PROPERTIES_RESERVED2 = 7,
    COMGLB_PROPERTIES_RESERVED3 = 8,
}
