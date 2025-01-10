// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Windows.SPRULESTATE;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SpeechRuleState
{
    SGDSInactive = SPRS_INACTIVE,
    SGDSActive = SPRS_ACTIVE,
    SGDSActiveWithAutoPause = SPRS_ACTIVE_WITH_AUTO_PAUSE,
    SGDSActiveUserDelimited = SPRS_ACTIVE_USER_DELIMITED,
}
