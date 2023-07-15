// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "HTMLGenericElement"/> struct.</summary>
public static unsafe partial class HTMLGenericElementTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "HTMLGenericElement"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(HTMLGenericElement).GUID, Is.EqualTo(IID_HTMLGenericElement));
    }

    /// <summary>Validates that the <see cref = "HTMLGenericElement"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HTMLGenericElement>(), Is.EqualTo(sizeof(HTMLGenericElement)));
    }

    /// <summary>Validates that the <see cref = "HTMLGenericElement"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HTMLGenericElement).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HTMLGenericElement"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HTMLGenericElement), Is.EqualTo(1));
    }
}