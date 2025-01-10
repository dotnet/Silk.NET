// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum FS_BPIO_INFLAGS
{
    FSBPIO_INFL_None = 0,
    FSBPIO_INFL_SKIP_STORAGE_STACK_QUERY = 1,
}
