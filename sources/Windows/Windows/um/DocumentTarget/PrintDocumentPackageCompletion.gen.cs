// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocumentTarget.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='PrintDocumentPackageCompletion.xml' path='doc/member[@name="PrintDocumentPackageCompletion"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum PrintDocumentPackageCompletion
{
    /// <include file='PrintDocumentPackageCompletion.xml' path='doc/member[@name="PrintDocumentPackageCompletion.PrintDocumentPackageCompletion_InProgress"]/*'/>
    PrintDocumentPackageCompletion_InProgress = 0,
    /// <include file='PrintDocumentPackageCompletion.xml' path='doc/member[@name="PrintDocumentPackageCompletion.PrintDocumentPackageCompletion_Completed"]/*'/>
    PrintDocumentPackageCompletion_Completed = (PrintDocumentPackageCompletion_InProgress + 1),
    /// <include file='PrintDocumentPackageCompletion.xml' path='doc/member[@name="PrintDocumentPackageCompletion.PrintDocumentPackageCompletion_Canceled"]/*'/>
    PrintDocumentPackageCompletion_Canceled = (PrintDocumentPackageCompletion_Completed + 1),
    /// <include file='PrintDocumentPackageCompletion.xml' path='doc/member[@name="PrintDocumentPackageCompletion.PrintDocumentPackageCompletion_Failed"]/*'/>
    PrintDocumentPackageCompletion_Failed = (PrintDocumentPackageCompletion_Canceled + 1),
}