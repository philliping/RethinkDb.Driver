












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

    public class ToIso8601 : ReqlExpr {

    
    
    
/// <summary>
/// <para>Convert a time object to a string in ISO 8601 format.</para>
/// </summary>
/// <example><para>Example: Return the current ISO 8601 time.</para>
/// <code>r.now().toISO8601().run(conn, callback)
/// // Result passed to callback
/// "2015-04-20T18:37:52.690+00:00"
/// </code></example>
        public ToIso8601 (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Convert a time object to a string in ISO 8601 format.</para>
/// </summary>
/// <example><para>Example: Return the current ISO 8601 time.</para>
/// <code>r.now().toISO8601().run(conn, callback)
/// // Result passed to callback
/// "2015-04-20T18:37:52.690+00:00"
/// </code></example>
        public ToIso8601 (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Convert a time object to a string in ISO 8601 format.</para>
/// </summary>
/// <example><para>Example: Return the current ISO 8601 time.</para>
/// <code>r.now().toISO8601().run(conn, callback)
/// // Result passed to callback
/// "2015-04-20T18:37:52.690+00:00"
/// </code></example>
        public ToIso8601 (Arguments args, object optargs)
         : base(TermType.TO_ISO8601, args, optargs) {
        }


    



    


    

    


    
    }
}
