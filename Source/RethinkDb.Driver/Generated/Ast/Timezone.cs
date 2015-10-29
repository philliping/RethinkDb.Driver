












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

    public class Timezone : ReqlExpr {

    
    
    
/// <summary>
/// <para>Return the timezone of the time object.</para>
/// </summary>
/// <example><para>Example: Return all the users in the "-07:00" timezone.</para>
/// <code>r.table("users").filter( function(user) {
///     return user("subscriptionDate").timezone().eq("-07:00")
/// })
/// </code></example>
        public Timezone (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Return the timezone of the time object.</para>
/// </summary>
/// <example><para>Example: Return all the users in the "-07:00" timezone.</para>
/// <code>r.table("users").filter( function(user) {
///     return user("subscriptionDate").timezone().eq("-07:00")
/// })
/// </code></example>
        public Timezone (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Return the timezone of the time object.</para>
/// </summary>
/// <example><para>Example: Return all the users in the "-07:00" timezone.</para>
/// <code>r.table("users").filter( function(user) {
///     return user("subscriptionDate").timezone().eq("-07:00")
/// })
/// </code></example>
        public Timezone (Arguments args, object optargs)
         : base(TermType.TIMEZONE, args, optargs) {
        }


    



    


    

    


    
    }
}
