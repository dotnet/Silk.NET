// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Windows.SPDATAKEYLOCATION;

namespace Silk.NET.Windows;
/// <include file='SpeechDataKeyLocation.xml' path='doc/member[@name="SpeechDataKeyLocation"]/*'/>
public enum SpeechDataKeyLocation
{
    /// <include file='SpeechDataKeyLocation.xml' path='doc/member[@name="SpeechDataKeyLocation.SDKLDefaultLocation"]/*'/>
    SDKLDefaultLocation = SPDKL_DefaultLocation,
    /// <include file='SpeechDataKeyLocation.xml' path='doc/member[@name="SpeechDataKeyLocation.SDKLCurrentUser"]/*'/>
    SDKLCurrentUser = SPDKL_CurrentUser,
    /// <include file='SpeechDataKeyLocation.xml' path='doc/member[@name="SpeechDataKeyLocation.SDKLLocalMachine"]/*'/>
    SDKLLocalMachine = SPDKL_LocalMachine,
    /// <include file='SpeechDataKeyLocation.xml' path='doc/member[@name="SpeechDataKeyLocation.SDKLCurrentConfig"]/*'/>
    SDKLCurrentConfig = SPDKL_CurrentConfig,
}