// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='XmlError.xml' path='doc/member[@name="XmlError"]/*'/>
public enum XmlError
{
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.MX_E_MX"]/*'/>
    MX_E_MX = unchecked((int)(0xc00cee00)),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.MX_E_INPUTEND"]/*'/>
    MX_E_INPUTEND = (MX_E_MX + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.MX_E_ENCODING"]/*'/>
    MX_E_ENCODING = (MX_E_INPUTEND + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.MX_E_ENCODINGSWITCH"]/*'/>
    MX_E_ENCODINGSWITCH = (MX_E_ENCODING + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.MX_E_ENCODINGSIGNATURE"]/*'/>
    MX_E_ENCODINGSIGNATURE = (MX_E_ENCODINGSWITCH + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_WC"]/*'/>
    WC_E_WC = unchecked((int)(0xc00cee20)),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_WHITESPACE"]/*'/>
    WC_E_WHITESPACE = (WC_E_WC + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_SEMICOLON"]/*'/>
    WC_E_SEMICOLON = (WC_E_WHITESPACE + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_GREATERTHAN"]/*'/>
    WC_E_GREATERTHAN = (WC_E_SEMICOLON + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_QUOTE"]/*'/>
    WC_E_QUOTE = (WC_E_GREATERTHAN + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_EQUAL"]/*'/>
    WC_E_EQUAL = (WC_E_QUOTE + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_LESSTHAN"]/*'/>
    WC_E_LESSTHAN = (WC_E_EQUAL + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_HEXDIGIT"]/*'/>
    WC_E_HEXDIGIT = (WC_E_LESSTHAN + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_DIGIT"]/*'/>
    WC_E_DIGIT = (WC_E_HEXDIGIT + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_LEFTBRACKET"]/*'/>
    WC_E_LEFTBRACKET = (WC_E_DIGIT + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_LEFTPAREN"]/*'/>
    WC_E_LEFTPAREN = (WC_E_LEFTBRACKET + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_XMLCHARACTER"]/*'/>
    WC_E_XMLCHARACTER = (WC_E_LEFTPAREN + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_NAMECHARACTER"]/*'/>
    WC_E_NAMECHARACTER = (WC_E_XMLCHARACTER + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_SYNTAX"]/*'/>
    WC_E_SYNTAX = (WC_E_NAMECHARACTER + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_CDSECT"]/*'/>
    WC_E_CDSECT = (WC_E_SYNTAX + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_COMMENT"]/*'/>
    WC_E_COMMENT = (WC_E_CDSECT + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_CONDSECT"]/*'/>
    WC_E_CONDSECT = (WC_E_COMMENT + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_DECLATTLIST"]/*'/>
    WC_E_DECLATTLIST = (WC_E_CONDSECT + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_DECLDOCTYPE"]/*'/>
    WC_E_DECLDOCTYPE = (WC_E_DECLATTLIST + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_DECLELEMENT"]/*'/>
    WC_E_DECLELEMENT = (WC_E_DECLDOCTYPE + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_DECLENTITY"]/*'/>
    WC_E_DECLENTITY = (WC_E_DECLELEMENT + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_DECLNOTATION"]/*'/>
    WC_E_DECLNOTATION = (WC_E_DECLENTITY + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_NDATA"]/*'/>
    WC_E_NDATA = (WC_E_DECLNOTATION + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_PUBLIC"]/*'/>
    WC_E_PUBLIC = (WC_E_NDATA + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_SYSTEM"]/*'/>
    WC_E_SYSTEM = (WC_E_PUBLIC + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_NAME"]/*'/>
    WC_E_NAME = (WC_E_SYSTEM + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_ROOTELEMENT"]/*'/>
    WC_E_ROOTELEMENT = (WC_E_NAME + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_ELEMENTMATCH"]/*'/>
    WC_E_ELEMENTMATCH = (WC_E_ROOTELEMENT + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_UNIQUEATTRIBUTE"]/*'/>
    WC_E_UNIQUEATTRIBUTE = (WC_E_ELEMENTMATCH + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_TEXTXMLDECL"]/*'/>
    WC_E_TEXTXMLDECL = (WC_E_UNIQUEATTRIBUTE + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_LEADINGXML"]/*'/>
    WC_E_LEADINGXML = (WC_E_TEXTXMLDECL + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_TEXTDECL"]/*'/>
    WC_E_TEXTDECL = (WC_E_LEADINGXML + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_XMLDECL"]/*'/>
    WC_E_XMLDECL = (WC_E_TEXTDECL + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_ENCNAME"]/*'/>
    WC_E_ENCNAME = (WC_E_XMLDECL + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_PUBLICID"]/*'/>
    WC_E_PUBLICID = (WC_E_ENCNAME + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_PESINTERNALSUBSET"]/*'/>
    WC_E_PESINTERNALSUBSET = (WC_E_PUBLICID + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_PESBETWEENDECLS"]/*'/>
    WC_E_PESBETWEENDECLS = (WC_E_PESINTERNALSUBSET + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_NORECURSION"]/*'/>
    WC_E_NORECURSION = (WC_E_PESBETWEENDECLS + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_ENTITYCONTENT"]/*'/>
    WC_E_ENTITYCONTENT = (WC_E_NORECURSION + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_UNDECLAREDENTITY"]/*'/>
    WC_E_UNDECLAREDENTITY = (WC_E_ENTITYCONTENT + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_PARSEDENTITY"]/*'/>
    WC_E_PARSEDENTITY = (WC_E_UNDECLAREDENTITY + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_NOEXTERNALENTITYREF"]/*'/>
    WC_E_NOEXTERNALENTITYREF = (WC_E_PARSEDENTITY + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_PI"]/*'/>
    WC_E_PI = (WC_E_NOEXTERNALENTITYREF + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_SYSTEMID"]/*'/>
    WC_E_SYSTEMID = (WC_E_PI + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_QUESTIONMARK"]/*'/>
    WC_E_QUESTIONMARK = (WC_E_SYSTEMID + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_CDSECTEND"]/*'/>
    WC_E_CDSECTEND = (WC_E_QUESTIONMARK + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_MOREDATA"]/*'/>
    WC_E_MOREDATA = (WC_E_CDSECTEND + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_DTDPROHIBITED"]/*'/>
    WC_E_DTDPROHIBITED = (WC_E_MOREDATA + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WC_E_INVALIDXMLSPACE"]/*'/>
    WC_E_INVALIDXMLSPACE = (WC_E_DTDPROHIBITED + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.NC_E_NC"]/*'/>
    NC_E_NC = unchecked((int)(0xc00cee60)),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.NC_E_QNAMECHARACTER"]/*'/>
    NC_E_QNAMECHARACTER = (NC_E_NC + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.NC_E_QNAMECOLON"]/*'/>
    NC_E_QNAMECOLON = (NC_E_QNAMECHARACTER + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.NC_E_NAMECOLON"]/*'/>
    NC_E_NAMECOLON = (NC_E_QNAMECOLON + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.NC_E_DECLAREDPREFIX"]/*'/>
    NC_E_DECLAREDPREFIX = (NC_E_NAMECOLON + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.NC_E_UNDECLAREDPREFIX"]/*'/>
    NC_E_UNDECLAREDPREFIX = (NC_E_DECLAREDPREFIX + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.NC_E_EMPTYURI"]/*'/>
    NC_E_EMPTYURI = (NC_E_UNDECLAREDPREFIX + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.NC_E_XMLPREFIXRESERVED"]/*'/>
    NC_E_XMLPREFIXRESERVED = (NC_E_EMPTYURI + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.NC_E_XMLNSPREFIXRESERVED"]/*'/>
    NC_E_XMLNSPREFIXRESERVED = (NC_E_XMLPREFIXRESERVED + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.NC_E_XMLURIRESERVED"]/*'/>
    NC_E_XMLURIRESERVED = (NC_E_XMLNSPREFIXRESERVED + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.NC_E_XMLNSURIRESERVED"]/*'/>
    NC_E_XMLNSURIRESERVED = (NC_E_XMLURIRESERVED + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.SC_E_SC"]/*'/>
    SC_E_SC = unchecked((int)(0xc00cee80)),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.SC_E_MAXELEMENTDEPTH"]/*'/>
    SC_E_MAXELEMENTDEPTH = (SC_E_SC + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.SC_E_MAXENTITYEXPANSION"]/*'/>
    SC_E_MAXENTITYEXPANSION = (SC_E_MAXELEMENTDEPTH + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WR_E_WR"]/*'/>
    WR_E_WR = unchecked((int)(0xc00cef00)),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WR_E_NONWHITESPACE"]/*'/>
    WR_E_NONWHITESPACE = (WR_E_WR + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WR_E_NSPREFIXDECLARED"]/*'/>
    WR_E_NSPREFIXDECLARED = (WR_E_NONWHITESPACE + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WR_E_NSPREFIXWITHEMPTYNSURI"]/*'/>
    WR_E_NSPREFIXWITHEMPTYNSURI = (WR_E_NSPREFIXDECLARED + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WR_E_DUPLICATEATTRIBUTE"]/*'/>
    WR_E_DUPLICATEATTRIBUTE = (WR_E_NSPREFIXWITHEMPTYNSURI + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WR_E_XMLNSPREFIXDECLARATION"]/*'/>
    WR_E_XMLNSPREFIXDECLARATION = (WR_E_DUPLICATEATTRIBUTE + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WR_E_XMLPREFIXDECLARATION"]/*'/>
    WR_E_XMLPREFIXDECLARATION = (WR_E_XMLNSPREFIXDECLARATION + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WR_E_XMLURIDECLARATION"]/*'/>
    WR_E_XMLURIDECLARATION = (WR_E_XMLPREFIXDECLARATION + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WR_E_XMLNSURIDECLARATION"]/*'/>
    WR_E_XMLNSURIDECLARATION = (WR_E_XMLURIDECLARATION + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WR_E_NAMESPACEUNDECLARED"]/*'/>
    WR_E_NAMESPACEUNDECLARED = (WR_E_XMLNSURIDECLARATION + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WR_E_INVALIDXMLSPACE"]/*'/>
    WR_E_INVALIDXMLSPACE = (WR_E_NAMESPACEUNDECLARED + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WR_E_INVALIDACTION"]/*'/>
    WR_E_INVALIDACTION = (WR_E_INVALIDXMLSPACE + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.WR_E_INVALIDSURROGATEPAIR"]/*'/>
    WR_E_INVALIDSURROGATEPAIR = (WR_E_INVALIDACTION + 1),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.XML_E_INVALID_DECIMAL"]/*'/>
    XML_E_INVALID_DECIMAL = unchecked((int)(0xc00ce01d)),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.XML_E_INVALID_HEXIDECIMAL"]/*'/>
    XML_E_INVALID_HEXIDECIMAL = unchecked((int)(0xc00ce01e)),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.XML_E_INVALID_UNICODE"]/*'/>
    XML_E_INVALID_UNICODE = unchecked((int)(0xc00ce01f)),
    /// <include file='XmlError.xml' path='doc/member[@name="XmlError.XML_E_INVALIDENCODING"]/*'/>
    XML_E_INVALIDENCODING = unchecked((int)(0xc00ce06e)),
}