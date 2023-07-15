// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ICreateTypeLib"/> struct.</summary>
public static unsafe partial class ICreateTypeLibTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ICreateTypeLib"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ICreateTypeLib).GUID, Is.EqualTo(IID_ICreateTypeLib));
    }

    /// <summary>Validates that the <see cref = "ICreateTypeLib"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ICreateTypeLib>(), Is.EqualTo(sizeof(ICreateTypeLib)));
    }

    /// <summary>Validates that the <see cref = "ICreateTypeLib"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ICreateTypeLib).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ICreateTypeLib"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ICreateTypeLib), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ICreateTypeLib), Is.EqualTo(4));
        }
    }
}