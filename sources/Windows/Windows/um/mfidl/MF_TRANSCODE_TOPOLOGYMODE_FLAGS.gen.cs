// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MF_TRANSCODE_TOPOLOGYMODE_FLAGS.xml' path='doc/member[@name="MF_TRANSCODE_TOPOLOGYMODE_FLAGS"]/*'/>
public enum MF_TRANSCODE_TOPOLOGYMODE_FLAGS
{
    /// <include file='MF_TRANSCODE_TOPOLOGYMODE_FLAGS.xml' path='doc/member[@name="MF_TRANSCODE_TOPOLOGYMODE_FLAGS.MF_TRANSCODE_TOPOLOGYMODE_SOFTWARE_ONLY"]/*'/>
    MF_TRANSCODE_TOPOLOGYMODE_SOFTWARE_ONLY = 0,
    /// <include file='MF_TRANSCODE_TOPOLOGYMODE_FLAGS.xml' path='doc/member[@name="MF_TRANSCODE_TOPOLOGYMODE_FLAGS.MF_TRANSCODE_TOPOLOGYMODE_HARDWARE_ALLOWED"]/*'/>
    MF_TRANSCODE_TOPOLOGYMODE_HARDWARE_ALLOWED = 1,
}