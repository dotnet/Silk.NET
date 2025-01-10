// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WS_XML_CANONICALIZATION_ALGORITHM
{
    WS_EXCLUSIVE_XML_CANONICALIZATION_ALGORITHM = 0,
    WS_EXCLUSIVE_WITH_COMMENTS_XML_CANONICALIZATION_ALGORITHM = 1,
    WS_INCLUSIVE_XML_CANONICALIZATION_ALGORITHM = 2,
    WS_INCLUSIVE_WITH_COMMENTS_XML_CANONICALIZATION_ALGORITHM = 3,
}
