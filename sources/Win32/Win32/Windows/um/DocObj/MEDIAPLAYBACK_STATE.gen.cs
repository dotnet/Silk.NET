// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum MEDIAPLAYBACK_STATE
{
    MEDIAPLAYBACK_RESUME = 0,
    MEDIAPLAYBACK_PAUSE = 1,
    MEDIAPLAYBACK_PAUSE_AND_SUSPEND = 2,
    MEDIAPLAYBACK_RESUME_FROM_SUSPEND = 3,
}
