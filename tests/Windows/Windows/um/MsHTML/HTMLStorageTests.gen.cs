// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "HTMLStorage"/> struct.</summary>
public static unsafe partial class HTMLStorageTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "HTMLStorage"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(HTMLStorage).GUID, Is.EqualTo(IID_HTMLStorage));
    }

    /// <summary>Validates that the <see cref = "HTMLStorage"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HTMLStorage>(), Is.EqualTo(sizeof(HTMLStorage)));
    }

    /// <summary>Validates that the <see cref = "HTMLStorage"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HTMLStorage).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HTMLStorage"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HTMLStorage), Is.EqualTo(1));
    }
}