// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ACENUMOPTION.xml' path='doc/member[@name="ACENUMOPTION"]/*'/>
public enum ACENUMOPTION
{
    /// <include file='ACENUMOPTION.xml' path='doc/member[@name="ACENUMOPTION.ACEO_NONE"]/*'/>
    ACEO_NONE = 0,
    /// <include file='ACENUMOPTION.xml' path='doc/member[@name="ACENUMOPTION.ACEO_MOSTRECENTFIRST"]/*'/>
    ACEO_MOSTRECENTFIRST = 0x1,
    /// <include file='ACENUMOPTION.xml' path='doc/member[@name="ACENUMOPTION.ACEO_FIRSTUNUSED"]/*'/>
    ACEO_FIRSTUNUSED = 0x10000,
}