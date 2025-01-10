// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum AM_PROPERTY_AC3
{
    AM_PROPERTY_AC3_ERROR_CONCEALMENT = 1,
    AM_PROPERTY_AC3_ALTERNATE_AUDIO = 2,
    AM_PROPERTY_AC3_DOWNMIX = 3,
    AM_PROPERTY_AC3_BIT_STREAM_MODE = 4,
    AM_PROPERTY_AC3_DIALOGUE_LEVEL = 5,
    AM_PROPERTY_AC3_LANGUAGE_CODE = 6,
    AM_PROPERTY_AC3_ROOM_TYPE = 7,
}
