// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='POLICY_AUDIT_CATEGORIES_INFO.xml' path='doc/member[@name="POLICY_AUDIT_CATEGORIES_INFO"]/*' />
public unsafe partial struct POLICY_AUDIT_CATEGORIES_INFO
{
    /// <include file='POLICY_AUDIT_CATEGORIES_INFO.xml' path='doc/member[@name="POLICY_AUDIT_CATEGORIES_INFO.MaximumCategoryCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint MaximumCategoryCount;

    /// <include file='POLICY_AUDIT_CATEGORIES_INFO.xml' path='doc/member[@name="POLICY_AUDIT_CATEGORIES_INFO.SubCategoriesInfo"]/*' />
    [NativeTypeName("PPOLICY_AUDIT_SUBCATEGORIES_INFO")]
    public POLICY_AUDIT_SUBCATEGORIES_INFO* SubCategoriesInfo;
}
