// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/combaseapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='CWMO_FLAGS.xml' path='doc/member[@name="CWMO_FLAGS"]/*'/>
[Flags]
public enum CWMO_FLAGS
{
    /// <include file='CWMO_FLAGS.xml' path='doc/member[@name="CWMO_FLAGS.CWMO_DEFAULT"]/*'/>
    CWMO_DEFAULT = 0,
    /// <include file='CWMO_FLAGS.xml' path='doc/member[@name="CWMO_FLAGS.CWMO_DISPATCH_CALLS"]/*'/>
    CWMO_DISPATCH_CALLS = 1,
    /// <include file='CWMO_FLAGS.xml' path='doc/member[@name="CWMO_FLAGS.CWMO_DISPATCH_WINDOW_MESSAGES"]/*'/>
    CWMO_DISPATCH_WINDOW_MESSAGES = 2,
}