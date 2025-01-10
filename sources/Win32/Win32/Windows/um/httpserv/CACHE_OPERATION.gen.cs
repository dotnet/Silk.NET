// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum CACHE_OPERATION
{
    CACHE_OPERATION_RETRIEVE,
    CACHE_OPERATION_ADD,
    CACHE_OPERATION_DELETE,
    CACHE_OPERATION_FLUSH_PREFIX,
    CACHE_OPERATION_ENUM,
}
