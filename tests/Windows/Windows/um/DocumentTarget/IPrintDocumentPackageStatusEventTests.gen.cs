// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocumentTarget.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IPrintDocumentPackageStatusEvent"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IPrintDocumentPackageStatusEventTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IPrintDocumentPackageStatusEvent"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IPrintDocumentPackageStatusEvent).GUID, Is.EqualTo(IID_IPrintDocumentPackageStatusEvent));
    }

    /// <summary>Validates that the <see cref = "IPrintDocumentPackageStatusEvent"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IPrintDocumentPackageStatusEvent>(), Is.EqualTo(sizeof(IPrintDocumentPackageStatusEvent)));
    }

    /// <summary>Validates that the <see cref = "IPrintDocumentPackageStatusEvent"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IPrintDocumentPackageStatusEvent).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IPrintDocumentPackageStatusEvent"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IPrintDocumentPackageStatusEvent), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IPrintDocumentPackageStatusEvent), Is.EqualTo(4));
        }
    }
}