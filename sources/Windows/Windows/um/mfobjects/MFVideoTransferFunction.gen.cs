// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MFVideoTransferFunction.xml' path='doc/member[@name="MFVideoTransferFunction"]/*'/>
public enum MFVideoTransferFunction
{
    /// <include file='MFVideoTransferFunction.xml' path='doc/member[@name="MFVideoTransferFunction.MFVideoTransFunc_Unknown"]/*'/>
    MFVideoTransFunc_Unknown = 0,
    /// <include file='MFVideoTransferFunction.xml' path='doc/member[@name="MFVideoTransferFunction.MFVideoTransFunc_10"]/*'/>
    MFVideoTransFunc_10 = 1,
    /// <include file='MFVideoTransferFunction.xml' path='doc/member[@name="MFVideoTransferFunction.MFVideoTransFunc_18"]/*'/>
    MFVideoTransFunc_18 = 2,
    /// <include file='MFVideoTransferFunction.xml' path='doc/member[@name="MFVideoTransferFunction.MFVideoTransFunc_20"]/*'/>
    MFVideoTransFunc_20 = 3,
    /// <include file='MFVideoTransferFunction.xml' path='doc/member[@name="MFVideoTransferFunction.MFVideoTransFunc_22"]/*'/>
    MFVideoTransFunc_22 = 4,
    /// <include file='MFVideoTransferFunction.xml' path='doc/member[@name="MFVideoTransferFunction.MFVideoTransFunc_709"]/*'/>
    MFVideoTransFunc_709 = 5,
    /// <include file='MFVideoTransferFunction.xml' path='doc/member[@name="MFVideoTransferFunction.MFVideoTransFunc_240M"]/*'/>
    MFVideoTransFunc_240M = 6,
    /// <include file='MFVideoTransferFunction.xml' path='doc/member[@name="MFVideoTransferFunction.MFVideoTransFunc_sRGB"]/*'/>
    MFVideoTransFunc_sRGB = 7,
    /// <include file='MFVideoTransferFunction.xml' path='doc/member[@name="MFVideoTransferFunction.MFVideoTransFunc_28"]/*'/>
    MFVideoTransFunc_28 = 8,
    /// <include file='MFVideoTransferFunction.xml' path='doc/member[@name="MFVideoTransferFunction.MFVideoTransFunc_Log_100"]/*'/>
    MFVideoTransFunc_Log_100 = 9,
    /// <include file='MFVideoTransferFunction.xml' path='doc/member[@name="MFVideoTransferFunction.MFVideoTransFunc_Log_316"]/*'/>
    MFVideoTransFunc_Log_316 = 10,
    /// <include file='MFVideoTransferFunction.xml' path='doc/member[@name="MFVideoTransferFunction.MFVideoTransFunc_709_sym"]/*'/>
    MFVideoTransFunc_709_sym = 11,
    /// <include file='MFVideoTransferFunction.xml' path='doc/member[@name="MFVideoTransferFunction.MFVideoTransFunc_2020_const"]/*'/>
    MFVideoTransFunc_2020_const = 12,
    /// <include file='MFVideoTransferFunction.xml' path='doc/member[@name="MFVideoTransferFunction.MFVideoTransFunc_2020"]/*'/>
    MFVideoTransFunc_2020 = 13,
    /// <include file='MFVideoTransferFunction.xml' path='doc/member[@name="MFVideoTransferFunction.MFVideoTransFunc_26"]/*'/>
    MFVideoTransFunc_26 = 14,
    /// <include file='MFVideoTransferFunction.xml' path='doc/member[@name="MFVideoTransferFunction.MFVideoTransFunc_2084"]/*'/>
    MFVideoTransFunc_2084 = 15,
    /// <include file='MFVideoTransferFunction.xml' path='doc/member[@name="MFVideoTransferFunction.MFVideoTransFunc_HLG"]/*'/>
    MFVideoTransFunc_HLG = 16,
    /// <include file='MFVideoTransferFunction.xml' path='doc/member[@name="MFVideoTransferFunction.MFVideoTransFunc_10_rel"]/*'/>
    MFVideoTransFunc_10_rel = 17,
    /// <include file='MFVideoTransferFunction.xml' path='doc/member[@name="MFVideoTransferFunction.MFVideoTransFunc_Last"]/*'/>
    MFVideoTransFunc_Last = (MFVideoTransFunc_10_rel + 1),
    /// <include file='MFVideoTransferFunction.xml' path='doc/member[@name="MFVideoTransferFunction.MFVideoTransFunc_ForceDWORD"]/*'/>
    MFVideoTransFunc_ForceDWORD = 0x7fffffff,
}