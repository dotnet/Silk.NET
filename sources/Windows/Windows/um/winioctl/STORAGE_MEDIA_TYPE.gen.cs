// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE"]/*'/>
public enum STORAGE_MEDIA_TYPE
{
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.DDS_4mm"]/*'/>
    DDS_4mm = 0x20,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.MiniQic"]/*'/>
    MiniQic,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.Travan"]/*'/>
    Travan,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.QIC"]/*'/>
    QIC,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.MP_8mm"]/*'/>
    MP_8mm,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.AME_8mm"]/*'/>
    AME_8mm,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.AIT1_8mm"]/*'/>
    AIT1_8mm,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.DLT"]/*'/>
    DLT,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.NCTP"]/*'/>
    NCTP,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.IBM_3480"]/*'/>
    IBM_3480,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.IBM_3490E"]/*'/>
    IBM_3490E,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.IBM_Magstar_3590"]/*'/>
    IBM_Magstar_3590,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.IBM_Magstar_MP"]/*'/>
    IBM_Magstar_MP,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.STK_DATA_D3"]/*'/>
    STK_DATA_D3,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.SONY_DTF"]/*'/>
    SONY_DTF,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.DV_6mm"]/*'/>
    DV_6mm,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.DMI"]/*'/>
    DMI,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.SONY_D2"]/*'/>
    SONY_D2,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.CLEANER_CARTRIDGE"]/*'/>
    CLEANER_CARTRIDGE,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.CD_ROM"]/*'/>
    CD_ROM,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.CD_R"]/*'/>
    CD_R,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.CD_RW"]/*'/>
    CD_RW,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.DVD_ROM"]/*'/>
    DVD_ROM,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.DVD_R"]/*'/>
    DVD_R,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.DVD_RW"]/*'/>
    DVD_RW,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.MO_3_RW"]/*'/>
    MO_3_RW,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.MO_5_WO"]/*'/>
    MO_5_WO,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.MO_5_RW"]/*'/>
    MO_5_RW,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.MO_5_LIMDOW"]/*'/>
    MO_5_LIMDOW,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.PC_5_WO"]/*'/>
    PC_5_WO,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.PC_5_RW"]/*'/>
    PC_5_RW,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.PD_5_RW"]/*'/>
    PD_5_RW,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.ABL_5_WO"]/*'/>
    ABL_5_WO,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.PINNACLE_APEX_5_RW"]/*'/>
    PINNACLE_APEX_5_RW,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.SONY_12_WO"]/*'/>
    SONY_12_WO,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.PHILIPS_12_WO"]/*'/>
    PHILIPS_12_WO,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.HITACHI_12_WO"]/*'/>
    HITACHI_12_WO,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.CYGNET_12_WO"]/*'/>
    CYGNET_12_WO,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.KODAK_14_WO"]/*'/>
    KODAK_14_WO,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.MO_NFR_525"]/*'/>
    MO_NFR_525,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.NIKON_12_RW"]/*'/>
    NIKON_12_RW,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.IOMEGA_ZIP"]/*'/>
    IOMEGA_ZIP,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.IOMEGA_JAZ"]/*'/>
    IOMEGA_JAZ,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.SYQUEST_EZ135"]/*'/>
    SYQUEST_EZ135,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.SYQUEST_EZFLYER"]/*'/>
    SYQUEST_EZFLYER,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.SYQUEST_SYJET"]/*'/>
    SYQUEST_SYJET,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.AVATAR_F2"]/*'/>
    AVATAR_F2,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.MP2_8mm"]/*'/>
    MP2_8mm,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.DST_S"]/*'/>
    DST_S,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.DST_M"]/*'/>
    DST_M,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.DST_L"]/*'/>
    DST_L,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.VXATape_1"]/*'/>
    VXATape_1,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.VXATape_2"]/*'/>
    VXATape_2,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.STK_9840"]/*'/>
    STK_9840,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.LTO_Ultrium"]/*'/>
    LTO_Ultrium,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.LTO_Accelis"]/*'/>
    LTO_Accelis,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.DVD_RAM"]/*'/>
    DVD_RAM,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.AIT_8mm"]/*'/>
    AIT_8mm,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.ADR_1"]/*'/>
    ADR_1,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.ADR_2"]/*'/>
    ADR_2,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.STK_9940"]/*'/>
    STK_9940,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.SAIT"]/*'/>
    SAIT,
    /// <include file='STORAGE_MEDIA_TYPE.xml' path='doc/member[@name="STORAGE_MEDIA_TYPE.VXATape"]/*'/>
    VXATape,
}