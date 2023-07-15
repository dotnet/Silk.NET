// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='_AM_PUSHSOURCE_FLAGS.xml' path='doc/member[@name="_AM_PUSHSOURCE_FLAGS"]/*'/>
public enum _AM_PUSHSOURCE_FLAGS
{
    /// <include file='_AM_PUSHSOURCE_FLAGS.xml' path='doc/member[@name="_AM_PUSHSOURCE_FLAGS.AM_PUSHSOURCECAPS_INTERNAL_RM"]/*'/>
    AM_PUSHSOURCECAPS_INTERNAL_RM = 0x1,
    /// <include file='_AM_PUSHSOURCE_FLAGS.xml' path='doc/member[@name="_AM_PUSHSOURCE_FLAGS.AM_PUSHSOURCECAPS_NOT_LIVE"]/*'/>
    AM_PUSHSOURCECAPS_NOT_LIVE = 0x2,
    /// <include file='_AM_PUSHSOURCE_FLAGS.xml' path='doc/member[@name="_AM_PUSHSOURCE_FLAGS.AM_PUSHSOURCECAPS_PRIVATE_CLOCK"]/*'/>
    AM_PUSHSOURCECAPS_PRIVATE_CLOCK = 0x4,
    /// <include file='_AM_PUSHSOURCE_FLAGS.xml' path='doc/member[@name="_AM_PUSHSOURCE_FLAGS.AM_PUSHSOURCEREQS_USE_STREAM_CLOCK"]/*'/>
    AM_PUSHSOURCEREQS_USE_STREAM_CLOCK = 0x10000,
    /// <include file='_AM_PUSHSOURCE_FLAGS.xml' path='doc/member[@name="_AM_PUSHSOURCE_FLAGS.AM_PUSHSOURCEREQS_USE_CLOCK_CHAIN"]/*'/>
    AM_PUSHSOURCEREQS_USE_CLOCK_CHAIN = 0x20000,
}