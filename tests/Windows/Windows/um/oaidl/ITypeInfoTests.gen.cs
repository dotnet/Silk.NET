// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ITypeInfo"/> struct.</summary>
public static unsafe partial class ITypeInfoTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ITypeInfo"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ITypeInfo).GUID, Is.EqualTo(IID_ITypeInfo));
    }

    /// <summary>Validates that the <see cref = "ITypeInfo"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ITypeInfo>(), Is.EqualTo(sizeof(ITypeInfo)));
    }

    /// <summary>Validates that the <see cref = "ITypeInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ITypeInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ITypeInfo"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ITypeInfo), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ITypeInfo), Is.EqualTo(4));
        }
    }
}