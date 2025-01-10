// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum PrintMediaType
{
    PrintMediaType_Default = 0,
    PrintMediaType_NotAvailable = 1,
    PrintMediaType_PrinterCustom = 2,
    PrintMediaType_AutoSelect = 3,
    PrintMediaType_Archival = 4,
    PrintMediaType_BackPrintFilm = 5,
    PrintMediaType_Bond = 6,
    PrintMediaType_CardStock = 7,
    PrintMediaType_Continuous = 8,
    PrintMediaType_EnvelopePlain = 9,
    PrintMediaType_EnvelopeWindow = 10,
    PrintMediaType_Fabric = 11,
    PrintMediaType_HighResolution = 12,
    PrintMediaType_Label = 13,
    PrintMediaType_MultiLayerForm = 14,
    PrintMediaType_MultiPartForm = 15,
    PrintMediaType_Photographic = 16,
    PrintMediaType_PhotographicFilm = 17,
    PrintMediaType_PhotographicGlossy = 18,
    PrintMediaType_PhotographicHighGloss = 19,
    PrintMediaType_PhotographicMatte = 20,
    PrintMediaType_PhotographicSatin = 21,
    PrintMediaType_PhotographicSemiGloss = 22,
    PrintMediaType_Plain = 23,
    PrintMediaType_Screen = 24,
    PrintMediaType_ScreenPaged = 25,
    PrintMediaType_Stationery = 26,
    PrintMediaType_TabStockFull = 27,
    PrintMediaType_TabStockPreCut = 28,
    PrintMediaType_Transparency = 29,
    PrintMediaType_TShirtTransfer = 30,
    PrintMediaType_None = 31,
}
