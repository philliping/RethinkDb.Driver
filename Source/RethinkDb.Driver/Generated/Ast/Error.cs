












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

    public class Error : ReqlExpr {

    
    
    
/// <summary>
/// <para>Throw a runtime error. If called with no arguments inside the second argument to <code>default</code>, re-throw the current error.</para>
/// </summary>
/// <example><para>Example: Iron Man can't possibly have lost a battle:</para>
/// <code>r.table('marvel').get('IronMan').do(function(ironman) {
///     return r.branch(ironman('victories').lt(ironman('battles')),
///         r.error('impossible code path'),
///         ironman)
/// }).run(conn, callback)
/// </code></example>
        public Error (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Throw a runtime error. If called with no arguments inside the second argument to <code>default</code>, re-throw the current error.</para>
/// </summary>
/// <example><para>Example: Iron Man can't possibly have lost a battle:</para>
/// <code>r.table('marvel').get('IronMan').do(function(ironman) {
///     return r.branch(ironman('victories').lt(ironman('battles')),
///         r.error('impossible code path'),
///         ironman)
/// }).run(conn, callback)
/// </code></example>
        public Error (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Throw a runtime error. If called with no arguments inside the second argument to <code>default</code>, re-throw the current error.</para>
/// </summary>
/// <example><para>Example: Iron Man can't possibly have lost a battle:</para>
/// <code>r.table('marvel').get('IronMan').do(function(ironman) {
///     return r.branch(ironman('victories').lt(ironman('battles')),
///         r.error('impossible code path'),
///         ironman)
/// }).run(conn, callback)
/// </code></example>
        public Error (Arguments args, object optargs)
         : base(TermType.ERROR, args, optargs) {
        }


    



    


    

    


    
    }
}
