// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='PUAFOUT.xml' path='doc/member[@name="PUAFOUT"]/*'/>
[Flags]
public enum PUAFOUT
{
    /// <include file='PUAFOUT.xml' path='doc/member[@name="PUAFOUT.PUAFOUT_DEFAULT"]/*'/>
    PUAFOUT_DEFAULT = 0,
    /// <include file='PUAFOUT.xml' path='doc/member[@name="PUAFOUT.PUAFOUT_ISLOCKZONEPOLICY"]/*'/>
    PUAFOUT_ISLOCKZONEPOLICY = 0x1,
}