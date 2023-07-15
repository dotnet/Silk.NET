// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MF_CAPTURE_ENGINE_AUDIO_PROCESSING_MODE.xml' path='doc/member[@name="MF_CAPTURE_ENGINE_AUDIO_PROCESSING_MODE"]/*'/>
public enum MF_CAPTURE_ENGINE_AUDIO_PROCESSING_MODE
{
    /// <include file='MF_CAPTURE_ENGINE_AUDIO_PROCESSING_MODE.xml' path='doc/member[@name="MF_CAPTURE_ENGINE_AUDIO_PROCESSING_MODE.MF_CAPTURE_ENGINE_AUDIO_PROCESSING_DEFAULT"]/*'/>
    MF_CAPTURE_ENGINE_AUDIO_PROCESSING_DEFAULT = 0,
    /// <include file='MF_CAPTURE_ENGINE_AUDIO_PROCESSING_MODE.xml' path='doc/member[@name="MF_CAPTURE_ENGINE_AUDIO_PROCESSING_MODE.MF_CAPTURE_ENGINE_AUDIO_PROCESSING_RAW"]/*'/>
    MF_CAPTURE_ENGINE_AUDIO_PROCESSING_RAW = 1,
}