// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MF_TRANSFER_VIDEO_FRAME_FLAGS.xml' path='doc/member[@name="MF_TRANSFER_VIDEO_FRAME_FLAGS"]/*'/>
public enum MF_TRANSFER_VIDEO_FRAME_FLAGS
{
    /// <include file='MF_TRANSFER_VIDEO_FRAME_FLAGS.xml' path='doc/member[@name="MF_TRANSFER_VIDEO_FRAME_FLAGS.MF_TRANSFER_VIDEO_FRAME_DEFAULT"]/*'/>
    MF_TRANSFER_VIDEO_FRAME_DEFAULT = 0,
    /// <include file='MF_TRANSFER_VIDEO_FRAME_FLAGS.xml' path='doc/member[@name="MF_TRANSFER_VIDEO_FRAME_FLAGS.MF_TRANSFER_VIDEO_FRAME_STRETCH"]/*'/>
    MF_TRANSFER_VIDEO_FRAME_STRETCH = 1,
    /// <include file='MF_TRANSFER_VIDEO_FRAME_FLAGS.xml' path='doc/member[@name="MF_TRANSFER_VIDEO_FRAME_FLAGS.MF_TRANSFER_VIDEO_FRAME_IGNORE_PAR"]/*'/>
    MF_TRANSFER_VIDEO_FRAME_IGNORE_PAR = 2,
}