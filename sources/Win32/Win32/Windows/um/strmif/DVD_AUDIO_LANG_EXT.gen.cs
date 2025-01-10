// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DVD_AUDIO_LANG_EXT
{
    DVD_AUD_EXT_NotSpecified = 0,
    DVD_AUD_EXT_Captions = 1,
    DVD_AUD_EXT_VisuallyImpaired = 2,
    DVD_AUD_EXT_DirectorComments1 = 3,
    DVD_AUD_EXT_DirectorComments2 = 4,
}
