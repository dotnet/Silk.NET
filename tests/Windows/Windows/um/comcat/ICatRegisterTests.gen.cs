// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/comcat.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ICatRegister"/> struct.</summary>
public static unsafe partial class ICatRegisterTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ICatRegister"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ICatRegister).GUID, Is.EqualTo(IID_ICatRegister));
    }

    /// <summary>Validates that the <see cref = "ICatRegister"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ICatRegister>(), Is.EqualTo(sizeof(ICatRegister)));
    }

    /// <summary>Validates that the <see cref = "ICatRegister"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ICatRegister).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ICatRegister"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ICatRegister), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ICatRegister), Is.EqualTo(4));
        }
    }
}