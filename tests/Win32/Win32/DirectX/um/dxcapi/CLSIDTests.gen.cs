// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.CLSID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "CLSID"/> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref = "CLSID_DxcCompiler"/> property is correct.</summary>

    [Test]
    public static void CLSID_DxcCompilerTest()
    {
        Assert.That(
            CLSID_DxcCompiler,
            Is.EqualTo(
                new Guid(0x73e22d93, 0xe6ce, 0x47f3, 0xb5, 0xbf, 0xf0, 0x66, 0x4f, 0x39, 0xc1, 0xb0)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DxcLinker"/> property is correct.</summary>

    [Test]
    public static void CLSID_DxcLinkerTest()
    {
        Assert.That(
            CLSID_DxcLinker,
            Is.EqualTo(
                new Guid(0xef6a8087, 0xb0ea, 0x4d56, 0x9e, 0x45, 0xd0, 0x7e, 0x1a, 0x8b, 0x78, 0x6)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DxcDiaDataSource"/> property is correct.</summary>

    [Test]
    public static void CLSID_DxcDiaDataSourceTest()
    {
        Assert.That(
            CLSID_DxcDiaDataSource,
            Is.EqualTo(
                new Guid(0xcd1f6b73, 0x2ab0, 0x484d, 0x8e, 0xdc, 0xeb, 0xe7, 0xa4, 0x3c, 0xa0, 0x9f)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DxcCompilerArgs"/> property is correct.</summary>

    [Test]
    public static void CLSID_DxcCompilerArgsTest()
    {
        Assert.That(
            CLSID_DxcCompilerArgs,
            Is.EqualTo(
                new Guid(0x3e56ae82, 0x224d, 0x470f, 0xa1, 0xa1, 0xfe, 0x30, 0x16, 0xee, 0x9f, 0x9d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DxcLibrary"/> property is correct.</summary>

    [Test]
    public static void CLSID_DxcLibraryTest()
    {
        Assert.That(
            CLSID_DxcLibrary,
            Is.EqualTo(
                new Guid(0x6245d6af, 0x66e0, 0x48fd, 0x80, 0xb4, 0x4d, 0x27, 0x17, 0x96, 0x74, 0x8c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DxcValidator"/> property is correct.</summary>

    [Test]
    public static void CLSID_DxcValidatorTest()
    {
        Assert.That(
            CLSID_DxcValidator,
            Is.EqualTo(
                new Guid(0x8ca3e215, 0xf728, 0x4cf3, 0x8c, 0xdd, 0x88, 0xaf, 0x91, 0x75, 0x87, 0xa1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DxcAssembler"/> property is correct.</summary>

    [Test]
    public static void CLSID_DxcAssemblerTest()
    {
        Assert.That(
            CLSID_DxcAssembler,
            Is.EqualTo(
                new Guid(0xd728db68, 0xf903, 0x4f80, 0x94, 0xcd, 0xdc, 0xcf, 0x76, 0xec, 0x71, 0x51)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DxcContainerReflection"/> property is correct.</summary>

    [Test]
    public static void CLSID_DxcContainerReflectionTest()
    {
        Assert.That(
            CLSID_DxcContainerReflection,
            Is.EqualTo(
                new Guid(0xb9f54489, 0x55b8, 0x400c, 0xba, 0x3a, 0x16, 0x75, 0xe4, 0x72, 0x8b, 0x91)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DxcOptimizer"/> property is correct.</summary>

    [Test]
    public static void CLSID_DxcOptimizerTest()
    {
        Assert.That(
            CLSID_DxcOptimizer,
            Is.EqualTo(
                new Guid(0xae2cd79f, 0xcc22, 0x453f, 0x9b, 0x6b, 0xb1, 0x24, 0xe7, 0xa5, 0x20, 0x4c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DxcContainerBuilder"/> property is correct.</summary>

    [Test]
    public static void CLSID_DxcContainerBuilderTest()
    {
        Assert.That(
            CLSID_DxcContainerBuilder,
            Is.EqualTo(
                new Guid(0x94134294, 0x411f, 0x4574, 0xb4, 0xd0, 0x87, 0x41, 0xe2, 0x52, 0x40, 0xd2)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DxcPdbUtils"/> property is correct.</summary>

    [Test]
    public static void CLSID_DxcPdbUtilsTest()
    {
        Assert.That(
            CLSID_DxcPdbUtils,
            Is.EqualTo(
                new Guid(0x54621dfb, 0xf2ce, 0x457e, 0xae, 0x8c, 0xec, 0x35, 0x5f, 0xae, 0xec, 0x7c)
            )
        );
    }
}
