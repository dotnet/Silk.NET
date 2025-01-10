// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum MF_CAPTURE_ENGINE_MEDIA_CATEGORY_TYPE
{
    MF_CAPTURE_ENGINE_MEDIA_CATEGORY_TYPE_OTHER = 0,
    MF_CAPTURE_ENGINE_MEDIA_CATEGORY_TYPE_COMMUNICATIONS = 1,
    MF_CAPTURE_ENGINE_MEDIA_CATEGORY_TYPE_MEDIA = 2,
    MF_CAPTURE_ENGINE_MEDIA_CATEGORY_TYPE_GAMECHAT = 3,
    MF_CAPTURE_ENGINE_MEDIA_CATEGORY_TYPE_SPEECH = 4,
    MF_CAPTURE_ENGINE_MEDIA_CATEGORY_TYPE_FARFIELDSPEECH = 5,
    MF_CAPTURE_ENGINE_MEDIA_CATEGORY_TYPE_UNIFORMSPEECH = 6,
    MF_CAPTURE_ENGINE_MEDIA_CATEGORY_TYPE_VOICETYPING = 7,
}
