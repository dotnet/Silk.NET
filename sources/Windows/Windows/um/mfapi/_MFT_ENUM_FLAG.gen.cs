// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='_MFT_ENUM_FLAG.xml' path='doc/member[@name="_MFT_ENUM_FLAG"]/*'/>
public enum _MFT_ENUM_FLAG
{
    /// <include file='_MFT_ENUM_FLAG.xml' path='doc/member[@name="_MFT_ENUM_FLAG.MFT_ENUM_FLAG_SYNCMFT"]/*'/>
    MFT_ENUM_FLAG_SYNCMFT = 0x00000001,
    /// <include file='_MFT_ENUM_FLAG.xml' path='doc/member[@name="_MFT_ENUM_FLAG.MFT_ENUM_FLAG_ASYNCMFT"]/*'/>
    MFT_ENUM_FLAG_ASYNCMFT = 0x00000002,
    /// <include file='_MFT_ENUM_FLAG.xml' path='doc/member[@name="_MFT_ENUM_FLAG.MFT_ENUM_FLAG_HARDWARE"]/*'/>
    MFT_ENUM_FLAG_HARDWARE = 0x00000004,
    /// <include file='_MFT_ENUM_FLAG.xml' path='doc/member[@name="_MFT_ENUM_FLAG.MFT_ENUM_FLAG_FIELDOFUSE"]/*'/>
    MFT_ENUM_FLAG_FIELDOFUSE = 0x00000008,
    /// <include file='_MFT_ENUM_FLAG.xml' path='doc/member[@name="_MFT_ENUM_FLAG.MFT_ENUM_FLAG_LOCALMFT"]/*'/>
    MFT_ENUM_FLAG_LOCALMFT = 0x00000010,
    /// <include file='_MFT_ENUM_FLAG.xml' path='doc/member[@name="_MFT_ENUM_FLAG.MFT_ENUM_FLAG_TRANSCODE_ONLY"]/*'/>
    MFT_ENUM_FLAG_TRANSCODE_ONLY = 0x00000020,
    /// <include file='_MFT_ENUM_FLAG.xml' path='doc/member[@name="_MFT_ENUM_FLAG.MFT_ENUM_FLAG_SORTANDFILTER"]/*'/>
    MFT_ENUM_FLAG_SORTANDFILTER = 0x00000040,
    /// <include file='_MFT_ENUM_FLAG.xml' path='doc/member[@name="_MFT_ENUM_FLAG.MFT_ENUM_FLAG_SORTANDFILTER_APPROVED_ONLY"]/*'/>
    MFT_ENUM_FLAG_SORTANDFILTER_APPROVED_ONLY = 0x000000C0,
    /// <include file='_MFT_ENUM_FLAG.xml' path='doc/member[@name="_MFT_ENUM_FLAG.MFT_ENUM_FLAG_SORTANDFILTER_WEB_ONLY"]/*'/>
    MFT_ENUM_FLAG_SORTANDFILTER_WEB_ONLY = 0x00000140,
    /// <include file='_MFT_ENUM_FLAG.xml' path='doc/member[@name="_MFT_ENUM_FLAG.MFT_ENUM_FLAG_SORTANDFILTER_WEB_ONLY_EDGEMODE"]/*'/>
    MFT_ENUM_FLAG_SORTANDFILTER_WEB_ONLY_EDGEMODE = 0x00000240,
    /// <include file='_MFT_ENUM_FLAG.xml' path='doc/member[@name="_MFT_ENUM_FLAG.MFT_ENUM_FLAG_UNTRUSTED_STOREMFT"]/*'/>
    MFT_ENUM_FLAG_UNTRUSTED_STOREMFT = 0x00000400,
    /// <include file='_MFT_ENUM_FLAG.xml' path='doc/member[@name="_MFT_ENUM_FLAG.MFT_ENUM_FLAG_ALL"]/*'/>
    MFT_ENUM_FLAG_ALL = 0x0000003F,
}