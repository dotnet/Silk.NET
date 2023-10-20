// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrSemanticLabelsSupportFlagsFB")]
    public enum SemanticLabelsSupportFlagsFB : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"MultipleSemanticLabelsBitFB\"")]
        [NativeName("Name", "XR_SEMANTIC_LABELS_SUPPORT_MULTIPLE_SEMANTIC_LABELS_BIT_FB")]
        SemanticLabelsSupportMultipleSemanticLabelsBitFB = 1,
        [Obsolete("Deprecated in favour of \"AcceptDeskToTableMigrationBitFB\"")]
        [NativeName("Name", "XR_SEMANTIC_LABELS_SUPPORT_ACCEPT_DESK_TO_TABLE_MIGRATION_BIT_FB")]
        SemanticLabelsSupportAcceptDeskToTableMigrationBitFB = 2,
        [NativeName("Name", "XR_SEMANTIC_LABELS_SUPPORT_MULTIPLE_SEMANTIC_LABELS_BIT_FB")]
        MultipleSemanticLabelsBitFB = 1,
        [NativeName("Name", "XR_SEMANTIC_LABELS_SUPPORT_ACCEPT_DESK_TO_TABLE_MIGRATION_BIT_FB")]
        AcceptDeskToTableMigrationBitFB = 2,
    }
}
