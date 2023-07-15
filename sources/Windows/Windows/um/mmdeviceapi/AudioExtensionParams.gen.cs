// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='AudioExtensionParams.xml' path='doc/member[@name="AudioExtensionParams"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct AudioExtensionParams
{
    /// <include file='AudioExtensionParams.xml' path='doc/member[@name="AudioExtensionParams.AddPageParam"]/*'/>
    public LPARAM AddPageParam;
    /// <include file='AudioExtensionParams.xml' path='doc/member[@name="AudioExtensionParams.pEndpoint"]/*'/>
    public IMMDevice* pEndpoint;
    /// <include file='AudioExtensionParams.xml' path='doc/member[@name="AudioExtensionParams.pPnpInterface"]/*'/>
    public IMMDevice* pPnpInterface;
    /// <include file='AudioExtensionParams.xml' path='doc/member[@name="AudioExtensionParams.pPnpDevnode"]/*'/>
    public IMMDevice* pPnpDevnode;
}