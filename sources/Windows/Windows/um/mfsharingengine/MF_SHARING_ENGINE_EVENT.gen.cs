// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='MF_SHARING_ENGINE_EVENT.xml' path='doc/member[@name="MF_SHARING_ENGINE_EVENT"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum MF_SHARING_ENGINE_EVENT
{
    /// <include file='MF_SHARING_ENGINE_EVENT.xml' path='doc/member[@name="MF_SHARING_ENGINE_EVENT.MF_SHARING_ENGINE_EVENT_DISCONNECT"]/*'/>
    MF_SHARING_ENGINE_EVENT_DISCONNECT = 2000,
    /// <include file='MF_SHARING_ENGINE_EVENT.xml' path='doc/member[@name="MF_SHARING_ENGINE_EVENT.MF_SHARING_ENGINE_EVENT_LOCALRENDERINGSTARTED"]/*'/>
    MF_SHARING_ENGINE_EVENT_LOCALRENDERINGSTARTED = 2001,
    /// <include file='MF_SHARING_ENGINE_EVENT.xml' path='doc/member[@name="MF_SHARING_ENGINE_EVENT.MF_SHARING_ENGINE_EVENT_LOCALRENDERINGENDED"]/*'/>
    MF_SHARING_ENGINE_EVENT_LOCALRENDERINGENDED = 2002,
    /// <include file='MF_SHARING_ENGINE_EVENT.xml' path='doc/member[@name="MF_SHARING_ENGINE_EVENT.MF_SHARING_ENGINE_EVENT_STOPPED"]/*'/>
    MF_SHARING_ENGINE_EVENT_STOPPED = 2003,
    /// <include file='MF_SHARING_ENGINE_EVENT.xml' path='doc/member[@name="MF_SHARING_ENGINE_EVENT.MF_SHARING_ENGINE_EVENT_ERROR"]/*'/>
    MF_SHARING_ENGINE_EVENT_ERROR = 2501,
}