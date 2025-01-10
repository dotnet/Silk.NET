// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum styleDisplay
{
    styleDisplayNotSet = 0,
    styleDisplayBlock = 1,
    styleDisplayInline = 2,
    styleDisplayListItem = 3,
    styleDisplayNone = 4,
    styleDisplayTableHeaderGroup = 5,
    styleDisplayTableFooterGroup = 6,
    styleDisplayInlineBlock = 7,
    styleDisplayTable = 8,
    styleDisplayInlineTable = 9,
    styleDisplayTableRow = 10,
    styleDisplayTableRowGroup = 11,
    styleDisplayTableColumn = 12,
    styleDisplayTableColumnGroup = 13,
    styleDisplayTableCell = 14,
    styleDisplayTableCaption = 15,
    styleDisplayRunIn = 16,
    styleDisplayRuby = 17,
    styleDisplayRubyBase = 18,
    styleDisplayRubyText = 19,
    styleDisplayRubyBaseContainer = 20,
    styleDisplayRubyTextContainer = 21,
    styleDisplayMsFlexbox = 22,
    styleDisplayMsInlineFlexbox = 23,
    styleDisplayMsGrid = 24,
    styleDisplayMsInlineGrid = 25,
    styleDisplayFlex = 26,
    styleDisplayInlineFlex = 27,
    styleDisplayWebkitBox = 28,
    styleDisplayWebkitInlineBox = 29,
    styleDisplay_Max = 2147483647,
}
