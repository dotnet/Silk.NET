// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[SupportedOSPlatform("windows10.0.14393.0")]
public enum VisualElementState
{
    ErrorResolved = 0,
    ErrorResourceNotFound = (ErrorResolved + 1),
    ErrorInvalidResource = (ErrorResourceNotFound + 1),
}
