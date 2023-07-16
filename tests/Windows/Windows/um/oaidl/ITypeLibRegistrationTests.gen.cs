// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ITypeLibRegistration"/> struct.</summary>
public static unsafe partial class ITypeLibRegistrationTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ITypeLibRegistration"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ITypeLibRegistration).GUID, Is.EqualTo(IID_ITypeLibRegistration));
    }

    /// <summary>Validates that the <see cref = "ITypeLibRegistration"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ITypeLibRegistration>(), Is.EqualTo(sizeof(ITypeLibRegistration)));
    }

    /// <summary>Validates that the <see cref = "ITypeLibRegistration"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ITypeLibRegistration).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ITypeLibRegistration"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ITypeLibRegistration), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ITypeLibRegistration), Is.EqualTo(4));
        }
    }
}