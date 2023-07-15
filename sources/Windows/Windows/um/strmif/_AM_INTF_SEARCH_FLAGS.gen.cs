// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='_AM_INTF_SEARCH_FLAGS.xml' path='doc/member[@name="_AM_INTF_SEARCH_FLAGS"]/*'/>
public enum _AM_INTF_SEARCH_FLAGS
{
    /// <include file='_AM_INTF_SEARCH_FLAGS.xml' path='doc/member[@name="_AM_INTF_SEARCH_FLAGS.AM_INTF_SEARCH_INPUT_PIN"]/*'/>
    AM_INTF_SEARCH_INPUT_PIN = 0x1,
    /// <include file='_AM_INTF_SEARCH_FLAGS.xml' path='doc/member[@name="_AM_INTF_SEARCH_FLAGS.AM_INTF_SEARCH_OUTPUT_PIN"]/*'/>
    AM_INTF_SEARCH_OUTPUT_PIN = 0x2,
    /// <include file='_AM_INTF_SEARCH_FLAGS.xml' path='doc/member[@name="_AM_INTF_SEARCH_FLAGS.AM_INTF_SEARCH_FILTER"]/*'/>
    AM_INTF_SEARCH_FILTER = 0x4,
}