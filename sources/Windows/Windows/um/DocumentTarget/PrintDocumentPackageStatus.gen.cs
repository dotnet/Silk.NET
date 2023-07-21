// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocumentTarget.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='PrintDocumentPackageStatus.xml' path='doc/member[@name="PrintDocumentPackageStatus"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct PrintDocumentPackageStatus
{
    /// <include file='PrintDocumentPackageStatus.xml' path='doc/member[@name="PrintDocumentPackageStatus.JobId"]/*' />
    [NativeTypeName("UINT32")]
    public uint JobId;

    /// <include file='PrintDocumentPackageStatus.xml' path='doc/member[@name="PrintDocumentPackageStatus.CurrentDocument"]/*' />
    [NativeTypeName("INT32")]
    public int CurrentDocument;

    /// <include file='PrintDocumentPackageStatus.xml' path='doc/member[@name="PrintDocumentPackageStatus.CurrentPage"]/*' />
    [NativeTypeName("INT32")]
    public int CurrentPage;

    /// <include file='PrintDocumentPackageStatus.xml' path='doc/member[@name="PrintDocumentPackageStatus.CurrentPageTotal"]/*' />
    [NativeTypeName("INT32")]
    public int CurrentPageTotal;

    /// <include file='PrintDocumentPackageStatus.xml' path='doc/member[@name="PrintDocumentPackageStatus.Completion"]/*' />
    public PrintDocumentPackageCompletion Completion;

    /// <include file='PrintDocumentPackageStatus.xml' path='doc/member[@name="PrintDocumentPackageStatus.PackageStatus"]/*' />
    public HRESULT PackageStatus;
}
