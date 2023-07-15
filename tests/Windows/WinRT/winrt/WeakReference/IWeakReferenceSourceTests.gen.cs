// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/WeakReference.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "IWeakReferenceSource"/> struct.</summary>
public static unsafe partial class IWeakReferenceSourceTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IWeakReferenceSource"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IWeakReferenceSource).GUID, Is.EqualTo(IID_IWeakReferenceSource));
    }

    /// <summary>Validates that the <see cref = "IWeakReferenceSource"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IWeakReferenceSource>(), Is.EqualTo(sizeof(IWeakReferenceSource)));
    }

    /// <summary>Validates that the <see cref = "IWeakReferenceSource"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IWeakReferenceSource).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IWeakReferenceSource"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IWeakReferenceSource), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IWeakReferenceSource), Is.EqualTo(4));
        }
    }
}