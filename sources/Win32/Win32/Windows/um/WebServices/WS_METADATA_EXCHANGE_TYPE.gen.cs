// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WS_METADATA_EXCHANGE_TYPE
{
    WS_METADATA_EXCHANGE_TYPE_NONE = 0,
    WS_METADATA_EXCHANGE_TYPE_MEX = 1,
    WS_METADATA_EXCHANGE_TYPE_HTTP_GET = 2,
}
