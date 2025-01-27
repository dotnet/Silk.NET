// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "__MIDL___MIDL_itf_documenttarget_0000_0002_0001")]
    public unsafe partial struct MIDLMIDLItfDocumentTarget000000020001
    {
        public MIDLMIDLItfDocumentTarget000000020001
        (
            uint? jobId = null,
            int? currentDocument = null,
            int? currentPage = null,
            int? currentPageTotal = null,
            PrintDocumentPackageCompletion? completion = null,
            int? packageStatus = null
        ) : this()
        {
            if (jobId is not null)
            {
                JobId = jobId.Value;
            }

            if (currentDocument is not null)
            {
                CurrentDocument = currentDocument.Value;
            }

            if (currentPage is not null)
            {
                CurrentPage = currentPage.Value;
            }

            if (currentPageTotal is not null)
            {
                CurrentPageTotal = currentPageTotal.Value;
            }

            if (completion is not null)
            {
                Completion = completion.Value;
            }

            if (packageStatus is not null)
            {
                PackageStatus = packageStatus.Value;
            }
        }


        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "JobId")]
        public uint JobId;

        [NativeName("Type", "INT32")]
        [NativeName("Type.Name", "INT32")]
        [NativeName("Name", "CurrentDocument")]
        public int CurrentDocument;

        [NativeName("Type", "INT32")]
        [NativeName("Type.Name", "INT32")]
        [NativeName("Name", "CurrentPage")]
        public int CurrentPage;

        [NativeName("Type", "INT32")]
        [NativeName("Type.Name", "INT32")]
        [NativeName("Name", "CurrentPageTotal")]
        public int CurrentPageTotal;

        [NativeName("Type", "PrintDocumentPackageCompletion")]
        [NativeName("Type.Name", "PrintDocumentPackageCompletion")]
        [NativeName("Name", "Completion")]
        public PrintDocumentPackageCompletion Completion;

        [NativeName("Type", "HRESULT")]
        [NativeName("Type.Name", "HRESULT")]
        [NativeName("Name", "PackageStatus")]
        public int PackageStatus;
    }
}
