// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/StorageProvider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IStorageProviderHandler"/> struct.</summary>
public static unsafe partial class IStorageProviderHandlerTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IStorageProviderHandler"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IStorageProviderHandler).GUID, Is.EqualTo(IID_IStorageProviderHandler));
    }

    /// <summary>Validates that the <see cref = "IStorageProviderHandler"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IStorageProviderHandler>(), Is.EqualTo(sizeof(IStorageProviderHandler)));
    }

    /// <summary>Validates that the <see cref = "IStorageProviderHandler"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IStorageProviderHandler).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IStorageProviderHandler"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IStorageProviderHandler), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IStorageProviderHandler), Is.EqualTo(4));
        }
    }
}