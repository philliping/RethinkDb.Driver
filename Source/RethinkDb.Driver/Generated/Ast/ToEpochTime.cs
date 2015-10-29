












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

    public class ToEpochTime : ReqlExpr {

    
    
    
/// <summary>
/// <para>Convert a time object to its epoch time.</para>
/// </summary>
/// <example><para>Example: Return the current time in seconds since the Unix Epoch with millisecond-precision.</para>
/// <code>r.now().toEpochTime()
/// </code></example>
        public ToEpochTime (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Convert a time object to its epoch time.</para>
/// </summary>
/// <example><para>Example: Return the current time in seconds since the Unix Epoch with millisecond-precision.</para>
/// <code>r.now().toEpochTime()
/// </code></example>
        public ToEpochTime (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Convert a time object to its epoch time.</para>
/// </summary>
/// <example><para>Example: Return the current time in seconds since the Unix Epoch with millisecond-precision.</para>
/// <code>r.now().toEpochTime()
/// </code></example>
        public ToEpochTime (Arguments args, object optargs)
         : base(TermType.TO_EPOCH_TIME, args, optargs) {
        }


    



    


    

    


    
    }
}
