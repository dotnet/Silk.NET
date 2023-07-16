// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WICMetadataCreationOptions.xml' path='doc/member[@name="WICMetadataCreationOptions"]/*'/>
public enum WICMetadataCreationOptions
{
    /// <include file='WICMetadataCreationOptions.xml' path='doc/member[@name="WICMetadataCreationOptions.WICMetadataCreationDefault"]/*'/>
    WICMetadataCreationDefault = 0,
    /// <include file='WICMetadataCreationOptions.xml' path='doc/member[@name="WICMetadataCreationOptions.WICMetadataCreationAllowUnknown"]/*'/>
    WICMetadataCreationAllowUnknown = WICMetadataCreationDefault,
    /// <include file='WICMetadataCreationOptions.xml' path='doc/member[@name="WICMetadataCreationOptions.WICMetadataCreationFailUnknown"]/*'/>
    WICMetadataCreationFailUnknown = 0x10000,
    /// <include file='WICMetadataCreationOptions.xml' path='doc/member[@name="WICMetadataCreationOptions.WICMetadataCreationMask"]/*'/>
    WICMetadataCreationMask = unchecked((int)(0xffff0000)),
}