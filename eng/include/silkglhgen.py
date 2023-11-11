#!/usr/bin/env python3
# -*- encoding utf-8 -*-
# Licensed to the .NET Foundation under one or more agreements.
# The .NET Foundation licenses this file to you under the MIT license.

from genheaders import *

buildList.clear()
buildList.append(
    CGeneratorOptions(
        filename="../../../include/glcompat/gl.h",  # output file name
        apiname="gl",  # profile name
        profile="compatibility",  # core/compatibility/common
        versions=allVersions,  # include all versions in output
        emitversions=allVersions,  # emit all of the included versions
        defaultExtensions="gl",  # include all gl extensions
        addExtensions=None,  # also include these extensions (none)
        removeExtensions=None,  # but don't include these extensions (none)
        prefixText=prefixStrings + glExtPlatformStrings,  # prefix the header with this text
        genFuncPointers=False,  # generate function pointer typedefs?
        protectFile=protectFile,  # protect against multiple includes?
        protectFeature=protectFeature,  # protect against multiple feature definitions?
        protectProto=False,  # protect against multiple typedef definitiosn?
        protectProtoStr="GL_GLEXT_PROTOTYPES",  # if we're protecting against multiple typedefs, what define should we use?
        apicall="GLAPI ",  # calling convention macro prefix
        apientry="APIENTRY ",  # function typedef prefix
        apientryp="APIENTRYP ",  # function pointer typedef prefix
    )
)
buildList.append(
    CGeneratorOptions(
        filename="../../../include/glcore/gl.h",  # output file name
        apiname="gl",  # profile name
        profile="core",  # core/compatibility/common
        versions=allVersions,  # include all versions in output
        emitversions=allVersions,  # emit all of the included versions
        defaultExtensions="glcore",  # include all gl extensions
        addExtensions=None,  # also include these extensions (none)
        removeExtensions=None,  # but don't include these extensions (none)
        prefixText=prefixStrings + glExtPlatformStrings,  # prefix the header with this text
        genFuncPointers=False,  # generate function pointer typedefs?
        protectFile=protectFile,  # protect against multiple includes?
        protectFeature=protectFeature,  # protect against multiple feature definitions?
        protectProto=False,  # protect against multiple typedef definitiosn?
        protectProtoStr="GL_GLEXT_PROTOTYPES",  # if we're protecting against multiple typedefs, what define should we use?
        apicall="GLAPI ",  # calling convention macro prefix
        apientry="APIENTRY ",  # function typedef prefix
        apientryp="APIENTRYP ",  # function pointer typedef prefix
    )
)
buildList.append(
    CGeneratorOptions(
        filename="../../../include/gles1/gl.h",  # output file name
        apiname="gles1",  # profile name
        profile="common",  # core/compatibility/common
        versions=allVersions,  # include all versions in output
        emitversions=allVersions,  # emit all of the included versions
        defaultExtensions="gles1",  # include all gl extensions
        addExtensions=None,  # also include these extensions (none)
        removeExtensions=None,  # but don't include these extensions (none)
        prefixText=prefixStrings
        + gles1PlatformStrings
        + apiEntryPrefixStrings,  # prefix the header with this text
        genFuncPointers=False,  # generate function pointer typedefs?
        protectFile=protectFile,  # protect against multiple includes?
        protectFeature=protectFeature,  # protect against multiple feature definitions?
        protectProto=False,  # protect against multiple typedef definitiosn?
        protectProtoStr="GL_GLEXT_PROTOTYPES",  # if we're protecting against multiple typedefs, what define should we use?
        apicall="GL_API ",
        apientry="GL_APIENTRY ",
        apientryp="GL_APIENTRYP ",
    )
)
buildList.append(
    CGeneratorOptions(
        filename="../../../include/gles2/gl.h",  # output file name
        apiname="gles2",  # profile name
        profile="common",  # core/compatibility/common
        versions=gles2onlyPat,  # include all versions in output
        emitversions=allVersions,  # emit all of the included versions
        defaultExtensions="gles2",  # include all gl extensions
        addExtensions=None,  # also include these extensions (none)
        removeExtensions=None,  # but don't include these extensions (none)
        prefixText=prefixStrings
        + gles2PlatformStrings
        + apiEntryPrefixStrings,  # prefix the header with this text
        genFuncPointers=False,  # generate function pointer typedefs?
        protectFile=protectFile,  # protect against multiple includes?
        protectFeature=protectFeature,  # protect against multiple feature definitions?
        protectProto=False,  # protect against multiple typedef definitiosn?
        protectProtoStr="GL_GLEXT_PROTOTYPES",  # if we're protecting against multiple typedefs, what define should we use?
        apicall="GL_APICALL ",
        apientry="GL_APIENTRY ",
        apientryp="GL_APIENTRYP ",
    )
)
for genOpts in buildList:
    diag = open("gen.log", "w")
    gen = COutputGenerator(errFile=sys.stderr, warnFile=sys.stderr, diagFile=diag)
    reg = Registry()
    tree = etree.parse(regFilename)
    reg.loadElementTree(tree)
    reg.setGenerator(gen)
    reg.apiGen(genOpts)
    diag.close()
