// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum APPLICATION_VIEW_SIZE_PREFERENCE
{
    AVSP_DEFAULT = 0,
    AVSP_USE_LESS = 1,
    AVSP_USE_HALF = 2,
    AVSP_USE_MORE = 3,
    AVSP_USE_MINIMUM = 4,
    AVSP_USE_NONE = 5,
    AVSP_CUSTOM = 6,
}
