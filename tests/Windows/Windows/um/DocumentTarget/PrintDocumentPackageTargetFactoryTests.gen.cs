// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocumentTarget.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "PrintDocumentPackageTargetFactory"/> struct.</summary>
public static unsafe partial class PrintDocumentPackageTargetFactoryTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "PrintDocumentPackageTargetFactory"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(PrintDocumentPackageTargetFactory).GUID, Is.EqualTo(CLSID_PrintDocumentPackageTargetFactory));
    }

    /// <summary>Validates that the <see cref = "PrintDocumentPackageTargetFactory"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PrintDocumentPackageTargetFactory>(), Is.EqualTo(sizeof(PrintDocumentPackageTargetFactory)));
    }

    /// <summary>Validates that the <see cref = "PrintDocumentPackageTargetFactory"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PrintDocumentPackageTargetFactory).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PrintDocumentPackageTargetFactory"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(PrintDocumentPackageTargetFactory), Is.EqualTo(1));
    }
}