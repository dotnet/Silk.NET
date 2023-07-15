// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='_AM_FILTER_MISC_FLAGS.xml' path='doc/member[@name="_AM_FILTER_MISC_FLAGS"]/*'/>
public enum _AM_FILTER_MISC_FLAGS
{
    /// <include file='_AM_FILTER_MISC_FLAGS.xml' path='doc/member[@name="_AM_FILTER_MISC_FLAGS.AM_FILTER_MISC_FLAGS_IS_RENDERER"]/*'/>
    AM_FILTER_MISC_FLAGS_IS_RENDERER = 0x1,
    /// <include file='_AM_FILTER_MISC_FLAGS.xml' path='doc/member[@name="_AM_FILTER_MISC_FLAGS.AM_FILTER_MISC_FLAGS_IS_SOURCE"]/*'/>
    AM_FILTER_MISC_FLAGS_IS_SOURCE = 0x2,
}