// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IDeskBarClient"/> struct.</summary>
public static unsafe partial class IDeskBarClientTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDeskBarClient"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDeskBarClient).GUID, Is.EqualTo(IID_IDeskBarClient));
    }

    /// <summary>Validates that the <see cref = "IDeskBarClient"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDeskBarClient>(), Is.EqualTo(sizeof(IDeskBarClient)));
    }

    /// <summary>Validates that the <see cref = "IDeskBarClient"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDeskBarClient).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDeskBarClient"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDeskBarClient), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDeskBarClient), Is.EqualTo(4));
        }
    }
}