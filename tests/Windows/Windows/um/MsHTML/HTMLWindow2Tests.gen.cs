// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "HTMLWindow2"/> struct.</summary>
public static unsafe partial class HTMLWindow2Tests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "HTMLWindow2"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(HTMLWindow2).GUID, Is.EqualTo(IID_HTMLWindow2));
    }

    /// <summary>Validates that the <see cref = "HTMLWindow2"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HTMLWindow2>(), Is.EqualTo(sizeof(HTMLWindow2)));
    }

    /// <summary>Validates that the <see cref = "HTMLWindow2"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HTMLWindow2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HTMLWindow2"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HTMLWindow2), Is.EqualTo(1));
    }
}