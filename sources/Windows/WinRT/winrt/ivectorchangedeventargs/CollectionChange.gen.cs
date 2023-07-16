// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/ivectorchangedeventargs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.WinRT;
/// <include file='CollectionChange.xml' path='doc/member[@name="CollectionChange"]/*'/>
public enum CollectionChange
{
    /// <include file='CollectionChange.xml' path='doc/member[@name="CollectionChange.CollectionChange_Reset"]/*'/>
    CollectionChange_Reset,
    /// <include file='CollectionChange.xml' path='doc/member[@name="CollectionChange.CollectionChange_ItemInserted"]/*'/>
    CollectionChange_ItemInserted,
    /// <include file='CollectionChange.xml' path='doc/member[@name="CollectionChange.CollectionChange_ItemRemoved"]/*'/>
    CollectionChange_ItemRemoved,
    /// <include file='CollectionChange.xml' path='doc/member[@name="CollectionChange.CollectionChange_ItemChanged"]/*'/>
    CollectionChange_ItemChanged,
}