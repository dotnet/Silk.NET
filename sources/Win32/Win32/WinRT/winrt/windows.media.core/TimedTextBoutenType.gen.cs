// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum TimedTextBoutenType
{
    TimedTextBoutenType_None = 0,
    TimedTextBoutenType_Auto = 1,
    TimedTextBoutenType_FilledCircle = 2,
    TimedTextBoutenType_OpenCircle = 3,
    TimedTextBoutenType_FilledDot = 4,
    TimedTextBoutenType_OpenDot = 5,
    TimedTextBoutenType_FilledSesame = 6,
    TimedTextBoutenType_OpenSesame = 7,
}
