// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SPEAKFLAGS
{
    SPF_DEFAULT = 0,
    SPF_ASYNC = (1 << 0),
    SPF_PURGEBEFORESPEAK = (1 << 1),
    SPF_IS_FILENAME = (1 << 2),
    SPF_IS_XML = (1 << 3),
    SPF_IS_NOT_XML = (1 << 4),
    SPF_PERSIST_XML = (1 << 5),
    SPF_NLP_SPEAK_PUNC = (1 << 6),
    SPF_PARSE_SAPI = (1 << 7),
    SPF_PARSE_SSML = (1 << 8),
    SPF_PARSE_AUTODETECT = 0,
    SPF_NLP_MASK = SPF_NLP_SPEAK_PUNC,
    SPF_PARSE_MASK = (SPF_PARSE_SAPI | SPF_PARSE_SSML),
    SPF_VOICE_MASK =
        (
            (
                (
                    (
                        (((SPF_ASYNC | SPF_PURGEBEFORESPEAK) | SPF_IS_FILENAME) | SPF_IS_XML)
                        | SPF_IS_NOT_XML
                    ) | SPF_NLP_MASK
                ) | SPF_PERSIST_XML
            ) | SPF_PARSE_MASK
        ),
    SPF_UNUSED_FLAGS = ~SPF_VOICE_MASK,
}
