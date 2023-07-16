// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WebWizardHost"/> struct.</summary>
public static unsafe partial class WebWizardHostTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "WebWizardHost"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(WebWizardHost).GUID, Is.EqualTo(IID_WebWizardHost));
    }

    /// <summary>Validates that the <see cref = "WebWizardHost"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WebWizardHost>(), Is.EqualTo(sizeof(WebWizardHost)));
    }

    /// <summary>Validates that the <see cref = "WebWizardHost"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WebWizardHost).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WebWizardHost"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WebWizardHost), Is.EqualTo(1));
    }
}