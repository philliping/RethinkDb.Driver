﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Templates.CodeGen
{
    using System;
    
    #line 2 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 3 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 4 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using Humanizer;
    
    #line default
    #line hidden
    
    #line 5 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using Newtonsoft.Json.Linq;
    
    #line default
    #line hidden
    
    #line 6 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using RazorGenerator.Templating;
    
    #line default
    #line hidden
    
    #line 7 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using Templates.CodeGen;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class AstSubclassTemplate : BaseTemplate
    {
#line hidden

        #line 11 "..\..\CodeGen\AstSubclassTemplate.cshtml"

    public string ClassName { get; set; }
    public string Superclass { get; set; }
    public string IncludeIn { get; set; }

    public IEnumerable<KeyValuePair<string, JObject>> TermsIn
    {
        get
        {
            return Meta.Where(kvp => kvp.Value["include_in"]?.Values<string>().Contains(this.IncludeIn) ?? false);
        }
    }


    public string TermType { get; set; }
    public Dictionary<string,JObject> Meta { get; set; }

    public override RazorTemplateBase UseParentLayout(RazorTemplateBase child)
    {
        return new AstSubclassTemplate()
            {
                ClassName = this.ClassName,
                Superclass = this.Superclass,
                IncludeIn = this.IncludeIn,
                TermType = this.TermType,
                Meta = this.Meta,
                ChildTemplate = child
            };
    }



        #line default
        #line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");







WriteLiteral("\r\n");


WriteLiteral("\r\n");


WriteLiteral("\r\n\r\n");


DefineSection("Ctors", () => {

WriteLiteral("\r\n");


            
            #line 45 "..\..\CodeGen\AstSubclassTemplate.cshtml"
     if( this.TermType != null )
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("public ");


            
            #line 47 "..\..\CodeGen\AstSubclassTemplate.cshtml"
            Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" (object arg) : this(new Arguments(arg), null) {\r\n");



WriteLiteral("        ");

WriteLiteral("}\r\n");



WriteLiteral("        ");

WriteLiteral("public ");


            
            #line 49 "..\..\CodeGen\AstSubclassTemplate.cshtml"
            Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" (Arguments args, OptArgs optargs) : this(null, args, optargs) {\r\n");



WriteLiteral("        ");

WriteLiteral("}\r\n");



WriteLiteral("        ");

WriteLiteral("public ");


            
            #line 51 "..\..\CodeGen\AstSubclassTemplate.cshtml"
            Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" (ReqlAst prev, Arguments args, OptArgs optargs)\r\n");



WriteLiteral("        ");

WriteLiteral("     : this(prev, TermType.");


            
            #line 52 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                Write(TermType);

            
            #line default
            #line hidden
WriteLiteral(", args, optargs) {\r\n");



WriteLiteral("        ");

WriteLiteral("}\r\n");


            
            #line 54 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    protected ");


            
            #line 56 "..\..\CodeGen\AstSubclassTemplate.cshtml"
         Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(pr" +
"evious, termType, args, optargs)\r\n    {\r\n    }\r\n");


});

WriteLiteral("\r\n\r\n");


DefineSection("StaticFactories", () => {

WriteLiteral("\r\n\r\n    /* Static Factories */\r\n\r\n");


            
            #line 65 "..\..\CodeGen\AstSubclassTemplate.cshtml"
     if( this.TermType != null )
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("public static ");


            
            #line 67 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                   Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" FromArgs(params object[] args){\r\n");



WriteLiteral("        ");

WriteLiteral(" return new ");


            
            #line 68 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                 Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" (new Arguments(args), null);\r\n");



WriteLiteral("        ");

WriteLiteral("}\r\n");


            
            #line 70 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    }

            
            #line default
            #line hidden

});

WriteLiteral(@"

//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class ");


            
            #line 84 "..\..\CodeGen\AstSubclassTemplate.cshtml"
            Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" : ");


            
            #line 84 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                Write(Superclass);

            
            #line default
            #line hidden
WriteLiteral(" {\r\n    \r\n    ");


            
            #line 86 "..\..\CodeGen\AstSubclassTemplate.cshtml"
Write(RenderSection("ctors"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    ");


            
            #line 88 "..\..\CodeGen\AstSubclassTemplate.cshtml"
Write(RenderSection("StaticFactories"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    ");


            
            #line 90 "..\..\CodeGen\AstSubclassTemplate.cshtml"
Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    ");


            
            #line 92 "..\..\CodeGen\AstSubclassTemplate.cshtml"
Write(RenderSection("SpecialMethods"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");


            
            #line 94 "..\..\CodeGen\AstSubclassTemplate.cshtml"
         foreach( var t in this.TermsIn )
        {

            
            #line default
            #line hidden
WriteLiteral("            ");

WriteLiteral("public ");


            
            #line 96 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                Write(Class(t.Key.ToLower()));

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 96 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                         Write(Method(t.Value["sharp_alias"]?.ToString() ?? t.Key.ToLower()));

            
            #line default
            #line hidden
WriteLiteral(" (params object[] fields){\r\n");


            
            #line 97 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                if( IncludeIn == "T_TOP_LEVEL" )
                {

            
            #line default
            #line hidden
WriteLiteral("                    ");

WriteLiteral("return new ");


            
            #line 99 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                            Write(Class(t.Key.ToLower()));

            
            #line default
            #line hidden
WriteLiteral(" (null, new Arguments(fields), new OptArgs());\r\n");


            
            #line 100 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    ");

WriteLiteral("return new ");


            
            #line 103 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                            Write(Class(t.Key.ToLower()));

            
            #line default
            #line hidden
WriteLiteral(" (this, new Arguments(fields), new OptArgs());\r\n");


            
            #line 104 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            ");

WriteLiteral("}\r\n");


            
            #line 106 "..\..\CodeGen\AstSubclassTemplate.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n    \r\n    }\r\n}\r\n");


        }
    }
}
#pragma warning restore 1591
