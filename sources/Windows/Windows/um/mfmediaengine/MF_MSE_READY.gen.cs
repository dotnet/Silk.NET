// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='MF_MSE_READY.xml' path='doc/member[@name="MF_MSE_READY"]/*'/>
[SupportedOSPlatform("windows6.3")]
public enum MF_MSE_READY
{
    /// <include file='MF_MSE_READY.xml' path='doc/member[@name="MF_MSE_READY.MF_MSE_READY_CLOSED"]/*'/>
    MF_MSE_READY_CLOSED = 1,
    /// <include file='MF_MSE_READY.xml' path='doc/member[@name="MF_MSE_READY.MF_MSE_READY_OPEN"]/*'/>
    MF_MSE_READY_OPEN = 2,
    /// <include file='MF_MSE_READY.xml' path='doc/member[@name="MF_MSE_READY.MF_MSE_READY_ENDED"]/*'/>
    MF_MSE_READY_ENDED = 3,
}