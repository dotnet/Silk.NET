// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum mediaType
{
    mediaTypeNotSet = 0,
    mediaTypeAll = 511,
    mediaTypeAural = 1,
    mediaTypeBraille = 2,
    mediaTypeEmbossed = 4,
    mediaTypeHandheld = 8,
    mediaTypePrint = 16,
    mediaTypeProjection = 32,
    mediaTypeScreen = 64,
    mediaTypeTty = 128,
    mediaTypeTv = 256,
    mediaType_Max = 2147483647,
}
