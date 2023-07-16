// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mediaobj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='_DMO_OUTPUT_DATA_BUFFER_FLAGS.xml' path='doc/member[@name="_DMO_OUTPUT_DATA_BUFFER_FLAGS"]/*'/>
public enum _DMO_OUTPUT_DATA_BUFFER_FLAGS
{
    /// <include file='_DMO_OUTPUT_DATA_BUFFER_FLAGS.xml' path='doc/member[@name="_DMO_OUTPUT_DATA_BUFFER_FLAGS.DMO_OUTPUT_DATA_BUFFERF_SYNCPOINT"]/*'/>
    DMO_OUTPUT_DATA_BUFFERF_SYNCPOINT = 0x1,
    /// <include file='_DMO_OUTPUT_DATA_BUFFER_FLAGS.xml' path='doc/member[@name="_DMO_OUTPUT_DATA_BUFFER_FLAGS.DMO_OUTPUT_DATA_BUFFERF_TIME"]/*'/>
    DMO_OUTPUT_DATA_BUFFERF_TIME = 0x2,
    /// <include file='_DMO_OUTPUT_DATA_BUFFER_FLAGS.xml' path='doc/member[@name="_DMO_OUTPUT_DATA_BUFFER_FLAGS.DMO_OUTPUT_DATA_BUFFERF_TIMELENGTH"]/*'/>
    DMO_OUTPUT_DATA_BUFFERF_TIMELENGTH = 0x4,
    /// <include file='_DMO_OUTPUT_DATA_BUFFER_FLAGS.xml' path='doc/member[@name="_DMO_OUTPUT_DATA_BUFFER_FLAGS.DMO_OUTPUT_DATA_BUFFERF_DISCONTINUITY"]/*'/>
    DMO_OUTPUT_DATA_BUFFERF_DISCONTINUITY = 0x8,
    /// <include file='_DMO_OUTPUT_DATA_BUFFER_FLAGS.xml' path='doc/member[@name="_DMO_OUTPUT_DATA_BUFFER_FLAGS.DMO_OUTPUT_DATA_BUFFERF_INCOMPLETE"]/*'/>
    DMO_OUTPUT_DATA_BUFFERF_INCOMPLETE = 0x1000000,
}