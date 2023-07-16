// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MF_TOPONODE_DRAIN_MODE.xml' path='doc/member[@name="MF_TOPONODE_DRAIN_MODE"]/*'/>
public enum MF_TOPONODE_DRAIN_MODE
{
    /// <include file='MF_TOPONODE_DRAIN_MODE.xml' path='doc/member[@name="MF_TOPONODE_DRAIN_MODE.MF_TOPONODE_DRAIN_DEFAULT"]/*'/>
    MF_TOPONODE_DRAIN_DEFAULT = 0,
    /// <include file='MF_TOPONODE_DRAIN_MODE.xml' path='doc/member[@name="MF_TOPONODE_DRAIN_MODE.MF_TOPONODE_DRAIN_ALWAYS"]/*'/>
    MF_TOPONODE_DRAIN_ALWAYS = (MF_TOPONODE_DRAIN_DEFAULT + 1),
    /// <include file='MF_TOPONODE_DRAIN_MODE.xml' path='doc/member[@name="MF_TOPONODE_DRAIN_MODE.MF_TOPONODE_DRAIN_NEVER"]/*'/>
    MF_TOPONODE_DRAIN_NEVER = (MF_TOPONODE_DRAIN_ALWAYS + 1),
}