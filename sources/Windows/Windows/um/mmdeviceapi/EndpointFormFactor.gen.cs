// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EndpointFormFactor.xml' path='doc/member[@name="EndpointFormFactor"]/*'/>
public enum EndpointFormFactor
{
    /// <include file='EndpointFormFactor.xml' path='doc/member[@name="EndpointFormFactor.RemoteNetworkDevice"]/*'/>
    RemoteNetworkDevice = 0,
    /// <include file='EndpointFormFactor.xml' path='doc/member[@name="EndpointFormFactor.Speakers"]/*'/>
    Speakers = (RemoteNetworkDevice + 1),
    /// <include file='EndpointFormFactor.xml' path='doc/member[@name="EndpointFormFactor.LineLevel"]/*'/>
    LineLevel = (Speakers + 1),
    /// <include file='EndpointFormFactor.xml' path='doc/member[@name="EndpointFormFactor.Headphones"]/*'/>
    Headphones = (LineLevel + 1),
    /// <include file='EndpointFormFactor.xml' path='doc/member[@name="EndpointFormFactor.Microphone"]/*'/>
    Microphone = (Headphones + 1),
    /// <include file='EndpointFormFactor.xml' path='doc/member[@name="EndpointFormFactor.Headset"]/*'/>
    Headset = (Microphone + 1),
    /// <include file='EndpointFormFactor.xml' path='doc/member[@name="EndpointFormFactor.Handset"]/*'/>
    Handset = (Headset + 1),
    /// <include file='EndpointFormFactor.xml' path='doc/member[@name="EndpointFormFactor.UnknownDigitalPassthrough"]/*'/>
    UnknownDigitalPassthrough = (Handset + 1),
    /// <include file='EndpointFormFactor.xml' path='doc/member[@name="EndpointFormFactor.SPDIF"]/*'/>
    SPDIF = (UnknownDigitalPassthrough + 1),
    /// <include file='EndpointFormFactor.xml' path='doc/member[@name="EndpointFormFactor.DigitalAudioDisplayDevice"]/*'/>
    DigitalAudioDisplayDevice = (SPDIF + 1),
    /// <include file='EndpointFormFactor.xml' path='doc/member[@name="EndpointFormFactor.UnknownFormFactor"]/*'/>
    UnknownFormFactor = (DigitalAudioDisplayDevice + 1),
    /// <include file='EndpointFormFactor.xml' path='doc/member[@name="EndpointFormFactor.EndpointFormFactor_enum_count"]/*'/>
    EndpointFormFactor_enum_count = (UnknownFormFactor + 1),
}