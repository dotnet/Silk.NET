// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum svgFecomponenttransferType
{
    SVG_FECOMPONENTTRANSFER_TYPE_UNKNOWN = 0,
    SVG_FECOMPONENTTRANSFER_TYPE_IDENTITY = 1,
    SVG_FECOMPONENTTRANSFER_TYPE_TABLE = 2,
    SVG_FECOMPONENTTRANSFER_TYPE_DISCRETE = 3,
    SVG_FECOMPONENTTRANSFER_TYPE_LINEAR = 4,
    SVG_FECOMPONENTTRANSFER_TYPE_GAMMA = 5,
    svgFecomponenttransferType_Max = 2147483647,
}
