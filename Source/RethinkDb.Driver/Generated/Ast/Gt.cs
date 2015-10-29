












//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public class Gt : ReqlExpr {

    
    
    
/// <summary>
/// <para>Test if the first value is greater than other.</para>
/// </summary>
/// <example><para>Example: Is 2 greater than 2?</para>
/// <code>r.expr(2).gt(2).run(conn, callback)
/// </code></example>
        public Gt (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Test if the first value is greater than other.</para>
/// </summary>
/// <example><para>Example: Is 2 greater than 2?</para>
/// <code>r.expr(2).gt(2).run(conn, callback)
/// </code></example>
        public Gt (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Test if the first value is greater than other.</para>
/// </summary>
/// <example><para>Example: Is 2 greater than 2?</para>
/// <code>r.expr(2).gt(2).run(conn, callback)
/// </code></example>
        public Gt (Arguments args, object optargs)
         : base(TermType.GT, args, optargs) {
        }


    



    


    

    


    
    }
}
