// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mediaobj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='_DMO_INPUT_DATA_BUFFER_FLAGS.xml' path='doc/member[@name="_DMO_INPUT_DATA_BUFFER_FLAGS"]/*'/>
public enum _DMO_INPUT_DATA_BUFFER_FLAGS
{
    /// <include file='_DMO_INPUT_DATA_BUFFER_FLAGS.xml' path='doc/member[@name="_DMO_INPUT_DATA_BUFFER_FLAGS.DMO_INPUT_DATA_BUFFERF_SYNCPOINT"]/*'/>
    DMO_INPUT_DATA_BUFFERF_SYNCPOINT = 0x1,
    /// <include file='_DMO_INPUT_DATA_BUFFER_FLAGS.xml' path='doc/member[@name="_DMO_INPUT_DATA_BUFFER_FLAGS.DMO_INPUT_DATA_BUFFERF_TIME"]/*'/>
    DMO_INPUT_DATA_BUFFERF_TIME = 0x2,
    /// <include file='_DMO_INPUT_DATA_BUFFER_FLAGS.xml' path='doc/member[@name="_DMO_INPUT_DATA_BUFFER_FLAGS.DMO_INPUT_DATA_BUFFERF_TIMELENGTH"]/*'/>
    DMO_INPUT_DATA_BUFFERF_TIMELENGTH = 0x4,
    /// <include file='_DMO_INPUT_DATA_BUFFER_FLAGS.xml' path='doc/member[@name="_DMO_INPUT_DATA_BUFFER_FLAGS.DMO_INPUT_DATA_BUFFERF_DISCONTINUITY"]/*'/>
    DMO_INPUT_DATA_BUFFERF_DISCONTINUITY = 0x8,
}