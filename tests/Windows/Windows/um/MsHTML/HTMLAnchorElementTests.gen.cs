// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "HTMLAnchorElement"/> struct.</summary>
public static unsafe partial class HTMLAnchorElementTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "HTMLAnchorElement"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(HTMLAnchorElement).GUID, Is.EqualTo(IID_HTMLAnchorElement));
    }

    /// <summary>Validates that the <see cref = "HTMLAnchorElement"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HTMLAnchorElement>(), Is.EqualTo(sizeof(HTMLAnchorElement)));
    }

    /// <summary>Validates that the <see cref = "HTMLAnchorElement"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HTMLAnchorElement).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HTMLAnchorElement"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HTMLAnchorElement), Is.EqualTo(1));
    }
}