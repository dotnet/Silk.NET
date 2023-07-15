// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/icm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT"]/*'/>
public enum BMFORMAT
{
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_x555RGB"]/*'/>
    BM_x555RGB = 0x0000,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_x555XYZ"]/*'/>
    BM_x555XYZ = 0x0101,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_x555Yxy"]/*'/>
    BM_x555Yxy,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_x555Lab"]/*'/>
    BM_x555Lab,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_x555G3CH"]/*'/>
    BM_x555G3CH,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_RGBTRIPLETS"]/*'/>
    BM_RGBTRIPLETS = 0x0002,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_BGRTRIPLETS"]/*'/>
    BM_BGRTRIPLETS = 0x0004,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_XYZTRIPLETS"]/*'/>
    BM_XYZTRIPLETS = 0x0201,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_YxyTRIPLETS"]/*'/>
    BM_YxyTRIPLETS,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_LabTRIPLETS"]/*'/>
    BM_LabTRIPLETS,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_G3CHTRIPLETS"]/*'/>
    BM_G3CHTRIPLETS,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_5CHANNEL"]/*'/>
    BM_5CHANNEL,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_6CHANNEL"]/*'/>
    BM_6CHANNEL,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_7CHANNEL"]/*'/>
    BM_7CHANNEL,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_8CHANNEL"]/*'/>
    BM_8CHANNEL,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_GRAY"]/*'/>
    BM_GRAY,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_xRGBQUADS"]/*'/>
    BM_xRGBQUADS = 0x0008,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_xBGRQUADS"]/*'/>
    BM_xBGRQUADS = 0x0010,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_xG3CHQUADS"]/*'/>
    BM_xG3CHQUADS = 0x0304,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_KYMCQUADS"]/*'/>
    BM_KYMCQUADS,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_CMYKQUADS"]/*'/>
    BM_CMYKQUADS = 0x0020,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_10b_RGB"]/*'/>
    BM_10b_RGB = 0x0009,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_10b_XYZ"]/*'/>
    BM_10b_XYZ = 0x0401,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_10b_Yxy"]/*'/>
    BM_10b_Yxy,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_10b_Lab"]/*'/>
    BM_10b_Lab,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_10b_G3CH"]/*'/>
    BM_10b_G3CH,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_NAMED_INDEX"]/*'/>
    BM_NAMED_INDEX,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_16b_RGB"]/*'/>
    BM_16b_RGB = 0x000A,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_16b_XYZ"]/*'/>
    BM_16b_XYZ = 0x0501,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_16b_Yxy"]/*'/>
    BM_16b_Yxy,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_16b_Lab"]/*'/>
    BM_16b_Lab,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_16b_G3CH"]/*'/>
    BM_16b_G3CH,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_16b_GRAY"]/*'/>
    BM_16b_GRAY,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_565RGB"]/*'/>
    BM_565RGB = 0x0001,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_32b_scRGB"]/*'/>
    BM_32b_scRGB = 0x0601,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_32b_scARGB"]/*'/>
    BM_32b_scARGB = 0x0602,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_S2DOT13FIXED_scRGB"]/*'/>
    BM_S2DOT13FIXED_scRGB = 0x0603,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_S2DOT13FIXED_scARGB"]/*'/>
    BM_S2DOT13FIXED_scARGB = 0x0604,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_R10G10B10A2"]/*'/>
    BM_R10G10B10A2 = 0x0701,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_R10G10B10A2_XR"]/*'/>
    BM_R10G10B10A2_XR = 0x0702,
    /// <include file='BMFORMAT.xml' path='doc/member[@name="BMFORMAT.BM_R16G16B16A16_FLOAT"]/*'/>
    BM_R16G16B16A16_FLOAT = 0x0703,
}