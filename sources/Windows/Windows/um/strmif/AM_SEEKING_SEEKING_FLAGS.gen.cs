// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='AM_SEEKING_SEEKING_FLAGS.xml' path='doc/member[@name="AM_SEEKING_SEEKING_FLAGS"]/*'/>
public enum AM_SEEKING_SEEKING_FLAGS
{
    /// <include file='AM_SEEKING_SEEKING_FLAGS.xml' path='doc/member[@name="AM_SEEKING_SEEKING_FLAGS.AM_SEEKING_NoPositioning"]/*'/>
    AM_SEEKING_NoPositioning = 0,
    /// <include file='AM_SEEKING_SEEKING_FLAGS.xml' path='doc/member[@name="AM_SEEKING_SEEKING_FLAGS.AM_SEEKING_AbsolutePositioning"]/*'/>
    AM_SEEKING_AbsolutePositioning = 0x1,
    /// <include file='AM_SEEKING_SEEKING_FLAGS.xml' path='doc/member[@name="AM_SEEKING_SEEKING_FLAGS.AM_SEEKING_RelativePositioning"]/*'/>
    AM_SEEKING_RelativePositioning = 0x2,
    /// <include file='AM_SEEKING_SEEKING_FLAGS.xml' path='doc/member[@name="AM_SEEKING_SEEKING_FLAGS.AM_SEEKING_IncrementalPositioning"]/*'/>
    AM_SEEKING_IncrementalPositioning = 0x3,
    /// <include file='AM_SEEKING_SEEKING_FLAGS.xml' path='doc/member[@name="AM_SEEKING_SEEKING_FLAGS.AM_SEEKING_PositioningBitsMask"]/*'/>
    AM_SEEKING_PositioningBitsMask = 0x3,
    /// <include file='AM_SEEKING_SEEKING_FLAGS.xml' path='doc/member[@name="AM_SEEKING_SEEKING_FLAGS.AM_SEEKING_SeekToKeyFrame"]/*'/>
    AM_SEEKING_SeekToKeyFrame = 0x4,
    /// <include file='AM_SEEKING_SEEKING_FLAGS.xml' path='doc/member[@name="AM_SEEKING_SEEKING_FLAGS.AM_SEEKING_ReturnTime"]/*'/>
    AM_SEEKING_ReturnTime = 0x8,
    /// <include file='AM_SEEKING_SEEKING_FLAGS.xml' path='doc/member[@name="AM_SEEKING_SEEKING_FLAGS.AM_SEEKING_Segment"]/*'/>
    AM_SEEKING_Segment = 0x10,
    /// <include file='AM_SEEKING_SEEKING_FLAGS.xml' path='doc/member[@name="AM_SEEKING_SEEKING_FLAGS.AM_SEEKING_NoFlush"]/*'/>
    AM_SEEKING_NoFlush = 0x20,
}