// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='VPWATERMARKFLAGS.xml' path='doc/member[@name="VPWATERMARKFLAGS"]/*'/>
[Flags]
public enum VPWATERMARKFLAGS
{
    /// <include file='VPWATERMARKFLAGS.xml' path='doc/member[@name="VPWATERMARKFLAGS.VPWF_DEFAULT"]/*'/>
    VPWF_DEFAULT = 0,
    /// <include file='VPWATERMARKFLAGS.xml' path='doc/member[@name="VPWATERMARKFLAGS.VPWF_ALPHABLEND"]/*'/>
    VPWF_ALPHABLEND = 0x1,
}