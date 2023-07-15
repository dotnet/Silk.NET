// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IEnumACString"/> struct.</summary>
public static unsafe partial class IEnumACStringTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IEnumACString"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IEnumACString).GUID, Is.EqualTo(IID_IEnumACString));
    }

    /// <summary>Validates that the <see cref = "IEnumACString"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IEnumACString>(), Is.EqualTo(sizeof(IEnumACString)));
    }

    /// <summary>Validates that the <see cref = "IEnumACString"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IEnumACString).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IEnumACString"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IEnumACString), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IEnumACString), Is.EqualTo(4));
        }
    }
}