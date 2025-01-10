// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.3")]
public enum PSS_OBJECT_TYPE
{
    PSS_OBJECT_TYPE_UNKNOWN = 0,
    PSS_OBJECT_TYPE_PROCESS = 1,
    PSS_OBJECT_TYPE_THREAD = 2,
    PSS_OBJECT_TYPE_MUTANT = 3,
    PSS_OBJECT_TYPE_EVENT = 4,
    PSS_OBJECT_TYPE_SECTION = 5,
    PSS_OBJECT_TYPE_SEMAPHORE = 6,
}
