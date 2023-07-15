// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='tagAM_SAMPLE_PROPERTY_FLAGS.xml' path='doc/member[@name="tagAM_SAMPLE_PROPERTY_FLAGS"]/*'/>
public enum tagAM_SAMPLE_PROPERTY_FLAGS
{
    /// <include file='tagAM_SAMPLE_PROPERTY_FLAGS.xml' path='doc/member[@name="tagAM_SAMPLE_PROPERTY_FLAGS.AM_SAMPLE_SPLICEPOINT"]/*'/>
    AM_SAMPLE_SPLICEPOINT = 0x1,
    /// <include file='tagAM_SAMPLE_PROPERTY_FLAGS.xml' path='doc/member[@name="tagAM_SAMPLE_PROPERTY_FLAGS.AM_SAMPLE_PREROLL"]/*'/>
    AM_SAMPLE_PREROLL = 0x2,
    /// <include file='tagAM_SAMPLE_PROPERTY_FLAGS.xml' path='doc/member[@name="tagAM_SAMPLE_PROPERTY_FLAGS.AM_SAMPLE_DATADISCONTINUITY"]/*'/>
    AM_SAMPLE_DATADISCONTINUITY = 0x4,
    /// <include file='tagAM_SAMPLE_PROPERTY_FLAGS.xml' path='doc/member[@name="tagAM_SAMPLE_PROPERTY_FLAGS.AM_SAMPLE_TYPECHANGED"]/*'/>
    AM_SAMPLE_TYPECHANGED = 0x8,
    /// <include file='tagAM_SAMPLE_PROPERTY_FLAGS.xml' path='doc/member[@name="tagAM_SAMPLE_PROPERTY_FLAGS.AM_SAMPLE_TIMEVALID"]/*'/>
    AM_SAMPLE_TIMEVALID = 0x10,
    /// <include file='tagAM_SAMPLE_PROPERTY_FLAGS.xml' path='doc/member[@name="tagAM_SAMPLE_PROPERTY_FLAGS.AM_SAMPLE_TIMEDISCONTINUITY"]/*'/>
    AM_SAMPLE_TIMEDISCONTINUITY = 0x40,
    /// <include file='tagAM_SAMPLE_PROPERTY_FLAGS.xml' path='doc/member[@name="tagAM_SAMPLE_PROPERTY_FLAGS.AM_SAMPLE_FLUSH_ON_PAUSE"]/*'/>
    AM_SAMPLE_FLUSH_ON_PAUSE = 0x80,
    /// <include file='tagAM_SAMPLE_PROPERTY_FLAGS.xml' path='doc/member[@name="tagAM_SAMPLE_PROPERTY_FLAGS.AM_SAMPLE_STOPVALID"]/*'/>
    AM_SAMPLE_STOPVALID = 0x100,
    /// <include file='tagAM_SAMPLE_PROPERTY_FLAGS.xml' path='doc/member[@name="tagAM_SAMPLE_PROPERTY_FLAGS.AM_SAMPLE_ENDOFSTREAM"]/*'/>
    AM_SAMPLE_ENDOFSTREAM = 0x200,
    /// <include file='tagAM_SAMPLE_PROPERTY_FLAGS.xml' path='doc/member[@name="tagAM_SAMPLE_PROPERTY_FLAGS.AM_STREAM_MEDIA"]/*'/>
    AM_STREAM_MEDIA = 0,
    /// <include file='tagAM_SAMPLE_PROPERTY_FLAGS.xml' path='doc/member[@name="tagAM_SAMPLE_PROPERTY_FLAGS.AM_STREAM_CONTROL"]/*'/>
    AM_STREAM_CONTROL = 1,
}