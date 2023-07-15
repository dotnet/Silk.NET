// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.WinRT;
/// <include file='MetadataBit.xml' path='doc/member[@name="MetadataBit"]/*'/>
[Flags]
[SupportedOSPlatform("windows10.0")]
public enum MetadataBit
{
    /// <include file='MetadataBit.xml' path='doc/member[@name="MetadataBit.None"]/*'/>
    None = 0,
    /// <include file='MetadataBit.xml' path='doc/member[@name="MetadataBit.IsValueHandle"]/*'/>
    IsValueHandle = 0x1,
    /// <include file='MetadataBit.xml' path='doc/member[@name="MetadataBit.IsPropertyReadOnly"]/*'/>
    IsPropertyReadOnly = 0x2,
    /// <include file='MetadataBit.xml' path='doc/member[@name="MetadataBit.IsValueCollection"]/*'/>
    IsValueCollection = 0x4,
    /// <include file='MetadataBit.xml' path='doc/member[@name="MetadataBit.IsValueCollectionReadOnly"]/*'/>
    IsValueCollectionReadOnly = 0x8,
    /// <include file='MetadataBit.xml' path='doc/member[@name="MetadataBit.IsValueBindingExpression"]/*'/>
    IsValueBindingExpression = 0x10,
    /// <include file='MetadataBit.xml' path='doc/member[@name="MetadataBit.IsValueNull"]/*'/>
    IsValueNull = 0x20,
    /// <include file='MetadataBit.xml' path='doc/member[@name="MetadataBit.IsValueHandleAndEvaluatedValue"]/*'/>
    IsValueHandleAndEvaluatedValue = 0x40,
}