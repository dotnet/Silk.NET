// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum htmlEffectAllowed
{
    htmlEffectAllowedCopy = 0,
    htmlEffectAllowedLink = 1,
    htmlEffectAllowedMove = 2,
    htmlEffectAllowedCopyLink = 3,
    htmlEffectAllowedCopyMove = 4,
    htmlEffectAllowedLinkMove = 5,
    htmlEffectAllowedAll = 6,
    htmlEffectAllowedNone = 7,
    htmlEffectAllowedUninitialized = 8,
    htmlEffectAllowed_Max = 2147483647,
}
