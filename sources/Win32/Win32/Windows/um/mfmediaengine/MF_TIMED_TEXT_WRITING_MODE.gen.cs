// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0")]
public enum MF_TIMED_TEXT_WRITING_MODE
{
    MF_TIMED_TEXT_WRITING_MODE_LRTB = 0,
    MF_TIMED_TEXT_WRITING_MODE_RLTB = 1,
    MF_TIMED_TEXT_WRITING_MODE_TBRL = 2,
    MF_TIMED_TEXT_WRITING_MODE_TBLR = 3,
    MF_TIMED_TEXT_WRITING_MODE_LR = 4,
    MF_TIMED_TEXT_WRITING_MODE_RL = 5,
    MF_TIMED_TEXT_WRITING_MODE_TB = 6,
}
