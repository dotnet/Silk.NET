// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "PublishingWizard"/> struct.</summary>
public static unsafe partial class PublishingWizardTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "PublishingWizard"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(PublishingWizard).GUID, Is.EqualTo(IID_PublishingWizard));
    }

    /// <summary>Validates that the <see cref = "PublishingWizard"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PublishingWizard>(), Is.EqualTo(sizeof(PublishingWizard)));
    }

    /// <summary>Validates that the <see cref = "PublishingWizard"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PublishingWizard).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PublishingWizard"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(PublishingWizard), Is.EqualTo(1));
    }
}