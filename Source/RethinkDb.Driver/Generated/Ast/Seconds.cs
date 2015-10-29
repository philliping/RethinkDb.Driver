












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

    public class Seconds : ReqlExpr {

    
    
    
/// <summary>
/// <para>Return the seconds in a time object as a number between 0 and 59.999 (double precision).</para>
/// </summary>
/// <example><para>Example: Return the post submitted during the first 30 seconds of every minute.</para>
/// <code>r.table("posts").filter(function(post) {
///     return post("date").seconds().lt(30)
/// })
/// </code></example>
        public Seconds (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Return the seconds in a time object as a number between 0 and 59.999 (double precision).</para>
/// </summary>
/// <example><para>Example: Return the post submitted during the first 30 seconds of every minute.</para>
/// <code>r.table("posts").filter(function(post) {
///     return post("date").seconds().lt(30)
/// })
/// </code></example>
        public Seconds (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Return the seconds in a time object as a number between 0 and 59.999 (double precision).</para>
/// </summary>
/// <example><para>Example: Return the post submitted during the first 30 seconds of every minute.</para>
/// <code>r.table("posts").filter(function(post) {
///     return post("date").seconds().lt(30)
/// })
/// </code></example>
        public Seconds (Arguments args, object optargs)
         : base(TermType.SECONDS, args, optargs) {
        }


    



    


    

    


    
    }
}
