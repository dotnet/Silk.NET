// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TOOLTIP_DISMISS_FLAGS.xml' path='doc/member[@name="TOOLTIP_DISMISS_FLAGS"]/*'/>
public enum TOOLTIP_DISMISS_FLAGS
{
    /// <include file='TOOLTIP_DISMISS_FLAGS.xml' path='doc/member[@name="TOOLTIP_DISMISS_FLAGS.TDF_REGISTER"]/*'/>
    TDF_REGISTER = 0x0001,
    /// <include file='TOOLTIP_DISMISS_FLAGS.xml' path='doc/member[@name="TOOLTIP_DISMISS_FLAGS.TDF_UNREGISTER"]/*'/>
    TDF_UNREGISTER = 0x0002,
}