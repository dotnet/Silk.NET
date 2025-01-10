// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SPCATEGORYTYPE
{
    SPCT_COMMAND = 0,
    SPCT_DICTATION = (SPCT_COMMAND + 1),
    SPCT_SLEEP = (SPCT_DICTATION + 1),
    SPCT_SUB_COMMAND = (SPCT_SLEEP + 1),
    SPCT_SUB_DICTATION = (SPCT_SUB_COMMAND + 1),
}
