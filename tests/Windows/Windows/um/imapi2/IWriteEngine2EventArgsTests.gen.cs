// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IWriteEngine2EventArgs"/> struct.</summary>
public static unsafe partial class IWriteEngine2EventArgsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IWriteEngine2EventArgs"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IWriteEngine2EventArgs).GUID, Is.EqualTo(IID_IWriteEngine2EventArgs));
    }

    /// <summary>Validates that the <see cref = "IWriteEngine2EventArgs"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IWriteEngine2EventArgs>(), Is.EqualTo(sizeof(IWriteEngine2EventArgs)));
    }

    /// <summary>Validates that the <see cref = "IWriteEngine2EventArgs"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IWriteEngine2EventArgs).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IWriteEngine2EventArgs"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IWriteEngine2EventArgs), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IWriteEngine2EventArgs), Is.EqualTo(4));
        }
    }
}