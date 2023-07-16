// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='PRJ_COMPLETE_COMMAND_TYPE.xml' path='doc/member[@name="PRJ_COMPLETE_COMMAND_TYPE"]/*'/>
[SupportedOSPlatform("windows10.0.17763.0")]
public enum PRJ_COMPLETE_COMMAND_TYPE
{
    /// <include file='PRJ_COMPLETE_COMMAND_TYPE.xml' path='doc/member[@name="PRJ_COMPLETE_COMMAND_TYPE.PRJ_COMPLETE_COMMAND_TYPE_NOTIFICATION"]/*'/>
    PRJ_COMPLETE_COMMAND_TYPE_NOTIFICATION = 1,
    /// <include file='PRJ_COMPLETE_COMMAND_TYPE.xml' path='doc/member[@name="PRJ_COMPLETE_COMMAND_TYPE.PRJ_COMPLETE_COMMAND_TYPE_ENUMERATION"]/*'/>
    PRJ_COMPLETE_COMMAND_TYPE_ENUMERATION = 2,
}