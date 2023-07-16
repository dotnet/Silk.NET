// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_PROPERTY_QUERY.xml' path='doc/member[@name="STORAGE_PROPERTY_QUERY"]/*'/>
public unsafe partial struct STORAGE_PROPERTY_QUERY
{
    /// <include file='STORAGE_PROPERTY_QUERY.xml' path='doc/member[@name="STORAGE_PROPERTY_QUERY.PropertyId"]/*'/>
    public STORAGE_PROPERTY_ID PropertyId;
    /// <include file='STORAGE_PROPERTY_QUERY.xml' path='doc/member[@name="STORAGE_PROPERTY_QUERY.QueryType"]/*'/>
    public STORAGE_QUERY_TYPE QueryType;
    /// <include file='STORAGE_PROPERTY_QUERY.xml' path='doc/member[@name="STORAGE_PROPERTY_QUERY.AdditionalParameters"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte AdditionalParameters[1];
}