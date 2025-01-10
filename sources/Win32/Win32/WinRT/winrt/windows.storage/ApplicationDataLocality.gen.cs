// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum ApplicationDataLocality
{
    ApplicationDataLocality_Local = 0,
    ApplicationDataLocality_Roaming = 1,
    ApplicationDataLocality_Temporary = 2,
    ApplicationDataLocality_LocalCache = 3,
    ApplicationDataLocality_SharedLocal = 4,
}
