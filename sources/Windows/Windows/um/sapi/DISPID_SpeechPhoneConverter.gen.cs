// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISPID_SpeechPhoneConverter.xml' path='doc/member[@name="DISPID_SpeechPhoneConverter"]/*'/>
public enum DISPID_SpeechPhoneConverter
{
    /// <include file='DISPID_SpeechPhoneConverter.xml' path='doc/member[@name="DISPID_SpeechPhoneConverter.DISPID_SPCLangId"]/*'/>
    DISPID_SPCLangId = 1,
    /// <include file='DISPID_SpeechPhoneConverter.xml' path='doc/member[@name="DISPID_SpeechPhoneConverter.DISPID_SPCPhoneToId"]/*'/>
    DISPID_SPCPhoneToId = (DISPID_SPCLangId + 1),
    /// <include file='DISPID_SpeechPhoneConverter.xml' path='doc/member[@name="DISPID_SpeechPhoneConverter.DISPID_SPCIdToPhone"]/*'/>
    DISPID_SPCIdToPhone = (DISPID_SPCPhoneToId + 1),
}